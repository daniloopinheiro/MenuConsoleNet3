using System;
using System.Collections.Generic;

namespace Body
{
    // Objetivo desta classe é apenas retorna textos(strings).
    public class Titles
    {
        public string Itens {get; set;}
        string[] numItens {get; set;}

        // Construtor da classe.
        public Titles()
        {
        }

        // Metódo apenas retorna textos unicos.
        public string Principal()
        {
            return "Menu Console do Asp.Net 3";
        }

        // Metódo apenas retorna lista de textos.
        public void Options()
        {
            // Lembrar de importar o assemblie do List<>.
            List<Titles> optins = new List<Titles>();

            optins.Add(new Titles() {Itens = "Primeiro"});
            optins.Add(new Titles() {Itens = "Segundo"});

        }

        // 
        public override string ToString()
        {
            numItens = new string[5];

            foreach (var item in numItens)
            {
                Console.WriteLine(item);
            }
            
            return $"{numItens}:" + Itens;
        }
    }
}
