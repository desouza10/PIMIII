namespace RentCar_Project
{
    class Cliente
    {
        private int _Id_Cliente;
        private string _logradouro;
        private int _numero;
        private string _bairro;
        private string _cidade;
        private string _cep;
        private string _uf;
        private string _telefone;
        private string _complemento;
  
        public int Id_Cliente
        {
            get { return _Id_Cliente; }
            set { _Id_Cliente = value; }
        }
        public string logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        public int numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        public string cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public string cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        public string uf
        {
            get { return _uf; }
            set { _uf = value; }
        }

        public string telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public string complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }
    }
}
