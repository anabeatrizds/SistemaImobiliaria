using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaParcialImobiliaria.Model
{
    class Imoveis
    {
        private int id;
        private String nomeproprietario;
        private String endereco;
        private float valor;
        private String date;
        private String foto;

        public Imoveis(int id, string nomeproprietario, string endereco, float valor, String date, string foto)
        {
            this.Id = id;
            this.Nomeproprietario = nomeproprietario;
            this.Endereco = endereco;
            this.Valor = valor;
            this.Date = date;
            this.Foto = foto;
        }

        public int Id { get => id; set => id = value; }
        public string Nomeproprietario { get => nomeproprietario; set => nomeproprietario = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public float Valor { get => valor; set => valor = value; }
        public String Date { get => date; set => date = value; }
        public string Foto { get => foto; set => foto = value; }
    }
}
