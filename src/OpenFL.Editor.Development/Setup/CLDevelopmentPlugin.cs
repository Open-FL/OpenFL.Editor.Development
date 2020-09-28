using System.Drawing;
using System.IO;
using System.Windows.Forms;

using OpenFL.Editor.Forms;
using OpenFL.Editor.Utils.Plugins;

using PluginSystem.Utility;

using ThemeEngine.Forms;

using Utility.IO.Callbacks;
using Utility.ProgressFeedback;
using Utility.WindowsForms.CustomControls;

namespace OpenFL.Editor.Development.Setup
{
    public class CLDevelopmentPlugin : APlugin<FLEditorPluginHost>
    {

        [ToolbarItem("CL", 3)]
        private void CLDummy()
        {
        }

        private void UnpackResources(IProgressIndicator indicator)
        {
            string workingDir = FLScriptEditor.Settings.WorkingDir ?? Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(Application.StartupPath);
            string[] files = IOManager.GetFiles("resources");

            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                indicator.SetProgress("Unpacking file: " + file, i, files.Length - 1);
                string dir = Path.GetDirectoryName(file);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                if (!File.Exists(file))
                {
                    Stream s = IOManager.GetStream(file);
                    Stream dst = File.Create(file);
                    s.CopyTo(dst);
                    s.Dispose();
                    dst.Dispose();
                }
            }

            Directory.SetCurrentDirectory(workingDir);
        }

        [ToolbarItem("CL/Unpack Resources", 2)]
        public void UnpackResources()
        {
            ProgressIndicator.RunTask(UnpackResources, Application.DoEvents);
            if (StyledMessageBox.Show(
                                "Do you want to load the unpacked files? (Requires Restart)",
                                "Unpacking Finished.",
                                MessageBoxButtons.YesNo, SystemIcons.Question
                               ) ==
                DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        [ToolbarItem("CL/Reload Resources(Restart Editor)", 2)]
        public void ReloadResources()
        {
            Application.Restart();
        }



    }
}