﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoDB {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class DatabaseProperties : global::System.Configuration.ApplicationSettingsBase {
        
        private static DatabaseProperties defaultInstance = ((DatabaseProperties)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DatabaseProperties())));
        
        public static DatabaseProperties Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=pamyatayka.db;Version=3;New=True;Compress=True;")]
        public string DBConnection {
            get {
                return ((string)(this["DBConnection"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CREATE TABLE IF NOT EXISTS Intervals (interval_id INTEGER PRIMARY KEY AUTOINCREMENT, name V" +
            "ARCHAR(60) NOT NULL);")]
        public string CreateIntervals {
            get {
                return ((string)(this["CreateIntervals"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CREATE TABLE IF NOT EXISTS Statuses (status_id INTEGER PRIMARY KEY AUTOINCREMENT, status VA" +
            "RCHAR(60) NOT NULL);")]
        public string CreateStatuses {
            get {
                return ((string)(this["CreateStatuses"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CREATE TABLE IF NOT EXISTS Categories (category_id INTEGER PRIMARY KEY AUTOINCREMENT, name " +
            "VARCHAR(60) NOT NULL, is_default bool NOT NULL, interval_fk varchar(60), FOREIGN" +
            " KEY (interval_fk) REFERENCES Intervals (interval_id) ON DELETE CASCADE);")]
        public string CreateCategories {
            get {
                return ((string)(this["CreateCategories"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"CREATE TABLE IF NOT EXISTS Grades (grade_id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(60) NOT NULL, interval_time timestamp NOT NULL, position integer NOT NULL, interval_fk varchar(60), FOREIGN KEY (interval_fk) REFERENCES Intervals (interval_id) ON DELETE CASCADE);")]
        public string CreateGrades {
            get {
                return ((string)(this["CreateGrades"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"CREATE TABLE IF NOT EXISTS Words (word_id INTEGER PRIMARY KEY AUTOINCREMENT, term VARCHAR(60) NOT NULL, definition TEXT NOT NULL, status_fk varchar(20) NOT NULL, category_fk varchar(60) NOT NULL, current_grade_fk varchar(60), FOREIGN KEY (status_fk) REFERENCES Statuses (status_id) ON DELETE CASCADE, FOREIGN KEY (category_fk) REFERENCES Categories (category_id) ON DELETE CASCADE, FOREIGN KEY (current_grade_fk) REFERENCES Grades (grade_id) ON DELETE CASCADE);")]
        public string CreateWords {
            get {
                return ((string)(this["CreateWords"]));
            }
        }
    }
}
