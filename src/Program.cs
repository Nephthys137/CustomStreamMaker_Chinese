using Microsoft.Win32;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CustomStreamMaker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var appDomain = AppDomain.CurrentDomain;
            appDomain.AssemblyResolve += OnAssemblyResolve;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StreamEditor());
        }
        static Assembly OnAssemblyResolve(object sender, ResolveEventArgs args)
        {
            DialogResult msg;
            string requestedAssemblyName = args.Name.Split(',')[0];
            string gamePath = !string.IsNullOrEmpty(Properties.Settings.Default.GameDirectory)
                ? Properties.Settings.Default.GameDirectory
                : Environment.Is64BitOperatingSystem
                    ? RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 1451940", false).GetValue("InstallLocation") != null
                                    ? RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 1451940", false).GetValue("InstallLocation") + "\\Windose_Data\\Managed\\"
                                    : null
                    : RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 1451940", false).GetValue("InstallLocation") != null
                                    ? RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 1451940", false).GetValue("InstallLocation") + "\\Windose_Data\\Managed\\"
                                    : null;
            try
            {
                if ((gamePath == null && string.IsNullOrEmpty(Properties.Settings.Default.GameDirectory)) || !Directory.Exists(gamePath))
                {
                    do
                    {
                        msg = MessageBox.Show("Could not find game path! \n\nTo continue, please open the folder containing the game executable. (NEEDY GIRL OVERDOSE)", "", MessageBoxButtons.OKCancel);
                        if (msg == DialogResult.Cancel)
                            Environment.Exit(0);
                    } while ((gamePath = OpenGamePath()) == null);
                    Properties.Settings.Default.GameDirectory = gamePath;
                    Properties.Settings.Default.Save();
                }
                return requestedAssemblyName == "Assembly-CSharp"
                    ? Assembly.LoadFrom(gamePath + requestedAssemblyName + ".dll")
                    : Assembly.LoadFrom(Path.Combine(Directory.GetCurrentDirectory(), "Assemblies", requestedAssemblyName + ".dll"));
            }
            catch
            {
                return null;
            }
        }

        static string OpenGamePath()
        {
            var openNsoStream = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.MyComputer
            };
            return openNsoStream.ShowDialog() == DialogResult.OK
                ? !File.Exists(openNsoStream.SelectedPath + @"\Windose_Data\Managed\Assembly-CSharp.dll") ? null : openNsoStream.SelectedPath
                : null;
        }
    }
}
