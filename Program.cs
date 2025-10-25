Console.Clear();

bool t, p, r, w;

Console.WriteLine("--- Simulador de Luz de Advertência ---\n");
Console.WriteLine("[A]tivado, [outro] Desativado\n");

Console.Write("Sensor de temperatura...: ");
string sensorT = Console.ReadLine()!.ToUpper();
t = (sensorT == "A");

Console.Write("Sensor de pressão.......: ");
string sensorP = Console.ReadLine()!.ToUpper();
p = (sensorP == "A");

Console.Write("Sensor de rotação.......: ");
string sensorR = Console.ReadLine()!.ToUpper();
r = (sensorR == "A");

w = t && (p || !r);

string resultado;

if (w)
{
    resultado = "ATIVADA";
}
else
{
    resultado = "DESATIVADA";
}

// resultado = w ? "ATIVADA" : "DESATIVADA";

Console.WriteLine($"\nA luz de advertência estará {resultado}.");