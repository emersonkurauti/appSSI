﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appSSI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.199.2" +
            "00)(PORT=1521))) (CONNECT_DATA=(SERVICE_NAME=orcl))); User Id=taskdesenv; Passwo" +
            "rd=taskdesenv")]
        public string strConexaoBancoIntegracao {
            get {
                return ((string)(this["strConexaoBancoIntegracao"]));
            }
            set {
                this["strConexaoBancoIntegracao"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\\\appSSI\\\\appSSI\\\\wappSSI")]
        public string sCaminhoServidor {
            get {
                return ((string)(this["sCaminhoServidor"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.55")]
        public float grauSimilaridade {
            get {
                return ((float)(this["grauSimilaridade"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\\\appSSI\\\\appSSI\\\\wappSSI\\\\Imagens\\\\Solucoes\\\\")]
        public string sCaminhoSolucoes {
            get {
                return ((string)(this["sCaminhoSolucoes"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\\\appSSI\\\\appSSI\\\\wappSSI\\\\Imagens\\\\Defeitos\\\\")]
        public string sCaminhoDefeitos {
            get {
                return ((string)(this["sCaminhoDefeitos"]));
            }
        }
    }
}
