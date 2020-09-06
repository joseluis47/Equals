using System;
using System.Collections.Generic;
using System.Text;

namespace Usuarios.Entities
{
    class Acessos
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Acessos(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public Acessos()
        {
        }


        public Acessos(string arquivo)
        {

            string[] linha = arquivo.Split(",");
            Name = linha[0];
            Date = DateTime.Parse(linha[1]);
        }

    }
}
