namespace Projekt_3_Linia_produkcyjna
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        class Wieszak
        {
            public bool zajety;
            public bool kolor;
            public bool pomalowany;
            public short ID;
            public Wieszak()
            {
                zajety = false;
                kolor = false;
                pomalowany = false;
            }
        }

        class  Bufor //wszytskie bufory 
        {
            public short max_pojemnosc;
            public short ilosc_wieszakow;
            public LinkedList<Wieszak> wieszaki_w_buforze = new LinkedList<Wieszak>();

            public void dodaj_wieszak_do_bufora(Wieszak wieszak_z_zawieszania)
            {
                if (ilosc_wieszakow < max_pojemnosc)
                {
                    wieszaki_w_buforze.AddFirst(wieszak_z_zawieszania);
                    ilosc_wieszakow++;
                }
            }

            public void oddaj_wieszak_do_malowania(Opoznienie_transportowe malowanie)
            {
                if (ilosc_wieszakow > 0)
                {
                    ilosc_wieszakow--;
                    malowanie.stos.Push(wieszaki_w_buforze.Last());
                    wieszaki_w_buforze.RemoveLast();

                }
            }

            public void oddaj_wieszak_do_zawieszenia(Opoznienie_transportowe zawieszanie)
            {
                if (ilosc_wieszakow > 0)
                {
                    ilosc_wieszakow--;
                    zawieszanie.stos.Push(wieszaki_w_buforze.Last.Value);
                    wieszaki_w_buforze.RemoveLast();
                }
            }
        }

        class Piec_i_chlodnia
        {
            public short temperatura_piec=20;
            public short max_temperatura_piec = 200;
            public bool piec_nagrzany = false;
            LinkedList<Wieszak> wieszaki_w_piecu = new LinkedList<Wieszak>();
            public short max_pojemnosc_pieca = 10;
            public short ilosc_wieszakow_pieca=0;

            public short temperatura_chlodnia = 20;
            LinkedList<Wieszak> wieszaki_w_chlodni = new LinkedList<Wieszak>();
            public short max_pojemnosc_chlodni = 11;
            public short ilosc_wieszakow_chlodni =0;

            public void oddaj_wieszak_do_zdejmowania(Opoznienie_transportowe zdejmowanie)
            {
                if (ilosc_wieszakow_chlodni > 0)
                {
                    ilosc_wieszakow_chlodni--;
                    zdejmowanie.stos.Push(wieszaki_w_chlodni.Last.Value);
                    wieszaki_w_chlodni.RemoveLast();
                }
            }
            
            public void przekaz_wieszak_do_chlodni()
            {
                if (ilosc_wieszakow_pieca > 0)
                {
                    ilosc_wieszakow_pieca--;
                    wieszaki_w_chlodni.AddLast(wieszaki_w_piecu.Last.Value);
                    wieszaki_w_piecu.RemoveLast();
                    ilosc_wieszakow_chlodni++;
                }
            }   
        }


        class  Opoznienie_transportowe
        {
            public Stack<Wieszak> stos = new Stack<Wieszak>();//stosa na jeden wieszak

        }

        short max_ilosc_wieszakow = 20;
        short aktualna_ilosc_wieszakow;
        Bufor bufor_przed_malowaniem = new Bufor();
        Bufor bufor_przed_zawieszaniem = new Bufor();
        Opoznienie_transportowe malowanie = new Opoznienie_transportowe();
        Opoznienie_transportowe zdejmowanie = new Opoznienie_transportowe();
        Opoznienie_transportowe zawieszanie = new Opoznienie_transportowe();
        Piec_i_chlodnia piec_i_chlodnia = new Piec_i_chlodnia();
        short predkosc_symulacji = 1;

        short czas_do_potwierdzenia_obecnosci = 30;
        bool obecnosc = true;

        short tick_zawieszanie = 0;
        short tick_malowanie = 0;

        Stack<Wieszak> stos_wieszakow = new Stack<Wieszak>();






        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bufor_przed_malowaniem_label = new Label();
            piec_label = new Label();
            chlodnia_label = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label4 = new Label();
            label11 = new Label();
            label12 = new Label();
            bufor_przed_zawieszaniem_label = new Label();
            label13 = new Label();
            label15 = new Label();
            piec_temperatura_label = new Label();
            menuStrip1 = new MenuStrip();
            oknoZKomunikatamiToolStripMenuItem = new ToolStripMenuItem();
            startToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            prędkość2xToolStripMenuItem = new ToolStripMenuItem();
            prędkość4xToolStripMenuItem = new ToolStripMenuItem();
            symulacja10xToolStripMenuItem = new ToolStripMenuItem();
            zakończToolStripMenuItem = new ToolStripMenuItem();
            malowanie_bar = new ProgressBar();
            timer_malowanie = new System.Windows.Forms.Timer(components);
            zawieszanie_bar = new ProgressBar();
            timer_zawieszanie = new System.Windows.Forms.Timer(components);
            zdejmowanie_bar = new ProgressBar();
            timer_zdejmowanie = new System.Windows.Forms.Timer(components);
            chlodnia_temeratura_label = new Label();
            label3 = new Label();
            button1 = new Button();
            obecnosc_button = new Button();
            timer_obecność = new System.Windows.Forms.Timer(components);
            czas_obecnosc_label = new Label();
            label17 = new Label();
            bufor_przed_malowaniem_bar = new ProgressBar();
            bufor_przed_zawieszaniem_bar = new ProgressBar();
            piec_bar = new ProgressBar();
            chlodnia_bar = new ProgressBar();
            label_console = new Label();
            timer_piec = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bufor_przed_malowaniem_label
            // 
            bufor_przed_malowaniem_label.AutoSize = true;
            bufor_przed_malowaniem_label.Font = new Font("Segoe UI", 25F);
            bufor_przed_malowaniem_label.Location = new Point(842, 190);
            bufor_przed_malowaniem_label.Name = "bufor_przed_malowaniem_label";
            bufor_przed_malowaniem_label.Size = new Size(109, 46);
            bufor_przed_malowaniem_label.TabIndex = 1;
            bufor_przed_malowaniem_label.Text = "label2";
            // 
            // piec_label
            // 
            piec_label.AutoSize = true;
            piec_label.Font = new Font("Segoe UI", 25F);
            piec_label.Location = new Point(116, 76);
            piec_label.Name = "piec_label";
            piec_label.Size = new Size(109, 46);
            piec_label.TabIndex = 4;
            piec_label.Text = "label5";
            // 
            // chlodnia_label
            // 
            chlodnia_label.AutoSize = true;
            chlodnia_label.Font = new Font("Segoe UI", 25F);
            chlodnia_label.Location = new Point(112, 237);
            chlodnia_label.Name = "chlodnia_label";
            chlodnia_label.Size = new Size(109, 46);
            chlodnia_label.TabIndex = 5;
            chlodnia_label.Text = "label6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(816, 373);
            label8.Name = "label8";
            label8.Size = new Size(160, 37);
            label8.TabIndex = 7;
            label8.Text = "Zawieszanie";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(752, 153);
            label9.Name = "label9";
            label9.Size = new Size(314, 37);
            label9.TabIndex = 8;
            label9.Text = "Bufor przed malowaniem";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F);
            label10.Location = new Point(370, 39);
            label10.Name = "label10";
            label10.Size = new Size(409, 37);
            label10.TabIndex = 9;
            label10.Text = "Pomieszczenie z natryskiem farby";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(122, 39);
            label4.Name = "label4";
            label4.Size = new Size(65, 37);
            label4.TabIndex = 10;
            label4.Text = "Piec";
            label4.Click += label4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F);
            label11.Location = new Point(112, 200);
            label11.Name = "label11";
            label11.Size = new Size(124, 37);
            label11.TabIndex = 11;
            label11.Text = "Chłodnia";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20F);
            label12.Location = new Point(90, 373);
            label12.Name = "label12";
            label12.Size = new Size(178, 37);
            label12.TabIndex = 12;
            label12.Text = "Zdejmowanie";
            // 
            // bufor_przed_zawieszaniem_label
            // 
            bufor_przed_zawieszaniem_label.AutoSize = true;
            bufor_przed_zawieszaniem_label.Font = new Font("Segoe UI", 25F);
            bufor_przed_zawieszaniem_label.Location = new Point(460, 375);
            bufor_przed_zawieszaniem_label.Name = "bufor_przed_zawieszaniem_label";
            bufor_przed_zawieszaniem_label.Size = new Size(127, 46);
            bufor_przed_zawieszaniem_label.TabIndex = 13;
            bufor_przed_zawieszaniem_label.Text = "label13";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20F);
            label13.Location = new Point(377, 338);
            label13.Name = "label13";
            label13.Size = new Size(324, 37);
            label13.TabIndex = 14;
            label13.Text = "Bufor przed zawieszaniem";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15F);
            label15.Location = new Point(112, 122);
            label15.Name = "label15";
            label15.Size = new Size(63, 28);
            label15.TabIndex = 15;
            label15.Text = "Temp:";
            label15.Click += label15_Click;
            // 
            // piec_temperatura_label
            // 
            piec_temperatura_label.AutoSize = true;
            piec_temperatura_label.Font = new Font("Segoe UI", 15F);
            piec_temperatura_label.Location = new Point(179, 122);
            piec_temperatura_label.Name = "piec_temperatura_label";
            piec_temperatura_label.Size = new Size(70, 28);
            piec_temperatura_label.TabIndex = 16;
            piec_temperatura_label.Text = "{temp}";
            piec_temperatura_label.Click += label16_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { oknoZKomunikatamiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1107, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // oknoZKomunikatamiToolStripMenuItem
            // 
            oknoZKomunikatamiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem, pauseToolStripMenuItem, prędkość2xToolStripMenuItem, prędkość4xToolStripMenuItem, symulacja10xToolStripMenuItem, zakończToolStripMenuItem });
            oknoZKomunikatamiToolStripMenuItem.Name = "oknoZKomunikatamiToolStripMenuItem";
            oknoZKomunikatamiToolStripMenuItem.Size = new Size(73, 20);
            oknoZKomunikatamiToolStripMenuItem.Text = "Symulacja";
            oknoZKomunikatamiToolStripMenuItem.Click += oknoZKomunikatamiToolStripMenuItem_Click;
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(149, 22);
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.Size = new Size(149, 22);
            pauseToolStripMenuItem.Text = "Pause";
            // 
            // prędkość2xToolStripMenuItem
            // 
            prędkość2xToolStripMenuItem.Name = "prędkość2xToolStripMenuItem";
            prędkość2xToolStripMenuItem.Size = new Size(149, 22);
            prędkość2xToolStripMenuItem.Text = "Prędkość 2x";
            prędkość2xToolStripMenuItem.Click += prędkość2xToolStripMenuItem_Click;
            // 
            // prędkość4xToolStripMenuItem
            // 
            prędkość4xToolStripMenuItem.Name = "prędkość4xToolStripMenuItem";
            prędkość4xToolStripMenuItem.Size = new Size(149, 22);
            prędkość4xToolStripMenuItem.Text = "Prędkość 4x";
            prędkość4xToolStripMenuItem.Click += prędkość4xToolStripMenuItem_Click;
            // 
            // symulacja10xToolStripMenuItem
            // 
            symulacja10xToolStripMenuItem.Name = "symulacja10xToolStripMenuItem";
            symulacja10xToolStripMenuItem.Size = new Size(149, 22);
            symulacja10xToolStripMenuItem.Text = "Symulacja 10x";
            symulacja10xToolStripMenuItem.Click += symulacja10xToolStripMenuItem_Click;
            // 
            // zakończToolStripMenuItem
            // 
            zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            zakończToolStripMenuItem.Size = new Size(149, 22);
            zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // malowanie_bar
            // 
            malowanie_bar.Location = new Point(448, 79);
            malowanie_bar.Name = "malowanie_bar";
            malowanie_bar.Size = new Size(238, 23);
            malowanie_bar.TabIndex = 18;
            // 
            // timer_malowanie
            // 
            timer_malowanie.Interval = 1000;
            timer_malowanie.Tick += timer_malowanie_Tick;
            // 
            // zawieszanie_bar
            // 
            zawieszanie_bar.Location = new Point(778, 424);
            zawieszanie_bar.Maximum = 7;
            zawieszanie_bar.Name = "zawieszanie_bar";
            zawieszanie_bar.Size = new Size(238, 23);
            zawieszanie_bar.Step = 1;
            zawieszanie_bar.TabIndex = 19;
            // 
            // timer_zawieszanie
            // 
            timer_zawieszanie.Interval = 1000;
            timer_zawieszanie.Tick += timer_zawieszanie_Tick;
            // 
            // zdejmowanie_bar
            // 
            zdejmowanie_bar.Location = new Point(58, 424);
            zdejmowanie_bar.Name = "zdejmowanie_bar";
            zdejmowanie_bar.Size = new Size(238, 23);
            zdejmowanie_bar.TabIndex = 20;
            // 
            // chlodnia_temeratura_label
            // 
            chlodnia_temeratura_label.AutoSize = true;
            chlodnia_temeratura_label.Font = new Font("Segoe UI", 15F);
            chlodnia_temeratura_label.Location = new Point(179, 286);
            chlodnia_temeratura_label.Name = "chlodnia_temeratura_label";
            chlodnia_temeratura_label.Size = new Size(70, 28);
            chlodnia_temeratura_label.TabIndex = 22;
            chlodnia_temeratura_label.Text = "{temp}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(112, 286);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 21;
            label3.Text = "Temp:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 509);
            button1.Name = "button1";
            button1.Size = new Size(206, 49);
            button1.TabIndex = 23;
            button1.Text = "Panel awarii";
            button1.UseVisualStyleBackColor = true;
            // 
            // obecnosc_button
            // 
            obecnosc_button.BackColor = Color.Green;
            obecnosc_button.Location = new Point(889, 509);
            obecnosc_button.Name = "obecnosc_button";
            obecnosc_button.Size = new Size(206, 49);
            obecnosc_button.TabIndex = 24;
            obecnosc_button.Text = "Potwierdź obecność";
            obecnosc_button.UseVisualStyleBackColor = false;
            obecnosc_button.Click += button2_Click;
            // 
            // timer_obecność
            // 
            timer_obecność.Interval = 1000;
            timer_obecność.Tick += timer_obecność_Tick;
            // 
            // czas_obecnosc_label
            // 
            czas_obecnosc_label.AutoSize = true;
            czas_obecnosc_label.Font = new Font("Segoe UI", 20F);
            czas_obecnosc_label.Location = new Point(793, 514);
            czas_obecnosc_label.Name = "czas_obecnosc_label";
            czas_obecnosc_label.Size = new Size(90, 37);
            czas_obecnosc_label.TabIndex = 25;
            czas_obecnosc_label.Text = "label7";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F);
            label17.Location = new Point(793, 478);
            label17.Name = "label17";
            label17.Size = new Size(302, 28);
            label17.TabIndex = 26;
            label17.Text = "Czas do potwierdzenia obecności";
            label17.Click += label17_Click;
            // 
            // bufor_przed_malowaniem_bar
            // 
            bufor_przed_malowaniem_bar.Location = new Point(774, 239);
            bufor_przed_malowaniem_bar.Maximum = 15;
            bufor_przed_malowaniem_bar.Name = "bufor_przed_malowaniem_bar";
            bufor_przed_malowaniem_bar.Size = new Size(238, 23);
            bufor_przed_malowaniem_bar.Step = 1;
            bufor_przed_malowaniem_bar.TabIndex = 27;
            // 
            // bufor_przed_zawieszaniem_bar
            // 
            bufor_przed_zawieszaniem_bar.Location = new Point(412, 424);
            bufor_przed_zawieszaniem_bar.Name = "bufor_przed_zawieszaniem_bar";
            bufor_przed_zawieszaniem_bar.Size = new Size(238, 23);
            bufor_przed_zawieszaniem_bar.TabIndex = 28;
            // 
            // piec_bar
            // 
            piec_bar.Location = new Point(58, 153);
            piec_bar.Name = "piec_bar";
            piec_bar.Size = new Size(238, 25);
            piec_bar.TabIndex = 29;
            // 
            // chlodnia_bar
            // 
            chlodnia_bar.Location = new Point(58, 317);
            chlodnia_bar.Name = "chlodnia_bar";
            chlodnia_bar.Size = new Size(238, 25);
            chlodnia_bar.TabIndex = 30;
            // 
            // label_console
            // 
            label_console.AutoSize = true;
            label_console.Font = new Font("Segoe UI", 25F);
            label_console.Location = new Point(370, 493);
            label_console.Name = "label_console";
            label_console.Size = new Size(220, 46);
            label_console.TabIndex = 31;
            label_console.Text = "label_console";
            // 
            // timer_piec
            // 
            timer_piec.Interval = 1000;
            timer_piec.Tick += timer_piec_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 570);
            Controls.Add(label_console);
            Controls.Add(chlodnia_bar);
            Controls.Add(piec_bar);
            Controls.Add(bufor_przed_zawieszaniem_bar);
            Controls.Add(bufor_przed_malowaniem_bar);
            Controls.Add(label17);
            Controls.Add(czas_obecnosc_label);
            Controls.Add(obecnosc_button);
            Controls.Add(button1);
            Controls.Add(chlodnia_temeratura_label);
            Controls.Add(label3);
            Controls.Add(zdejmowanie_bar);
            Controls.Add(zawieszanie_bar);
            Controls.Add(malowanie_bar);
            Controls.Add(piec_temperatura_label);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(bufor_przed_zawieszaniem_label);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(chlodnia_label);
            Controls.Add(piec_label);
            Controls.Add(bufor_przed_malowaniem_label);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label bufor_przed_malowaniem_label;
        private Label piec_label;
        private Label chlodnia_label;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label4;
        private Label label11;
        private Label label12;
        private Label bufor_przed_zawieszaniem_label;
        private Label label13;
        private Label label15;
        private Label piec_temperatura_label;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oknoZKomunikatamiToolStripMenuItem;
        private ProgressBar malowanie_bar;
        private System.Windows.Forms.Timer timer_malowanie;
        private ProgressBar zawieszanie_bar;
        private System.Windows.Forms.Timer timer_zawieszanie;
        private ProgressBar zdejmowanie_bar;
        private System.Windows.Forms.Timer timer_zdejmowanie;
        private Label chlodnia_temeratura_label;
        private Label label3;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem prędkość2xToolStripMenuItem;
        private ToolStripMenuItem prędkość4xToolStripMenuItem;
        private ToolStripMenuItem zakończToolStripMenuItem;
        private Button button1;
        private Button obecnosc_button;
        private System.Windows.Forms.Timer timer_obecność;
        private Label czas_obecnosc_label;
        private Label label17;
        private ProgressBar bufor_przed_malowaniem_bar;
        private ProgressBar bufor_przed_zawieszaniem_bar;
        private ProgressBar piec_bar;
        private ProgressBar chlodnia_bar;
        private ToolStripMenuItem symulacja10xToolStripMenuItem;
        private Label label_console;
        private System.Windows.Forms.Timer timer_piec;
    }
}
