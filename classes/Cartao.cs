namespace Encapsulamento.classes
{
    public class Cartao
    {
        //declaração dos atributos
        private string numero;
        public string Numero{
            get{return numero;}
            set{numero = value;}
        }
        private string bandeira = "MasterCard";
        public string Bandeira{
            get{return bandeira;}
        }
        protected string token = "quertyui";
        public string Token{
            get{return token;}
        }
        private string cvv;
        public string Cvv{
            get{return cvv;}
            set{cvv = value;}
        }
        protected float LimiteDeCompra{
            get{return LimiteDeCompra;}
        }
        //declaração dos métodos
        public string RegistrarCompra(bool validado){

            return "";
        }
        private bool ValidarCompra(float saldo){

            return true;
        }
        protected string ValidarToken(string token){

            return "";
        }
    }
}