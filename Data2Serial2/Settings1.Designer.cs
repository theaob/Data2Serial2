﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data2Serial2 {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings1 : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings1 defaultInstance = ((Settings1)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings1())));
        
        public static Settings1 Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red")]
        public global::System.Drawing.Color cancelButtonColor {
            get {
                return ((global::System.Drawing.Color)(this["cancelButtonColor"]));
            }
            set {
                this["cancelButtonColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 192, 0")]
        public global::System.Drawing.Color sendButtonColor {
            get {
                return ((global::System.Drawing.Color)(this["sendButtonColor"]));
            }
            set {
                this["sendButtonColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color terminalBackcolor {
            get {
                return ((global::System.Drawing.Color)(this["terminalBackcolor"]));
            }
            set {
                this["terminalBackcolor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Lime")]
        public global::System.Drawing.Color terminalForecolor {
            get {
                return ((global::System.Drawing.Color)(this["terminalForecolor"]));
            }
            set {
                this["terminalForecolor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color clearLinkForecolor {
            get {
                return ((global::System.Drawing.Color)(this["clearLinkForecolor"]));
            }
            set {
                this["clearLinkForecolor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color sendButtonTextColor {
            get {
                return ((global::System.Drawing.Color)(this["sendButtonTextColor"]));
            }
            set {
                this["sendButtonTextColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color cancelButtonTextColor {
            get {
                return ((global::System.Drawing.Color)(this["cancelButtonTextColor"]));
            }
            set {
                this["cancelButtonTextColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>115200</string>
  <string>57600</string>
  <string>38400</string>
  <string>19200</string>
  <string>9600</string>
  <string>1200</string>
  <string>300</string>
  <string>921600</string>
  <string>460800</string>
  <string>230400</string>
  <string>4800</string>
  <string>2400</string>
  <string>150</string>
  <string>110</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection baudRates {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["baudRates"]));
            }
            set {
                this["baudRates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int lastBaudRateIndex {
            get {
                return ((int)(this["lastBaudRateIndex"]));
            }
            set {
                this["lastBaudRateIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool howToScroll {
            get {
                return ((bool)(this["howToScroll"]));
            }
            set {
                this["howToScroll"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool autoUpdate {
            get {
                return ((bool)(this["autoUpdate"]));
            }
            set {
                this["autoUpdate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int parityIndex {
            get {
                return ((int)(this["parityIndex"]));
            }
            set {
                this["parityIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int dataBitIndex {
            get {
                return ((int)(this["dataBitIndex"]));
            }
            set {
                this["dataBitIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int stopBitIndex {
            get {
                return ((int)(this["stopBitIndex"]));
            }
            set {
                this["stopBitIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Microsoft Sans Serif, 8.25pt")]
        public global::System.Drawing.Font terminalFont {
            get {
                return ((global::System.Drawing.Font)(this["terminalFont"]));
            }
            set {
                this["terminalFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool isOnTop {
            get {
                return ((bool)(this["isOnTop"]));
            }
            set {
                this["isOnTop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public double opacity {
            get {
                return ((double)(this["opacity"]));
            }
            set {
                this["opacity"] = value;
            }
        }
    }
}