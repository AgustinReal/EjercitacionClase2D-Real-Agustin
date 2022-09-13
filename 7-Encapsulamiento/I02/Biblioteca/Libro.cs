using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                string retorno = String.Empty; //String vacio

                if (i >=0 && i < this.paginas.Count) //aca valido que Index que lea la pagina este en el rango del libro. 
                {
                    retorno = paginas[i];
                }
                return retorno;
            }

            set
            {
                if(i>=0)
                {
                    this.paginas.Insert(i, value);
                }
                else if(i > this.paginas.Count)
                {
                    this.paginas.Add(value);
                }
            }
        }
    }
}
