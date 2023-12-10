namespace MedClinica.WebAPI.Models
{
    public class PacienteEspecialidade
    {

        public int PacienteId { get; set; }

        public string Paciente { get; set; }

        public int EspecialidadeId { get; set; }

        public Especialidade agendamento { get; set; }


        public PacienteEspecialidade()
        {

        }
        public PacienteEspecialidade(int pacienteId,  int EspecialidadeId)
        {
            PacienteId = pacienteId;

            EspecialidadeId = EspecialidadeId;
           
        }
    }

}
