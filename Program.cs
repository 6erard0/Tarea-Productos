using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Bienvenido al sistema de ventas***");
            Console.WriteLine(" ");

            while (true)
            {
                // Solicitar la cantidad de productos al usuario
                Console.Write("Ingrese la cantidad de productos que desea comprar: ");

                int cantidadProductos = int.Parse(Console.ReadLine());

                // Definir el precio por producto
                double precioPorProducto = 0.0;
                double descuento = 0.0;

                // Verificar la cantidad y establecer el precio por producto y el descuento
                if (cantidadProductos <= 10)
                {
                    precioPorProducto = 20.0;
                    descuento = cantidadProductos * precioPorProducto * 0.2; // 20% de descuento
                    Console.WriteLine(" ");
                    Console.Write("Como seleccionó 10 o menos el precio de cada producto es $20. ");
                    Console.WriteLine(" ");
                }
                else
                {
                    precioPorProducto = 15.0;
                    descuento = cantidadProductos * precioPorProducto * 0.15; // 15% de descuento
                    Console.WriteLine(" ");
                    Console.Write("Como seleccionó mas de 10 el precio de cada producto es $15. ");
                    Console.WriteLine(" ");
                }

                // Calcular el precio total sin descuento
                double precioTotalSinDescuento = cantidadProductos * precioPorProducto;

                // Calcular el precio total con descuento
                double precioTotalConDescuento = precioTotalSinDescuento - descuento;

                // Mostrar resultados
                Console.WriteLine($"\nCantidad de productos: {cantidadProductos}");
                Console.WriteLine($"Precio por producto: ${precioPorProducto}");
                Console.WriteLine($"Precio total sin descuento: ${precioTotalSinDescuento}");
                Console.WriteLine($"Descuento aplicado: ${descuento}");
                Console.WriteLine($"Precio total con descuento: ${precioTotalConDescuento}");

                // Pedir al usuario que presione Enter para salir o 1 para continuar
                Console.WriteLine("\nPresione Enter para salir o 1 para continuar...");
                string opcion = Console.ReadLine();

                if (opcion != "1")
                {
                    break; // Salir del bucle si no se ingresa "1"
                }
            }
        }
    }
}

