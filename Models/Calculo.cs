using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valor_Prestacao.Models
{
    public class Calculo
    {
        private double Prestacao { get; set; }
        private double Valor { get; set; }
        private double Taxa { get; set; }
        private int Tempo { get; set; }



        public Calculo(double calcula_prestacao, double valor, double taxa, int tempo)
        {
            this.Prestacao = Prestacao;
            this.Valor = valor;
            this.Taxa = taxa;
            this.Tempo = tempo;
        }



        public double RetornaValor_Prestacao()
        {


            Prestacao = Valor + (Valor * (Taxa / 100) * Tempo);

            return Prestacao;
        }








    }
}
