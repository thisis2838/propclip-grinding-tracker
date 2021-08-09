using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using static propclip_grinding_tracker.Utils.ThreadHelper;
using propclip_grinding_tracker.Utils;
using Ookii.Dialogs.WinForms;

namespace propclip_grinding_tracker
{
    public partial class MainForm : Form
    {
        private Thread _workThread;
        private CancellationTokenSource _workThreadCTS;
        private List<SegmentFile> _files;
        private SettingsHandler _settings;
        public MainForm()
        {
            InitializeComponent();
            Load += (a, b) => 
            {
                _files = new List<SegmentFile>();
                dgvFiles.SortCompare += DgvFiles_SortCompare;
                _workThreadCTS = new CancellationTokenSource();
                _workThread = new Thread(Work);
                _workThread.Start();

                _settings = new SettingsHandler();
                _settings.SubscribedSettings.Add(new SettingEntry(
                    "gamedir",
                    (s) => { boxGameDir.Text = s; },
                    () => { return boxGameDir.Text; }
                ));
                _settings.SubscribedSettings.Add(new SettingEntry(
                    "workdir",
                    (s) => { boxWorkDir.Text = s; },
                    () => { return boxWorkDir.Text; }
                ));
                _settings.SubscribedSettings.Add(new SettingEntry(
                    "demoname",
                    (s) => { boxSaveDemoName.Text = s; },
                    () => { return boxSaveDemoName.Text; }
                ));

                _settings.LoadSettings();

            };
            FormClosing += (s, e) =>
            {
                _workThreadCTS.Cancel();
                _settings.WriteSettings();
            };
        }

        private void DgvFiles_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            switch (e.Column.Index)
            {
                case 0:
                case 2:
                    {
                        e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                        e.Handled = true;
                        break;
                    }
                default:
                    break;
            }
        }

        private void AddFileEntry(SegmentFile file)
        {
            _files.Add(file);
            ThreadAction(this, () => 
            {
                dgvFiles.Rows.Add(new string[]
                {
                    _files.IndexOf(file).ToString(),
                    file.DemoInfo.MapName,
                    file.DemoInfo.AdjustedTicks.ToString(),
                    file.AchievementDate.ToString(),
                    file.Name
                });
            });
        }

        private void Work()
        {
            while (!_workThreadCTS.IsCancellationRequested)
            {
                Thread.Sleep(15);

                string saveName = GetValue(this, boxSaveDemoName, x => x.Text);
                string gameDir = GetValue(this, boxGameDir, x => x.Text);
                string workDir = GetValue(this, boxWorkDir, x => x.Text);

                if (saveName == "" || !Directory.Exists(gameDir) || !Directory.Exists(workDir))
                    continue;

                string savPath = Path.Combine(gameDir, "save", saveName + ".sav");
                string demPath = Path.Combine(gameDir, saveName + ".dem");
                if (File.Exists(savPath) && File.Exists(demPath))
                {
                    // wait till the demo is finalized
                    Thread.Sleep(500);
                    DemoParseResult result = new DemoParseResult(demPath);
                    DateTime lastWriteTime = File.GetLastWriteTime(savPath);
                    string segName = $"[{result.MapName}] - [{result.AdjustedTicks}] - [{lastWriteTime}]".Replace(':','-');
                    File.Move(savPath, Path.Combine(workDir, segName + ".sav"));
                    File.Move(demPath, Path.Combine(workDir, segName + ".dem"));
                    AddFileEntry(new SegmentFile(segName, workDir, result, lastWriteTime));
                }
            }
        }

        private void butBrowseGameDir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "gameinfo.txt | gameinfo.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
                boxGameDir.Text = Path.GetDirectoryName(dialog.FileName);
        }

        private void butBrowseWorkDir_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog dialog = new VistaFolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
                boxWorkDir.Text = dialog.SelectedPath;
        }

        private void butHowTo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
First make sure the script you're using for propclip grinding produces .dem and .sav files with the same name, and there's at least a second between each successful attempt

Then select your Game's Directory.

Then choose a Working Directory where your .dem and .save will be saved, make sure this folder is empty to avoid confusion.

Then simply begin the script! Successful tries will automatically be cataloged and moved into the Working Directory.

If you wish to export a specific segment, select it in the List and press Copy Selected and choose the folder of your choice.
", "How to Use");
        }

        private void butCopySelect_Click(object sender, EventArgs e)
        {
            if (dgvFiles.SelectedCells.Count == 0)
                return;

            int index = int.Parse(dgvFiles.Rows[dgvFiles.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            VistaFolderBrowserDialog dialog = new VistaFolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                _files[index].Copy(dialog.SelectedPath);
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(boxWorkDir.Text) && _files.Count > 0)
            {
                DialogResult d = MessageBox.Show("Are you sure to delete all .dem and .sav in the List?", "Clear", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    _files.ForEach(x => x.Remove());
                    _files.Clear();
                }
            }
        }
    }
}
