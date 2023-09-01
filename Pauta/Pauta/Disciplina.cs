using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pauta
{
    public class Disciplina
    {
        public string Nome { get; set; }
       
        public int CargaHoraria { get; set; }

        public Disciplina(string nome, int cargaHoraria)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
        }

    }
}