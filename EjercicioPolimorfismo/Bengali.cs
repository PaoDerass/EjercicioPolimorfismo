

namespace EjercicioPolimorfismo
{
    public class Bengali : Gato
    {
        public override void Sonido()
        {
            Console.WriteLine($"{Nombre} dice Miau");
        }
        public override void Informacion()
        {
            Console.WriteLine($"{Nombre} tiene {Edad}es un gato Bengali De origen asiático, el gato bengalí tiene un cuerpo robusto y musculoso. Su pelaje atigrado lo convierte en un cruce entre gato doméstico y gato leopardo. Es un felino curioso, cariñoso y de espíritu salvaje. Tiene un carácter fuerte y siempre le gusta estar activo.");
        }
    }
}
