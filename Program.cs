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
            float preco = float.Parse(Console.ReadLine());
            float total = quantidade*preco;
            if(quantidade<=5){
                float pagar = total - ((quantidade * preco) * 0.02f);
                Console.WriteLine($"O total a pagar é {pagar} Reais.");
            }else if(quantidade>5 && quantidade<=10){
                float pagar = total - ((quantidade * preco) * 0.03f);
                Console.WriteLine($"O total a pagar é {pagar} Reais.");
            }else{
                float pagar = total - ((quantidade * preco) * 0.05f);
                Console.WriteLine($"O total a pagar é {pagar} Reais.");
            }
        }
    }
}
