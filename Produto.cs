using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wishlist
{
    internal class Produto
    {
        public string Descricao { get; set; }
        public double ValorMin { get; private set; }
        public double ValorMax { get; private set; }

        public Produto(string descricao, double valorMin, double valorMax)
        {
            Descricao = descricao;
            ValorMin = valorMin;
            ValorMax = valorMax;
        }

        public void AlterarValorMinimo(double valor)
        {
            if (valor < ValorMax)
                ValorMin = valor;
        }

        public void AlterarValorMaximo(double valor)
        {
            if (valor > ValorMin) 
                ValorMax = valor; 
        }

        public override string ToString()
        {
            return Descricao 
                + " / R$ " + ValorMin.ToString("F2", CultureInfo.InvariantCulture) 
                + " - R$ " +ValorMax.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
