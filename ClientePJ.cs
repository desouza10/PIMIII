using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar_Project
{
    class ClientePJ : Cliente
    {
        private string _cnpj;
        private string _incricaoEstadual;
        private string _razaoSocial;
        private string _representante;
        private int _ID_motorista;
        private string _motorista;
        private string _cnhMotorista;
        private string _email;

        public string cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        public string inscricaoEstadual
        {
            get { return _incricaoEstadual; }
            set { _incricaoEstadual = value; }
        }

        public string razaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = value; }
        }

        public string representante
        {
            get { return _representante; }
            set { _representante = value; }
        }

        public int ID_Motorista
        {
            get { return _ID_motorista; }
            set { _ID_motorista = value; }
        }

        public string motorista
        {
            get { return _motorista; }
            set { _motorista = value; }
        }

        public string cnhMotorista
        {
            get { return _cnhMotorista; }
            set { _cnhMotorista = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
