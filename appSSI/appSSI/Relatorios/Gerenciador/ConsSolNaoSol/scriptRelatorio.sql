drop function popula_cons_sol_nao_sol;
/
drop type t_type_cons_sol_nao_sol;
/
create or replace type type_cons_sol_nao_sol as object
	(
		DescDefeitoPesq VARCHAR2(4000), 
		cdSistema       NUMBER, 
		nmSistema       VARCHAR2(45), 
		cdModulo        NUMBER,
		nmModulo        VARCHAR2(60), 
		cdTela          NUMBER, 
		nmTela          VARCHAR2(30), 
		cdAcao          NUMBER, 
		deAcao          VARCHAR2(30), 
    cdEmpresa       NUMBER,
    nmEmpresa       VARCHAR2(100),
		flResultado     CHAR(1),
		deSolucao       VARCHAR2(4000), 
		dtConsulta      DATE,
		pcdSistema VARCHAR2(200),
		pcdModulo  VARCHAR2(200),
		pcdTela    VARCHAR2(200),
		pcdAcao    VARCHAR2(200),
    pcdEmpresa VARCHAR2(200),
		pdtIni     VARCHAR2(10),
		pdtFim     VARCHAR2(10)
	);
/
create or replace type t_type_cons_sol_nao_sol as table of type_cons_sol_nao_sol;
/
create or replace function get_cons_sol_nao_sol(
    pcdSistema IN sistemas.cdSistema%TYPE,
    pcdModulo  IN modulos.cdModulo%TYPE,
    pcdTela    IN telas.cdTela%TYPE,
    pcdAcao    IN acoes.cdAcao%TYPE,
    pcdEmpresa IN empresas.cdEmpresa%TYPE,
    pdtIni     IN VARCHAR2,
    pdtFim     IN VARCHAR2
  )
  return sys_refcursor
AS
  crReult sys_refcursor;
