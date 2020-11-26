﻿using System;

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
            Console.WriteLine($"O valor total é {total} Reais.");
            float resultado = TotalPagamento(quantidade, preco, total);
            if(resultado > 100){
                Console.WriteLine("Receber brinde");
            }else{
                Console.WriteLine("Receber adesivos para juntar");
            }
            float TotalPagamento(int quantidade, float preco, float total){
                float pagar;
                if(quantidade<=5){
                    float desconto = ((quantidade * preco) * 0.02f);
                    Console.WriteLine($"O desconto é de {desconto} Reais.");
                    pagar = total - desconto;
                    Console.WriteLine($"O total a pagar é {pagar} Reais.");
                }else if(quantidade>5 && quantidade<=10){
                    float desconto = ((quantidade * preco) * 0.03f);
                    Console.WriteLine($"O desconto é de {desconto} Reais.");
                    pagar = total - desconto;
                    Console.WriteLine($"O total a pagar é {pagar} Reais.");
                }else{
                    float desconto = ((quantidade * preco) * 0.05f);
                    Console.WriteLine($"O desconto é de {desconto} Reais.");
                    pagar = total - desconto;
                    Console.WriteLine($"O total a pagar é {pagar} Reais.");
                }
                return pagar;
            }
        }
    }
}
