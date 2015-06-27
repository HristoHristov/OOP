using System;
namespace P4_HTML_Dispatcher
{
    static class HTMLDispatcher
    {
        private static string img;
        private static string url;
        private static string input;

        private static void CheckingData(string data)
        {           
                if (data.Length < 2 || data == null)
                {
                    throw new ArgumentOutOfRangeException("The input data length should be more than 2 characters!");
                }            
        }

        public static void CreateImage(string imageSorce, string alt, string title)
        {
            HTMLDispatcher.CheckingData(imageSorce);
            HTMLDispatcher.CheckingData(alt);
            HTMLDispatcher.CheckingData(title);            
            HTMLDispatcher.img = String.Format("<img src=\"{0}\" alt=\"{1}\" title=\"{2}\" />", imageSorce, alt, title);
        }        
        public static void CreateURL(string url, string text, string title)
        {
            HTMLDispatcher.CheckingData(url);
            HTMLDispatcher.CheckingData(text);
            HTMLDispatcher.CheckingData(title);
            HTMLDispatcher.url = String.Format("<a href=\"{0}\" title=\"{1}\">{2}</a>", url, title, text);
        }
        public static void CreateInput(string type, string name, string value)
        {
            HTMLDispatcher.CheckingData(type);
            HTMLDispatcher.CheckingData(name);
            HTMLDispatcher.CheckingData(value);
            HTMLDispatcher.input = String.Format("<inpt type=\"{0}\" name=\"{1}\" value=\"{2}\" />", type, name, value);
        }

        public static string GetImage
        {
            get { return HTMLDispatcher.img; }
        }
        public static string GetURL
        {
            get { return HTMLDispatcher.url; }
        }
        public static string GetInput
        {
            get { return HTMLDispatcher.input;}
        }
    }
}
