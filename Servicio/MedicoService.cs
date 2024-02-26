using YarvizApiHospital.Clases;

namespace YarvizApiHospital.Services
{
    public class MedicoService
    {
        private readonly List<Medico> _medicos;

        public MedicoService()
        {
            _medicos = new List<Medico>();
        }

        public void AgregarMedico(Medico medico)
        {
            _medicos.Add(medico);
        }

        public List<Medico> ObtenerMedicos()
        {
            return _medicos;
        }
    }
}