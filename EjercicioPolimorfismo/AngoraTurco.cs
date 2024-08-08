
namespace EjercicioPolimorfismo
{
    public class AngoraTurco : Gato
    {
        public override void Sonido()
        {
            Console.WriteLine($"{Nombre} Maulla suave");
        }
        public override void Informacion()
        {
            Console.WriteLine($"{Nombre} tiene {Edad} al ser un gato Angora Turco es uno de los más antiguos. Se suele confundir con el persa, pero este último es de un mayor tamaño. El Angora es mediano, de pelo largo y de diferentes colores");
        }

    }
}
