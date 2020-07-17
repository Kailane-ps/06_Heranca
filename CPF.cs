namespace Heranca
{
    public class CPF : Pessoa
    {
        public string cpf;

          public bool ValidarCPF()
        {
            if (cpf != null)
            {
            return true;
            }
            return false;
        }
    }
}