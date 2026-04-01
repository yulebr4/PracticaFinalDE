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

        // ============================================================
        //  PARTE II — ANÁLISIS DE CIRCUITO ELÉCTRICO MIXTO
        //  Matrícula 0769:
        //    Primer dígito = 0  →  R1 = 10 + 0 = 10 Ω
        //    Último dígito = 9  →  R4 = 15 + 9 = 24 Ω
        // ============================================================

        Console.WriteLine("══════════════════════════════════════════════════════════");
        Console.WriteLine("  PARTE II — CIRCUITO ELÉCTRICO MIXTO");
        Console.WriteLine("══════════════════════════════════════════════════════════");

        // Voltaje de la fuente de alimentación en Voltios
        double voltaje = 220.0;

        // --- Definición de resistencias ---
        // R1: valor base 10 Ω + primer dígito matrícula (0) = 10 Ω
        double R1 = 10.0 + 0.0;

        // R2: valor fijo según enunciado
        double R2 = 25.0;

        // R3: valor fijo según enunciado
        double R3 = 40.0;

        // R4: valor base 15 Ω + último dígito matrícula (9) = 24 Ω
        double R4 = 15.0 + 9.0;

        // --- Resistencia de cada rama ---
        // Rama A: R1 y R2 en SERIE → se suman directamente
        double rRamaA = R1 + R2;   // 10 + 25 = 35 Ω

        // Rama B: R3 y R4 en SERIE → se suman directamente
        double rRamaB = R3 + R4;   // 40 + 24 = 64 Ω

        // --- Resistencia total (Rama A en PARALELO con Rama B) ---
        // FÓRMULA paralelo: R_total = (R_A × R_B) / (R_A + R_B)
        double rTotal = (rRamaA * rRamaB) / (rRamaA + rRamaB);

        // --- Corriente total — LEY DE OHM: I = V / R ---
        double iTotal = voltaje / rTotal;

        // --- Potencia total disipada — FÓRMULA: P = V × I ---
        double potenciaTotal = voltaje * iTotal;

        // --- Corriente por cada rama — LEY DE OHM: I = V / R_rama ---
        // En paralelo el voltaje es el mismo en ambas ramas (220 V)
        double iRamaA = voltaje / rRamaA;
        double iRamaB = voltaje / rRamaB;

        // --- Impresión de resultados ---
        Console.WriteLine($"  R1 (Rama A)                  : {R1:F2} Ω");
        Console.WriteLine($"  R2 (Rama A)                  : {R2:F2} Ω");
        Console.WriteLine($"  R3 (Rama B)                  : {R3:F2} Ω");
        Console.WriteLine($"  R4 (Rama B)                  : {R4:F2} Ω");
        Console.WriteLine($"  Resistencia Rama A (R1+R2)   : {rRamaA:F2} Ω");
        Console.WriteLine($"  Resistencia Rama B (R3+R4)   : {rRamaB:F2} Ω");
        Console.WriteLine($"  Resistencia Total (paralelo) : {rTotal:F2} Ω");
        Console.WriteLine($"  Corriente Total              : {iTotal:F2} A");
        Console.WriteLine($"  Potencia Total Disipada      : {potenciaTotal:F2} W");
        Console.WriteLine($"  Corriente Rama A             : {iRamaA:F2} A");
        Console.WriteLine($"  Corriente Rama B             : {iRamaB:F2} A");
        Console.WriteLine();

    } // fin de Main
} // fin de class
