using Sandbox.Game;
using VRage.Plugins;

namespace NoFeedbackOnExit
{
    public class Main : IPlugin
    {
        public void Dispose()
        {
            
        }

        public void Init(object gameInstance)
        {
            MyPlatformGameSettings.FEEDBACK_ON_EXIT = false;
            MyPlatformGameSettings.FEEDBACK_URL = "";
        }

        public void Update()
        {
            
        }
    }
}
