using System;
using System.IO;
using System.Windows.Forms;

using PluginSystem.Core.Pointer;
using PluginSystem.FileSystem;
using PluginSystem.FileSystem.PackageData;
using PluginSystem.FileSystem.Packer;

namespace OpenFL.Editor.Development.Forms
{
    public partial class PluginPackageConverterForm : Form
    {

        private BasePluginPointer inputPtr;
        private readonly PluginAssemblyPointer Pointer;
        private string unpackedInputPath;

        public PluginPackageConverterForm(PluginAssemblyPointer ptr)
        {
            InitializeComponent();
            Pointer = ptr;
        }

        private void PackerWindow_Load(object sender, EventArgs e)
        {
            if (PluginPacker.FormatCount == 0)
            {
                MessageBox.Show("Can not start the Packer GUI. There is no Plugin Package Format installed.");
                Close();
                return;
            }

            if (PackageDataManager.FormatCount == 0)
            {
                MessageBox.Show("Can not start the Packer GUI. There is no Package Data Format installed.");
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
            btnPack.Enabled = Directory.Exists(tbOutputDir.Text) && tbInputDir.Enabled;
        }

        private void tbInputDir_TextChanged(object sender, EventArgs e)
        {
            panelPack.Enabled = false;
            btnUnpack.Enabled = Directory.Exists(tbInputDir.Text) || File.Exists(tbInputDir.Text);
        }

        private void btnSelectInputDir_Click(object sender, EventArgs e)
        {
            if (fbdInput.ShowDialog() == DialogResult.OK)
            {
                tbInputDir.Text = fbdInput.SelectedPath;
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
            PackageDataManager.GetFormatAt(cbDataFormats.SelectedIndex).SaveData(inputPtr, unpackedInputPath);
            PluginPacker.GetFormatAt(cbPackerFormats.SelectedIndex).Pack(unpackedInputPath, tbOutputDir.Text);
            Directory.Delete(unpackedInputPath, true);
            Close();
        }

        private void btnUnpack_Click(object sender, EventArgs e)
        {
            string tempDir = Path.Combine(PluginPaths.GetPluginTempDirectory(Pointer), "TempUnpack");
            if (Directory.Exists(tempDir))
            {
                Directory.Delete(tempDir, true);
            }

            Directory.CreateDirectory(tempDir);
            rtbInputInfo.Text = "";
            try
            {
                rtbInputInfo.Text += "Unpacking: ";
                PluginPacker.Unpack(tbInputDir.Text, tempDir);
                rtbInputInfo.Text += "SUCCESS\nReading Data Format: ";
                unpackedInputPath = tempDir;
                inputPtr = PackageDataManager.LoadData(tempDir);
                rtbInputInfo.Text += "SUCCESS";
                panelPack.Enabled = true;
            }
            catch (Exception exception)
            {
                Directory.Delete(tempDir, true);
                rtbInputInfo.Text += "FAILED\n";
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