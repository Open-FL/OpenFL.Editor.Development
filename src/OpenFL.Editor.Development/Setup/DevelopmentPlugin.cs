using PluginSystem.Utility;

namespace OpenFL.Editor.Development.Setup
{
    public class DevelopmentPlugin : APlugin<FLEditorPluginHost>
    {

        public override string Name => "fl-debugger-development";

        public override bool IsMainPlugin => true;

    }
}