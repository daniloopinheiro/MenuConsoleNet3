using System;
using BodyLib;

namespace AppMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            new Borders().GetTop(new Titles().GetTitles(new Borders().GetTop(null)));
            // new Borders().GetCenter();
            // new Borders().GetButton();
        }
    }
}
