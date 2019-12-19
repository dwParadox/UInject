using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UInjectLoader
{
    public enum MonoType : int
    {
        MONO_1,
        MONO_2
    }

    public struct MonoApp
    {
        public string Name;
        public int Id;
        public IntPtr Handle;
        public MonoType MonoType;
    }

    public class MonoAppManager
    {
        public List<MonoApp> MonoApps;

        public event Action AppListUpdating;
        public event Action AppListUpdated;

        private void OnAppListUpdating()
        {
            AppListUpdating?.Invoke();
        }

        private void OnAppListUpdated()
        {
            AppListUpdated?.Invoke();
        }

        public MonoAppManager()
        {
            MonoApps = new List<MonoApp>();
        }

        public void GetMonoApps()
        {
            OnAppListUpdating();
            Thread getMonoThread = new Thread(FindMonoApps);
            getMonoThread.Start(this);
        }

        private void FindMonoApps(object data)
        {
            List<MonoApp> acceptableGames = new List<MonoApp>();

            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                ProcessModuleCollection modules;

                try { modules = p.Modules; }
                catch (Exception) { continue; }

                foreach (ProcessModule m in modules)
                {
                    string moduleName = Path.GetFileNameWithoutExtension(m.FileName);
                    if (moduleName.Equals("mono") || moduleName.Equals("mono-2.0-bdwgc"))
                    {
                        acceptableGames.Add(new MonoApp()
                        {
                            Name = p.ProcessName,
                            Id = p.Id,
                            Handle = p.Handle,
                            MonoType = moduleName.Equals("mono") ? MonoType.MONO_1 : MonoType.MONO_2
                        });

                        break;
                    }
                }
            }

            (data as MonoAppManager).MonoApps = acceptableGames;

            OnAppListUpdated();
        }
    }
}
