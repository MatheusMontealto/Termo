using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Termo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string letra1, letra2, letra3, letra4, letra5, palavra_final, palavra_correta = sorteiaPalavraDaRodada();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (verificaSePalavraPossuiCincoLetras())
            {
                //Faz o desmembramento da palavra digitada para as posições serem preenchidas
                desmembraPalavrasEmLetras();
                atribuiLetrasAosBotoes();

                //Verifica se letras estão nas posições corretas, se existem na palavra ou não.
                verificaSePossuiLetras();

                if (verificaSeEhAPalavraCorreta())
                {
                    lblAPalavraEra.Visible = true;
                    lblPalavraCorreta.Text = palavra_correta;

                    System.Windows.Forms.MessageBox.Show("Sucesso! A palavra era: "+palavra_correta);
                }
                else
                {

                    //Verifica se jogo foi perdido através do preenchimento da ultima posição possível.
                    if (!string.IsNullOrEmpty(button30.Text))
                    {
                        lblAPalavraEra.Visible = true;
                        lblPalavraCorreta.Text = palavra_correta;

                        System.Windows.Forms.MessageBox.Show("Perdeu! A palavra era: " + palavra_correta);
                    }
                    else
                    {
                        passaAVezDaPalavra();
                        txtDigitarPalavra.Text = string.Empty;
                    }
                }

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("A palavra não foi digitada ou não possui 5 letras.");
            }
        }

        private bool verificaSePalavraPossuiCincoLetras()
        {
            if (txtDigitarPalavra.TextLength == 5)
            {
                palavra_final = txtDigitarPalavra.Text;
                return true;
            }
            else
                return false;
        }

        private void desmembraPalavrasEmLetras()
        {
            letra1 = txtDigitarPalavra.Text.Substring(0, 1);
            letra2 = txtDigitarPalavra.Text.Substring(1, 1);
            letra3 = txtDigitarPalavra.Text.Substring(2, 1);
            letra4 = txtDigitarPalavra.Text.Substring(3, 1);
            letra5 = txtDigitarPalavra.Text.Substring(4, 1);
        }

        private void atribuiLetrasAosBotoes()
        {
            if (string.IsNullOrEmpty(button1.Text))
            {
                button1.Text = letra1;
                button2.Text = letra2;
                button3.Text = letra3;
                button4.Text = letra4;
                button5.Text = letra5;
            }
            else if (string.IsNullOrEmpty(button6.Text))
            {
                button6.Text = letra1;
                button7.Text = letra2;
                button8.Text = letra3;
                button9.Text = letra4;
                button10.Text = letra5;
            }
            else if (string.IsNullOrEmpty(button11.Text))
            {
                button11.Text = letra1;
                button12.Text = letra2;
                button13.Text = letra3;
                button14.Text = letra4;
                button15.Text = letra5;
            }
            else if (string.IsNullOrEmpty(button16.Text))
            {
                button16.Text = letra1;
                button17.Text = letra2;
                button18.Text = letra3;
                button19.Text = letra4;
                button20.Text = letra5;
            }
            else if (string.IsNullOrEmpty(button21.Text))
            {
                button21.Text = letra1;
                button22.Text = letra2;
                button23.Text = letra3;
                button24.Text = letra4;
                button25.Text = letra5;
            }
            else if (string.IsNullOrEmpty(button26.Text))
            {
                button26.Text = letra1;
                button27.Text = letra2;
                button28.Text = letra3;
                button29.Text = letra4;
                button30.Text = letra5;
            }
        }

        private void btnJogarNovamente_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void txtDigitarPalavra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToInt16(Keys.Enter))
            {
                btnConfirmar_Click(sender, e);
            }
        }

        private bool verificaSeEhAPalavraCorreta()
        {
            if (palavra_correta == palavra_final)
            {
                return true;
            }

            return false;
        }

        private void verificaSePossuiLetras()
        {
            if(button1.Text == palavra_correta.Substring(0, 1))
            {
                button1.BackColor = Color.Green;
            }
            else if (palavra_correta.Contains(button1.Text))
            {
                button1.BackColor = Color.Orange;
            }
            else
            {
                button1.BackColor = Color.Gray;
            }

            if (button2.Text == palavra_correta.Substring(1, 1))
            {
                button2.BackColor = Color.Green;
            }
            else if (palavra_correta.Contains(button2.Text))
            {
                button2.BackColor = Color.Orange;
            }
            else
            {
                button2.BackColor = Color.Gray;
            }

            if (button3.Text == palavra_correta.Substring(2, 1))
            {
                button3.BackColor = Color.Green;
            }
            else if (palavra_correta.Contains(button3.Text))
            {
                button3.BackColor = Color.Orange;
            }
            else
            {
                button3.BackColor = Color.Gray;
            }

            if (button4.Text == palavra_correta.Substring(3, 1))
            {
                button4.BackColor = Color.Green;
            }
            else if (palavra_correta.Contains(button4.Text))
            {
                button4.BackColor = Color.Orange;
            }
            else
            {
                button4.BackColor = Color.Gray;
            }

            if (button5.Text == palavra_correta.Substring(4, 1))
            {
                button5.BackColor = Color.Green;
            }
            else if (palavra_correta.Contains(button5.Text))
            {
                button5.BackColor = Color.Orange;
            }
            else
            {
                button5.BackColor = Color.Gray;
            }

            if (!string.IsNullOrEmpty(button6.Text))
            {
                if (button6.Text == palavra_correta.Substring(0, 1))
                {
                    button6.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button6.Text))
                {
                    button6.BackColor = Color.Orange;
                }
                else
                {
                    button6.BackColor = Color.Gray;
                }

                if (button7.Text == palavra_correta.Substring(1, 1))
                {
                    button7.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button7.Text))
                {
                    button7.BackColor = Color.Orange;
                }
                else
                {
                    button7.BackColor = Color.Gray;
                }

                if (button8.Text == palavra_correta.Substring(2, 1))
                {
                    button8.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button8.Text))
                {
                    button8.BackColor = Color.Orange;
                }
                else
                {
                    button8.BackColor = Color.Gray;
                }

                if (button9.Text == palavra_correta.Substring(3, 1))
                {
                    button9.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button9.Text))
                {
                    button9.BackColor = Color.Orange;
                }
                else
                {
                    button9.BackColor = Color.Gray;
                }

                if (button10.Text == palavra_correta.Substring(4, 1))
                {
                    button10.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button10.Text))
                {
                    button10.BackColor = Color.Orange;
                }
                else
                {
                    button10.BackColor = Color.Gray;
                }
            }

            if (!string.IsNullOrEmpty(button11.Text))
            {
                if (button11.Text == palavra_correta.Substring(0, 1))
                {
                    button11.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button11.Text))
                {
                    button11.BackColor = Color.Orange;
                }
                else
                {
                    button11.BackColor = Color.Gray;
                }

                if (button12.Text == palavra_correta.Substring(1, 1))
                {
                    button12.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button12.Text))
                {
                    button12.BackColor = Color.Orange;
                }
                else
                {
                    button12.BackColor = Color.Gray;
                }

                if (button13.Text == palavra_correta.Substring(2, 1))
                {
                    button13.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button13.Text))
                {
                    button13.BackColor = Color.Orange;
                }
                else
                {
                    button13.BackColor = Color.Gray;
                }

                if (button14.Text == palavra_correta.Substring(3, 1))
                {
                    button14.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button14.Text))
                {
                    button14.BackColor = Color.Orange;
                }
                else
                {
                    button14.BackColor = Color.Gray;
                }

                if (button15.Text == palavra_correta.Substring(4, 1))
                {
                    button15.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button15.Text))
                {
                    button15.BackColor = Color.Orange;
                }
                else
                {
                    button15.BackColor = Color.Gray;
                }
            }

            if (!string.IsNullOrEmpty(button16.Text))
            {
                if (button16.Text == palavra_correta.Substring(0, 1))
                {
                    button16.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button16.Text))
                {
                    button16.BackColor = Color.Orange;
                }
                else
                {
                    button16.BackColor = Color.Gray;
                }

                if (button17.Text == palavra_correta.Substring(1, 1))
                {
                    button17.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button17.Text))
                {
                    button17.BackColor = Color.Orange;
                }
                else
                {
                    button17.BackColor = Color.Gray;
                }

                if (button18.Text == palavra_correta.Substring(2, 1))
                {
                    button18.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button18.Text))
                {
                    button18.BackColor = Color.Orange;
                }
                else
                {
                    button18.BackColor = Color.Gray;
                }

                if (button19.Text == palavra_correta.Substring(3, 1))
                {
                    button19.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button19.Text))
                {
                    button19.BackColor = Color.Orange;
                }
                else
                {
                    button19.BackColor = Color.Gray;
                }

                if (button20.Text == palavra_correta.Substring(4, 1))
                {
                    button20.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button20.Text))
                {
                    button20.BackColor = Color.Orange;
                }
                else
                {
                    button20.BackColor = Color.Gray;
                }
            }

            if (!string.IsNullOrEmpty(button21.Text))
            {
                if (button21.Text == palavra_correta.Substring(0, 1))
                {
                    button21.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button21.Text))
                {
                    button21.BackColor = Color.Orange;
                }
                else
                {
                    button21.BackColor = Color.Gray;
                }

                if (button22.Text == palavra_correta.Substring(1, 1))
                {
                    button22.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button22.Text))
                {
                    button22.BackColor = Color.Orange;
                }
                else
                {
                    button22.BackColor = Color.Gray;
                }

                if (button23.Text == palavra_correta.Substring(2, 1))
                {
                    button23.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button23.Text))
                {
                    button23.BackColor = Color.Orange;
                }
                else
                {
                    button23.BackColor = Color.Gray;
                }

                if (button24.Text == palavra_correta.Substring(3, 1))
                {
                    button24.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button24.Text))
                {
                    button24.BackColor = Color.Orange;
                }
                else
                {
                    button24.BackColor = Color.Gray;
                }

                if (button25.Text == palavra_correta.Substring(4, 1))
                {
                    button25.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button25.Text))
                {
                    button25.BackColor = Color.Orange;
                }
                else
                {
                    button25.BackColor = Color.Gray;
                }
            }

            if (!string.IsNullOrEmpty(button26.Text))
            {
                if (button26.Text == palavra_correta.Substring(0, 1))
                {
                    button26.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button26.Text))
                {
                    button26.BackColor = Color.Orange;
                }
                else
                {
                    button26.BackColor = Color.Gray;
                }

                if (button27.Text == palavra_correta.Substring(1, 1))
                {
                    button27.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button27.Text))
                {
                    button27.BackColor = Color.Orange;
                }
                else
                {
                    button27.BackColor = Color.Gray;
                }

                if (button28.Text == palavra_correta.Substring(2, 1))
                {
                    button28.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button28.Text))
                {
                    button28.BackColor = Color.Orange;
                }
                else
                {
                    button28.BackColor = Color.Gray;
                }

                if (button29.Text == palavra_correta.Substring(3, 1))
                {
                    button29.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button29.Text))
                {
                    button29.BackColor = Color.Orange;
                }
                else
                {
                    button29.BackColor = Color.Gray;
                }

                if (button30.Text == palavra_correta.Substring(4, 1))
                {
                    button30.BackColor = Color.Green;
                }
                else if (palavra_correta.Contains(button30.Text))
                {
                    button30.BackColor = Color.Orange;
                }
                else
                {
                    button30.BackColor = Color.Gray;
                }
            }            
        } 

        private void passaAVezDaPalavra()
        {
            if (!string.IsNullOrEmpty(button5.Text) && string.IsNullOrEmpty(button6.Text))
            {
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
                button10.BackColor = Color.White;
            }
            if (!string.IsNullOrEmpty(button10.Text) && string.IsNullOrEmpty(button11.Text))
            {
                button11.BackColor = Color.White;
                button12.BackColor = Color.White;
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
            }
            if (!string.IsNullOrEmpty(button15.Text) && string.IsNullOrEmpty(button16.Text))
            {
                button16.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button19.BackColor = Color.White;
                button20.BackColor = Color.White;
            }
            if (!string.IsNullOrEmpty(button20.Text) && string.IsNullOrEmpty(button21.Text))
            {
                button21.BackColor = Color.White;
                button22.BackColor = Color.White;
                button23.BackColor = Color.White;
                button24.BackColor = Color.White;
                button25.BackColor = Color.White;
            }
            if (!string.IsNullOrEmpty(button25.Text) && string.IsNullOrEmpty(button26.Text))
            {
                button26.BackColor = Color.White;
                button27.BackColor = Color.White;
                button28.BackColor = Color.White;
                button29.BackColor = Color.White;
                button30.BackColor = Color.White;
            }
        }

        private static string sorteiaPalavraDaRodada()
        {
            var random = new Random();
            var list = new List<string> {
            "sagaz",
            "âmago",
            "negro",
            "êxito",
            "mexer",
            "termo",
            "senso",
            "nobre",
            "algoz",
            "afeto",
            "plena",
            "ética",
            "mútua",
            "tênue",
            "sutil",
            "vigor",
            "aquém",
            "fazer",
            "porém",
            "audaz",
            "sanar",
            "seção",
            "assim",
            "inato",
            "cerne",
            "ideia",
            "fosse",
            "desde",
            "poder",
            "moral",
            "torpe",
            "muito",
            "honra",
            "justo",
            "fútil",
            "gozar",
            "anexo",
            "razão",
            "etnia",
            "quiçá",
            "sobre",
            "ícone",
            "sonho",
            "tange",
            "égide",
            "lapso",
            "mútuo",
            "expor",
            "amigo",
            "haver",
            "hábil",
            "casal",
            "porra",
            "tempo",
            "seara",
            "pesar",
            "ávido",
            "então",
            "dengo",
            "posse",
            "boçal",
            "genro",
            "coser",
            "ardil",
            "causa",
            "corja",
            "dizer",
            "prole",
            "pária",
            "detém",
            "tenaz",
            "dever",
            "saber",
            "óbice",
            "digno",
            "graça",
            "crivo",
            "ápice",
            "ânsia",
            "ânimo",
            "orgia",
            "brado",
            "ceder",
            "comum",
            "gleba",
            "sendo",
            "temor",
            "assaz",
            "culto",
            "atroz",
            "mundo",
            "pauta",
            "censo",
            "fugaz",
            "ainda",
            "cozer",
            "denso",
            "valha",
            "neném",
            "vício",
            "forte",
            "estar",
            "vulgo",
            "revés",
            "pudor",
            "regra",
            "dogma",
            "louco",
            "criar",
            "banal",
            "impor",
            "round",
            "saúde",
            "jeito",
            "tenro",
            "pífio",
            "atrás",
            "desse",
            "ordem",
            "apraz",
            "pedir",
            "mercê",
            "clava",
            "reaça",
            "usura",
            "prosa",
            "viril",
            "juízo",
            "feliz",
            "servo",
            "sábio",
            "homem",
            "coisa",
            "ontem",
            "manso",
            "presa",
            "xibiu",
            "falar",
            "forma",
            "cunho",
            "devir",
            "fluir",
            "afago",
            "meiga",
            "ébrio",
            "mesmo",
            "platô",
            "vendo",
            "sério",
            "limbo",
            "guisa",
            "mágoa",
            "visar",
            "pleno",
            "herói",
            "temer",
            "acaso",
            "puder",
            "cisma",
            "valor",
            "bruma",
            "lugar",
            "posso",
            "êxodo",
            "afins",
            "óbvio",
            "gerar",
            "ímpio",
            "obter",
            "certo",
            "crise",
            "matiz",
            "praxe",
            "senil",
            "havia",
            "vênia",
            "fluxo",
            "enfim",
            "todos",
            "ritmo",
            "tédio",
            "álibi",
            "abrir",
            "união",
            "tomar",
            "garbo",
            "valia",
            "reter",
            "pulha",
            "visão",
            "falso",
            "parvo",
            "fácil",
            "vital",
            "grato",
            "bravo",
            "favor",
            "vivaz",
            "prumo",
            "laico",
            "parco",
            "gênio",
            "olhar",
            "burro",
            "legal",
            "ameno",
            "possa",
            "reles",
            "levar",
            "tecer",
            "óbito",
            "casta",
            "tesão",
            "prime",
            "selar",
            "anelo",
            "fator",
            "ranço",
            "morte",
            "noção",
            "rogar",
            "citar",
            "façam",
            "farsa",
            "sábia",
            "noite",
            "adiar",
            "achar",
            "cabal",
            "coeso",
            "cisão",
            "épico",
            "falta",
            "nicho",
            "ouvir",
            "fardo",
            "força",
            "ativo",
            "viver",
            "sinto",
            "brega",
            "gente",
            "imune",
            "exato",
            "haste",
            "amplo",
            "passo",
            "sonso",
            "lavra",
            "sulco",
            "dúbio",
            "cesta",
            "tendo",
            "leigo",
            "sesta",
            "único",
            "revel",
            "labor",
            "deter",
            "gesto",
            "vemos",
            "calma",
            "vadia",
            "árduo",
            "humor",
            "linda",
            "atuar",
            "feixe",
            "rever",
            "ciúme",
            "pobre",
            "ótica",
            "tende",
            "carma",
            "outro",
            "igual",
            "ponto",
            "hiato",
            "toada",
            "velho",
            "ajuda",
            "ideal",
            "claro",
            "sonsa",
            "débil",
            "vácuo",
            "ambos",
            "terno",
            "remir",
            "varão",
            "cauda",
            "fusão",
            "probo",
            "senão",
            "leito",
            "fonte",
            "marco",
            "jovem",
            "advém",
            "doido",
            "inata",
            "capaz",
            "horda",
            "xeque",
            "terra",
            "tenra",
            "relva",
            "ficar",
            "algum",
            "velar",
            "caçar",
            "série",
            "apoio",
            "farão",
            "líder",
            "anuir",
            "vazio",
            "vimos",
            "rigor",
            "tanto",
            "verso",
            "coçar",
            "dorso",
            "entre",
            "botar",
            "frase",
            "pouco",
            "massa",
            "signo",
            "sente",
            "cruel",
            "coesa",
            "prece",
            "moção",
            "vírus",
            "ambas",
            "morar",
            "fauna",
            "peste",
            "raiva",
            "casto",
            "covil",
            "feito",
            "minha",
            "preso",
            "credo",
            "ciclo",
            "papel",
            "corno",
            "faina",
            "ímpar",
            "torço",
            "lazer",
            "furor",
            "dócil",
            "flora",
            "brisa",
            "vetor",
            "chata",
            "maior",
            "árido",
            "trama",
            "aceso",
            "beata",
            "houve",
            "pegar",
            "blasé",
            "adeus",
            "manha",
            "vulto",
            "nossa",
            "setor",
            "liame",
            "banzo",
            "breve",
            "vasto",
            "birra",
            "senda",
            "salvo",
            "seita",
            "ardor",
            "livro",
            "meses",
            "peixe",
            "morro",
            "visse",
            "pecha",
            "átomo",
            "chuva",
            "prado",
            "antro",
            "reger",
            "comer",
            "prono",
            "sorte",
            "plano",
            "avaro",
            "segue",
            "saiba",
            "ocaso",
            "rezar",
            "foder",
            "pajem",
            "carro",
            "nunca",
            "aliás",
            "saída",
            "ótimo",
            "áureo",
            "anciã",
            "junto",
            "mudar",
            "acima",
            "chulo",
            "séria",
            "serão",
            "sinal",
            "opção",
            "fitar",
            "jazia",
            "fruir",
            "parar",
            "treta",
            "fugir",
            "nação",
            "puxar",
            "bando",
            "andar",
            "grupo",
            "prazo",
            "motim",
            "gerir",
            "leite",
            "norma",
            "tosco",
            "lenda",
            "alude",
            "brava",
            "época",
            "sinhá",
            "rapaz",
            "tenso",
            "parte",
            "campo",
            "exame",
            "avião",
            "ídolo",
            "psico",
            "arcar",
            "reino",
            "tirar",
            "venal",
            "malta",
            "soldo",
            "praga",
            "agora",
            "vilão",
            "quota",
            "anais",
            "corpo",
            "aonde",
            "sumir",
            "índio",
            "virão",
            "risco",
            "praia",
            "logro",
            "antes",
            "preto",
            "traga",
            "fixar",
            "voraz",
            "pompa",
            "cheio",
            "exijo",
            "quase",
            "filho",
            "certa",
            "texto",
            "turba",
            "nódoa",
            "oásis",
            "cópia",
            "solto",
            "alado",
            "apego",
            "turva",
            "caixa",
            "prova",
            "estão",
            "acesa",
            "messe",
            "grave",
            "doído",
            "nível",
            "ligar",
            "perda",
            "parva",
            "verve",
            "conta",
            "apelo",
            "verbo",
            "átrio",
            "tocar",
            "áurea",
            "pardo",
            "lindo",
            "trupe",
            "coito",
            "fenda",
            "livre",
            "dessa",
            "sabia",
            "opaco",
            "alçar",
            "navio",
            "viria",
            "fraco",
            "retém",
            "afora",
            "festa",
            "jirau",
            "ficha",
            "ético",
            "astro",
            "parca",
            "faixa",
            "elite",
            "oxalá",
            "supra",
            "lidar",
            "glosa",
            "autor",
            "mente",
            "fatos",
            "tinha",
            "firme",
            "verba",
            "magia",
            "cioso",
            "fatal",
            "grata",
            "manhã",
            "bater",
            "calda",
            "reses",
            "pique",
            "cousa",
            "junco",
            "privê",
            "deixa",
            "salve",
            "irmão",
            "pagão",
            "macio",
            "molho",
            "douto",
            "atual",
            "abriu",
            "bicho",
            "light",
            "supor",
            "posto",
            "torso",
            "turvo",
            "asilo",
            "ígneo",
            "sexta",
            "extra",
            "vezes",
            "órfão",
            "judeu",
            "sarça",
            "curso",
            "caber",
            "longe",
            "rouca",
            "locus",
            "besta",
            "porta",
            "pisar",
            "drops",
            "cânon",
            "rádio",
            "desta",
            "abuso",
            "ruína",
            "zelar",
            "vídeo",
            "combo",
            "vosso",
            "bioma",
            "ereto",
            "vinha",
            "culpa",
            "finda",
            "paira",
            "menos",
            "agudo",
            "baixo",
            "feudo",
            "bônus",
            "facto",
            "nosso",
            "tetra",
            "advir",
            "urgia",
            "estio",
            "cútis",
            "surja",
            "meigo",
            "traço",
            "sítio",
            "super",
            "gosto",
            "calão",
            "autos",
            "facho",
            "tento",
            "suave",
            "rumor",
            "amena",
            "pilar",
            "cocho",
            "turma",
            "museu",
            "clean",
            "chama",
            "lasso",
            "ações",
            "geral",
            "louça",
            "acolá",
            "lápis",
            "pífia",
            "optar",
            "local",
            "pódio",
            "boato",
            "mosto",
            "hobby",
            "medir",
            "júlia",
            "rubro",
            "crime",
            "pacto",
            "penta",
            "letal",
            "folga",
            "refém",
            "ponha",
            "brabo",
            "poema",
            "drama",
            "páreo",
            "cacho",
            "aluno",
            "móvel",
            "aroma",
            "mesma",
            "vigia",
            "cover",
            "feroz",
            "hoste",
            "vetar",
            "peito",
            "pasmo",
            "fazia",
            "rival",
            "açude",
            "metiê",
            "golpe",
            "monte",
            "ávida",
            "finjo",
            "troça",
            "axila",
            "coral",
            "teste",
            "chato",
            "ecoar",
            "fórum",
            "lição",
            "daqui",
            "riste",
            "piada",
            "forem",
            "plebe",
            "poeta",
            "verde",
            "monge",
            "lesse",
            "artur",
            "clima",
            "carta",
            "súcia",
            "passa",
            "cetro",
            "ébano",
            "escol",
            "tacha",
            "swing",
            "macro",
            "ateia",
            "broxa",
            "venha",
            "falha",
            "briga",
            "calmo",
            "roupa",
            "conto",
            "sarau",
            "viram",
            "busca",
            "cargo",
            "idoso",
            "fruto",
            "plaga",
            "farta",
            "tarde",
            "légua",
            "perco",
            "átimo",
            "tribo",
            "aviso",
            "plumo",
            "berro",
            "chefe",
            "vento",
            "grama",
            "virar",
            "civil",
            "corso",
            "catre",
            "arado",
            "surto",
            "seixo",
            "assar",
            "estro",
            "saldo",
            "traje",
            "ornar",
            "bruta",
            "nuvem",
            "recém",
            "beijo",
            "pedra",
            "manga",
            "deste",
            "fosso",
            "troca",
            "mangá",
            "única",
            "gíria",
            "casar",
            "trato",
            "ímpia",
            "depor",
            "bença",
            "vedar",
            "amiga",
            "úteis",
            "porte",
            "arfar",
            "tição",
            "deram",
            "magna",
            "irado",
            "âmbar",
            "canso",
            "grota",
            "amado",
            "tutor",
            "sósia",
            "cifra",
            "silvo",
            "bazar",
            "gabar",
            "tiver",
            "vazão",
            "itens",
            "pasma",
            "rural",
            "bruto",
            "renda",
            "laudo",
            "perto",
            "jejum",
            "pavor",
            "régio",
            "mídia",
            "segar",
            "bucho",
            "nesse",
            "pinho",
            "tchau",
            "inter",
            "troco",
            "feita",
            "minar",
            "órgão",
            "odiar",
            "vagar",
            "fossa",
            "viado",
            "molde",
            "areia",
            "clero",
            "vadio",
            "lesto",
            "meche",
            "sótão",
            "pomar",
            "aviar",
            "negar",
            "canto",
            "mamãe",
            "cenho",
            "lesão",
            "cinto",
            "largo",
            "rocha",
            "paiol",
            "horto",
            "visto",
            "ileso",
            "bolsa",
            "proto",
            "ruído",
            "stand",
            "amada",
            "pugna",
            "guria",
            "invés",
            "densa",
            "marca",
            "podar",
            "morfo",
            "close",
            "bunda",
            "urdir",
            "jogar",
            "vista",
            "ufano",
            "xucro",
            "vasta",
            "dúbia",
            "mocho",
            "frota",
            "chula",
            "cível",
            "penso",
            "cheia",
            "bulir",
            "úmido",
            "piche",
            "culta",
            "linha",
            "úbere",
            "peita",
            "esgar",
            "varoa",
            "resto",
            "apear",
            "canil",
            "misto",
            "manto",
            "fundo",
            "natal",
            "tenha",
            "ágape",
            "demão",
            "monta",
            "narco",
            "fazes",
            "santo",
            "nessa",
            "findo",
            "barão",
            "campa",
            "cerca",
            "volta",
            "gemer",
            "símio",
            "jazer",
            "velha",
            "chaga",
            "álbum",
            "preço",
            "logos",
            "pólis",
            "mover",
            "retro",
            "verão",
            "ardis",
            "lábia",
            "letra",
            "cosmo",
            "seiva",
            "ferpa",
            "venho",
            "folia",
            "banto",
            "matar",
            "troço",
            "punha",
            "álamo",
            "nesta",
            "etapa",
            "sabor",
            "porca",
            "áudio",
            "ceita",
            "trago",
            "barro",
            "coroa",
            "calça",
            "rente",
            "sigla",
            "axial",
            "final",
            "louro",
            "salva",
            "redor",
            "firma",
            "arroz",
            "limpo",
            "bolso",
            "torna",
            "coevo",
            "tumba",
            "queda",
            "solta",
            "míope",
            "enjoo",
            "lutar",
            "farol",
            "lousa",
            "dança",
            "baixa",
            "folha",
            "fugiu",
            "ousar",
            "mimar",
            "neste",
            "corar",
            "veloz",
            "zumbi",
            "burra",
            "sinta",
            "nácar",
            "longo",
            "obtém",
            "reler",
            "salmo",
            "macho",
            "cacto",
            "forro",
            "penca",
            "vazia",
            "fátuo",
            "calor",
            "justa",
            "vário",
            "farto",
            "todas",
            "bedel",
            "quite",
            "mania",
            "gueto",
            "chave",
            "lucro",
            "sugar",
            "repor",
            "calvo",
            "puído",
            "merda",
            "logia",
            "sexto",
            "staff",
            "ultra",
            "custo",
            "subir",
            "passe",
            "refil",
            "urgir",
            "viger",
            "sadio",
            "mimos",
            "versa",
            "harém",
            "valer",
            "hífen",
            "lento",
            "usual",
            "rédea",
            "sócio",
            "cardo",
            "árdua",
            "louca"
            };
            int index = random.Next(list.Count);

            return list[index];
        }
    }
}