begin
  open crReult for 
    select PD.DescDefeitoPesq,
           PS.cdSistema,
           PS.nmSistema,
           PM.cdModulo,
           PM.nmModulo,
           PT.cdTela,
           PT.nmTela,
           PA.cdAcao,
           PA.deAcao,
           PU.cdEmpresa,
           PU.nmEmpresa,
           CAST(I.FLRESULTADO AS CHAR(1)),
           NVL(S.DESOLUCAO, ' ') as deSolucao,
           NVL(SUBSTR(PDTC.dtConsulta,1,10), ' ') as dtConsulta,
           CASE WHEN pcdSistema = 0 THEN
             'Todos'
           ELSE
             PS.cdSistema || ' - ' || PS.nmSistema
           END AS pcdSistema,
           CASE WHEN pcdModulo = 0 THEN
             'Todos'
           ELSE
             PM.cdModulo || ' - ' || PM.nmModulo
           END AS pcdModulo,
           CASE WHEN pcdTela = 0 THEN
             'Todas'
           ELSE
             PT.cdTela || ' - ' || PT.nmTela
           END AS pcdTela,
           CASE WHEN pcdAcao = 0 THEN
             'Todas'
           ELSE
             PA.cdAcao || ' - ' || PA.deAcao
           END AS pcdAcao,
           CASE WHEN pcdEmpresa = 0 THEN
             'Todas'
           ELSE
             PU.cdEmpresa || ' - ' || PU.nmEmpresa
           END AS pcdEmpresa,
           NVL(pdtIni, '---') as pdtIni,
           NVL(pdtFim, '---') as pdtFim
        from INDICADORES I
       inner join (select NVL(VLPARAMETRO, ' ') as DescDefeitoPesq, CDINDICADOR
               from PARAMETROS
              where NMPARAMETRO = 'DescDefeito') PD on PD.CDINDICADOR = I.CDINDICADOR
       inner join (select NVL(S.nmSistema, 'Outros') as nmSistema, NVL(S.cdSistema,0) as cdSistema, P.CDINDICADOR
               from PARAMETROS P
               left join Sistemas S on S.cdSistema = P.VLPARAMETRO
              where NMPARAMETRO = 'Sistema') PS on PS.CDINDICADOR = I.CDINDICADOR
       inner join (select NVL(M.nmModulo, 'Outros') as nmModulo, NVL(M.cdModulo,0) as cdModulo, P.CDINDICADOR
               from PARAMETROS P
               left join Modulos M on M.cdModulo = P.VLPARAMETRO
              where NMPARAMETRO = 'Modulo') PM on PM.CDINDICADOR = I.CDINDICADOR
       inner join (select NVL(T.nmTela, 'Outros') as nmTela, NVL(T.cdTela,0) as cdTela, P.CDINDICADOR
               from PARAMETROS P
               left join Telas T on T.cdTela = P.VLPARAMETRO
              where NMPARAMETRO = 'Tela') PT on PT.CDINDICADOR = I.CDINDICADOR
       inner join (select NVL(Ac.deAcao, 'Outros') as deAcao, NVL(Ac.cdAcao,0) as cdAcao, P.CDINDICADOR
               from PARAMETROS P
               left join Acoes Ac on Ac.cdAcao = P.VLPARAMETRO
              where NMPARAMETRO = 'Acao') PA on PA.CDINDICADOR = I.CDINDICADOR
       inner join (select NVL(E.cdEmpresa, 0) as cdEmpresa, NVL(E.nmEmpresa, 'Sem Empresa') as nmEmpresa, P.CDINDICADOR
               from PARAMETROS P
               left join Usuarios U on U.cdUsuario = P.VLPARAMETRO
               left join Empresas E on E.cdEmpresa = U.cdEmpresa
              where NMPARAMETRO = 'Usuario') PU on PU.CDINDICADOR = I.CDINDICADOR
        left join (select NVL(P.VLPARAMETRO, ' ') as dtConsulta, P.CDINDICADOR
               from PARAMETROS P
              where NMPARAMETRO = 'dtConsulta') PDTC on PDTC.CDINDICADOR = I.CDINDICADOR
        left join SOLUCOES S on S.CDSOLUCAO = I.CDSOLUCAO
       where (PS.cdSistema = pcdSistema or pcdSistema = 0)
           and (PM.cdModulo  = pcdModulo or pcdModulo = 0)
           and (PT.cdTela    = pcdTela or pcdTela = 0)
           and (PA.cdAcao    = pcdAcao or pcdAcao = 0)
           and (PU.cdEmpresa = pcdEmpresa or pcdEmpresa = 0)
           and ((PDTC.dtConsulta between pdtIni and pdtFim) or pdtIni is null);
 
    
  return crReult;
