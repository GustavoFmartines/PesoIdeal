Console.Clear();

Console.Write("Digite sua altura em metros: ");
    double altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o seu sexo [F]eminino/[M]asculino: ");
    string sexo = Console.ReadLine().ToUpper();

    double PesoIdeal;

if (sexo == "M")
{

        PesoIdeal = altura * 72.7 - 58.0;
    Console.WriteLine($"Seu peso ideal é: {PesoIdeal:F1}kg");

}
if (sexo == "F")
{

        PesoIdeal = altura * 62.1 - 44.7;
    Console.WriteLine($"Seu peso ideal é: {PesoIdeal:F1}kg."); 

}
else
{

    Console.WriteLine("Sexo inválido. Digite M ou F.");

}
