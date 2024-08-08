

namespace EjercicioPolimorfismo
{
    public abstract class Gato
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }

        public abstract void Sonido();
        public abstract void Informacion();
    }
}
