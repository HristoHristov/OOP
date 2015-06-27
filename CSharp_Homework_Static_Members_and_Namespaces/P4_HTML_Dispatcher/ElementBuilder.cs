namespace P4_HTML_Dispatcher
{
    using System;

    class ElementBuilder
    {
        private static string element;
        private static string attribute = "";
        private static string content = "";
        private static string result = "";
        public ElementBuilder(string elemName)
        {
            this.ElementName = elemName;
        }

        public void CheckingData(string data)
        {
            if (data.Length < 2 || data == null)
            {
                throw new ArgumentOutOfRangeException("The input data length should be more than 2 characters!");
            }
        }

        public string ElementName
        {
            get { return ElementBuilder.element; }
            private set
            {
                CheckingData(value);
                ElementBuilder.element = value;
            }
        }
        public void AddAtribute(string attribute, string value)
        {
            CheckingData(attribute);
            CheckingData(value);
            ElementBuilder.attribute += " " + attribute + "=\"" + value + "\"";
        }
        public string AddContent
        {
            get { return ElementBuilder.content; }
            set
            {
                CheckingData(value);
                ElementBuilder.content += value;
            }
        }
        
        public  static ElementBuilder operator *(ElementBuilder f1, int count)
        {
            
            for (int i = 0; i < count; i++)
            {
                result += "<" + ElementBuilder.element + ElementBuilder.attribute + 
                          ">" + ElementBuilder.content + "</" + ElementBuilder.element + ">";
            }
            return new ElementBuilder(ElementBuilder.result);
            
        }
        public override string ToString()
        {
            return String.Format(ElementBuilder.result);
        }


    }
}
