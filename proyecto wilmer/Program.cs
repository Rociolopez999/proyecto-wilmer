using System;
class Ventas
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al sistema de Ventas Cosmetic Fashion");
            Console.Write("Favor Ingrese su Nombre: ");
            string Nombre = Console.ReadLine();
            Console.Write("Favor Ingrese Edad: ");
            int Edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seleccione la Categoria del Producto a comprar");
            Console.WriteLine("1.Maquillaje ");
            Console.WriteLine("2.Cuidado de la Piel");
            Console.WriteLine("3.Cuidado del Cabello");
            Console.WriteLine("4.Fragancias");


            string categoria = Console.ReadLine();
            double precio = 0;
            string producto;
            switch (categoria)
            {
                case "1":
                    Console.WriteLine("Estos son los artículos disponibles en nuestra linea de maquillajes,");
                    Console.WriteLine("1. polvos 100 Lps");
                    Console.WriteLine("2. sombras 50 Lps");
                    producto = Console.ReadLine();
                    if (producto == "1")
                    {
                        precio = 100;
                    }
                    else if (producto == "2")
                    {
                        precio = 50;
                    }
                    break;

                case "2":
                    Console.WriteLine("Estos son los artículos disponibles en nuestra linea de cuidado de la piel,");
                    Console.WriteLine("1.Limpiador Facial 30 Lps");
                    Console.WriteLine("2.crema hidratante 50 Lps");
                    producto = Console.ReadLine();
                    if (producto == "1")
                    {
                        precio = 100;
                    }
                    else if (producto == "2")
                    {
                        precio = 50;
                    }
                    break;

                case "3":
                    Console.WriteLine("Estos son los artículos disponibles en nuestra linea de cuidado del cabello,");
                    Console.WriteLine("1.shampoo hidratante 40 Lps");
                    Console.WriteLine("2.acondicionador 60 Lps");
                    producto = Console.ReadLine();
                    if (producto == "1")
                    {
                        precio = 40;
                    }
                    else if (producto == "2")
                    {
                        precio = 60;
                    }
                    break;

                case "4":
                    Console.WriteLine("Estos son los artículos disponibles en nuestra linea de Fragancias,");
                    Console.WriteLine("1.perfume floral 80 Lps");
                    Console.WriteLine("2.Colonia Citrus 100 Lps");
                    producto = Console.ReadLine();
                    if (producto == "1")
                    {
                        precio = 80;
                    }
                    else if (producto == "2")
                    {
                        precio = 100;
                    }
                    else
                    {
                        Console.WriteLine("No contamos con el artículo que ha elegido.");
                        precio = 0;
                    }
                    break;
            }
            Console.WriteLine("Determine el tamaño del producto que desea.");
            Console.WriteLine("1. Pequeño");
            Console.WriteLine("2. Mediano");
            Console.WriteLine("3. Grande");
            int tamano = Convert.ToInt32(Console.ReadLine());
            if (tamano == 1)
            {
                precio = precio;
            }
            else if (tamano == 2)
            {
                precio = precio * 1.2;
            }
            else if (tamano == 3)
            {
                precio = precio * 1.2 * 1.3;
            }

            Console.WriteLine("Ingese la cantidad a Comprar");
            int Cantidad = Convert.ToInt32(Console.ReadLine());
            double Subtotal = precio * Cantidad;
            double Impuesto = 0;
            if (categoria == "1")
            {
                Impuesto = Subtotal * 0.08;
            }
            else if (categoria == "2")
            {
                Impuesto = Subtotal * 0.14;
            }
            else if (categoria == "3")
            {
                Impuesto = Subtotal * 0.20;
            }

            double descuento = 0;
            if (Cantidad > 10 & Cantidad < 40)
            {
                descuento = Subtotal * 0.20;
            }
            else if (Cantidad > 40 & Cantidad < 70)
            {
                descuento = Subtotal * 0.35;
            }
            else if (Cantidad > 70 & Cantidad < 100)
            {
                descuento = Subtotal * 0.45;
            }
            else if (Cantidad > 100)
            {
                descuento = Subtotal * 0.50;
            }

            Console.WriteLine($"lleva un subtotal de {Subtotal}");

            double Total = Subtotal + Impuesto - descuento;

            Console.WriteLine($"El valor a pagar es de: {Total} usted esta pagando un impuesto de {Impuesto} y un descuento de: {descuento}");

            if (continuar)
            {
                Console.WriteLine("Precione cualquier tecla para continuar... ");
                Console.ReadKey();
            }
        }


    }
}