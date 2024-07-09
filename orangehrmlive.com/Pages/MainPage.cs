﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orangehrmlive.com.Pages
{
    public class MainPage
    {
        //private IWebDriver Driver;
        private IWebDriver driver;


        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetMainPageTitle()
        {
            return driver.Title;
        }
    }
}
