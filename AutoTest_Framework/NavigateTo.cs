using AutoTest_Framework.UiElements;
using System.Threading;

namespace AutoTest_Framework
{
    public static class NavigateTo
    {
        public static void LoginFormScenarioThroughTestCases()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameFieldPost ucPost = new UsernameFieldPost();

            menu.TestCases.Click();
            tcPage.UsernameField.Click();
            ucPost.LoginFormLink.Click();
        }

        public static void LoginFormScenarioThroughMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            tsPage.LoginFormScenario.Click();
        }


    }
}
