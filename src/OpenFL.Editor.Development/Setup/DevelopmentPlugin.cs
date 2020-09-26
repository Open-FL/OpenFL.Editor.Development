using PluginSystem.Utility;

namespace OpenFL.Editor.Development.Setup
{
    public class DevelopmentPlugin : APlugin<FLEditorPluginHost>
    {

        public override string Name => "fl-editor-development";

        public override bool IsMainPlugin => true;

    }
}