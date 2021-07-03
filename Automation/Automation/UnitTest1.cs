using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Automation
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            string tn = NUnit.Framework.TestContext.CurrentContext.Test.Name;
            
        }

        [Test, Parallelizable]
        [TestCase(0)]
        public bool Test1(int i)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\hanam\Downloads\chromedriver_win32");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(200));
            DefaultWait<IWebDriver> Hana = new DefaultWait<IWebDriver>(driver);
            Hana.PollingInterval = TimeSpan.FromMilliseconds(200);

            // driver.Navigate().GoToUrl("http:/google.com");
            //driver.Manage().Window.Maximize();
            //IReadOnlyList<IWebElement> links = driver.FindElement(By.XPath("//*[@id ='SIvCob']")).FindElements(By.TagName("a"));
            //System.Console.WriteLine(links.Count);
            //for(int i = links.Count-1; i >= 0; i--)
            //{
            //    Console.WriteLine(links[i].Text);
            //}
            //Assert.Pass();

            // int num = 15;
            // int co = 0;
            // int remainder = 0;
            // string result = "";
            // while (num >= 1)
            // {
            //     remainder = num % 2;
            //     co = num / 2;
            //     num = co;
            //     result = result + remainder.ToString();


            // }
            //Console.WriteLine(result);
            /*
             /////1
             /////12
             /////123
             /////1234
             /////12345
             for (int j = 1; j <=5; j++)
             { 
                 for(int k=1;k<=j; k++)
                 {
                     Console.Write(k);
                 }
                 Console.WriteLine("");
             }*/

            /*             
             /////        1 
             /////       1 2
             /////      1 2 3
             /////     1 2 3 4
             /////    1 2 3 4 5
             
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 5; k >= j; k--)
                {
                    Console.Write(" ");
                }
                for (int m = 1; m <= j; m++)
                {
                    Console.Write(m);
                }
                Console.WriteLine("");
            }*/
            /*
             * 1 2 3 4 5
             *  1 2 3 4 
             *   1 2 3 
             *    1 2
             *     1
             *    
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 0; k <= j; k++)
                {
                    Console.Write(" ");
                }
                for (int m = 1; m <= 6-j; m++)
                {
                    Console.Write(m);
                }
                Console.WriteLine("");
            }*/

            /*
             *        1
             *      1 2 1
             *    1 2 3 2 1
             *  1 2 3 4 3 2 1
             *1 2 3 4 5 4 3 2 1  
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 5; k >= j; k--)
                {
                    Console.Write(" ");
                }
                for (int m = 1; m <= j; m++)
                {
                    Console.Write(m);                    
                }
                for (int z = j-1; z > 0; z--)
                {
                    Console.Write(z);
                }
                Console.WriteLine("");
            }
            */


            int[] A = { 1, 2, 1, 6, 7 };
            string smallval = "";

            if (A.Length == 0)
                return false;

            for (int j =0; j<=A.Length; j++)
            {
                if(A[j]!=0)
                {
                    continue;                    
                }
                else 
                {
                    smallval =smallval+"0";
                    if (smallval.Contains("00"))
                    {
                        if(j<A.Length && A[j]==7)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }

                }

                
            }
            Console.WriteLine(smallval);
            return true;







        }

        [Test, Parallelizable]
        public void Test2()
        {
            
            IWebDriver driver = new ChromeDriver(@"C:\Users\hanam\Downloads\chromedriver_win32");
            driver.Navigate().GoToUrl("http:/facebook.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("hsp.sjbit@gmail.com");            
            driver.FindElement(By.XPath("//input[@id='pass']")).SendKeys("B33719886006516");
            driver.FindElement(By.XPath("//button[@name='login']")).Click();
            driver.FindElements(By.XPath("//div[Contains(Class,\"B6fmyf\")]"));
            IReadOnlyList<IWebElement> links = driver.FindElement(By.XPath("//*[@id ='SIvCob']")).FindElements(By.TagName("a"));
            System.Console.WriteLine(links.Count);
            for (int i = links.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(links[i].Text);
            }
        }

        [Test, Parallelizable]
        public void Test3()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\hanam\Downloads\chromedriver_win32");
             // driver.Navigate().GoToUrl("http:/google.com");
            
            driver.Manage().Window.Maximize();
            IReadOnlyList<IWebElement> links = driver.FindElement(By.XPath("//*[@id ='SIvCob']")).FindElements(By.TagName("a"));
            System.Console.WriteLine(links.Count);
            for (int i = links.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(links[i].Text);
            }
            //Assert.Pass();
        }

    }

}