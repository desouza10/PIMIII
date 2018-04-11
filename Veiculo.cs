using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar_Project
{
    class Veiculo
    {
        private string _Id_Veiculo;
        private string _placa;
        private string _marca;
        private string _modelo;
        private string _ano;
        private string _cambio;
        private float _motor;
        private string _arCondicionado;
        private string _direcaoHidraulica;
        private string _cor;
        private string _radioEmbutido;
        private string _vidrosEletricos;
        private string _portas;
        private int _status;

        public string Placa
        {
            get
            {
                return _placa;
            }

            set
            {
                _placa = value;
            }
        }

        public string Marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                _modelo = value;
            }
        }

        public string Ano
        {
            get
            {
                return _ano;
            }

            set
            {
                _ano = value;
            }
        }

        public string Cambio
        {
            get
            {
                return _cambio;
            }

            set
            {
                _cambio = value;
            }
        }

        public float Motor
        {
            get
            {
                return _motor;
            }

            set
            {
                _motor = value;
            }
        }

        public string ArCondicionado
        {
            get
            {
                return _arCondicionado;
            }

            set
            {
                _arCondicionado = value;
            }
        }

        public string DirecaoHidraulica
        {
            get
            {
                return _direcaoHidraulica;
            }

            set
            {
                _direcaoHidraulica = value;
            }
        }

        public string Cor
        {
            get
            {
                return _cor;
            }

            set
            {
                _cor = value;
            }
        }

        public string RadioEmbutido
        {
            get
            {
                return _radioEmbutido;
            }

            set
            {
                _radioEmbutido = value;
            }
        }

        public string VidrosEletricos
        {
            get
            {
                return _vidrosEletricos;
            }

            set
            {
                _vidrosEletricos = value;
            }
        }

        public string Portas
        {
            get
            {
                return _portas;
            }

            set
            {
                _portas = value;
            }
        }

        public int Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }

        public string Id_Veiculo
        {
            get
            {
                return _Id_Veiculo;
            }

            set
            {
                _Id_Veiculo = value;
            }
        }
    }
}
