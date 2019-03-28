using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace HW_5_1_NUnit
{
    public class StepBase
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            if (Browser.Driver == null)
                Browser.Initialize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.Driver.Quit();
            Browser.Driver.Dispose();
        }
    }
}


