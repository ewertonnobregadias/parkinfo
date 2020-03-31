namespace PARKINFO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_quadras = new System.Windows.Forms.Button();
            this.bt_bosques = new System.Windows.Forms.Button();
            this.bt_piscinas = new System.Windows.Forms.Button();
            this.bt_agenda = new System.Windows.Forms.Button();
            this.bt_estacionamento = new System.Windows.Forms.Button();
            this.bt_mapa = new System.Windows.Forms.Button();
            this.lb_vc = new System.Windows.Forms.Label();
            this.pb_corrida = new System.Windows.Forms.PictureBox();
            this.pb_teatro = new System.Windows.Forms.PictureBox();
            this.pb_natacao = new System.Windows.Forms.PictureBox();
            this.pb_alongamento = new System.Windows.Forms.PictureBox();
            this.pb_jogos_quadra = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_mapa = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_info_evento = new System.Windows.Forms.PictureBox();
            this.lb_info_evento = new System.Windows.Forms.Label();
            this.lb_relogio = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_corrida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_teatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_natacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_alongamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_jogos_quadra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info_evento)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_quadras
            // 
            this.bt_quadras.BackColor = System.Drawing.Color.Sienna;
            this.bt_quadras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_quadras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quadras.ForeColor = System.Drawing.Color.White;
            this.bt_quadras.Location = new System.Drawing.Point(830, 189);
            this.bt_quadras.Name = "bt_quadras";
            this.bt_quadras.Size = new System.Drawing.Size(120, 75);
            this.bt_quadras.TabIndex = 1;
            this.bt_quadras.Text = "QUADRAS";
            this.bt_quadras.UseVisualStyleBackColor = false;
            this.bt_quadras.Click += new System.EventHandler(this.bt_quadras_Click);
            // 
            // bt_bosques
            // 
            this.bt_bosques.BackColor = System.Drawing.Color.Sienna;
            this.bt_bosques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_bosques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bosques.ForeColor = System.Drawing.Color.White;
            this.bt_bosques.Location = new System.Drawing.Point(830, 344);
            this.bt_bosques.Name = "bt_bosques";
            this.bt_bosques.Size = new System.Drawing.Size(120, 75);
            this.bt_bosques.TabIndex = 2;
            this.bt_bosques.Text = "BOSQUES";
            this.bt_bosques.UseVisualStyleBackColor = false;
            this.bt_bosques.Click += new System.EventHandler(this.bt_bosques_Click);
            // 
            // bt_piscinas
            // 
            this.bt_piscinas.BackColor = System.Drawing.Color.Sienna;
            this.bt_piscinas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_piscinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_piscinas.ForeColor = System.Drawing.Color.White;
            this.bt_piscinas.Location = new System.Drawing.Point(29, 504);
            this.bt_piscinas.Name = "bt_piscinas";
            this.bt_piscinas.Size = new System.Drawing.Size(120, 75);
            this.bt_piscinas.TabIndex = 3;
            this.bt_piscinas.Text = "PISCINAS";
            this.bt_piscinas.UseVisualStyleBackColor = false;
            this.bt_piscinas.Click += new System.EventHandler(this.bt_piscinas_Click);
            // 
            // bt_agenda
            // 
            this.bt_agenda.BackColor = System.Drawing.Color.Sienna;
            this.bt_agenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agenda.ForeColor = System.Drawing.Color.LightGreen;
            this.bt_agenda.Location = new System.Drawing.Point(830, 504);
            this.bt_agenda.Name = "bt_agenda";
            this.bt_agenda.Size = new System.Drawing.Size(120, 75);
            this.bt_agenda.TabIndex = 6;
            this.bt_agenda.Text = "AGENDA DE HOJE";
            this.bt_agenda.UseVisualStyleBackColor = false;
            this.bt_agenda.Click += new System.EventHandler(this.bt_agenda_Click);
            // 
            // bt_estacionamento
            // 
            this.bt_estacionamento.BackColor = System.Drawing.Color.Sienna;
            this.bt_estacionamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_estacionamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_estacionamento.ForeColor = System.Drawing.Color.White;
            this.bt_estacionamento.Location = new System.Drawing.Point(29, 344);
            this.bt_estacionamento.Name = "bt_estacionamento";
            this.bt_estacionamento.Size = new System.Drawing.Size(120, 75);
            this.bt_estacionamento.TabIndex = 5;
            this.bt_estacionamento.Text = "ESTACIONAMENTO LANCHES";
            this.bt_estacionamento.UseVisualStyleBackColor = false;
            this.bt_estacionamento.Click += new System.EventHandler(this.bt_estacionamentp_Click);
            // 
            // bt_mapa
            // 
            this.bt_mapa.BackColor = System.Drawing.Color.Sienna;
            this.bt_mapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_mapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mapa.ForeColor = System.Drawing.Color.White;
            this.bt_mapa.Location = new System.Drawing.Point(29, 189);
            this.bt_mapa.Name = "bt_mapa";
            this.bt_mapa.Size = new System.Drawing.Size(120, 75);
            this.bt_mapa.TabIndex = 4;
            this.bt_mapa.Text = "MAPA COMPLETO";
            this.bt_mapa.UseVisualStyleBackColor = false;
            this.bt_mapa.Click += new System.EventHandler(this.bt_mapa_Click);
            // 
            // lb_vc
            // 
            this.lb_vc.AutoSize = true;
            this.lb_vc.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vc.Location = new System.Drawing.Point(244, 660);
            this.lb_vc.Name = "lb_vc";
            this.lb_vc.Size = new System.Drawing.Size(259, 31);
            this.lb_vc.TabIndex = 11;
            this.lb_vc.Text = "Você esta nesta marca!";
            // 
            // pb_corrida
            // 
            this.pb_corrida.BackColor = System.Drawing.Color.Transparent;
            this.pb_corrida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_corrida.Image = global::PARKINFO.Properties.Resources.pin_meu_atividades;
            this.pb_corrida.Location = new System.Drawing.Point(660, 523);
            this.pb_corrida.Name = "pb_corrida";
            this.pb_corrida.Size = new System.Drawing.Size(20, 20);
            this.pb_corrida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_corrida.TabIndex = 16;
            this.pb_corrida.TabStop = false;
            // 
            // pb_teatro
            // 
            this.pb_teatro.BackColor = System.Drawing.Color.Transparent;
            this.pb_teatro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_teatro.Image = global::PARKINFO.Properties.Resources.pin_meu_atividades;
            this.pb_teatro.Location = new System.Drawing.Point(354, 433);
            this.pb_teatro.Name = "pb_teatro";
            this.pb_teatro.Size = new System.Drawing.Size(20, 20);
            this.pb_teatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_teatro.TabIndex = 15;
            this.pb_teatro.TabStop = false;
            // 
            // pb_natacao
            // 
            this.pb_natacao.BackColor = System.Drawing.Color.Transparent;
            this.pb_natacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_natacao.Image = global::PARKINFO.Properties.Resources.pin_meu_atividades;
            this.pb_natacao.Location = new System.Drawing.Point(491, 449);
            this.pb_natacao.Name = "pb_natacao";
            this.pb_natacao.Size = new System.Drawing.Size(20, 20);
            this.pb_natacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_natacao.TabIndex = 14;
            this.pb_natacao.TabStop = false;
            // 
            // pb_alongamento
            // 
            this.pb_alongamento.BackColor = System.Drawing.Color.Transparent;
            this.pb_alongamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_alongamento.Image = global::PARKINFO.Properties.Resources.pin_meu_atividades;
            this.pb_alongamento.Location = new System.Drawing.Point(580, 290);
            this.pb_alongamento.Name = "pb_alongamento";
            this.pb_alongamento.Size = new System.Drawing.Size(20, 20);
            this.pb_alongamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_alongamento.TabIndex = 13;
            this.pb_alongamento.TabStop = false;
            // 
            // pb_jogos_quadra
            // 
            this.pb_jogos_quadra.BackColor = System.Drawing.Color.Transparent;
            this.pb_jogos_quadra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_jogos_quadra.Image = global::PARKINFO.Properties.Resources.pin_meu_atividades;
            this.pb_jogos_quadra.Location = new System.Drawing.Point(354, 311);
            this.pb_jogos_quadra.Name = "pb_jogos_quadra";
            this.pb_jogos_quadra.Size = new System.Drawing.Size(20, 20);
            this.pb_jogos_quadra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_jogos_quadra.TabIndex = 12;
            this.pb_jogos_quadra.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::PARKINFO.Properties.Resources.pin_meu;
            this.pictureBox3.Location = new System.Drawing.Point(203, 656);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::PARKINFO.Properties.Resources.pin_meu;
            this.pictureBox2.Location = new System.Drawing.Point(555, 550);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PARKINFO.Properties.Resources.logo_sem_bg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 102);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_mapa
            // 
            this.pb_mapa.BackColor = System.Drawing.Color.Transparent;
            this.pb_mapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_mapa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_mapa.Image = global::PARKINFO.Properties.Resources.map_total;
            this.pb_mapa.Location = new System.Drawing.Point(214, 125);
            this.pb_mapa.Name = "pb_mapa";
            this.pb_mapa.Size = new System.Drawing.Size(573, 509);
            this.pb_mapa.TabIndex = 0;
            this.pb_mapa.TabStop = false;
            this.pb_mapa.WaitOnLoad = true;
            this.pb_mapa.Click += new System.EventHandler(this.pb_mapa_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(228, 605);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Outros PARKINFO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pb_info_evento
            // 
            this.pb_info_evento.BackColor = System.Drawing.Color.Transparent;
            this.pb_info_evento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_info_evento.Image = global::PARKINFO.Properties.Resources.pin_meu_atividades;
            this.pb_info_evento.Location = new System.Drawing.Point(523, 656);
            this.pb_info_evento.Name = "pb_info_evento";
            this.pb_info_evento.Size = new System.Drawing.Size(35, 35);
            this.pb_info_evento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_info_evento.TabIndex = 19;
            this.pb_info_evento.TabStop = false;
            // 
            // lb_info_evento
            // 
            this.lb_info_evento.AutoSize = true;
            this.lb_info_evento.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info_evento.Location = new System.Drawing.Point(564, 660);
            this.lb_info_evento.Name = "lb_info_evento";
            this.lb_info_evento.Size = new System.Drawing.Size(147, 31);
            this.lb_info_evento.TabIndex = 20;
            this.lb_info_evento.Text = "info_evento";
            // 
            // lb_relogio
            // 
            this.lb_relogio.AutoSize = true;
            this.lb_relogio.Font = new System.Drawing.Font("Felix Titling", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_relogio.ForeColor = System.Drawing.Color.Green;
            this.lb_relogio.Location = new System.Drawing.Point(787, 61);
            this.lb_relogio.Name = "lb_relogio";
            this.lb_relogio.Size = new System.Drawing.Size(163, 40);
            this.lb_relogio.TabIndex = 21;
            this.lb_relogio.Text = "00:00 PM";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Felix Titling", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.ForeColor = System.Drawing.Color.Green;
            this.lb_data.Location = new System.Drawing.Point(755, 21);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(195, 40);
            this.lb_data.TabIndex = 22;
            this.lb_data.Text = "30/03/2020";
            this.lb_data.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Bem vindo ao Parque Estadual de Exemplo!";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lb_relogio);
            this.Controls.Add(this.lb_info_evento);
            this.Controls.Add(this.pb_info_evento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pb_corrida);
            this.Controls.Add(this.pb_teatro);
            this.Controls.Add(this.pb_natacao);
            this.Controls.Add(this.pb_alongamento);
            this.Controls.Add(this.pb_jogos_quadra);
            this.Controls.Add(this.lb_vc);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_agenda);
            this.Controls.Add(this.bt_estacionamento);
            this.Controls.Add(this.bt_mapa);
            this.Controls.Add(this.bt_piscinas);
            this.Controls.Add(this.bt_bosques);
            this.Controls.Add(this.bt_quadras);
            this.Controls.Add(this.pb_mapa);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARKINFO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_corrida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_teatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_natacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_alongamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_jogos_quadra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info_evento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_mapa;
        private System.Windows.Forms.Button bt_quadras;
        private System.Windows.Forms.Button bt_bosques;
        private System.Windows.Forms.Button bt_piscinas;
        private System.Windows.Forms.Button bt_agenda;
        private System.Windows.Forms.Button bt_estacionamento;
        private System.Windows.Forms.Button bt_mapa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_vc;
        private System.Windows.Forms.PictureBox pb_jogos_quadra;
        private System.Windows.Forms.PictureBox pb_alongamento;
        private System.Windows.Forms.PictureBox pb_natacao;
        private System.Windows.Forms.PictureBox pb_teatro;
        private System.Windows.Forms.PictureBox pb_corrida;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_info_evento;
        private System.Windows.Forms.Label lb_info_evento;
        private System.Windows.Forms.Label lb_relogio;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label label2;
    }
}

