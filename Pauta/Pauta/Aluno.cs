using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pauta
{

    class Aluno
    {

        private string NomeAluno { get; set; }
        private double? Nota1 { get; set; }
        private double? Nota2 { get; set; }
        private string Status { get; set; }
        private bool IsSemestreFinalizado { get; set; }
        private double Faltas { get; set; }
        public Disciplina Materia { get; set; }


        public Aluno(string nomeAluno,
                    Disciplina materia,
                     int faltas = 0,
                     double? nota1 = null,
                     double? nota2 = null
                     ) {
            NomeAluno = nomeAluno;
            Materia = materia;
            Nota1 = nota1;
            Nota2 = nota2;
            Status = "Cursando";
            Faltas = faltas;
            VerificarSemestreFinalizado();



        }
        public double? AtribuirNota1(double nota1) {
            Nota1 = nota1;
            VerificarSemestreFinalizado();
            return nota1;

        }
        public double? AtribuirNota2(double nota2)
        {
            Nota2 = nota2;
            VerificarSemestreFinalizado();
            return Nota2;
        }
        public double? CalcularMedia()
        {
            return (Nota1 + Nota2) / 2;
        }
        public void AtribuirFalta()
        {
            Faltas++;
        }
        private void VerificarSemestreFinalizado()
        {
            if (Nota1 != null && Nota2 != null) {
                IsSemestreFinalizado = true;
                VerificarStatus();
            }
            else
            {
                IsSemestreFinalizado = false;
            }
        }
        public void VerificarStatus()
        {
            double? media = CalcularMedia();
            if (Faltas / (double)Materia.CargaHoraria <= 0.25 && media >= 7)
            {
                Status = "Aprovado";
            }
            else {
                Status = "Reprovado";
            }

        }

        public void DecrescerFalta()
        {
            Faltas--;
            VerificarStatus();
        }
        public void AcrescentarFalta()
        {
            Faltas++;
            VerificarStatus();
        }
        public override string ToString()
        {
            return $"O aluno {NomeAluno} está {Status} na disciplina {Materia.Nome}";
        }
    }   
}