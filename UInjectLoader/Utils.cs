using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UInjectLoader
{
    public class Utils
    {
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process([In] IntPtr processHandle, [Out, MarshalAs(UnmanagedType.Bool)] out bool wow64Process);

        public static bool Is64BitProcess(Process process)
        {
            if (!Environment.Is64BitOperatingSystem)
                return false;

            bool isWow64Process;
            if (!IsWow64Process(process.Handle, out isWow64Process))
                throw new Win32Exception(Marshal.GetLastWin32Error());

            return !isWow64Process;
        }

        public static IntPtr GetModuleBase(Process process, string moduleName)
        {
            ProcessModuleCollection modules;

            try { modules = process.Modules; }
            catch (Exception) { return IntPtr.Zero; }

            foreach (ProcessModule m in modules)
            {
                string name = Path.GetFileName(m.FileName);
                if (name.Equals(Path.GetFileName(moduleName)))
                    return m.BaseAddress;
            }

            return IntPtr.Zero;
        }
    }
}
