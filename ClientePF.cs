using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar_Project
{
    class ClientePF : Cliente
    {
        private string _nome;
        private string _rg;
        private string _cpf;
        private string _orgaoEmissor;
        private string _dataEmissao;
        private string _cnh;
        private string _email;
        private string _Data_Nascimento;

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string rg
        {
            get { return _rg; }
            set { _rg = value; }
        }

        public string cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        public string orgaoEmissor
        {
            get { return _orgaoEmissor; }
            set { _orgaoEmissor = value; }
        }

        public string dataEmissao
        {
            get { return _dataEmissao; }
            set { _dataEmissao = value; }
        }

        public string cnh
        {
            get { return _cnh; }
            set { _cnh = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Data_Nascimento
        {
            get { return _Data_Nascimento; }
            set { _Data_Nascimento = value; }
        }
    }
}
