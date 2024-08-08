
namespace EjercicioPolimorfismo
{
    public class Mainecoon : Gato

    {
        public override void Sonido()
        {
            Console.WriteLine($"{Nombre} Maulla Fuerte, como un rugido");
        }
        public override void Informacion()
        {
            Console.WriteLine($"{Nombre} tiene {Edad} es un gato Maine Coon Tiene sus orígenes en Estados Unidos y es muy popular en Europa y América del Norte. ¿Sabías que sus raíces guardan algunas curiosidades? Su nombre “Maine” deriva del estado de Maine de EEUU y “Coon” proviene de “racoon” que significa mapache. Y es que se dice que esta raza de felino es una mezcla entre los mapaches y los gatos salvajes.");
        }
    }
}
