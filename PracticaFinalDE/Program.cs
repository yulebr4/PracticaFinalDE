// VIDEO: 
// Estudiante: Yulenny Bonilla
// Matrícula:  0769
// Curso:      IND-421 — Diseño de Experimentos

// "using System" permite usar las clases básicas de C#
// como Console (para imprimir) y DateTime (para la fecha)
using System;

// "class" define el contenedor principal del programa
// Todos los métodos y variables viven dentro de esta clase
class PracticaFinaDE
{
    // "static void Main" es el punto de entrada del programa
    // Es el primer método que ejecuta C# cuando corres el programa
    static void Main(string[] args)
    {
        // ============================================================
        //  ENCABEZADO DEL REPORTE
        //  Se imprime al inicio para identificar el documento
        // ============================================================

        // Console.WriteLine imprime una línea de texto en la consola
        Console.WriteLine("============================================================");
        Console.WriteLine("   ANÁLISIS TÉRMICO Y ELÉCTRICO — MOTOR INDUSTRIAL");
        Console.WriteLine("   Zona Franca de San Pedro de Macorís");
        Console.WriteLine("============================================================");

        // Se muestran los datos del estudiante
        Console.WriteLine("  Estudiante : Yulenny Bonilla");
        Console.WriteLine("  Matrícula  : 0769");

        // DateTime.Now obtiene la fecha y hora actual del sistema
        // .ToString("dd/MM/yyyy HH:mm:ss") la formatea legible
        Console.WriteLine("  Fecha      : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

        Console.WriteLine("============================================================\n");
        // El \n al final agrega una línea vacía de separación

    } // fin de Main
} // fin de class
