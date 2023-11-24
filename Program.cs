Console.WriteLine("Entrada Válida");
int numero = -1;

  while (numero < 0|| numero > 9)
{
    Console.Write("Digite um número entre 1 e 9: ");
    Int32.TryParse(Console.ReadLine(), out numero);

}

if(numero == 0){
    Console.WriteLine("Operação Cancelada");
}
else{
    Console.WriteLine($"Numero selecionado = {numero}");
}