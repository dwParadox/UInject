using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UInjectLoader
{
    public class MonoInjector
    {
        private const int PROCESS_ALL_ACCESS = 0x1F0FFF;

        private MonoApp monoApp;

        private IntPtr monoProxyPtr;

        private readonly string _expectedProxyPath;
        
        [DllImport("UInjectHelper.dll", EntryPoint = "LoadDll")]
        public static extern bool LoadDll(int processId, char[] dllPath, char[] dllNamespace, char[] proxyPath, IntPtr proxyBase);

        private DllInjector dllInjector;
        public MonoInjector(MonoApp app)
        {
            this.dllInjector = new DllInjector();
         
            this.monoApp = app;
            _expectedProxyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\" + @"MonoProxy\" + (monoApp.MonoType == MonoType.MONO_1 ? "Mono1" : "Mono2") + @"\MonoProxy.dll";

        }

        private bool LoadMonoProxy()
        {
            if (!File.Exists(_expectedProxyPath))
                return false;

            dllInjector.InjectDll(Process.GetProcessById(monoApp.Id), _expectedProxyPath);

            return true;
        }

        public void LoadMonoDll(string dllPath, string dllNamespace)
        {
            if (Utils.GetModuleBase(Process.GetProcessById(monoApp.Id), _expectedProxyPath) == IntPtr.Zero)
            {
                MessageBox.Show("MonoProxy not found, Loading a new instance.");
                if (!LoadMonoProxy())
                    throw new Exception("MonoProxy injection failed.");
            }

            Thread.Sleep(1000);

            monoProxyPtr = Utils.GetModuleBase(Process.GetProcessById(monoApp.Id), _expectedProxyPath);
            if (monoProxyPtr == IntPtr.Zero)
                throw new Exception("Couldn't resolve MonoProxy.");

            if (!LoadDll(monoApp.Id, (dllPath + "\0").ToCharArray(), (dllNamespace + "\0").ToCharArray(), (_expectedProxyPath + "\0").ToCharArray(), monoProxyPtr))
                throw new Exception("Couldn't load MonoDLL");
        }
    }
}
