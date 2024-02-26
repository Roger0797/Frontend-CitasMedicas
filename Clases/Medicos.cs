namespace YarvizApiHospital.Clases
{
    public class Medico
    {
        public int Codigo { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public EstadoUsuario EstadoUsuario { get; set; }
        public EstadoMedico EstadoMedico { get; set; }
        public string Especialidad { get; set; }

        // Constructor para inicializar el médico con valores predeterminados
        public Medico()
        {
            // Inicializar la fecha de nacimiento como la fecha actual
            FechaNacimiento = DateTime.Now;
            // Establecer el estado del usuario y del médico como "Activo" por defecto
            EstadoUsuario = EstadoUsuario.Activo;
            EstadoMedico = EstadoMedico.Activo;
        }
    }

    // Enumeración para representar el estado del usuario
    public enum EstadoUsuario
    {
        Activo,
        Inactivo
    }

    // Enumeración para representar el estado del médico
    public enum EstadoMedico
    {
        Activo,
        Inactivo,
        Ausente
    }
}