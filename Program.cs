const string AGUAS_MARINHAS = "M";
const string AGUAS_CONTINENTAIS = "C";

const double LimiteAguasContinentaisEmKg = 10;
const double LimiteAguasMarinhasEmKg = 15;

const decimal MultaExcessoPeso = 1000;
const decimal MultaPorKgExcedido = 20;

double PesoDoPescadoEmKg;
string LocalPesca;

Console.Clear();

Console.WriteLine("--- Pesca Amadora ---\n");

Console.Write("Peso (em kg)...: ");

PesoDoPescadoEmKg = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Águas [c]ontinentais ou [m]arinhas? ");
LocalPesca = Console.ReadLine()!
                .Trim()
                .Substring(0, 1)
                .ToUpper();

Console.WriteLine();

if (LocalPesca != AGUAS_CONTINENTAIS 
 && LocalPesca != AGUAS_MARINHAS)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Local não reconhecido.");
    Console.ResetColor();
    return;
}

if ((LocalPesca == AGUAS_CONTINENTAIS 
    && PesoDoPescadoEmKg <= LimiteAguasContinentaisEmKg) 
    ||
    (LocalPesca == AGUAS_MARINHAS
    && PesoDoPescadoEmKg <= LimiteAguasMarinhasEmKg))
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Pescaria dentro dos limites legais.");
    Console.ResetColor();
    return;       
}

double PesoPermitido;

if (LocalPesca == AGUAS_CONTINENTAIS)
{
    PesoPermitido = LimiteAguasContinentaisEmKg;
}
else
{
    PesoPermitido = LimiteAguasMarinhasEmKg;
}

double PesoEmExcesso = PesoDoPescadoEmKg - PesoPermitido;

decimal Multa = MultaExcessoPeso + 
                 (MultaPorKgExcedido * Convert.ToDecimal(PesoEmExcesso));

Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine($"Pescaria excede os limites legais em {PesoEmExcesso}kg.");
Console.WriteLine($"Sujeito a multa de {Multa:C2}.");

Console.ResetColor();