end get_cons_sol_nao_sol;
/
create or replace function popula_cons_sol_nao_sol(
    pcdSistema IN sistemas.cdSistema%TYPE,
    pcdModulo  IN modulos.cdModulo%TYPE,
    pcdTela    IN telas.cdTela%TYPE,
    pcdAcao    IN acoes.cdAcao%TYPE,
    pcdEmpresa IN empresas.cdEmpresa%TYPE,
    pdtIni     IN VARCHAR2,
    pdtFim     IN VARCHAR2
  )
  return t_type_cons_sol_nao_sol is
  v_emptype t_type_cons_sol_nao_sol := t_type_cons_sol_nao_sol();
  v_rc      sys_refcursor; 
  v_cnt     number := 0;

  --Paramtros
  v_pcdSistema VARCHAR2(200); 
  v_pcdModulo  VARCHAR2(200); 
  v_pcdTela    VARCHAR2(200); 
  v_pcdAcao    VARCHAR2(200);
  v_pcdEmpresa VARCHAR2(200);
  v_dtIni      VARCHAR2(10);
  v_dtFim      VARCHAR2(10);
  
  v_cdSistema sistemas.cdSistema%TYPE;
  v_nmSistema sistemas.nmSistema%TYPE; 
  v_cdModulo  modulos.cdModulo%TYPE; 
  v_nmModulo  modulos.nmModulo%TYPE; 
  v_cdTela    telas.cdTela%TYPE; 
  v_nmTela    telas.nmTela%TYPE; 
  v_cdAcao    acoes.cdAcao%TYPE; 
  v_deAcao    acoes.deAcao%TYPE;
  v_cdEmpresa empresas.cdEmpresa%TYPE;
  v_nmEmpresa empresas.nmEmpresa%TYPE;
  v_deSolucao solucoes.deSolucao%TYPE;
  v_DescDefeitoPesq varchar2(4000);
  v_flResultado VARCHAR2(4000);
  v_dtConsulta  DATE;
  begin
    v_rc := get_cons_sol_nao_sol(pcdSistema, pcdModulo, pcdTela, pcdAcao, pcdEmpresa, pdtIni, pdtFim);
	
    loop
      fetch v_rc into 
        v_DescDefeitoPesq, 
        v_cdSistema, 
        v_nmSistema, 
        v_cdModulo, 
        v_nmModulo, 
        v_cdTela, 
        v_nmTela, 
        v_cdAcao, 
        v_deAcao, 
        v_cdEmpresa,
        v_nmEmpresa,
        v_flResultado,
        v_deSolucao, 
        v_dtConsulta,
        v_pcdSistema,
        v_pcdModulo,
        v_pcdTela,
        v_pcdAcao,
        v_pcdEmpresa,
        v_dtIni,
        v_dtFim
        ;
      
      exit when v_rc%NOTFOUND;
      v_emptype.extend;
      v_cnt := v_cnt + 1;
      v_emptype(v_cnt) := type_cons_sol_nao_sol(
                            v_DescDefeitoPesq, 
                            v_cdSistema, 
                            v_nmSistema, 
                            v_cdModulo, 
                            v_nmModulo, 
                            v_cdTela, 
                            v_nmTela, 
                            v_cdAcao, 
                            v_deAcao, 
                            v_cdEmpresa,
                            v_nmEmpresa,
                            v_flResultado,
                            v_deSolucao,
                            v_dtConsulta,
                            v_pcdSistema,
                            v_pcdModulo,
                            v_pcdTela,
                            v_pcdAcao,
                            v_pcdEmpresa,
                            v_dtIni,
                            v_dtFim
                            );
    end loop;
    close v_rc;
    return v_emptype;
 end;
 /
/*
declare
  cdRelatorio NUMBER;
  cdParamRel NUMBER;
begin
  Select Max(cdRelatorio) + 1 into cdRelatorio
    from relatorios;
    
  insert into relatorios (CDRELATORIO, DERELATORIO, deprocrelatorio, nmrelatorio, decaminhorelatorio, flgerenciado)
  values (cdRelatorio, 'Consultas Solucionadas/Não Solucionadas', 'popula_cons_sol_nao_sol', 'crConsSolNaoSol.rpt', 'C:\appSSI\appSSI\appSSI\appSSI\Relatorios\Gerenciador\ConsSolNaoSol', 'S');
  
  Select Max(cdParamRelatorio) + 1 into cdParamRel
    from parametros_relatorios;
  
  insert into parametros_relatorios(cdParamRelatorio, cdTpParametro, cdRelatorio, nmParamRelatorio, deSQLParamRelatorio, deComponente)
  values (cdParamRel, 8, cdRelatorio, '', '', 'appSSI.ucParametroConsSolNaoSol,appSSI');
  
  Select Max(cdParamRelatorio) + 1 into cdParamRel
    from parametros_relatorios;
  
  insert into parametros_relatorios(cdParamRelatorio, cdTpParametro, cdRelatorio, nmParamRelatorio, deSQLParamRelatorio, deComponente)
  values (cdParamRel, 8, cdRelatorio, '', '', 'appSSI.ucPeriodo,appSSI');
  
  commit;
end;
*/ 