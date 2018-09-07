Imports Entidades
Module LoroTest

    Sub Main()
        Dim loro1 As New Loro("Chaplin", "12/07/1995")

        Console.WriteLine("Edad del loro: " & loro1.CalcularEdad)

        loro1.Escuchar("Hola")
        loro1.Escuchar(" Pepe")
        loro1.Escuchar(" Quiero")
        loro1.Escuchar(" Papa")
        Console.WriteLine(loro1.Hablar)
        loro1.Escuchar(" Tengo")
        Console.WriteLine(loro1.Hablar)
        loro1.Escuchar(" Hambre")
        Console.WriteLine(loro1.Hablar)
    End Sub

End Module
