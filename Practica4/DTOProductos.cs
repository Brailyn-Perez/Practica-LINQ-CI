
namespace Practica4
{
    public  class DTOProductos
    {
        public List<Productos> GetListProductos()
        {
            var ListaDeProductos = new List<Productos>
            {
                new Productos(1, "Suavitel", "olor a madre", 15.0m, 200, "Detergente", DateTime.Now),
                new Productos(2, "Coca-Cola", "La ultima en el desierto", 50.0m, 20, "Bebida", DateTime.Now),
                new Productos(3, "Jabon", "olor a Limon", 10.0m, 200, "Detergente", DateTime.Now),
                new Productos(4, "Bocina", "Prende colores y se esucha bien", 499.99m, 20, "Tecnologia", DateTime.Now),
                new Productos(5, "Carnetion", "Leche De Queso", 70.0m, 100, "Lacteo", DateTime.Now),
                new Productos(6, "Cubo Rubik", "Original", 299.99m, 20, "Juego", DateTime.Now),
                new Productos(7, "Jabon", "Esfoliante de Avena", 40.0m, 20, "Belleza", DateTime.Now),
                new Productos(8, "Teclado", "Prende colores", 199.99m, 10, "Tecnologia", DateTime.Now),
                new Productos(9, "Celular", "Marca Sanmsung", 5000.0m, 5, "Tecnologia", DateTime.Now),
                new Productos(10, "Iphone", "Iphone 8 plus", 8000.0m, 10, "Tecnologia", DateTime.Now),
                new Productos(11, "Procesador core i5" , "Generacion 2", 9000.0m,10, "Tecnologia", DateTime.Now ),
                new Productos(12, "Dettol", "antiséptico", 35.0m, 60, "Desinfectante", DateTime.Now),
                new Productos(13, "Bounty", "toallas de papel", 5.0m, 500, "Papelería", DateTime.Now),
                new Productos(14, "Tide", "detergente líquido", 27.0m, 110, "Detergente", DateTime.Now),
                new Productos(15, "Scrubbing Bubbles", "limpieza de baño", 15.0m, 130, "Limpiador", DateTime.Now),
                new Productos(16, "Windex", "limpiador de vidrios", 12.0m, 140, "Limpiador", DateTime.Now),
                new Productos(17, "Zote", "jabón de lavar", 8.0m, 300, "Detergente", DateTime.Now),
                new Productos(18, "Ajax", "limpiador en crema", 10.0m, 160, "Limpiador", DateTime.Now),
                new Productos(19, "Palmolive", "jabón líquido", 9.0m, 180, "Detergente", DateTime.Now),
                new Productos(20, "Comet", "limpiador en polvo", 7.0m, 220, "Limpiador", DateTime.Now),
                new Productos(21, "Febreze", "ambientador", 14.0m, 140, "Ambientador", DateTime.Now),
                new Productos(22, "Purell", "gel antibacterial", 20.0m, 75, "Desinfectante", DateTime.Now),
                new Productos(23, "Seventh Generation", "detergente ecológico", 25.0m, 50, "Detergente", DateTime.Now),
                new Productos(24, "Ecover", "limpiador ecológico", 30.0m, 40, "Limpiador", DateTime.Now),
                new Productos(25, "Method", "limpiador multiusos", 18.0m, 90, "Limpiador", DateTime.Now),
                new Productos(26, "Mrs. Meyer's", "limpiador de cocina", 22.0m, 80, "Limpiador", DateTime.Now),
                new Productos(27, "Clorox", "toallitas desinfectantes", 15.0m, 100, "Desinfectante", DateTime.Now),
                new Productos(28, "Lysol", "toallitas desinfectantes", 20.0m, 70, "Desinfectante", DateTime.Now),
                new Productos(29, "OxiClean", "quitamanchas en spray", 28.0m, 60, "Detergente", DateTime.Now),
                new Productos(30, "Bissell", "limpiadora de alfombras", 150.0m, 10, "Electrodoméstico", DateTime.Now),
                new Productos(31, "Shout", "quitamanchas", 12.0m, 130, "Detergente", DateTime.Now),
                new Productos(32, "Zep", "limpiador industrial", 40.0m, 30, "Limpiador", DateTime.Now),
                new Productos(33, "Simple Green", "limpiador multiusos", 15.0m, 90, "Limpiador", DateTime.Now),
                new Productos(34, "Pledge", "limpiador de muebles", 18.0m, 80, "Limpiador", DateTime.Now),
                new Productos(35, "Swiffer", "mopa desechable", 25.0m, 50, "Limpiador", DateTime.Now),
                new Productos(36, "Tecnomaster", "Nevera", 15000.0m, 20, "Electrodomestico", DateTime.Now),
                new Productos(37, "Pepsi", "Mejor que coca-cola", 15.0m, 300, "Bebida", DateTime.Now),
                new Productos(38, "Toalla nosotras", "Toallas sanitarias", 10.0m, 200, "Higiene Personal", DateTime.Now),
                new Productos(39, "Manitos limpia", "Limpiador de manos", 19.99m, 20, "Higiene Personal", DateTime.Now),
                new Productos(40, "Espaguetis Princesa", "Espaguetis de mejor calidad", 13.0m, 100, "Comida", DateTime.Now),
                new Productos(41, "Cubo Rubik", "Original", 299.99m, 20, "Juego", DateTime.Now),
                new Productos(42, "Jabon", "Esfoliante de Avena", 40.0m, 20, "Belleza", DateTime.Now),
                new Productos(43, "Teclado", "Prende colores", 199.99m, 10, "Tecnologia", DateTime.Now),
                new Productos(44, "Celular", "Marca Sanmsung", 5000.0m, 5, "Tecnologia", DateTime.Now),
                new Productos(45, "Iphone", "Iphone 8 plus", 8000.0m, 10, "Tecnologia", DateTime.Now),
                new Productos(46, "Procesador core i5" , "Generacion 2", 9000.0m,10, "Tecnologia", DateTime.Now ),
                new Productos(47, "Dettol", "antiséptico", 35.0m, 60, "Desinfectante", DateTime.Now),
                new Productos(48, "Bounty", "toallas de papel", 5.0m, 500, "Papelería", DateTime.Now),
                new Productos(49, "Tide", "detergente líquido", 27.0m, 110, "Detergente", DateTime.Now),
                new Productos(50, "Scrubbing Bubbles", "limpieza de baño", 15.0m, 130, "Limpiador", DateTime.Now)
            };
            return ListaDeProductos;
        }
    }
}
