using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;

namespace appRelatorios
{
    public partial class frmGerenciadorRPT : Form
    {
        private int _cdRelatorio;
        public int cdRelatorio
        {
            get { return _cdRelatorio; }
            set { _cdRelatorio = value; }
        }

        private string strNomeRpt;
        private string strNomeProc;
        private string strProcExec;
        public DataTable dtParamRel = new DataTable();
        public DataTable dtRelatorios = new DataTable();

        private string _strPath = @"C:/Relatorios";
        public string strPath
        {
            get { return _strPath; }
            set { _strPath = value; }
        }

        public frmGerenciadorRPT()
        {
            InitializeComponent();
        }

        public void LimpaParametros(Control.ControlCollection Controles)
        {
            foreach (var control in Controles)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Dispose();
                }
                else
                {
                    if (control is DateTimePicker)
                    {
                        ((DateTimePicker)control).Dispose();
                    }
                    else
                    {
                        if (control is FlowLayoutPanel)
                        {
                            LimpaParametros(((FlowLayoutPanel)control).Controls);
                        }
                        else
                        {
                            if (control is Label)
                            {
                                ((Label)control).Dispose();
                            }
                        }
                    }
                }
            }
        }

        public void PreencheParametros(Control.ControlCollection Controles)
        {
            foreach (var control in Controles)
            {
                if (control is TextBox)
                {
                    strProcExec += "'%" + ((TextBox)control).Text + "%',";
                }
                else
                {
                    if (control is CheckBox)
                    {
                        if (((CheckBox)control).Checked)
                            strProcExec += "1,";
                        else strProcExec += "0,";
                    }
                    else
                    {
                        if (control is DateTimePicker)
                        {
                            strProcExec += "'" + ((DateTimePicker)control).Value.Date.Year.ToString()+"-"
                                               + ((DateTimePicker)control).Value.Date.Month.ToString() + "-"
                                               + ((DateTimePicker)control).Value.Date.Day.ToString() + "',";
                        }
                        else
                        {
                            if (control is FlowLayoutPanel)
                            {
                                int i = 0;
                                foreach (var control2 in ((FlowLayoutPanel)control).Controls)
                                {
                                    if (control2 is DateTimePicker && i == 0)
                                    {
                                        strProcExec += "'" + ((DateTimePicker)control2).Value.Date.Year.ToString() + "-"
                                                           + ((DateTimePicker)control2).Value.Date.Month.ToString() + "-"
                                                           + ((DateTimePicker)control2).Value.Date.Day.ToString() + " ";
                                        i++;
                                    }
                                    else
                                    {
                                        if (control2 is DateTimePicker && i == 1)
                                        {
                                            strProcExec += "" + ((DateTimePicker)control2).Value.Date.Hour.ToString() + ":"
                                                              + ((DateTimePicker)control2).Value.Date.Minute.ToString() + ":"
                                                              + ((DateTimePicker)control2).Value.Date.Second.ToString() + "',";
                                            i++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void CarregarRelatorios()
        {
            coRelatorios objcoRelatorios = new coRelatorios();
            conRelatorio objConRelatorio = new conRelatorio();

            if (!objConRelatorio.Select())
            {
                MessageBox.Show(objConRelatorio.strMensagemErro);
                return;
            }

            dtRelatorios = objConRelatorio.dtDados;
        }

        private void frmGerenciadorRPT_Load(object sender, EventArgs e)
        {
            caRelatorios objCaRelatorios = new caRelatorios();
            CarregarRelatorios();

            for (int i = 0; i < dtRelatorios.Rows.Count; i++)
                lbRPT.Items.Add(dtRelatorios.Rows[i][objCaRelatorios.deRelatorio].ToString());
        }

        private void lbRPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            caRelatorios objCaRelatorios = new caRelatorios();

            caParametros objCaParametros = new caParametros();
            conParamRelatorio objConParamRelatorio = new conParamRelatorio();
            caTipoParametro objCaTipoParametro = new caTipoParametro();
            conTipoParametro objConTipoParametro = new conTipoParametro();
            string strParam = string.Empty;

            flpParam.Controls.Clear();

            if (lbRPT.SelectedIndex != -1)
            {
                strNomeProc = dtRelatorios.Rows[lbRPT.SelectedIndex][objCaRelatorios.deProcRelatorio].ToString();
                strNomeRpt = dtRelatorios.Rows[lbRPT.SelectedIndex][objCaRelatorios.nmRelatorio].ToString();
                _strPath = dtRelatorios.Rows[lbRPT.SelectedIndex][objCaRelatorios.deCaminhoRelatorio].ToString();

                objConParamRelatorio.objCoParametros.cdRelatorio = Convert.ToInt32(dtRelatorios.Rows[lbRPT.SelectedIndex][objCaParametros.cdRelatorio].ToString());

                if (!objConParamRelatorio.Select())
                {
                    MessageBox.Show(objConParamRelatorio.strMensagemErro);
                    return;
                }

                dtParamRel = objConParamRelatorio.dtDados;

                for (int i = 0; i < dtParamRel.Rows.Count; i++)
                {
                    objConTipoParametro.objCoTipoParametro.cdTipoParametro = Convert.ToInt32(dtParamRel.Rows[i][objCaParametros.cdTpParametro].ToString());

                    if (objConTipoParametro.Select())
                    {
                        MessageBox.Show(objConTipoParametro.strMensagemErro);
                        return;
                    }
                    
                    strParam = objConTipoParametro.dtDados.Rows[0][objCaTipoParametro.deTipoParametro].ToString();

                    if (strParam != "CHECK")
                    {
                        Label lbl = new Label();
                        lbl.Text = dtParamRel.Rows[i][objCaParametros.nmParamRelatorio].ToString();
                        lbl.Parent = flpParam;
                    }

                    switch (strParam)
                    {
                        case "TEXTO":
                            TextBox txtParam = new TextBox();
                            txtParam.Parent = flpParam;
                            txtParam.Width = 200;
                            flpParam.Controls.Add(txtParam);
                            break;
                        case "DATA":
                            DateTimePicker dtpData = new DateTimePicker();
                            dtpData.Parent = flpParam;
                            dtpData.Format = DateTimePickerFormat.Short;
                            dtpData.Width = 95;
                            flpParam.Controls.Add(dtpData);
                            break;
                        case "DATA HORA":
                            FlowLayoutPanel flpParamData = new FlowLayoutPanel();
                            DateTimePicker dtpDataH = new DateTimePicker();
                            DateTimePicker dtpHora = new DateTimePicker();
                            flpParamData.Width = 200;
                            flpParamData.Height = dtpDataH.Height;
                            flpParamData.Parent = flpParam;
                            flpParamData.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
                            dtpDataH.Parent = flpParamData;
                            dtpHora.Parent = flpParamData;
                            dtpDataH.Format = DateTimePickerFormat.Short;
                            dtpHora.Format = DateTimePickerFormat.Time;
                            dtpDataH.Width = 90;
                            dtpHora.Width = 80;
                            dtpHora.Text = "00:00:00";
                            flpParamData.Controls.Add(dtpDataH);
                            flpParamData.Controls.Add(dtpHora);
                            break;
                        case "HORA":
                            DateTimePicker THora = new DateTimePicker();
                            THora.Parent = flpParam;
                            THora.Format = DateTimePickerFormat.Time;
                            THora.Width = 100;
                            THora.Text = "00:00:00";
                            flpParam.Controls.Add(THora);
                            break;
                        case "COMBO":
                            ComboBox cbbParam = new ComboBox();
                            cbbParam.Parent = flpParam;
                            cbbParam.Width = 200;
                            flpParam.Controls.Add(cbbParam);
                            //colocar sql
                            break;
                        case "CHECK":
                            CheckBox cbParam = new CheckBox();
                            cbParam.Parent = flpParam;
                            cbParam.Text = dtParamRel.Rows[i][objCaParametros.nmParamRelatorio].ToString();
                            cbParam.Width = 200;
                            flpParam.Controls.Add(cbParam);
                            break;
                        case "LIST":
                            ListBox lbParam = new ListBox();
                            lbParam.Parent = flpParam;
                            lbParam.Width = 200;
                            lbParam.Height = 250;
                            flpParam.Controls.Add(lbParam);
                            //colocar sql
                            break;
                    }
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            conRelatorio objConRelatorio = new conRelatorio();
            DataTable dt = new DataTable();

            PreencheParametros(flpParam.Controls);

            //strProcExec = strNomeProc + "(";
            //strProcExec = "CALL " + strProcExec.Substring(0, strProcExec.Length - 1) + ")";

            //if (!objConRelatorio.GerarRelatorio(strProcExec, out dt))
            //    throw new Exception("Erro ao executar consulta do relatório!");

            GerarRelatorio(dt);
        }

        private void GerarRelatorio(DataTable dt)
        {
            if (Directory.Exists(_strPath))
            {
                if (File.Exists(_strPath + "/" + strNomeRpt))
                {
                    ReportDocument crDocument = new ReportDocument();

                    crDocument.Load(_strPath + "/" + strNomeRpt);

                    crDocument.SetDataSource(dt);

                    frmVisualizador f = new frmVisualizador();
                    f.carregar(crDocument);
                    f.ShowDialog();
                }
                else
                    MessageBox.Show("Relatório " + strNomeRpt + " não existe!");
            }
            else
                MessageBox.Show("Diretório 'Relatorios' não existe!");
        }

        public void GerarRelatorio(int cdRelatorio, DataTable dtDados)
        {
            caRelatorios objcaRelatorios = new caRelatorios();
            conRelatorio objConRelatorio = new conRelatorio();

            objConRelatorio.objCoRelatorios.cdRelatorio = cdRelatorio;

            if (!objConRelatorio.Select())
            {
                MessageBox.Show(objConRelatorio.strMensagemErro);
                return;
            }

            strNomeProc = objConRelatorio.dtDados.Rows[0][objcaRelatorios.deProcRelatorio].ToString();
            strNomeRpt = objConRelatorio.dtDados.Rows[0][objcaRelatorios.nmRelatorio].ToString();
            _strPath = objConRelatorio.dtDados.Rows[0][objcaRelatorios.deCaminhoRelatorio].ToString();

            GerarRelatorio(dtDados);
        }
    }
}
