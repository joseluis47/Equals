using System;
using System.Collections.Generic;
using System.Text;

namespace Usuarios.Entities
{
    class Acesso
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Acesso(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public Acesso()
        {
        }


        public Acesso(string arquivo)
        {

            string[] linha = arquivo.Split(" ");
            Name = linha[0];
            Date = DateTime.Parse(linha[1]);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Acesso))
            {
                throw new Exception("Parâmetro não é Acesso");
            }
            Acesso outros = obj as Acesso;
            return Name.Equals(outros.Name);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
