using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.Msie;
using JavaScriptEngineSwitcher.V8;

namespace EstateAgents.CMS.App_Start
{
    public class JsEngineSwitcherConfig
    {
        public static void Configure(JsEngineSwitcher engineSwitcher)
        {
            engineSwitcher.EngineFactories
                .AddMsie(new MsieSettings
                {
                    UseEcmaScript5Polyfill = true,
                    UseJson2Library = true
                })
                .AddV8()
                ;

            engineSwitcher.DefaultEngineName = ChakraCoreJsEngine.EngineName;
        }
    }
}