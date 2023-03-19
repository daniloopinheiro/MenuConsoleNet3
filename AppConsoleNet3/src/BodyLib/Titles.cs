using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BodyLib
{
    public class Titles
    {
         // Objetivo desta classe é apenas retorna textos(strings).
        private string _itens; 
        private string[] _numItens;

        public Titles()
        {
        }

        public Titles(string itens, string[] numItens)
        {
            _itens = itens;
            _numItens = numItens;
        }
        
        // Metódo apenas retorna textos unicos.
        public string GetTitles(string title)
        {
            Console.Write(_itens = "Menu Console do Asp.Net 3");
            return title;
        }
        
        public string[] GetOptions(string[] options)
        {
            // Lembrar de importar o assemblie do List<>.
            // List<Titles> option = new List<Titles>();
            
            return _numItens = options;
        }
        
        // 
        // public override string ToString()
        // {
        //     numItens = new string[5];
        //
        //     foreach (var item in numItens)
        //     {
        //         Console.WriteLine(item);
        //     }
        //     
        //     return $"{numItens}:" + Itens;
        // }
    }
}