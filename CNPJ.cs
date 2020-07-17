namespace Heranca
{
    public class CNPJ : Pessoa
    {
        public string cnpj;
        public string rg;
  
        public bool ValidarCNPJ(){
            if (cnpj !=null)
            {
                return true;
            }
                return false;
        }
    }
}