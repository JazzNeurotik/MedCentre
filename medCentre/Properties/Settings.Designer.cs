﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace medCentre.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\basesql.mdf;I" +
            "ntegrated Security=True;Connect Timeout=30")]
        public string basesqlConnectionString {
            get {
                return ((string)(this["basesqlConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"C:\\USERS\\OPTIM\\DOWNLOADS\\TELE" +
            "GRAM DESKTOP\\MEDCENTRE\\MEDCENTRE\\BASESQL.MDF\";Integrated Security=True;Connect T" +
            "imeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string C__USERS_OPTIM_DOWNLOADS_TELEGRAM_DESKTOP_MEDCENTRE_MEDCENTRE_BASESQL_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_OPTIM_DOWNLOADS_TELEGRAM_DESKTOP_MEDCENTRE_MEDCENTRE_BASESQL_MDFConnecti" +
                    "onString"]));
            }
        }
    }
}
