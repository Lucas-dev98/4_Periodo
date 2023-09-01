using Pauta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Disciplina d1 = new Disciplina("Matematica", 20);
        Aluno aluno = new Aluno("Lucas",d1);

        aluno.AtribuirNota1(7);
        aluno.AtribuirNota2(8);
        aluno.AtribuirFalta();
        aluno.AtribuirFalta();
        aluno.DecrescerFalta();      
        Console.WriteLine(aluno);
    }


}