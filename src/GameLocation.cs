using Microsoft.Win32;
using System;
using System.IO;

namespace CustomStreamMaker
{
    internal class GameLocation
    {
        internal static string InitializeValidGamePath()
        {
            string gamePath = !string.IsNullOrEmpty(Properties.Settings.Default.GameDirectory)
                ? Properties.Settings.Default.GameDirectory
                : Environment.Is64BitOperatingSystem
                    ? (string)RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 1451940", false).GetValue("InstallLocation")
                    : (string)RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 1451940", false).GetValue("InstallLocation");
            return gamePath;
        }

        private string InitializeValidSteamPath()
        {
            string steamPath = Environment.Is64BitOperatingSystem
                ? (string)RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Valve\Steam", false).GetValue("SteamExe")
                : (string)RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Valve\Steam", false).GetValue("SteamExe");
            return steamPath;
        }

        internal static bool IsGameModded(out string modPath)
        {
            modPath = InitializeValidGamePath() + @"\BepInEx\plugins";
            if (!Directory.Exists(modPath))
            {
                modPath = null;
                return false;
            }
            return true;
        }
    }
}
