﻿using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;


namespace testsetting.Helpers
{
   public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        #endregion

        private const string DisplayLanguageKey = "display_language_key";
        private static readonly string DisplayLanguageDefault = "English";
        public static string GeneralSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(SettingsKey, value);
            }
        }
        public static string DisplayLanguage
        {
            get
            {
                return AppSettings.GetValueOrDefault(DisplayLanguageKey, DisplayLanguageDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(DisplayLanguageKey, value);
            }
        }

    }
}
