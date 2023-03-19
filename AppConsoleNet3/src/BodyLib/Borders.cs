using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BodyLib
{
    public class Borders
    {
        private string _top;
        private string _center;
        private string _button;
        
        public Borders(){}
        
        public Borders(string top, string center, string button)
        {
            _top = top;
            _center = center;
            _button = button;
        }

        public string GetTop(string top)
        {
            Console.Write(_top = "\t==========\t");
            return top;
        }

        public string GetCenter(string center)
        {
            Console.Write(_center = "**********");
            return center;  
        }

        public string GetButton(string button)
        {
            Console.Write(_button = "----------");
            return button;
        }
    }
}