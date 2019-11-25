using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNascimento
{
    class Idade1
    {
        private DateTime data;
        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }

        private string diasemana
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
                // Atenção: MinValue = 1/1/1

                string frase = "A sua idade é ";
                frase += (idade.Year - 1) + " anos, ";
                frase += (idade.Month - 1) + " meses e ";
                frase += (idade.Day - 1) + " dias.\n";
                return frase;
            }
        }
        private string signo
        {
            get
            {
                string s = "";
                int d = data.Month * 100 + data.Day;
                if (d < 121 | d > 1221) s = "Capricórnio.\nOs Nativos de Capricórnio este ano vão descobrir a força do seu lado espiritual e vão deixar um pouco de lado os aspectos mais materiais da vida que eles tanto amam e perseguem.";
                else if (d < 219) s = "Aquário.\nO arranque do ano para os nativos de Aquário vai ser a um ritmo muito lento, mas eles vão ter de mudar de atitude e acelerar o ritmo para conseguirem atingir os seus objectivos. No trabalho, os seus superiores irão testar os seus limites e aumentar o grau de exigência do seu trabalho, por isso prepare-se porque 2019 vai ser um ano extenuante.";
                else if (d < 321) s = "Peixes.\nEste ano será um ano de colheita e muito prazeroso para os Nativos de Peixes, após vários anos a trabalhar arduamente, tanto na carreira, como nas relações, chegou a hora de desfrutar dos excelentes resultados, aproveite porque o mérito é todo seu.";
                else if (d < 420) s = "Carneiro.\nOs nativos de Carneiro vão fazer o trabalho de casa antes de iniciar o novo ano, com uma lista bem definida de objectivos que pretendem alcançar até ao final do ano, tudo irá correr sem imprevistos. Contudo, o objectivo que mais desafiará os nativos de carneiro será o de controlar a sua própria impulsividade.";
                else if (d < 521) s = "Touro.\nOs Nativos de Touro podem esperar de 2019 um período exigente que irá exigir muita aprendizagem da sua parte, nomeadamente na área financeira. O ano vai começar com períodos de trabalho muito intensos e que vão necessitar de toda a sua energia e empenho, mas irá valer a pena porque a sua vida profissional vai ser o sector que receberá mais energia positiva.";
                else if (d < 621) s = "Gémeos.\nEste ano, os Nativos de Gémeos vão necessitar de fazer um grande exercício de introspecção sobre as decisões que tomaram no passado, para assim estarem preparados e conseguirem identificar o que os estará a impedir de alcançar os tão esperados objectivos financeiros.";
                else if (d < 723) s = "Caranguejo.\nOs nativos de Caranguejo / Câncer, estão decididos a sair da sua zona de conforto e mudar a sua vida radicalmente. Para isso, vão tentar implementar as suas boas ideias mas, lembrem-se que nem sempre o mercado está preparado para responder da forma que pretende, esteja preparado para situações difíceis.";
                else if (d < 823) s = "Leão.\nSerá um ano em que os Nativos de Leão terão de tomar decisões com a cabeça bem fria. É preciso ter consciência que só pelo trabalho é que consegue melhorar a sua disponibilidade financeira, pelo que o caminho é simples mas trabalhoso. Invista na sua carreira profissional e o retorno financeiro a seu tempo chegará. Aproveite esta fase positiva para atingir os seus objectivos mais rapidamente.";
                else if (d < 923) s = "Virgem.\nos nativos do Signo Virgem que facilmente se conformam com uma vida rotineira e pacata, preparem-se porque este novo ano vai chegar com grandes mudanças. A mudança de perspectiva de vida terá como consequência um grande crescimento pessoal, vai ser um ano de viragem para todos os virginianos, aproveitem.";
                else if (d < 1022) s = "Balança.\n2019 será para os Nativos de Balança / Libra, um ano de limpeza, as mudanças drásticas serão vitais para uma renovação e recomeço. Não ponha entraves, nem desista a meio, porque estas mudanças são imprescindíveis.";
                else if (d < 1122) s = "Escorpião.\nOs Nativos de Escorpião vão iniciar o seu novo ano sem dúvidas e com convições bem definidas. Este ano, vão estar inteiramente por sua conta e risco, o que irá contribuir para que se sintam poderosos e independentes, não irão necessitar do aval de ninguém, mas devem ter atenção para não meterem os pés pelas mãos.";
                else if (d < 1222) s = "Sagitário.\nA estabilidade, será a palavra chave para os nativos de Sagitário durante o ano de 2019, apesar do ritmo ser lento, isso não significam que os seus projectos não estejam a caminhar para o sucesso, mas um pouco de paciência é o que irá precisar durante todo o ano.";
                string frase = "O seu signo é ";
                frase += s;
                return frase;
            }
        }
        public string envia
        {
            get
            {
                return diasemana + idade + signo;
            }
        }

    }
}
