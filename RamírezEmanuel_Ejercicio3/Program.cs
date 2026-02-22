using System.Threading.Channels;

Console.WriteLine("Seleccione el tipo de cliente: ");
Console.WriteLine("");
Console.WriteLine("1. Estudiante");
Console.WriteLine("2. Docente");
Console.WriteLine("3. Administrativo");
Console.WriteLine("4. Externo");
Console.WriteLine("");
int cliente=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el Monto base (Q): ");
Console.WriteLine("");
double monto=double.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el Método de pago: ");
Console.WriteLine("");
Console.WriteLine("1. Efectivo");
Console.WriteLine("2. Tarjeta");
Console.WriteLine("3. Transferencia");
Console.WriteLine("");
int pago=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Tiene cupón? (s/n)");
Console.WriteLine("");
string cupon=Console.ReadLine();
string codigo = "";
if (cupon=="s")
{
    Console.WriteLine("Ingrese el código: ");
    codigo = Console.ReadLine();
}
Console.WriteLine("");
Console.WriteLine("Ingrese el Reporte antifraude: ");
Console.WriteLine("");
Console.WriteLine("1. Ninguno");
Console.WriteLine("2. Cupón inválido repetido");
Console.WriteLine("3. Pagos rechazados múltiples");
Console.WriteLine("");
int reporte=int.Parse(Console.ReadLine());
Console.WriteLine("");