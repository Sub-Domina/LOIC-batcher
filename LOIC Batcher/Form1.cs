using System.Diagnostics;
using System.Linq;
using System.Text.Json;

namespace LOIC_Batcher
{
    public partial class Form1 : Form
    {
        private const string SETTING_PATH = "\\LOIC.setting";

        private GlobalSetting globalSetting;
        private BatchSetting batchSetting;
        private TargetCollection targetsCollection;
        private TargetsCollectionView targetsCollectionView;
        private string settingPath;

        public Form1()
        {
            InitializeComponent();

            SaveData? saveData = null;
            settingPath = Application.LocalUserAppDataPath + SETTING_PATH;
            if (!File.Exists(settingPath))
            {
                File.Create(settingPath).Close();
                globalSetting = new GlobalSetting();
                batchSetting = new BatchSetting();
                targetsCollection = new TargetCollection();
                SaveSettings();
            }
            else
            {
                saveData = JsonSerializer.Deserialize<SaveData>(File.ReadAllText(settingPath));
                globalSetting = saveData.GlobalSetting!;
                batchSetting = saveData.BatchSetting!;
                targetsCollection = saveData.TargetsCollection!;
            }

            path.Text = globalSetting.LoicPath;

            threads.Text = batchSetting.Threads;
            sockets.Text = batchSetting.Sockets;
            delay.Value = int.Parse(batchSetting.Delay);
            hiddenCheckBox.Checked = batchSetting.Hidden;

            targetsCollectionView = new TargetsCollectionView(targetsPanel, targetsCollection.Targets);

            targetCount.Text = targetsCollection.Targets.Length.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            Attack();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            targetsCollection.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            targetsCollection.Stop();
            SaveSettings();
        }

        private void SaveSettings()
        {
            SaveData saveData = new SaveData();
            saveData.GlobalSetting = globalSetting;
            saveData.BatchSetting = batchSetting;
            saveData.TargetsCollection = targetsCollection;
            string json = JsonSerializer.Serialize<SaveData>(saveData);
            File.WriteAllText(settingPath, json);
        }

        private void Attack()
        {
            targetsCollection.Stop();
            targetsCollection.Attack(batchSetting, globalSetting);
        }

        private void openFileLOIC_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            path.Text = globalSetting.LoicPath = openFileLOIC.FileName;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileLOIC.ShowDialog(this);
        }

        private void threads_TextChanged(object sender, EventArgs e)
        {
            batchSetting.Threads = threads.Text;
        }

        private void sockets_TextChanged(object sender, EventArgs e)
        {
            batchSetting.Sockets = sockets.Text;
        }

        private void delay_Scroll(object sender, EventArgs e)
        {
            batchSetting.Delay = delay.Value.ToString();
        }

        private void targetCount_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(targetCount.Text, out int count))
                return;
            targetsCollection.SetTargetCount(count);
            targetsCollectionView.SetTargets(targetsPanel, targetsCollection.Targets!);
        }

        private void hiddenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            batchSetting.Hidden = hiddenCheckBox.Checked;
        }
    }
}