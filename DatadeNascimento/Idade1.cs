using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatadeNascimento
{
    class Idade1
    {
        private DateTime data = new DateTime().Date;


        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }

        public string envia
        {
            get
            {
                DateTime today = DateTime.Now;

                int anos = today.Year - data.Year;
                int meses = today.Month - data.Month;
                int dias = today.Day - data.Day;

                if (dias < 0)
                {
                    meses--;
                    dias += 30;
                }

                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                }

                string frase = "A sua idade é ";
                frase += anos.ToString() + " anos ";
                frase += meses.ToString() + " meses e ";
                frase += dias.ToString() + " dias. ";


                return frase + "O dia da semana em que nasceu foi " + data.ToString("dddddd");
            }
        }

        private string diadasemana
        {
            get
            {
                string frase = "O dia da semana em que nasceu é ";
                frase += data.ToString("dddd") + ".\n";
                return frase;
            }
        }


        private string idade
        {
            get
            {
                DateTime hoje = DateTime.Now;
                TimeSpan dif = hoje - data;
                DateTime idade = DateTime.MinValue + dif;
                //MinValue = 1/1/1
                string frase = "A sua idade é";
                frase += (idade.Year - 1) + " anos, ";
                frase += (idade.Month - 1) + "meses é";
                frase += (idade.Day - 1) + "dias,";

                return frase;
            }
        }

        private string sign
        {
            get
            {
                string s = "";
                int d = data.Month * 100 + data.Day;
                if (d < 121 | d > 1221) s = "Sagitario";
                else if (d < 219) s = "Aquario";
                else if (d < 219) s = "Peixe";
                else if (d < 321) s = "Carneiro";
                else if (d < 420) s = "Touro";
                else if (d < 521) s = "Gémeos";
                else if (d < 621) s = "Caranguejo";
                else if (d < 723) s = "Leâo";
                else if (d < 823) s = "Virgem";
                else if (d < 923) s = "Aquario";
                else if (d < 1022) s = "Balança";
                else if (d < 1122) s = "Escorpião";
                else if (d < 1222) s = "Sagitário";
                string frase = "O seu signo é ";
                frase += s + ".\n";
                return frase;
            }
        }

        public string envia1
        {
            get
            {
                return diadasemana + idade + sign;
            }
        }
    }
}
