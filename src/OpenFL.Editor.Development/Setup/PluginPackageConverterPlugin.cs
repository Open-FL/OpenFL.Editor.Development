using OpenFL.Editor.Development.Forms;
using OpenFL.Editor.Utils.Plugins;

using PluginSystem.Utility;

namespace OpenFL.Editor.Development.Setup
{
    public class PluginPackageConverterPlugin : APlugin<FLEditorPluginHost>
    {

        public override string Name => "fl-debugger-plugin-package-converter";

        private BatchPluginPackageConverterForm bf;

        private PluginPackageConverterForm f;

        [ToolbarItem("Plugins/Batch Package Converter", 2)]
        public void OnBatchConvert()
        {
            if (bf == null || bf.IsDisposed)
            {
                bf = new BatchPluginPackageConverterForm(PluginAssemblyData);
                bf.Show();
            }
        }

        [ToolbarItem("Plugins/Package Converter", 3)]
        private void OnViewerOpen()
        {
            if (f == null || f.IsDisposed)
            {
                f = new PluginPackageConverterForm(PluginAssemblyData);
                f.Show();
            }
        }

    }
}