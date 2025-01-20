// EN: Create a program that asks the user for the full amount of their purchase. Apply a 10% discount on the total purchase. Print the amount after the discount
// PT: Crie um programa que solicite ao usuário o valor total de sua compra. Aplique um desconto de 10% no total da compra. Imprima o valor após o desconto.

Console.Write("What is the total value of your purchase?: ");
int total_value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"With the 10% discount the final value is a: {total_value - (total_value * 0.1)}");