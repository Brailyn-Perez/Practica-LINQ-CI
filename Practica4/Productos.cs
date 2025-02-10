
namespace Practica4
{
    public class Productos
    {
        public Productos(int id, string nombre, string descripcion, decimal precio, int stock, string categoria, DateTime fechaCreacion) 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Stock = stock;
            this.Categoria = categoria;
            this.FechaCreacion = fechaCreacion;
        }


        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaCreacion { get; set; }

        public override string ToString()
        {
            var Producto = $"ID : {Id} \n" +
                $"Nombre: {Nombre} \n" +
                $"Descripcion: {Descripcion}\n" +
                $"Precio: {Precio}\n" +
                $"Stock: {Stock}\n" +
                $"Categoria: {Categoria}\n" +
                $"Fecha de Creacion: {FechaCreacion}\n" +
                $"-----------------------------------------\n";

            return Producto;
        }
    }
}
