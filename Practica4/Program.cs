using Microsoft.VisualBasic;
using System.Net.WebSockets;

namespace Practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DTOProductos dTOProductos = new DTOProductos();
            var ListaDeProductos = dTOProductos.GetListProductos();
            //ABSOLUTAMENTE TODOS LOS EJERCICIOS FUERON HECHOS A MANO POR MI, NO HAY NADA DE IA EN ESTA TAREA
            //GRACIAS POR LA RECOMENDACION EN LA TAREA ANTERIOR, NO PUEDO DEPENDER DE LA IA - GRACIAS

            // 1. Obtener todos los productos de la lista.
            /*
            
            var Productos = from P in ListaDeProductos
                            select P;

            foreach (var item in Productos)
            {
                Console.WriteLine(item.ToString());
            }

            */
            // 2. Obtener los nombres de todos los productos.
            /*            
                       var ProductosPorNombre = (from p in ListaDeProductos
                                                 select p.Nombre).ToList();

                        foreach (var p in ProductosPorNombre)
                        {
                            Console.WriteLine(p);
                        }
            */
            // 3. Obtener los productos cuyo precio sea mayor a 500.
            /*           
                        var precioMatorQue500 = from p in ListaDeProductos
                                               where p.Precio > 500
                                               select p.Precio;

                       foreach (var p in precioMatorQue500)
                           Console.WriteLine(p);
            */
            // 4. Obtener los productos con stock menor a 10.
            /* 
             * var productosEnStockMenorA10 = from p in ListaDeProductos
                                             where p.Stock < 10
                                             select p.Stock;

              foreach (var item in productosEnStockMenorA10)
                  Console.WriteLine(item);*/
            // 5. Obtener los productos de la categoría "Electrónica".
            /*
             * var ProductosPorCategorias = from p in ListaDeProductos
                                         where p.Categoria == "Electrónica"
                                         select p.Nombre;
            foreach (var item in ProductosPorCategorias)
                    Console.WriteLine(item);*/
            // 6. Obtener los productos cuyo nombre comience con la letra 'L'.
            /*            
             *            var productos = from p in ListaDeProductos
                                        where p.Nombre.StartsWith("L")
                                        select p;
                        foreach (var item in productos)
                        {
                            Console.WriteLine(item.Nombre);
                        }*/
            // 7. Obtener los productos cuyo precio esté entre 100 y 500.
            /*       
             *       var productos = from p in ListaDeProductos 
                                   where p.Precio >100 && p.Precio < 500
                                   select p;
            foreach (var p in productos)
                Console.WriteLine(p);*/
            // 8. Obtener los productos ordenados por precio ascendente.
            /*         
             *         var productos = from p in ListaDeProductos
                                     orderby p.Precio ascending
                                     select p;

             foreach (var item in productos)
                 Console.WriteLine(item);*/
            // 9. Obtener los productos ordenados por precio descendente.
            /* 
             * var productos = from p in ListaDeProductos
                             orderby p.Precio descending
                             select p;

             foreach (var item in productos)
                 Console.WriteLine(item);*/
            // 10. Obtener los productos ordenados por nombre en orden alfabético.
            /*
             * var productos = from p in ListaDeProductos
                            orderby p.Nombre ascending
                            select p;

            foreach (var item in productos)
                Console.WriteLine(item);*/
            // 11. Obtener los productos ordenados por stock de mayor a menor.
            /*
             * var productos = from p in ListaDeProductos
                            orderby p.Stock descending
                            select p;

            foreach (var item in productos)
                Console.WriteLine(item);*/
            // 12. Obtener los primeros 5 productos más caros.
            /*
                        var productos = ListaDeProductos.OrderByDescending(p => p.Precio).Take(5);
                        foreach (var item in productos)
                        {
                            Console.WriteLine(item.ToString());
                        }
            */
            // 13. Obtener los 10 productos con menor stock.
            /*
             * var productos = ListaDeProductos.OrderBy(p => p.Stock).Take(10);
            foreach (var item in productos)
            {
                Console.WriteLine(item.ToString());
            }*/
            // 14. Obtener la cantidad total de productos en la lista.
            /*            
             *            var productos = from p in ListaDeProductos
                                        select p;
                        Console.WriteLine(productos.Count());
            */
            // 15. Obtener la suma de todos los precios de los productos.
            /* 
             * var productos = from p in ListaDeProductos
                             select p.Precio;


             Console.WriteLine(productos.Sum());
            */
            // 16. Obtener el precio promedio de los productos.
            /* 
             * var productos = from p in ListaDeProductos
                             select p.Precio;


             Console.WriteLine(productos.Average());*/
            // 17. Obtener el producto más caro.
            /*
             * var productos = from p in ListaDeProductos
                            select p.Precio;


            Console.WriteLine(productos.Max());*/
            // 18. Obtener el producto más barato.
            /*
             * var productos = from p in ListaDeProductos
                            select p.Precio;


            Console.WriteLine(productos.Min());*/
            // 19. Verificar si hay algún producto con precio mayor a 1000.
            /*
             * var productos = from p in ListaDeProductos
                            where p.Precio > 100
                            select p.Precio;


            Console.WriteLine(productos.Count());*/
            // 20. Verificar si todos los productos tienen stock mayor a 5.

            // 21. Contar cuántos productos hay en la categoría "Audio".
            /*
             * var productos = from p in ListaDeProductos
                            where p.Categoria == "Audio"
                            select p;


            Console.WriteLine(productos.Count());*/
            // 22. Agrupar los productos por categoría.
            /*
             * var productos = from p in ListaDeProductos
                            group p by p.Categoria into grouped
                            select grouped;

            foreach (var item in productos)
            {
                Console.WriteLine($"{item.Key}");
            }
                */
            // 23. Obtener la categoría con más productos
            // 24. Obtener el stock total de todos los productos.
            /*
                        var productos = ListaDeProductos.Sum(p => p.Stock);
                        Console.WriteLine(productos);
            */
            // 25. Obtener el producto con el nombre más largo.
            /*
                        var producto = ListaDeProductos.Where(p=>p.Nombre.Length == ListaDeProductos.Max(p=>p.Nombre.Length)).ToList();
                        foreach (var item in producto)
                        {
                            Console.WriteLine(item.Nombre);
                        }
            */
            // 26. Obtener el producto con la descripción más corta.
            /*
                        var producto = ListaDeProductos.Where(p => p.Descripcion.Length == ListaDeProductos.Min(p => p.Descripcion.Length)).ToList();

                        foreach (var item in producto)
                        {
                            Console.WriteLine(item.Nombre);
                        }
            */
            // 27. Filtrar los productos cuya descripción contenga la palabra "pantalla".
            // 28. Obtener el promedio de stock de los productos de la categoría "Almacenamiento".
            // 29. Obtener los productos creados en una fecha específica (20/12/2022).
            // 30. Obtener los productos cuya ID sea par.
            // 31. Obtener los productos cuya ID sea impar.
            // 32. Obtener los productos cuyo precio tenga un decimal mayor a .50.
            // 33. Obtener los productos cuyo nombre tenga más de 10 caracteres.
            /*            
                        var producto = ListaDeProductos.Where(p => p.Nombre.Length >10).ToList();
                        foreach (var item in producto)
                        {
                            Console.WriteLine(item.Nombre);
                        }
            */
            // 34. Obtener los productos cuyo stock sea un número primo.
            // 35. Obtener los productos cuyo nombre contenga la palabra "Pro".
            // 36. Obtener los productos cuyo stock sea un múltiplo de 5.
            // 37. Obtener los productos que tengan una descripción con más de 20 caracteres.
            /*
            var producto = ListaDeProductos.Where(p => p.Descripcion.Length > 20).ToList();
            foreach (var item in producto)
            {
                Console.WriteLine(item.Descripcion);
            }

            */
            // 38. Obtener los productos cuyo precio sea un número redondo (sin decimales).
            // 39. Obtener los productos que tengan exactamente dos palabras en su nombre.
            // 40. Obtener la cantidad de productos que no pertenecen a la categoría "General".
            /*
                        var producto = ListaDeProductos.Where(p => p.Categoria != "General").Count();
                        Console.WriteLine(producto);
            */

        }
    }
}
