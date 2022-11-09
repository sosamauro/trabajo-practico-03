namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente[] pacientesConsultas = Controlador.InicializarTurnos();
            Paciente[] pacientesUrgencias = Controlador.InicializarTurnos();

            AtenderContext oAtender = new AtenderContext();

            oAtender.EstablecerEstrategiaTriaje();
            Paciente[] pacientesOrdenados = oAtender.Atender(pacientesConsultas);

            foreach (Paciente paciente in pacientesOrdenados)
            {
                Console.WriteLine($"Nombre: {paciente.Nombre}. Tiempo de espera: {paciente.TiempoEspera}. Nivel: {paciente.Nivel}");
            }

            Console.ReadKey();
        }
    }
}