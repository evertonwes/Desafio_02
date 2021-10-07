using System;

namespace Desafio_02
{
    class Program
    {

        static void Main(string[] args)
        {
            //Imprime na tela
            Console.WriteLine(" UBUNTU 002 - STARTS...");
            Console.WriteLine(" ");

            string nome1 = "Ubuntu1 Silva";
            int idade1 = 33;
            decimal peso1 = 88.50M;
            decimal altura1 = 1.65M;
            bool EhDev1 = true;

            Console.Write(" Nome = ");
            Console.WriteLine(nome1);
            Console.Write(" Idade = ");
            Console.WriteLine(idade1);
            Console.Write(" Kg = ");
            Console.WriteLine(peso1);
            Console.Write(" Altura= ");
            Console.WriteLine(altura1);
            Console.Write(" Dev = ");
            Console.WriteLine(EhDev1);
            Console.WriteLine(" ");

            string nome2 = "Ubuntu2 Santos";
            int idade2 = 26;
            decimal peso2 = 84.50M;
            decimal altura2 = 2.10M;
            bool EhDev2 = true;

            Console.Write(" Nome = ");
            Console.WriteLine(nome2);
            Console.Write(" Idade = ");
            Console.WriteLine(idade2);
            Console.Write(" Kg = ");
            Console.WriteLine(peso2);
            Console.Write(" Altura= ");
            Console.WriteLine(altura2);
            Console.Write(" Dev = ");
            Console.WriteLine(EhDev2);
            Console.WriteLine(" ");

            string nome3 = "Ubuntu3 Silva";
            int idade3 = 85;
            decimal peso3 = 66.50M;
            decimal altura3 = 1.40M;
            bool EhDev3 = false;

            Console.Write(" Nome = ");
            Console.WriteLine(nome3);
            Console.Write(" Idade = ");
            Console.WriteLine(idade3);
            Console.Write(" Kg = ");
            Console.WriteLine(peso3);
            Console.Write(" Altura= ");
            Console.WriteLine(altura3);
            Console.Write(" Dev = ");
            Console.WriteLine(EhDev3);
            Console.WriteLine(" ");


            //T1 - Somar a idade de todos Ubuntus
            int somaIdade = (idade1 + idade2 + idade3);

            Console.Write(" A soma da idade de todos os Ubuntus é: ");
            Console.WriteLine(somaIdade);
            Console.WriteLine(" ");

            //T2 - Agrupar os nomes de todos Ubuntus
            Console.Write(" Nome de todos os Ubuntos : ");
            Console.WriteLine(nome1 + " " + nome2 + " " + nome3);
            Console.WriteLine(" ");

            //T3 - Calcular Média dos IMC de todos Ubuntus

            decimal IMC1 = peso1 / (altura1 * altura1);

            //Para criar um ojbeto, instanciar um ojbeto bastar dar 'new' e o nome da clase;
            var imcManager = new IMCManager();
            decimal IMC2 = imcManager.PegaIMC(peso2,altura2);

            decimal IMC3 = IMCManager.PegaStaticIMC(peso3, altura3);

            decimal mediaIMC = (IMC1 + IMC2 + IMC3) / 3;

            Console.Write(" A média do IMC de todos os Ubuntos é : ");
            Console.WriteLine(mediaIMC);
            Console.WriteLine(" ");

            //T4 - Contar quantos Ubuntus sao Devs
            int SomaDev = 0;
         
            if (EhDev1)
            {
                SomaDev = SomaDev + 1;
            }

            if (EhDev2) 
            {
                SomaDev = SomaDev + 1;
            } 

            if (EhDev3)
            {
                SomaDev = SomaDev + 1;
            }

            Console.Write(" Quantos Ubuntos são Devs: ");
            Console.WriteLine(SomaDev);
            Console.WriteLine(" ");

            //T5 - Exibir somente Ubuntu com nome Silva
            Console.WriteLine(" Nome dos Ubuntos que contem Sobrenome Silva: ");
            string sobrenome = "Silva";

            if (nome1.Contains(sobrenome))
            {
                Console.WriteLine(" " + nome1);
            }
            if (nome2.Contains(sobrenome))
            {
                Console.WriteLine(" " + nome2);
            }
            if (nome3.Contains(sobrenome))
            {
                Console.WriteLine(" " + nome3);
            }
            Console.WriteLine(" ");



            //Imprime na tela
            Console.WriteLine(" UBUNTU 002 - ENDS...");

            //PAUSA NA TELA (GAMBIARRA PERMITIDA PRA INICIANTES)
            Console.Read();
        }
    
        static decimal GetIMC(decimal peso, decimal altura)
        {
            decimal IMC = (peso / (altura * altura));
            return IMC;
        }
    }

    //Classe contem Funções e Propriedades
    public class IMCManager
    {
        public decimal PegaIMC(decimal peso, decimal altura)
        {
            decimal IMC = (peso / (altura * altura));
            return IMC;
        }

        public static decimal PegaStaticIMC(decimal peso, decimal altura)
        {
            decimal IMC = (peso / (altura * altura));
            return IMC;
        }

    }
}
