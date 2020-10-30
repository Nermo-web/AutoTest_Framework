﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest_Framework.UiElements
{
    public class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.Id, Using = "menu-item-25")]
        public IWebElement Introduction { get; set; }
        [FindsBy(How = How.Id, Using = "menu-item-106")]
        public IWebElement Selectors { get; set; }
        [FindsBy(How = How.Id, Using = "menu-item-35")]
        public IWebElement SpecialElements { get; set; }
        [FindsBy(How = How.Id, Using = "menu-item-57")]
        public IWebElement TestCases { get; set; }
        [FindsBy(How = How.Id, Using = "menu-item-58")]
        public IWebElement TestScenarios { get; set; }
        [FindsBy(How = How.Id, Using = "menu-item-26")]
        public IWebElement About { get; set; }

    }
}
