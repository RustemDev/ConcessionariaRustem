using System;
using System.Collections.Generic;
using System.Text;

namespace ConcessionariaRustem.Models
{
    public class Carro
    {
        public string Marca { get; set; }
        public double Preco { get; set; }
        public string Lataria { get; set; }
        public int Cor { get; set; }
        public int Pneu { get; set; }
        public int Portas { get; set; }
        public int Motor { get; set; }
        public int PortaMalas { get; set; }
        public int Farol { get; set; }
        public int Volante { get; set; }
        public int CambioDeMarcha { get; set; }
        public int Banco { get; set; }
        public int CintoDeSegurança { get; set; }
        public string Ignição { get; set; }
        public int Pedal { get; set; }
        public int AirBag { get; set; }

        public string LigarCarro()
        {
            return "Carro Ligado rum rum rum";
        }


        public string AcenderFarolCarro()
        {
            return "Farol do carro acesso";
        }


        public string DestravarPortasDoCarro()
        {
            return "Portas do carro destravadas";
        }




    }
}
