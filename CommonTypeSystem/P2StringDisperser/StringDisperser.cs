using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2StringDisperser
{
    class StringDisperser : ICloneable, IComparable
    {
        private List<char> _chars= new List<char>();
        private List<string>_parameter = new List<string>();
        private bool isEquals = true;
        public StringDisperser(params string[] parameters)
        {
            this.SetParameter(parameters);                   
        }
        public void SetParameter(params string[] parameters)
        {
            foreach (var param in parameters)
            {
                this._parameter.Add(param.ToString());
            }
        }
        
        public override bool Equals(object obj)
        {
            StringDisperser strDesp = obj as StringDisperser;
            if(strDesp == null)
            {
                return false;
            }
            if (strDesp._parameter.Count > this._parameter.Count || strDesp._parameter.Count < this._parameter.Count)
            {
                return false;
            }
            for (int i = 0; i < strDesp._parameter.Count; i++)
            {
                if(!Object.Equals(strDesp._parameter.ElementAt(i), this._parameter.ElementAt(i)))
                {
                    this.isEquals = false;
                }
            }
            return this.isEquals;
        }
        public static bool operator ==(StringDisperser str1, StringDisperser str2)
        {
            return StringDisperser.Equals(str1, str2);
        }
        public static bool operator !=(StringDisperser str1, StringDisperser str2)
        {
            return !(StringDisperser.Equals(str1, str2));
        }
        public override int GetHashCode()
        {
            var hashCode = this._parameter.ElementAt(0).GetHashCode();
            for (int i = 1; i < this._parameter.Count; i++)
            {
                hashCode ^= this._parameter.ElementAt(i).GetHashCode();
            }
            return hashCode;
        }
        public object Clone()
        {
            return new StringDisperser(this._parameter.ToArray());
        }

        public int CompareTo(object str)
        {
            return this._parameter.ElementAt(0).CompareTo(str);
        }

        public override string ToString()
        {
            string result = "";
            foreach (var elements in this._parameter)
            {
                string[] element = elements.ToString().Split(' ');
                foreach (var elem in element)
                {
                    for (int i = 0; i < elem.Length; i++)
                    {
                        result += elem[i] + " ";
                    }
                }

            }        
            return String.Format("{0}", result);
        }        
    }
}
