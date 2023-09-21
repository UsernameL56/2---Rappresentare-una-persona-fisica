using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Classe2
{
    public class Class1
    {
    }

    public class Persona
    {
        // attributi
        private int codice;
        private string cognome;
        private string nome;
        private bool registrato;

        public string Output()
        {
            if(registrato == true)
            {
                string stringa = codice + cognome + nome + registrato;
                return stringa;
            }else
                return string.Empty;
        }

        // costruttore 
        public Persona(int codice, string cognome, string nome, bool registrato) 
        {
            setCodice(codice);
            setCognome(cognome);
            setNome(nome);
            setRegistrato(registrato);
        }

        public void setCodice(int codice)
        {
            this.codice = codice;
        }
        public void setCognome(string cognome)
        {
            this.cognome = cognome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setRegistrato(bool registrato)
        {
            this.registrato = registrato;
        }
    }
}
