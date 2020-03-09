using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Logicando
{
    public partial class Form1 : Form
    {
        int[] listaRespotas = new int[20];
        int[] listaComandos = new int[20];

        int contadorAcoes = 0;

        //funcoes prontas
        private void iniciarJogo()
        {
            bt_start.Visible = false;
            bt_about.Visible = false;

            lbl_lista.Visible = true;

            bt_right.Visible = true;
            bt_left.Visible = true;
            bt_proceed.Visible = true;
            bt_stop.Visible = true;
            bt_condition.Visible = true;
            bt_while.Visible = true;
            bt_park.Visible = true;

            lbl_actions.Visible = true;
            lb_actions.Visible = true;
        }

        private void adicionarLista(int valor)
        {   
            //siginifica que o jogador quer parar
            if(valor == 0)
            {
                string n = "";

                for(int i=0; i< 3; i++)
                {
                    n += listaComandos[i].ToString();
                }

                MessageBox.Show(n, "");
            }
            else
            {
                //verifica o ultimo elemento que seja 0, e muda pelo valor
                for (int i = 0; i < listaComandos.Length; i++)
                {
                    if (listaComandos[i] == 0)
                    {
                        //adicionar o valor a lista de acoes e a lista comandos
                        string action = "Action [" + i +"]: " + getAction(valor);

                        lb_actions.Items.Add(action);
                        listaComandos[i] = valor;
                        break;
                    }
                }
            }
        }

        //pegar determinada ação pelo valor
        private string getAction(int valor)
        {
            string action = "";

            switch (valor)
            {
                case 1:
                    action = "RIGHT";
                    break;

                case 2:
                    action = "LEFT";
                    break;

                case 3:
                    action = "PROCEED";
                    break;

                case 4:
                    action = "STOP";
                    break;
            }

            return action;
        }

        private void visibleButtons()
        {
            //desabilitar os botoes quando entra em algum laço ou condição
            bt_right.Visible = false;
            bt_left.Visible = false;
            bt_proceed.Visible = false;
            bt_stop.Visible = false;
            bt_park.Visible = false;
        }

        //Interface Grafica
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            iniciarJogo();
        }

        private void bt_right_Click(object sender, EventArgs e)
        {
            adicionarLista(1);
        }

        private void bt_left_Click(object sender, EventArgs e)
        {
            adicionarLista(2);
        }

        private void bt_proceed_Click(object sender, EventArgs e)
        {
            adicionarLista(3);
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            adicionarLista(4);
        }

        private void bt_park_Click(object sender, EventArgs e)
        {
            adicionarLista(0);
            Process.Start("t.py");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_condition_Click(object sender, EventArgs e)
        {
            //ativar e desativar a visibilidade do contenier CONDITION
            if (gb_Condition.Visible)
            {
                gb_Condition.Visible = false;

                //voltar como estava antes
                iniciarJogo();
            }
            else
            {
                gb_Condition.Visible = true;

                //desabilitar outros botoes
                visibleButtons();
                bt_while.Visible = false;
            }
        }
    }
}
