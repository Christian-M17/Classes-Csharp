using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMatematica
{
    internal class Matematica
    {
        public void Triplo(int numero)
        {
            int resultado = numero * 3;
            MessageBox.Show("O triplo de " + numero + " é: " + resultado);
        }
        public void Quadrado(int numero)
        {
            int resultado = numero * numero;
            MessageBox.Show(numero + " Elevado ao quadrado é: " + resultado);
        }
        public void Soma(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            MessageBox.Show(numero1 + " somado a " + numero2 + " é: " + resultado);
        }
    }
}
