using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2806POO.Entidades
{
    public class Jugador
    {
        public delegate void delFestejo(string mensaje);
        public delegate void delInsulto(string mensaje, int volumen);

        public event delFestejo festejo;
        public event delInsulto insulto;

        Random random = new Random();

        public void patear()
        {
            int resultado = random.Next(0, 2);
            switch (resultado)
            {
                case 0:
                    {
                        if(festejo != null)
                        {
                            festejo("Gol");
                        }
                        break;
                    }
                case 1:
                    {
                        if(insulto != null)
                        {
                            insulto("asdadssa", 10);
                        }
                        break;
                    }
            }
        }
    }
}
