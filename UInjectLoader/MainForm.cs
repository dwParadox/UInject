using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
    public partial class MainForm : Form
    {
        private MonoAppManager monoManager;

        private void OnAppListUpdating()
        {
            lblStatus.Invoke(new Action(() => lblStatus.Text = "Status: Finding MonoApps"));
        }

        private void OnAppListUpdated()
        {
            MonoAppList.Invoke(new Action(() => MonoAppList.Items.Clear()));
            MonoAppList.Invoke(new Action(() => MonoAppList.Items.AddRange(monoManager.MonoApps.Select(a => a.Name).ToArray())));
            lblStatus.Invoke(new Action(() => lblStatus.Text = "Status: Idle"));
        }

        public MainForm()
        {
            InitializeComponent();

            monoManager = new MonoAppManager();
            monoManager.AppListUpdating += OnAppListUpdating;
            monoManager.AppListUpdated += OnAppListUpdated;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            monoManager.GetMonoApps();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            monoManager.GetMonoApps();
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            if (MonoAppList.SelectedIndex >= 0)
            {
                var monoInjector = new MonoInjector(monoManager.MonoApps[MonoAppList.SelectedIndex]);

                if (chkInjectUInject.Checked)
                    monoInjector.LoadMonoDll(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\" + @"UInject.dll", "UInject");

                Thread.Sleep(500);

                monoInjector.LoadMonoDll(txtDllPath.Text, txtDllNamespace.Text);
            }
        }

        private void btnFindDll_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "DLL Files (*.dll)|*.dll|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtDllPath.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
