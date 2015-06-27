using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P4_HTML_Dispatcher
{
    class P4_HTML_Dispatcher
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAtribute("class", "div's");
            div.AddAtribute("id", "wrapper");
            div.AddContent = "<a href='google.bg'>Google</a>";
            Console.WriteLine(div * 3);

            HTMLDispatcher.CreateImage("Desctop/C#.png", "Image Not Found", "C#");
            Console.WriteLine(HTMLDispatcher.GetImage);

            HTMLDispatcher.CreateURL("http://softuni.bg", "Google", "Google");
            Console.WriteLine(HTMLDispatcher.GetURL);

            HTMLDispatcher.CreateInput("text", "homework", "C#");
            Console.WriteLine(HTMLDispatcher.GetInput);
            
            

        }
    }
}
