using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_o_Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis 
            double HT;

            double SB;
            double IMP;
            double SL;

            Console.Clear(); //Limpando a tela
            Console.WriteLine("Digite o nº de horas trabalhadas: ");//Interface 1
            Console.SetCursorPosition(35, 0); //Posição 1
            HT = double.Parse(Console.ReadLine()); //Entrada 1

            //Operações
            SB = HT * 9.79;
            IMP = SB * 0.05;
            SL = SB - IMP;

            //Saídas
            Console.WriteLine("Salário Líquido: " + SL);
            Console.WriteLine("Salário Bruto: " + SB);
            Console.WriteLine("Imposto: " + IMP);
            Console.ReadLine();
        }
    }
}
