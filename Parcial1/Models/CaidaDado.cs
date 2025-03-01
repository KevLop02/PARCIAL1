namespace Parcial1.Models
{
    public class CaidaDadoModel
    {
        public double DatoInicial { get; set; }   // El valor inicial del dato.
        public double DatoFinal { get; set; }     // El valor final calculado de la caída.
        public double Caida { get; set; }         // El valor de la caída calculada.

        public int NumeroAleatorio { get; set; }  // El número aleatorio generado.

        // Método para calcular la caída de un dato
        public void CalcularCaida()
        {
            // Simulación simple de caída (disminución de dato)
            Caida = DatoInicial * 0.1;  // Ejemplo: una caída del 10% del valor inicial.
            DatoFinal = DatoInicial - Caida;
        }

        // Método para generar un número aleatorio
        public void GenerarNumeroAleatorio()
        {
            Random random = new Random();
            NumeroAleatorio = random.Next(1, 100);  // Genera un número aleatorio entre 1 y 100.
        }
    }
}
