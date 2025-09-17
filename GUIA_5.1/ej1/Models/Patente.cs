using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ej1.Models
{
    internal class Patente:IPatentes
    {
        public string Pat { get; private set; }
        public Patente(string patente) { this.Pat = patente; }
        public int DeterminarTipo()
        {
            int tipo = -1;
            int izq = 0; int med = 0; int der = 0; int cont = 0; bool esNumero = true; bool esLetra = true;
            string cadena = this.Pat.Replace(" ","").ToUpper();
            while(esLetra && cont < cadena.Length) //registramos primeros numeros
            {
                char c = (char)cadena[cont];
                if (char.IsLetter(c))
                {
                    izq++; cont++;
                }
                else
                {
                    esLetra = false;
                }
            }
            while(esNumero && cont < cadena.Length)//registramos numeros
            {
                char c = cadena[cont];
                if (char.IsNumber(c))
                {
                    med++; cont++;
                }
                else
                {
                    esNumero = false;
                }
            }
            esLetra = true;
            while(esLetra && cont < cadena.Length)//registramos ultimas letras
            {
                char c = (char)cadena[cont];
                if (char.IsLetter(c))
                {
                    der++; cont++;
                }
                else
                {
                    esLetra = false;
                }
            }
            if(izq == 3 && med == 3 && der == 0) { tipo = 0; }//comprobamos tipo
            else if (izq ==2 && med == 3 && der == 2) { tipo = 1; }
            else if (izq ==2 && med == 3 && der== 3) { tipo = 2; }
            else if (izq ==2 && med == 4 && der == 0) { tipo = 3; }
            return tipo;
        }
    }
}
