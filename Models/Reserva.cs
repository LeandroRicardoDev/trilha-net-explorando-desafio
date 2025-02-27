namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {            
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {                
                throw new Exception("Esta suíte não está disponível devido a quantidade de hóspedes, favor trocar a suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {            
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {   
            decimal calculoValorDiario = DiasReservados * Suite.ValorDiaria;
         
            if (DiasReservados >= 10)
            {
                return calculoValorDiario - (calculoValorDiario / 10) ;
            }

            return calculoValorDiario;
        }
    }
}