using Parcial1.entidades;
using Parcial1.negocio;




using System;

usuario usuario = new usuario();
Clsusuario clsUsuario = new Clsusuario();
Venta venta = new Venta();
clsVentas clsVentas = new clsVentas();

Console.WriteLine("Ingrese su usuario");
usuario.usuarioE = Console.ReadLine();
Console.WriteLine("Ingrese su contraseña");
usuario.contraseña = Console.ReadLine();

bool Resultado = clsUsuario.Autenticacion(usuario);
if (Resultado == true)
{
    Console.WriteLine("===========================================");
    Console.WriteLine("Bienvenido ala tienda parcia1");
    Console.WriteLine("donde encuentras lo que buscabas");
    Console.WriteLine("==========================================");
    Console.Write("\nIngrese el identificador del producto: ");
    venta.IdProducto = Convert.ToInt32(Console.ReadLine());
    Console.Write("\nIngrese el nombre del producto: ");
    venta.NomProducto = Console.ReadLine();
    Console.Write("\nIngresar una breve descripcion del producto: ");
    venta.DescripProducto = Console.ReadLine();
    Console.Write("\nIngrese el precio del producto:  ");
    venta.PreProducto = Convert.ToDouble(Console.ReadLine());
    Console.Write("\nIngrese la cantidad del producto que lleva: ");
    venta.CantidadProducto = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($@"El ID del producto es: {venta.IdProducto}
El producto que lleva es: {venta.NomProducto}
precio del producto es: {venta.PreProducto}
total a pagar es: {clsVentas.Cobro(venta)}");
}
else
{
    Console.WriteLine("Tu usuario o contraseña es incorrecta");
}
