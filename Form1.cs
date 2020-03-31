using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PARKINFO
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
            Bounds = Screen.PrimaryScreen.Bounds;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pb_mapa.BackColor = Color.Transparent;

            //pb_atividades
            pb_jogos_quadra.Visible = false;
            pb_teatro.Visible = false;
            pb_natacao.Visible = false;
            pb_corrida.Visible = false;
            pb_alongamento.Visible = false;

            lb_info_evento.Visible = false;
            pb_info_evento.Visible = false;


            //Fake Relogio
            //timer interval
            t.Interval = 1000;  //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            t.Start();  //this will use t_Tick() method

        }


        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            lb_relogio.Text = time;
        }



        private void bt_quadras_Click(object sender, EventArgs e)
        {
            if (bt_agenda.Text == "<- VOLTAR")
            {
                pb_jogos_quadra.Visible = true;
                pb_teatro.Visible = false;
                pb_natacao.Visible = false;
                pb_corrida.Visible = false;
                pb_alongamento.Visible = false;

                pb_info_evento.Visible = true;
                lb_info_evento.Visible = true;
                lb_info_evento.Text = "Jogos de Quadra: Próximo as 14:00";
            }
            else
            {
                pb_mapa.Image = Properties.Resources.map_quadras;
                pb_mapa.Refresh();
                pb_mapa.Visible = true;

                pb_jogos_quadra.Visible = false;
                pb_teatro.Visible = false;
                pb_natacao.Visible = false;
                pb_corrida.Visible = false;
                pb_alongamento.Visible = false;
            }
        }

        private void bt_bosques_Click(object sender, EventArgs e)
        {
            if (bt_agenda.Text == "<- VOLTAR")
            {
                pb_jogos_quadra.Visible = false;
                pb_teatro.Visible = true;
                pb_natacao.Visible = false;
                pb_corrida.Visible = false;
                pb_alongamento.Visible = false;

                pb_info_evento.Visible = true;
                lb_info_evento.Visible = true;
                lb_info_evento.Text = "Teatro Infantil: Próximo as 16:00";
            }
            else
            {
                pb_mapa.Image = Properties.Resources.map_bosques;
                pb_mapa.Refresh();
                pb_mapa.Visible = true;

                pb_jogos_quadra.Visible = false;
                pb_teatro.Visible = false;
                pb_natacao.Visible = false;
                pb_corrida.Visible = false;
                pb_alongamento.Visible = false;
            }
        }

        private void bt_piscinas_Click(object sender, EventArgs e)
        {
            if (bt_agenda.Text == "<- VOLTAR")
            {
                pb_jogos_quadra.Visible = false;
                pb_teatro.Visible = false;
                pb_natacao.Visible = true;
                pb_corrida.Visible = false;
                pb_alongamento.Visible = false;


                pb_info_evento.Visible = true;
                lb_info_evento.Visible = true;
                lb_info_evento.Text = "Natação: Próxima as 12:00";
            }
            else
            {
                pb_mapa.Image = Properties.Resources.map_piscinas;
                pb_mapa.Refresh();
                pb_mapa.Visible = true;

                pb_jogos_quadra.Visible = false;
                pb_teatro.Visible = false;
                pb_natacao.Visible = false;
                pb_corrida.Visible = false;
                pb_alongamento.Visible = false;
            }
        }

        private void bt_mapa_Click(object sender, EventArgs e)
        {
            if (bt_agenda.Text == "<- VOLTAR")
            {
                pb_jogos_quadra.Visible = false;
                pb_teatro.Visible = false;
                pb_natacao.Visible = false;
                pb_corrida.Visible = true;
                pb_alongamento.Visible = false;

                pb_info_evento.Visible = true;
                lb_info_evento.Visible = true;
                lb_info_evento.Text = "Caminhada: Próxima as 13:30";
            }
            else
            {
                pb_mapa.Image = Properties.Resources.map_total;
                pb_mapa.Refresh();
                pb_mapa.Visible = true; 
                
                pb_jogos_quadra.Visible = false;
                pb_teatro.Visible = false;
                pb_natacao.Visible = false;
                pb_corrida.Visible = false;
                pb_alongamento.Visible = false;
            }
        }

        private void bt_estacionamentp_Click(object sender, EventArgs e)
        {
            if (bt_agenda.Text == "<- VOLTAR")
            {
                pb_jogos_quadra.Visible = false;
                pb_teatro.Visible = false;
                pb_natacao.Visible = false;
                pb_corrida.Visible = false;
                pb_alongamento.Visible = true;

                pb_info_evento.Visible = true;
                lb_info_evento.Visible = true;
                lb_info_evento.Text = "Alongamento: Próxima as 17:30";
            }
            else
            {
                pb_mapa.Image = Properties.Resources.map_estacionamento;
                pb_mapa.Refresh();
                pb_mapa.Visible = true;

                pb_jogos_quadra.Visible = false;
                pb_teatro.Visible = false;
                pb_natacao.Visible = false;
                pb_corrida.Visible = false;
                pb_alongamento.Visible = false;
            }
        }

        private void pb_mapa_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_agenda_Click(object sender, EventArgs e)
        {
            
            if(bt_agenda.Text == "<- VOLTAR")
            {
                bt_agenda.Text = "AGENDA DE HOJE";
                bt_agenda.ForeColor = Color.LightGreen;
                bt_agenda.BackColor = Color.Sienna;

                bt_mapa.Text = "MAPA COMPLETO";
                bt_mapa.ForeColor = Color.White;
                bt_mapa.BackColor = Color.Sienna;

                bt_estacionamento.Text = "ESTACIONAMENTO LANCHES";
                bt_estacionamento.ForeColor = Color.White;
                bt_estacionamento.BackColor = Color.Sienna;

                bt_piscinas.Text = "PISCINAS";
                bt_piscinas.ForeColor = Color.White;
                bt_piscinas.BackColor = Color.Sienna;

                bt_quadras.Text = "QUADRAS";
                bt_quadras.ForeColor = Color.White;
                bt_quadras.BackColor = Color.Sienna;

                bt_bosques.Text = "BOSQUES";
                bt_bosques.ForeColor = Color.White;
                bt_bosques.BackColor = Color.Sienna;

                pb_jogos_quadra.Visible = false;
                pb_teatro.Visible = false;
                pb_natacao.Visible = false;
                pb_corrida.Visible = false;
                pb_alongamento.Visible = false;

                lb_info_evento.Visible = false;
                pb_info_evento.Visible = false;

            }
            else {
                bt_agenda.Text = "<- VOLTAR";
                bt_agenda.BackColor = Color.White;
                bt_agenda.ForeColor = Color.Green;

                pb_mapa.Image = Properties.Resources.map_total;
                pb_mapa.Refresh();
                pb_mapa.Visible = true;


                bt_mapa.Text = "Caminhada";
                bt_mapa.BackColor = Color.LightGreen;
                bt_mapa.ForeColor = Color.Black;

                bt_quadras.Text = "Jogos de quadra";
                bt_quadras.BackColor = Color.LightGreen;
                bt_quadras.ForeColor = Color.Black;

                bt_piscinas.Text = "Natação";
                bt_piscinas.BackColor = Color.LightGreen;
                bt_piscinas.ForeColor = Color.Black;

                bt_estacionamento.Text = "Alongamento";
                bt_estacionamento.BackColor = Color.LightGreen;
                bt_estacionamento.ForeColor = Color.Black;

                bt_bosques.Text = "Teatro ar Livre";
                bt_bosques.BackColor = Color.LightGreen;
                bt_bosques.ForeColor = Color.Black;

                lb_info_evento.Visible = false;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
