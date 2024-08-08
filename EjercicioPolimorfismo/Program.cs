﻿using EjercicioPolimorfismo;

List<Gato> gatos = new List<Gato>
{
    new AngoraTurco {Nombre = "Ares", Edad = "6 meses" },
        new AngoraTurco {Nombre = "Fingaro", Edad = "1 año" },
            new AngoraTurco {Nombre = "Don gato", Edad = "2 años" },
};

foreach (Gato gato in gatos)
{
    gato.Sonido();
    gato.Informacion();

    Console.WriteLine();
}