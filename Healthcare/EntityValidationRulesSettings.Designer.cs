﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Healthcare {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class EntityValidationRulesSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static EntityValidationRulesSettings defaultInstance = ((EntityValidationRulesSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new EntityValidationRulesSettings())));
        
        public static EntityValidationRulesSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// XML document specifying custom server-side validation rules
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document specifying custom server-side validation rules")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("EntityValidationRules.xml")]
        public string CustomRulesXml {
            get {
                return ((string)(this["CustomRulesXml"]));
            }
        }
    }
}