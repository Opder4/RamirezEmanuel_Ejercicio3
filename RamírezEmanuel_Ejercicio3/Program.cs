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
bool validacion=false;
if (cupon=="s")
{
    Console.WriteLine("Ingrese la primera letra de su cupón: ");
    Console.WriteLine("");
    string primeraletra=Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("Ingrese el último dígito de su cupón: ");
    Console.WriteLine("");
    int ultimodigito=int.Parse(Console.ReadLine());
    Console.WriteLine("");
    if (primeraletra == "U" && (ultimodigito % 2 == 0))
    {
        validacion = true;
    }
    else
    {
        validacion = false;
    }
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
double descuento = 0.1;
double recargo = 0.05;
if (monto>=0 && (cupon=="s" || cupon == "n") && reporte>=1 && reporte<=3)
{
switch (cliente)
    {
        case 1:
            switch (pago)
            {
                case 1:
                    if (reporte==2 || reporte==3)
                    {
                        Console.WriteLine("Descuento: Ninguno");
                        Console.WriteLine($"Recargo: {recargo*100}%");
                        Console.WriteLine($"Total final: Q{monto+(monto*recargo)}");
                    }
                    else if (validacion)
                    {
                        Console.WriteLine($"Descuento: {descuento*100}%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{(monto - (monto * descuento))-(0.1* (monto - (monto * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine("Descuento: 10%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{monto + (monto * 0.1)}");
                    }
                        break;
                case 2:
                    if (reporte == 2 || reporte == 3)
                    {
                        Console.WriteLine("Descuento: Ninguno");
                        Console.WriteLine($"Recargo: {recargo * 100}%");
                        Console.WriteLine($"Total final: Q{monto + (monto * recargo)}");
                    }
                    else if (validacion)
                    {
                        Console.WriteLine($"Descuento: {descuento * 100}%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{(monto - (monto * descuento)) - (0.07 * (monto - (monto * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine("Descuento: 7%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{monto - (monto * 0.07)}");
                    }
                    break;
                case 3:
                    if (reporte == 2 || reporte == 3)
                    {
                        Console.WriteLine("Descuento: Ninguno");
                        Console.WriteLine($"Recargo: {recargo * 100}%");
                        Console.WriteLine($"Total final: Q{monto + (monto * recargo)}");
                    }
                    else if (validacion)
                    {
                        Console.WriteLine($"Descuento: {descuento * 100}%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{(monto - (monto * descuento)) - (0.07 * (monto - (monto * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine("Descuento: 0%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{monto}");
                    }
                    break;
                default:
                    Console.WriteLine("Método de pago no válido");
                    break;
            }
            break;
        case 2:
            switch (pago)
            {
                case 1:
                    if (reporte == 2 || reporte == 3)
                    {
                        Console.WriteLine("Descuento: Ninguno");
                        Console.WriteLine($"Recargo: {recargo * 100}%");
                        Console.WriteLine($"Total final: Q{monto + (monto * recargo)}");
                    }
                    else if (validacion)
                    {
                        Console.WriteLine($"Descuento: {descuento * 100}%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{(monto - (monto * descuento)) - (0.1 * (monto - (monto * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine("Descuento: 0%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{monto}");
                    }
                    break;
                case 2:
                    if (reporte == 2 || reporte == 3)
                    {
                        Console.WriteLine("Descuento: Ninguno");
                        Console.WriteLine($"Recargo: {recargo * 100}%");
                        Console.WriteLine($"Total final: Q{monto + (monto * recargo)}");
                    }
                    else if (validacion)
                    {
                        Console.WriteLine($"Descuento: {descuento * 100}%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{(monto - (monto * descuento)) - (0.07 * (monto - (monto * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine("Descuento: 0%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{monto}");
                    }
                    break;
                case 3:
                    if (reporte == 2 || reporte == 3)
                    {
                        Console.WriteLine("Descuento: Ninguno");
                        Console.WriteLine($"Recargo: {recargo * 100}%");
                        Console.WriteLine($"Total final: Q{monto + (monto * recargo)}");
                    }
                    else if (validacion)
                    {
                        Console.WriteLine($"Descuento: {descuento * 100}%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{(monto - (monto * descuento)) - (0.07 * (monto - (monto * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine("Descuento: 0%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{monto}");
                    }
                    break;
                default:
                    Console.WriteLine("Método de pago no válido");
                    break;
            }
            break;
        case 3:
            switch (pago)
            {
                case 1:
                    if (reporte == 2 || reporte == 3)
                    {
                        Console.WriteLine("Descuento: Ninguno");
                        Console.WriteLine($"Recargo: {recargo * 100}%");
                        Console.WriteLine($"Total final: Q{monto + (monto * recargo)}");
                    }
                    else if (validacion)
                    {
                        Console.WriteLine($"Descuento: {descuento * 100}%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{(monto - (monto * descuento)) - (0.1 * (monto - (monto * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine("Descuento: 0%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{monto}");
                    }
                    break;
                case 2:
                    if (reporte == 2 || reporte == 3)
                    {
                        Console.WriteLine("Descuento: Ninguno");
                        Console.WriteLine($"Recargo: {recargo * 100}%");
                        Console.WriteLine($"Total final: Q{monto + (monto * recargo)}");
                    }
                    else if (validacion)
                    {
                        Console.WriteLine($"Descuento: {descuento * 100}%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{(monto - (monto * descuento)) - (0.07 * (monto - (monto * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine("Descuento: 0%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{monto}");
                    }
                    break;
                case 3:
                    if (reporte == 2 || reporte == 3)
                    {
                        Console.WriteLine("Descuento: Ninguno");
                        Console.WriteLine($"Recargo: {recargo * 100}%");
                        Console.WriteLine($"Total final: Q{monto + (monto * recargo)}");
                    }
                    else if (validacion)
                    {
                        Console.WriteLine($"Descuento: {descuento * 100}%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{(monto - (monto * descuento)) - (0.07 * (monto - (monto * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine("Descuento: 0%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{monto}");
                    }
                    break;
                default:
                    Console.WriteLine("Método de pago no válido");
                    break;
            }
            break;
        case 4:
            switch (pago)
            {
                case 1:
                    if (reporte == 2 || reporte == 3)
                    {
                        Console.WriteLine("Descuento: Ninguno");
                        Console.WriteLine($"Recargo: {recargo * 100}%");
                        Console.WriteLine($"Total final: Q{monto + (monto * recargo)}");
                    }
                    else if (validacion)
                    {
                        Console.WriteLine($"Descuento: {descuento * 100}%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{(monto - (monto * descuento)) - (0.1 * (monto - (monto * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine("Descuento: 0%%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{monto}");
                    }
                    break;
                case 2:
                    if (reporte == 2 || reporte == 3)
                    {
                        Console.WriteLine("Descuento: Ninguno");
                        Console.WriteLine($"Recargo: {recargo * 100}%");
                        Console.WriteLine($"Total final: Q{monto + (monto * recargo)}");
                    }
                    else if (validacion)
                    {
                        Console.WriteLine($"Descuento: {descuento * 100}%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{(monto - (monto * descuento)) - (0.07 * (monto - (monto * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine("Descuento: 0%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{monto}");
                    }
                    break;
                case 3:
                    if (reporte == 2 || reporte == 3)
                    {
                        Console.WriteLine("Descuento: Ninguno");
                        Console.WriteLine($"Recargo: {recargo * 100}%");
                        Console.WriteLine($"Total final: Q{monto + (monto * recargo)}");
                    }
                    else if (validacion)
                    {
                        Console.WriteLine($"Descuento: {descuento * 100}%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{(monto - (monto * descuento)) - (0.07 * (monto - (monto * descuento)))}");
                    }
                    else
                    {
                        Console.WriteLine("Descuento: 0%");
                        Console.WriteLine($"Recargo: {recargo * 0}%");
                        Console.WriteLine($"Total final: Q{monto}");
                    }
                    break;
                default:
                    Console.WriteLine("Método de pago no válido");
                    break;
            }
            break;
        default:
            Console.WriteLine("Tipo de cliente no válido");
            break;
    }
}
else
{
    Console.WriteLine("Los datos son inválidos");
    Console.WriteLine("Ingrese datos que sean válidos");
}
Console.WriteLine("");