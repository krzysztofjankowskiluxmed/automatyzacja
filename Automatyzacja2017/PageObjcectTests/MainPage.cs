using System;

using System.Linq;



namespace PageObjcectTests

{

    internal class MainPage

    {

        private static string url = "https://autotestdotnet.wordpress.com/";



        internal static void GoTo()

        {

            Browser.NavigateTo(url);



        }



        internal static void OpenFirstNote()

        {

            var element = Browser.FindByXpath("//article/header");

            element.First().Click();

        }

    }

}