namespace Encapsulamento.classes
{
    public class MasterCard : Cartao
    {
        // Atributos
        private int parcelas;
         
        // Get e Set
        public int Parcelas{
            get{ return parcelas;} //pegar dados - Leitura
            set{ parcelas = value;} //Inserir dados - Escrita
        }

        //Métodos
    }
}