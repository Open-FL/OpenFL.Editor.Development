using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using PluginSystem.Core.Pointer;
using PluginSystem.FileSystem;
using PluginSystem.FileSystem.PackageData;
using PluginSystem.FileSystem.Packer;

using ThemeEngine.Forms;

namespace OpenFL.Editor.Development.Forms
{
    public partial class BatchPluginPackageConverterForm : Form
    {

        private BasePluginPointer[] inputPtr;
        private readonly PluginAssemblyPointer Pointer;
        private string[] unpackedInputPath;

        public BatchPluginPackageConverterForm(PluginAssemblyPointer ptr)
        {
            InitializeComponent();
            Pointer = ptr;
        }

        private void PackerWindow_Load(object sender, EventArgs e)
        {
            if (PluginPacker.FormatCount == 0)
            {
                StyledMessageBox.Show("Error","Can not start the Packer GUI. There is no Plugin Package Format installed.", MessageBoxButtons.OK, SystemIcons.Error);
                Close();
                return;
            }

            if (PackageDataManager.FormatCount == 0)
            {
                StyledMessageBox.Show("Error","Can not start the Packer GUI. There is no Package Data Format installed.", MessageBoxButtons.OK, SystemIcons.Error);
                Close();
                return;
            }

            cbPackerFormats.Items.Clear();
            for (int i = 0; i < PluginPacker.FormatCount; i++)
            {
                cbPackerFormats.Items.Add(PluginPacker.GetFormatAt(i));
            }

            cbPackerFormats.SelectedIndex = 0;

            for (int i = 0; i < PackageDataManager.FormatCount; i++)
            {
                cbDataFormats.Items.Add(PackageDataManager.GetFormatAt(i));
            }

            cbDataFormats.SelectedIndex = 0;
        }

        private void tbOutputDir_TextChanged(object sender, EventArgs e)
        {
            btnPack.Enabled = Directory.Exists(tbOutputDir.Text) && btnUnpack.Enabled;
        }

        private void tbInputDir_TextChanged(object sender, EventArgs e)
        {
            panelPack.Enabled = false;
            btnUnpack.Enabled = File.Exists(tbInputDir.Text);
        }

        private void ShowInputDialog()
        {
            if (ofdInput.ShowDialog() == DialogResult.OK)
            {
                tbInputDir.Text = ofdInput.FileName;
            }
        }

        private void btnSelectOutputDir_Click(object sender, EventArgs e)
        {
            if (fbdOutput.ShowDialog() == DialogResult.OK)
            {
                tbOutputDir.Text = fbdOutput.SelectedPath;
            }
        }

        private void cbPackerFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnPack.Enabled)
            {
                btnPack.Enabled = cbPackerFormats.SelectedIndex != -1;
            }
        }

        private void btnPack_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < unpackedInputPath.Length; i++)
            {
                string s = unpackedInputPath[i];
                PackageDataManager.GetFormatAt(cbDataFormats.SelectedIndex).SaveData(inputPtr[i], s);
                string path = Path.Combine(tbOutputDir.Text, inputPtr[i].PluginName);
                Directory.CreateDirectory(path);
                PluginPacker.GetFormatAt(cbPackerFormats.SelectedIndex).Pack(s, path);
                Directory.Delete(unpackedInputPath[i], true);
            }

            Close();
        }

        private void btnUnpack_Click(object sender, EventArgs e)
        {
            string[] files = File.ReadAllLines(tbInputDir.Text);
            unpackedInputPath = new string[files.Length];
            inputPtr = new BasePluginPointer[files.Length];
            rtbInputInfo.Text = "";
            for (int i = 0; i < files.Length; i++)
            {
                string tempDir = Path.Combine(PluginPaths.GetPluginTempDirectory(Pointer), "TempUnpack");
                if (Directory.Exists(tempDir))
                {
                    Directory.Delete(tempDir, true);
                }

                Directory.CreateDirectory(tempDir);
                try
                {
                    rtbInputInfo.Text += $"Unpacking({Path.GetFileName(files[i])}): ";
                    PluginPacker.Unpack(files[i], tempDir);
                    rtbInputInfo.Text += "SUCCESS\nReading Data Format: ";
                    inputPtr[i] = PackageDataManager.LoadData(tempDir);
                    string outPath = Path.Combine(PluginPaths.GetPluginTempDirectory(Pointer), inputPtr[i].PluginName);
                    if (Directory.Exists(outPath))
                    {
                        Directory.Delete(outPath, true);
                    }

                    Directory.Move(tempDir, outPath);
                    unpackedInputPath[i] = outPath;
                    rtbInputInfo.Text += "SUCCESS\n\n";
                    panelPack.Enabled = true;
                }
                catch (Exception exception)
                {
                    Directory.Delete(tempDir, true);
                    rtbInputInfo.Text += "FAILED\n" + exception.Message + "\n\n";
                }
            }
        }

        private void cbDataFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnPack.Enabled)
            {
                btnPack.Enabled = cbDataFormats.SelectedIndex != -1;
            }
        }

    }
}