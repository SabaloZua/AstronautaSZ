using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqteste
{
    public class Produtos
    {
        public int Id { get; set; }
        public string? Descrisao { get; set; }
        public decimal Unitario { get; set; }
        public int Quantidade { get; set; }
        public string? Setor { get; set; }

        public Produtos() { }

        public Produtos(int id, string descrisao, decimal unitario, int quantidade, string setor)
        {
            Id = id;
            Descrisao = descrisao;
            Unitario = unitario;
            Setor = setor;
            Quantidade = quantidade;
        }
        // Metodo que busca os dados da Lista
        public List<Produtos> GetALL()
        {
            var listaProdutos = new List<Produtos>();
            listaProdutos.Add(new Produtos(2, "Cafe em po 250 gramas", 10.83M, 15, "Alimentos"));
            listaProdutos.Add(new Produtos(4, "Sabão em po 500 gramas", 16.50M, 12, "Limpeza"));
            listaProdutos.Add(new Produtos(7, "Óleo de soja 1 litro", 7.23M, 26, "Alimentos"));
            listaProdutos.Add(new Produtos(13, "Cafe em po 500 gramas", 19.99M, 8, "Alimentos"));
            listaProdutos.Add(new Produtos(18, "Óleo de gerassol 1 litro", 9.56M, 32, "Alimentos"));
            listaProdutos.Add(new Produtos(21, "Sabão em pedra 250 gramas", 4.12M, 63, "Limpeza"));
            listaProdutos.Add(new Produtos(27, "Sumo  de Mucua 350 ml", 3.89M, 79, "Alimentos"));
            return listaProdutos;

        }



    }
}
