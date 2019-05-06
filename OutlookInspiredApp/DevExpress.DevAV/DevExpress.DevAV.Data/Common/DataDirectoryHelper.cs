using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
#if !REALTORWORLDDEMO
#if !DXCORE3
    using System.Deployment.Application;
#endif
using System.Windows.Interop;
using System.Threading;
using System.Diagnostics;
using System.Security;
using System.Runtime.InteropServices;
using Microsoft.Win32;
#endif

namespace DevExpress.Internal {
#if DEVAV
    public class DevAVDataDirectoryHelper {
#else
    public class DataDirectoryHelper {
#endif
#if !REALTORWORLDDEMO && !DXCORE3
        static bool? _isClickOnce = null;

        public static bool IsClickOnce {
            get {
                if(_isClickOnce == null) {
#if DEBUG && !CLICKONCE
                    _isClickOnce = false;
#else
                    _isClickOnce = !BrowserInteropHelper.IsBrowserHosted && ApplicationDeployment.IsNetworkDeployed;
#endif
                }
                return (bool)_isClickOnce;
            }
        }
#endif
        public static string GetDataDirectory() {
#if DXCORE3
            return GetEntryAssemblyDirectory();
#else
#if REALTORWORLDDEMO
            return AppDomain.CurrentDomain.BaseDirectory;
#else
            return IsClickOnce
                ? ApplicationDeployment.CurrentDeployment.DataDirectory
                : GetEntryAssemblyDirectory();
#endif
#endif
        }
        public const string DataFolderName = "Data";
        public static string GetFile(string fileName, string directoryName) {
            if(DataPath != null)
                return Path.Combine(DataPath, fileName);
            string dataDirectory = GetDataDirectory();
            if(dataDirectory == null) return null;
            string dirName = Path.GetFullPath(dataDirectory);
            for(int n = 0; n < 9; n++) {
                string path = dirName + "\\" + directoryName + "\\" + fileName;
                try {
                    if(File.Exists(path) || Directory.Exists(path))
                        return path;
                } catch { }
                dirName += @"\..";
            }
            throw new FileNotFoundException(string.Format("{0} not found. ({1})", fileName, dirName));
        }
        public static string GetDirectory(string directoryName) {
            string dataDirectory = GetDataDirectory();
            if(dataDirectory == null) return null;
            string dirName = Path.GetFullPath(dataDirectory);
            for(int n = 0; n < 9; n++) {
                string path = dirName + "\\" + directoryName;
                try {
                    if(Directory.Exists(path))
                        return path;
                } catch { }
                dirName += @"\..";
            }
            throw new DirectoryNotFoundException(directoryName + " not found");
        }
#if !REALTORWORLDDEMO
        public static void SetWebBrowserMode() {
            try {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", true);
                if(key == null)
                    key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION");
                if(key != null)
                    key.SetValue(Path.GetFileName(Process.GetCurrentProcess().ProcessName + ".exe"), 0, RegistryValueKind.DWord); //Latest IE
            } catch { }
        }
        public static string LocalPrefix { get; set; }
        public static string DataPath { get; set; }
        public static string GetFileLocalCopy(string fileName, string directoryName) {
            if(string.IsNullOrEmpty(LocalPrefix))
                throw new InvalidOperationException();
            string localName = LocalPrefix + fileName;
            string filePath = GetFile(fileName, directoryName);
            string fileDirectoryPath = Path.GetDirectoryName(filePath);
            string localFilePath = Path.Combine(fileDirectoryPath, localName);
            if(File.Exists(localFilePath)) return localFilePath;
            File.Copy(filePath, localFilePath);
            FileAttributes attributes = File.GetAttributes(localFilePath);
            if((attributes & FileAttributes.ReadOnly) != 0)
                File.SetAttributes(localFilePath, attributes & ~FileAttributes.ReadOnly);
            return localFilePath;
        }
        public static IDisposable SingleInstanceApplicationGuard(string applicationName, out bool exit) {
            Mutex mutex = new Mutex(true, applicationName + AssemblyInfo.VersionShort);
            if(mutex.WaitOne(0, false)) {
                exit = false;
            } else {
                Process current = Process.GetCurrentProcess();
                foreach(Process process in Process.GetProcessesByName(current.ProcessName)) {
                    if(process.Id != current.Id && process.MainWindowHandle != IntPtr.Zero) {
                        WinApiHelper.SetForegroundWindow(process.MainWindowHandle);
                        WinApiHelper.RestoreWindowAsync(process.MainWindowHandle);
                        break;
                    }
                }
                exit = true;
            }
            return mutex;
        }
        static class WinApiHelper {
            [SecuritySafeCritical]
            public static bool SetForegroundWindow(IntPtr hwnd) {
                return Import.SetForegroundWindow(hwnd);
            }
            [SecuritySafeCritical]
            public static bool RestoreWindowAsync(IntPtr hwnd) {
                return Import.ShowWindowAsync(hwnd, IsMaxmimized(hwnd) ? (int)Import.ShowWindowCommands.ShowMaximized : (int)Import.ShowWindowCommands.Restore);
            }
            [SecuritySafeCritical]
            public static bool IsMaxmimized(IntPtr hwnd) {
                Import.WINDOWPLACEMENT placement = new Import.WINDOWPLACEMENT();
                placement.length = Marshal.SizeOf(placement);
                if(!Import.GetWindowPlacement(hwnd, ref placement)) return false;
                return placement.showCmd == Import.ShowWindowCommands.ShowMaximized;
            }
            static class Import {
                [DllImport("user32.dll")]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);
                [DllImport("user32.dll")]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool SetForegroundWindow(IntPtr hWnd);
                [DllImport("user32.dll")]
                public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
                [StructLayout(LayoutKind.Sequential)]
                public struct WINDOWPLACEMENT {
                    public int length;
                    public int flags;
                    public ShowWindowCommands showCmd;
                    public System.Drawing.Point ptMinPosition;
                    public System.Drawing.Point ptMaxPosition;
                    public System.Drawing.Rectangle rcNormalPosition;
                }
                public enum ShowWindowCommands : int {
                    Hide = 0,
                    Normal = 1,
                    ShowMinimized = 2,
                    ShowMaximized = 3,
                    ShowNoActivate = 4,
                    Show = 5,
                    Minimize = 6,
                    ShowMinNoActive = 7,
                    ShowNA = 8,
                    Restore = 9,
                    ShowDefault = 10,
                    ForceMinimize = 11
                }
            }
        }
        static string GetEntryAssemblyDirectory() {
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            if(entryAssembly == null) return null;
            string appPath = entryAssembly.Location;
            return Path.GetDirectoryName(appPath);
        }
#endif
    }
}
