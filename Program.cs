using System;

namespace Total_a_pagar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a descrição do produto (nome)");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade adquirida");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço unitário");
            double preco = float.Parse(Console.ReadLine());
            double total = quantidade*preco;
            if(quantidade<=5){
                double pagar = total - (preco*0.02);
                Console.WriteLine($"O total a pagar é {pagar} Reais.");
            }else if(quantidade>5 && quantidade<=10){
                double pagar = total - (preco*0.03);
                Console.WriteLine($"O total a pagar é {pagar} Reais.");
            }else{
                double pagar = total - (preco*0.05);
                Console.WriteLine($"O total a pagar é {pagar} Reais.");
            }
        }
    }
}
