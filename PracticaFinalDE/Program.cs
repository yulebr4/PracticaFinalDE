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


        // ============================================================
        //  PARTE I — CONVERSIÓN DE TEMPERATURA Y ERROR DE MEDICIÓN
        //  Los últimos 2 dígitos de matrícula 0769 son 69
        //  Por eso la temperatura base es 269 °F
        // ============================================================

        // Título de sección en consola
        Console.WriteLine("══════════════════════════════════════════════════════════");
        Console.WriteLine("  PARTE I — CONVERSIÓN DE TEMPERATURA");
        Console.WriteLine("══════════════════════════════════════════════════════════");

        // Variable tipo double para guardar decimales con precisión
        // 269.0 porque los últimos 2 dígitos de 0769 son 69 → 269 °F
        double tempF = 269.0;

        // FÓRMULA: °C = (°F - 32) × 5 ÷ 9
        // Se usa 5.0 y 9.0 (con decimal) para que C# haga división real
        // Si usáramos 5 y 9 (enteros), C# haría división entera y perdería decimales
        double tempC = (tempF - 32.0) * 5.0 / 9.0;

        // FÓRMULA: K = °C + 273.15
        // 273.15 es la constante de conversión Celsius a Kelvin
        double tempK = tempC + 273.15;

        // Imprecisión del sensor según el enunciado: ±1.5 °F
        double imprecision = 1.5;

        // FÓRMULA: Error relativo % = (imprecisión / valor referencia) × 100
        // El valor de referencia es la temperatura en °F (269)
        double errorRelativo = (imprecision / tempF) * 100.0;

        // Se imprimen los resultados con 2 decimales usando {variable:F2}
        // F2 = formato de punto flotante con 2 decimales
        Console.WriteLine($"  Temperatura ingresada        : {tempF:F2} °F");
        Console.WriteLine($"  Temperatura en Celsius       : {tempC:F2} °C");
        Console.WriteLine($"  Temperatura en Kelvin        : {tempK:F2} K");
        Console.WriteLine($"  Error relativo del sensor    : {errorRelativo:F2} %");

        // Línea vacía de separación entre secciones
        Console.WriteLine();

    } // fin de Main
} // fin de class
