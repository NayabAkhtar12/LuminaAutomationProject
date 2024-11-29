using AventStack.ExtentReports;
using Lumina_AI.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace Live_Earth_Map.Pages
{
    class TextToImage
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        AdHelper AdHelper;

        //Constructor
        public TextToImage(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.AdHelper = new AdHelper(driver);
        }

        public void TexttoImsage()
        {
            ExtentTest test = Extent.CreateTest("Report 1");

            //Prompt 1
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("Generate an image of a cat playing with a ball");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(30000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    if (AdHelper.IsAdPresent())
                    {
                        AdHelper.HandleAd();
                    }
                }
                catch (Exception ex)
                {
                    HandleException(" - AdHelper.HandleAd Generate Button", ex);
                }


                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    watchadimage3menu.Click();
                    Thread.Sleep(20000);
                    WatchVideoAd.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    if (AdHelper.IsAdPresent())
                    {
                        AdHelper.HandleAd();
                    }
                }
                catch (Exception ex)
                {
                    HandleException(" - AdHelper.HandleAd Generate Button", ex);
                }

                Thread.Sleep(40000);


                try
                {
                    DownloadImage.Click();
                    WatchVideoAd.Click();

                    try
                    {
                        if (AdHelper.IsAdPresent())
                        {
                            AdHelper.HandleAd();
                        }
                    }
                    catch (Exception ex)
                    {
                        HandleException(" - AdHelper.HandleAd download Button", ex);
                    }

                    driver.Navigate().Back();

                    driver.BackgroundApp(TimeSpan.FromSeconds(5));

                    // Perform other actions while the app is in the background (if needed)

                    // Bring the app back to the foreground
                    driver.LaunchApp();


                    Thread.Sleep(5000);
                }
                catch (Exception ex)
                {
                    HandleException(" - Downloading Image Button", ex);
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);

                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);

                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            //Prompt 2
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("Generate a blog post outlining the future of renewable energy.");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            //Prompt 3

            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("Develop a character sketch for a hero with an unusual superpower.");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            //Prompt 4
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("Rubber Duck Aliens visiting the Earth for the first time, hyper-realistic, cinematic, detailed --ar 16:9\r\n\r\n");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            //Prompt 5
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("earth after human extinction, a new beginning, nature taking back the planet, harmony, peace, earth balanced --version 3 --s 42000 --uplight --ar 4:3 --no text, blur, people, humans, pollution");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }


            //Prompt 6
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("Reunion of man, team, squad, cyberpunk, abstract, full hd render + 3d octane render +4k UHD + immense detail + dramatic lighting + well lit + black, purple, blue, pink, cerulean, teal, metallic colours, + fine details + octane render + 8k");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);

                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }


            //Prompt 7
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("2 medieval warriors ::0.4 travelling on a cliff to a background castle , view of a coast line landscape , English coastline, Irish coastline, scottish coastline, perspective, folklore, King Arthur, Lord of the Rings, Game of Thrones. Photographic, Photography, photorealistic, concept art, Artstation trending , cinematic lighting, cinematic composition, rule of thirds , ultra-detailed, dusk sky , low contrast, natural lighting, fog, realistic, light fogged, detailed, atmosphere hyperrealistic , volumetric light, ultra photoreal, | 35mm| , Matte painting, movie concept art, hyper-detailed, insanely detailed, corona render, octane render, 8k, --ar 3:1 --no blur");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            //Prompt 8
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("viking north druid lich mermaid king wise old man god of death witch pagan face portrait, underwater, covered in runes, crown made of bones, necromancer, zdzisław beksiński, mikhail vrubel, hr giger, gustav klimt, symmetry, mystical occult symbol in real life, high detail, green light --ar 9:16");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            //Prompt 9
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("Samhain figure, creature, wicca, occult, harvest, fall, hyper-realistic, ultra resolution, creepy, dark, witchcore");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            //Prompt 10
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("Sophia Loren in a heart shaped bath tub surrounded by rubber ducks:: hightly detailed, hyper realistic, photographic, wide angle lens:: in the style of Richard Avedon, Patrick Demarchelier, Vogue, Baron Adolphe De Meyer:: --ar 9:16 --q 2");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            //Prompt 11
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("A digital art piece of a giant octopus made of jelly beans, attacking a city skyline");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            //Prompt 11
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            //Prompt 11
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("An AI-generated image that is blurry and distorted, representing a failed output from the app.\r\n\r\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            //Prompt 12
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("A person using a laptop with an AI app open, with an image being generated as the output on the screen\r\n\r\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            //Prompt 13
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("A quirky, retro diner scene in the style of Edward Hopper\r\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            //Prompt 14
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("A man without a beard");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            //Prompt 15
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("A turtle following a metal anchor to the bottom of the sea, fantasy, painting by Greg Rutkowski and Alphonse Mucha");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            //Prompt 16
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("The goddess of chaos intricate elegant, highly detailed, digital painting, artstation, concept art, smooth, sharp focus, illustration, art by artgerm and greg rutkowski and alphonse mucha, heavily influenced by frank frazetta and boris vallejo");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            //Prompt 17
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("Realistic portrait of a woman with thin gold roses, intricate, elegant, highly detailed, wonderful eyes, sweet, digital painting, artstation, concept art, smooth, sharp focus, illustration, art by artgerm and greg rutkowski and alphonse mucha and williamadolphe bouguereau");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            //Prompt 18
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("Beautiful ocean, pirate ship, natural lighting, mm photography, highly detailed, K, artgerm, sharp focus, cgsociety, cool lighting.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            //Prompt 19
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("Beautiful anime girl, hourglass slim figure, techwear hakama, black hair, body portrait, slight smile, highly detailed, digital painting, artstation, concept art, sharp focus, illustration, art by wlop and greg rutkowski and alphonse mucha and artgerm.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            //Prompt 20
            try
            {
                // Initialize WebDriverWait with a timeout of 10 seconds
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                try
                {
                    EditPrompt.SendKeys("Portrait of rugged male ranger dd muscular fantasy intricate elegant headshot portrait detailed face coherent face highly detailed digital painting artstation concept art smooth sharp focus illustration art by artgerm and greg rutkowski and alphonse mucha");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in Edit Prompt: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    Generate.Click();
                    Thread.Sleep(10000);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on Generate Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }

                try
                {
                    wait.Until(d => GenerateMore.Displayed);
                    Thread.Sleep(20000);
                    GenerateMore.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred on GenerateMore Button: " + ex.Message);
                    Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in Text to Image Module: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }


        }
        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }
        IWebElement TextToImageMenu => driver.FindElementById("");
        IWebElement EditPrompt => driver.FindElementById("com.lumina.aiart.artgenerator.artavatar:id/promptEditText");
        IWebElement Generate => driver.FindElementById("com.lumina.aiart.artgenerator.artavatar:id/generateButton");
        IWebElement Discard => driver.FindElementById("com.lumina.aiart.artgenerator.artavatar:id/yesBtn");
        IWebElement GenerateMore => driver.FindElementById("com.lumina.aiart.artgenerator.artavatar:id/btnTv");
        IWebElement CloseRating => driver.FindElementById("com.lumina.aiart.artgenerator.artavatar:id/iv_close");

        IWebElement WatchVideoAd => driver.FindElementById("com.lumina.aiart.artgenerator.artavatar:id/yesBtn");
        IWebElement watchadimage3menu => driver.FindElementById("com.lumina.aiart.artgenerator.artavatar:id/overlayImg3");
        IWebElement TextToImageMenu2 => driver.FindElementById("");
        IWebElement DownloadImage => driver.FindElementById("com.lumina.aiart.artgenerator.artavatar:id/downloadBtn");



    }
}
