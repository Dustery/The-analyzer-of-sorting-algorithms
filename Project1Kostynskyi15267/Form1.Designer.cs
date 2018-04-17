namespace SortowanieAlgorytmow
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ok_btnKolorLinii = new System.Windows.Forms.Button();
            this.ok_btnKolorTla = new System.Windows.Forms.Button();
            this.ok_lblKolorTla = new System.Windows.Forms.Label();
            this.ok_lblWzierniktla = new System.Windows.Forms.Label();
            this.ok_lblWziernikLinii = new System.Windows.Forms.Label();
            this.ok_lblStylLinii = new System.Windows.Forms.Label();
            this.ok_cbStylLinii = new System.Windows.Forms.ComboBox();
            this.ok_lblGruboscLinii = new System.Windows.Forms.Label();
            this.ok_tbGruboscLinii = new System.Windows.Forms.TrackBar();
            this.ok_numericGrubosc = new System.Windows.Forms.NumericUpDown();
            this.ok_lblGruboscLiczbowo = new System.Windows.Forms.Label();
            this.ok_lblinfo1 = new System.Windows.Forms.Label();
            this.ok_txtMin = new System.Windows.Forms.TextBox();
            this.ok_lblinfo2 = new System.Windows.Forms.Label();
            this.ok_txtMax = new System.Windows.Forms.TextBox();
            this.ok_lblinfo5 = new System.Windows.Forms.Label();
            this.ok_txtDolnaG = new System.Windows.Forms.TextBox();
            this.ok_txtGornaG = new System.Windows.Forms.TextBox();
            this.ok_lblinfo4 = new System.Windows.Forms.Label();
            this.ok_lblinfo3 = new System.Windows.Forms.Label();
            this.ok_cbAlgorytm = new System.Windows.Forms.ComboBox();
            this.ok_btnWizPrzed = new System.Windows.Forms.Button();
            this.ok_btnWizPo = new System.Windows.Forms.Button();
            this.ok_btnTabela = new System.Windows.Forms.Button();
            this.ok_btnDemo = new System.Windows.Forms.Button();
            this.ok_btnResetuj = new System.Windows.Forms.Button();
            this.ok_btnWykres = new System.Windows.Forms.Button();
            this.ok_lblWzorzec = new System.Windows.Forms.Label();
            this.ok_cdKolorLini = new System.Windows.Forms.ColorDialog();
            this.ok_panel = new System.Windows.Forms.Panel();
            this.ok_naglowek = new System.Windows.Forms.Label();
            this.ok_dGWTabelaprzed = new System.Windows.Forms.DataGridView();
            this.ok_TabBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok_TabAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok_TabKosztA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.ok_lblKolorLini = new System.Windows.Forms.Label();
            this.ok_Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.ok_kolLini2 = new System.Windows.Forms.Label();
            this.ok_infoo = new System.Windows.Forms.Label();
            this.ok_zegar = new System.Windows.Forms.Timer(this.components);
            this.ok_lbl1 = new System.Windows.Forms.Label();
            this.ok_lbl2 = new System.Windows.Forms.Label();
            this.ok_lbl3 = new System.Windows.Forms.Label();
            this.ok_lbl4 = new System.Windows.Forms.Label();
            this.ok_lbl5 = new System.Windows.Forms.Label();
            this.ok_lbl6 = new System.Windows.Forms.Label();
            this.ok_lbl7 = new System.Windows.Forms.Label();
            this.ok_lbl8 = new System.Windows.Forms.Label();
            this.ok_lbl9 = new System.Windows.Forms.Label();
            this.ok_lbl10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ok_tbGruboscLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok_numericGrubosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok_dGWTabelaprzed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok_Wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_btnKolorLinii
            // 
            this.ok_btnKolorLinii.AutoSize = true;
            this.ok_btnKolorLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_btnKolorLinii.Location = new System.Drawing.Point(12, 64);
            this.ok_btnKolorLinii.Name = "ok_btnKolorLinii";
            this.ok_btnKolorLinii.Size = new System.Drawing.Size(108, 44);
            this.ok_btnKolorLinii.TabIndex = 0;
            this.ok_btnKolorLinii.Text = "Wybierz kolor \r\nlinii";
            this.ok_btnKolorLinii.UseVisualStyleBackColor = true;
            this.ok_btnKolorLinii.Click += new System.EventHandler(this.ok_btnKolorLinii_Click);
            // 
            // ok_btnKolorTla
            // 
            this.ok_btnKolorTla.AutoSize = true;
            this.ok_btnKolorTla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_btnKolorTla.Location = new System.Drawing.Point(342, 99);
            this.ok_btnKolorTla.Name = "ok_btnKolorTla";
            this.ok_btnKolorTla.Size = new System.Drawing.Size(166, 60);
            this.ok_btnKolorTla.TabIndex = 3;
            this.ok_btnKolorTla.Text = "Wybierz kolor tła dla \r\nobszaru wykresu";
            this.ok_btnKolorTla.UseVisualStyleBackColor = true;
            this.ok_btnKolorTla.Click += new System.EventHandler(this.ok_btnKolorTla_Click);
            // 
            // ok_lblKolorTla
            // 
            this.ok_lblKolorTla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ok_lblKolorTla.Location = new System.Drawing.Point(530, 131);
            this.ok_lblKolorTla.Name = "ok_lblKolorTla";
            this.ok_lblKolorTla.Size = new System.Drawing.Size(129, 20);
            this.ok_lblKolorTla.TabIndex = 5;
            // 
            // ok_lblWzierniktla
            // 
            this.ok_lblWzierniktla.AutoSize = true;
            this.ok_lblWzierniktla.Location = new System.Drawing.Point(531, 91);
            this.ok_lblWzierniktla.Name = "ok_lblWzierniktla";
            this.ok_lblWzierniktla.Size = new System.Drawing.Size(128, 34);
            this.ok_lblWzierniktla.TabIndex = 4;
            this.ok_lblWzierniktla.Text = "Wziernik koloru tła \r\ndla wykresu";
            this.ok_lblWzierniktla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok_lblWziernikLinii
            // 
            this.ok_lblWziernikLinii.AutoSize = true;
            this.ok_lblWziernikLinii.Location = new System.Drawing.Point(126, 64);
            this.ok_lblWziernikLinii.Name = "ok_lblWziernikLinii";
            this.ok_lblWziernikLinii.Size = new System.Drawing.Size(129, 17);
            this.ok_lblWziernikLinii.TabIndex = 6;
            this.ok_lblWziernikLinii.Text = "Wziernik koloru linii";
            // 
            // ok_lblStylLinii
            // 
            this.ok_lblStylLinii.AutoSize = true;
            this.ok_lblStylLinii.Location = new System.Drawing.Point(828, 108);
            this.ok_lblStylLinii.Name = "ok_lblStylLinii";
            this.ok_lblStylLinii.Size = new System.Drawing.Size(150, 17);
            this.ok_lblStylLinii.TabIndex = 7;
            this.ok_lblStylLinii.Text = "Ustaw styl linii wykresu";
            this.ok_lblStylLinii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok_cbStylLinii
            // 
            this.ok_cbStylLinii.FormattingEnabled = true;
            this.ok_cbStylLinii.Items.AddRange(new object[] {
            "Solid ",
            "Dash",
            "Dot",
            "Dash_Dot",
            "Dash_Dot_Dot"});
            this.ok_cbStylLinii.Location = new System.Drawing.Point(831, 128);
            this.ok_cbStylLinii.Name = "ok_cbStylLinii";
            this.ok_cbStylLinii.Size = new System.Drawing.Size(147, 24);
            this.ok_cbStylLinii.TabIndex = 8;
            this.ok_cbStylLinii.Text = "Ciągła (solid)";
            this.ok_cbStylLinii.SelectedIndexChanged += new System.EventHandler(this.ok_cbStylLinii_SelectedIndexChanged);
            // 
            // ok_lblGruboscLinii
            // 
            this.ok_lblGruboscLinii.AutoSize = true;
            this.ok_lblGruboscLinii.Location = new System.Drawing.Point(1106, 99);
            this.ok_lblGruboscLinii.Name = "ok_lblGruboscLinii";
            this.ok_lblGruboscLinii.Size = new System.Drawing.Size(130, 34);
            this.ok_lblGruboscLinii.TabIndex = 9;
            this.ok_lblGruboscLinii.Text = "Zmień grubość linii \r\nwykresu";
            this.ok_lblGruboscLinii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok_tbGruboscLinii
            // 
            this.ok_tbGruboscLinii.Location = new System.Drawing.Point(1109, 139);
            this.ok_tbGruboscLinii.Minimum = 1;
            this.ok_tbGruboscLinii.Name = "ok_tbGruboscLinii";
            this.ok_tbGruboscLinii.Size = new System.Drawing.Size(127, 45);
            this.ok_tbGruboscLinii.TabIndex = 10;
            this.ok_tbGruboscLinii.Value = 4;
            this.ok_tbGruboscLinii.Scroll += new System.EventHandler(this.ok_tbGruboscLinii_Scroll);
            // 
            // ok_numericGrubosc
            // 
            this.ok_numericGrubosc.Location = new System.Drawing.Point(1116, 258);
            this.ok_numericGrubosc.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ok_numericGrubosc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ok_numericGrubosc.Name = "ok_numericGrubosc";
            this.ok_numericGrubosc.Size = new System.Drawing.Size(120, 23);
            this.ok_numericGrubosc.TabIndex = 11;
            this.ok_numericGrubosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ok_numericGrubosc.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.ok_numericGrubosc.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ok_numericGrubosc.ValueChanged += new System.EventHandler(this.ok_numericGrubosc_ValueChanged);
            // 
            // ok_lblGruboscLiczbowo
            // 
            this.ok_lblGruboscLiczbowo.AutoSize = true;
            this.ok_lblGruboscLiczbowo.Location = new System.Drawing.Point(1106, 221);
            this.ok_lblGruboscLiczbowo.Name = "ok_lblGruboscLiczbowo";
            this.ok_lblGruboscLiczbowo.Size = new System.Drawing.Size(147, 34);
            this.ok_lblGruboscLiczbowo.TabIndex = 12;
            this.ok_lblGruboscLiczbowo.Text = "Ustalona grubość linii \r\n(liczbowo)";
            this.ok_lblGruboscLiczbowo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok_lblinfo1
            // 
            this.ok_lblinfo1.AutoSize = true;
            this.ok_lblinfo1.Location = new System.Drawing.Point(12, 187);
            this.ok_lblinfo1.Name = "ok_lblinfo1";
            this.ok_lblinfo1.Size = new System.Drawing.Size(224, 68);
            this.ok_lblinfo1.TabIndex = 13;
            this.ok_lblinfo1.Text = "Minimalna próba badawcza\r\n(liczba powtórzeń sortowania\r\ntablicy o tych samych roz" +
    "miarach, \r\nale o różnej zawartości)";
            // 
            // ok_txtMin
            // 
            this.ok_txtMin.Location = new System.Drawing.Point(15, 258);
            this.ok_txtMin.Name = "ok_txtMin";
            this.ok_txtMin.Size = new System.Drawing.Size(150, 23);
            this.ok_txtMin.TabIndex = 14;
            this.ok_txtMin.Text = "10";
            // 
            // ok_lblinfo2
            // 
            this.ok_lblinfo2.AutoSize = true;
            this.ok_lblinfo2.Location = new System.Drawing.Point(12, 313);
            this.ok_lblinfo2.Name = "ok_lblinfo2";
            this.ok_lblinfo2.Size = new System.Drawing.Size(136, 34);
            this.ok_lblinfo2.TabIndex = 15;
            this.ok_lblinfo2.Text = "Maksymalny rozmiar\r\n sortowanych tablic";
            // 
            // ok_txtMax
            // 
            this.ok_txtMax.Location = new System.Drawing.Point(15, 350);
            this.ok_txtMax.Name = "ok_txtMax";
            this.ok_txtMax.Size = new System.Drawing.Size(150, 23);
            this.ok_txtMax.TabIndex = 16;
            this.ok_txtMax.Text = "30";
            // 
            // ok_lblinfo5
            // 
            this.ok_lblinfo5.AutoSize = true;
            this.ok_lblinfo5.Location = new System.Drawing.Point(12, 403);
            this.ok_lblinfo5.Name = "ok_lblinfo5";
            this.ok_lblinfo5.Size = new System.Drawing.Size(165, 51);
            this.ok_lblinfo5.TabIndex = 17;
            this.ok_lblinfo5.Text = "Dolna granica przedziału\r\nwartości elementów \r\nsortowanych tablicy";
            this.ok_lblinfo5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok_txtDolnaG
            // 
            this.ok_txtDolnaG.Location = new System.Drawing.Point(15, 457);
            this.ok_txtDolnaG.Name = "ok_txtDolnaG";
            this.ok_txtDolnaG.Size = new System.Drawing.Size(150, 23);
            this.ok_txtDolnaG.TabIndex = 18;
            this.ok_txtDolnaG.Text = "1";
            // 
            // ok_txtGornaG
            // 
            this.ok_txtGornaG.Location = new System.Drawing.Point(15, 562);
            this.ok_txtGornaG.Name = "ok_txtGornaG";
            this.ok_txtGornaG.Size = new System.Drawing.Size(150, 23);
            this.ok_txtGornaG.TabIndex = 20;
            this.ok_txtGornaG.Text = "101";
            // 
            // ok_lblinfo4
            // 
            this.ok_lblinfo4.AutoSize = true;
            this.ok_lblinfo4.Location = new System.Drawing.Point(12, 508);
            this.ok_lblinfo4.Name = "ok_lblinfo4";
            this.ok_lblinfo4.Size = new System.Drawing.Size(172, 51);
            this.ok_lblinfo4.TabIndex = 19;
            this.ok_lblinfo4.Text = "Górna granica przedziału \r\nwartości elementów \r\nsortowanych tablicy";
            this.ok_lblinfo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok_lblinfo3
            // 
            this.ok_lblinfo3.AutoSize = true;
            this.ok_lblinfo3.Location = new System.Drawing.Point(12, 614);
            this.ok_lblinfo3.Name = "ok_lblinfo3";
            this.ok_lblinfo3.Size = new System.Drawing.Size(185, 17);
            this.ok_lblinfo3.TabIndex = 21;
            this.ok_lblinfo3.Text = "Wybierz algorytm do analizy";
            this.ok_lblinfo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok_cbAlgorytm
            // 
            this.ok_cbAlgorytm.FormattingEnabled = true;
            this.ok_cbAlgorytm.Items.AddRange(new object[] {
            "Insertion",
            "Selection",
            "Merge",
            "Heap",
            "Quick",
            "Bubble",
            "Shell",
            "Comb"});
            this.ok_cbAlgorytm.Location = new System.Drawing.Point(15, 645);
            this.ok_cbAlgorytm.Name = "ok_cbAlgorytm";
            this.ok_cbAlgorytm.Size = new System.Drawing.Size(150, 24);
            this.ok_cbAlgorytm.TabIndex = 22;
            this.ok_cbAlgorytm.Text = "Insertion";
            // 
            // ok_btnWizPrzed
            // 
            this.ok_btnWizPrzed.AutoSize = true;
            this.ok_btnWizPrzed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_btnWizPrzed.Location = new System.Drawing.Point(375, 758);
            this.ok_btnWizPrzed.Name = "ok_btnWizPrzed";
            this.ok_btnWizPrzed.Size = new System.Drawing.Size(184, 60);
            this.ok_btnWizPrzed.TabIndex = 23;
            this.ok_btnWizPrzed.Text = "Wizualizacja tablicy przed \r\nsortowaniem";
            this.ok_btnWizPrzed.UseVisualStyleBackColor = true;
            this.ok_btnWizPrzed.Click += new System.EventHandler(this.ok_btnWizPrzed_Click);
            // 
            // ok_btnWizPo
            // 
            this.ok_btnWizPo.AutoSize = true;
            this.ok_btnWizPo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_btnWizPo.Location = new System.Drawing.Point(567, 758);
            this.ok_btnWizPo.Name = "ok_btnWizPo";
            this.ok_btnWizPo.Size = new System.Drawing.Size(193, 60);
            this.ok_btnWizPo.TabIndex = 24;
            this.ok_btnWizPo.Text = "Wizualizacja tablicy po\r\n sortowaniu";
            this.ok_btnWizPo.UseVisualStyleBackColor = true;
            this.ok_btnWizPo.Click += new System.EventHandler(this.ok_btnWizPo_Click);
            // 
            // ok_btnTabela
            // 
            this.ok_btnTabela.AutoSize = true;
            this.ok_btnTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_btnTabela.Location = new System.Drawing.Point(1087, 434);
            this.ok_btnTabela.Name = "ok_btnTabela";
            this.ok_btnTabela.Size = new System.Drawing.Size(166, 60);
            this.ok_btnTabela.TabIndex = 25;
            this.ok_btnTabela.Text = "Wyniki w formie \r\ntabelarycznej";
            this.ok_btnTabela.UseVisualStyleBackColor = true;
            this.ok_btnTabela.Click += new System.EventHandler(this.ok_btnTabela_Click);
            // 
            // ok_btnDemo
            // 
            this.ok_btnDemo.AutoSize = true;
            this.ok_btnDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_btnDemo.Location = new System.Drawing.Point(1091, 645);
            this.ok_btnDemo.Name = "ok_btnDemo";
            this.ok_btnDemo.Size = new System.Drawing.Size(171, 60);
            this.ok_btnDemo.TabIndex = 26;
            this.ok_btnDemo.Text = "Demo\r\n(działanie algorytmu)";
            this.ok_btnDemo.UseVisualStyleBackColor = true;
            this.ok_btnDemo.Click += new System.EventHandler(this.ok_btnDemo_Click);
            // 
            // ok_btnResetuj
            // 
            this.ok_btnResetuj.AutoSize = true;
            this.ok_btnResetuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_btnResetuj.Location = new System.Drawing.Point(1092, 574);
            this.ok_btnResetuj.Name = "ok_btnResetuj";
            this.ok_btnResetuj.Size = new System.Drawing.Size(166, 60);
            this.ok_btnResetuj.TabIndex = 27;
            this.ok_btnResetuj.Text = "Resetuj\r\n(stan początkowy)";
            this.ok_btnResetuj.UseVisualStyleBackColor = true;
            this.ok_btnResetuj.Click += new System.EventHandler(this.ok_btnResetuj_Click);
            // 
            // ok_btnWykres
            // 
            this.ok_btnWykres.AutoSize = true;
            this.ok_btnWykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_btnWykres.Location = new System.Drawing.Point(1092, 508);
            this.ok_btnWykres.Name = "ok_btnWykres";
            this.ok_btnWykres.Size = new System.Drawing.Size(166, 60);
            this.ok_btnWykres.TabIndex = 28;
            this.ok_btnWykres.Text = "Wyniki w formie\r\nwykresu";
            this.ok_btnWykres.UseVisualStyleBackColor = true;
            this.ok_btnWykres.Click += new System.EventHandler(this.ok_btnWykres_Click);
            // 
            // ok_lblWzorzec
            // 
            this.ok_lblWzorzec.AutoSize = true;
            this.ok_lblWzorzec.Location = new System.Drawing.Point(1102, 325);
            this.ok_lblWzorzec.Name = "ok_lblWzorzec";
            this.ok_lblWzorzec.Size = new System.Drawing.Size(134, 17);
            this.ok_lblWzorzec.TabIndex = 29;
            this.ok_lblWzorzec.Text = "Wziernik wzorca linii";
            this.ok_lblWzorzec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok_panel
            // 
            this.ok_panel.Location = new System.Drawing.Point(1087, 345);
            this.ok_panel.Name = "ok_panel";
            this.ok_panel.Size = new System.Drawing.Size(166, 53);
            this.ok_panel.TabIndex = 30;
            this.ok_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.ok_panel_Paint);
            // 
            // ok_naglowek
            // 
            this.ok_naglowek.AutoSize = true;
            this.ok_naglowek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ok_naglowek.Location = new System.Drawing.Point(436, 40);
            this.ok_naglowek.Name = "ok_naglowek";
            this.ok_naglowek.Size = new System.Drawing.Size(456, 31);
            this.ok_naglowek.TabIndex = 31;
            this.ok_naglowek.Text = "Analizator algorytmów Sortowania";
            // 
            // ok_dGWTabelaprzed
            // 
            this.ok_dGWTabelaprzed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ok_dGWTabelaprzed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ok_dGWTabelaprzed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ok_dGWTabelaprzed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ok_TabBefore,
            this.ok_TabAfter,
            this.ok_TabKosztA});
            this.ok_dGWTabelaprzed.Location = new System.Drawing.Point(259, 165);
            this.ok_dGWTabelaprzed.Name = "ok_dGWTabelaprzed";
            this.ok_dGWTabelaprzed.Size = new System.Drawing.Size(822, 774);
            this.ok_dGWTabelaprzed.TabIndex = 32;
            // 
            // ok_TabBefore
            // 
            this.ok_TabBefore.FillWeight = 80F;
            this.ok_TabBefore.HeaderText = "Tabela przed sortowaniem";
            this.ok_TabBefore.Name = "ok_TabBefore";
            // 
            // ok_TabAfter
            // 
            this.ok_TabAfter.HeaderText = "Tablica po sortowaniu";
            this.ok_TabAfter.Name = "ok_TabAfter";
            // 
            // ok_TabKosztA
            // 
            this.ok_TabKosztA.HeaderText = "Analityczny koszt czasowy";
            this.ok_TabKosztA.Name = "ok_TabKosztA";
            // 
            // ok_error
            // 
            this.ok_error.ContainerControl = this;
            // 
            // ok_lblKolorLini
            // 
            this.ok_lblKolorLini.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ok_lblKolorLini.Location = new System.Drawing.Point(149, 86);
            this.ok_lblKolorLini.Name = "ok_lblKolorLini";
            this.ok_lblKolorLini.Size = new System.Drawing.Size(78, 20);
            this.ok_lblKolorLini.TabIndex = 33;
            // 
            // ok_Wykres
            // 
            chartArea1.Name = "ChartArea1";
            this.ok_Wykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ok_Wykres.Legends.Add(legend1);
            this.ok_Wykres.Location = new System.Drawing.Point(259, 187);
            this.ok_Wykres.Name = "ok_Wykres";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ok_Wykres.Series.Add(series1);
            this.ok_Wykres.Size = new System.Drawing.Size(822, 565);
            this.ok_Wykres.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 36;
            this.button1.Text = "Wybierz kolor \r\nlinii drugiej";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ok_kolLini2
            // 
            this.ok_kolLini2.BackColor = System.Drawing.Color.Red;
            this.ok_kolLini2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ok_kolLini2.Location = new System.Drawing.Point(146, 148);
            this.ok_kolLini2.Name = "ok_kolLini2";
            this.ok_kolLini2.Size = new System.Drawing.Size(81, 20);
            this.ok_kolLini2.TabIndex = 38;
            // 
            // ok_infoo
            // 
            this.ok_infoo.AutoSize = true;
            this.ok_infoo.Location = new System.Drawing.Point(126, 131);
            this.ok_infoo.Name = "ok_infoo";
            this.ok_infoo.Size = new System.Drawing.Size(129, 17);
            this.ok_infoo.TabIndex = 37;
            this.ok_infoo.Text = "Wziernik koloru linii";
            // 
            // ok_zegar
            // 
            this.ok_zegar.Interval = 2000;
            this.ok_zegar.Tick += new System.EventHandler(this.ok_zegar_Tick);
            // 
            // ok_lbl1
            // 
            this.ok_lbl1.Location = new System.Drawing.Point(283, 267);
            this.ok_lbl1.Name = "ok_lbl1";
            this.ok_lbl1.Size = new System.Drawing.Size(46, 17);
            this.ok_lbl1.TabIndex = 39;
            // 
            // ok_lbl2
            // 
            this.ok_lbl2.Location = new System.Drawing.Point(350, 267);
            this.ok_lbl2.Name = "ok_lbl2";
            this.ok_lbl2.Size = new System.Drawing.Size(46, 17);
            this.ok_lbl2.TabIndex = 40;
            // 
            // ok_lbl3
            // 
            this.ok_lbl3.Location = new System.Drawing.Point(412, 267);
            this.ok_lbl3.Name = "ok_lbl3";
            this.ok_lbl3.Size = new System.Drawing.Size(46, 17);
            this.ok_lbl3.TabIndex = 41;
            // 
            // ok_lbl4
            // 
            this.ok_lbl4.Location = new System.Drawing.Point(478, 267);
            this.ok_lbl4.Name = "ok_lbl4";
            this.ok_lbl4.Size = new System.Drawing.Size(46, 17);
            this.ok_lbl4.TabIndex = 42;
            // 
            // ok_lbl5
            // 
            this.ok_lbl5.Location = new System.Drawing.Point(540, 267);
            this.ok_lbl5.Name = "ok_lbl5";
            this.ok_lbl5.Size = new System.Drawing.Size(46, 17);
            this.ok_lbl5.TabIndex = 43;
            // 
            // ok_lbl6
            // 
            this.ok_lbl6.Location = new System.Drawing.Point(602, 267);
            this.ok_lbl6.Name = "ok_lbl6";
            this.ok_lbl6.Size = new System.Drawing.Size(46, 17);
            this.ok_lbl6.TabIndex = 44;
            // 
            // ok_lbl7
            // 
            this.ok_lbl7.Location = new System.Drawing.Point(664, 267);
            this.ok_lbl7.Name = "ok_lbl7";
            this.ok_lbl7.Size = new System.Drawing.Size(46, 17);
            this.ok_lbl7.TabIndex = 45;
            // 
            // ok_lbl8
            // 
            this.ok_lbl8.Location = new System.Drawing.Point(727, 267);
            this.ok_lbl8.Name = "ok_lbl8";
            this.ok_lbl8.Size = new System.Drawing.Size(46, 17);
            this.ok_lbl8.TabIndex = 46;
            // 
            // ok_lbl9
            // 
            this.ok_lbl9.AutoSize = true;
            this.ok_lbl9.Location = new System.Drawing.Point(789, 267);
            this.ok_lbl9.Name = "ok_lbl9";
            this.ok_lbl9.Size = new System.Drawing.Size(0, 17);
            this.ok_lbl9.TabIndex = 47;
            // 
            // ok_lbl10
            // 
            this.ok_lbl10.Location = new System.Drawing.Point(851, 267);
            this.ok_lbl10.Name = "ok_lbl10";
            this.ok_lbl10.Size = new System.Drawing.Size(46, 17);
            this.ok_lbl10.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1274, 729);
            this.Controls.Add(this.ok_dGWTabelaprzed);
            this.Controls.Add(this.ok_Wykres);
            this.Controls.Add(this.ok_lbl9);
            this.Controls.Add(this.ok_kolLini2);
            this.Controls.Add(this.ok_infoo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ok_lblKolorLini);
            this.Controls.Add(this.ok_naglowek);
            this.Controls.Add(this.ok_panel);
            this.Controls.Add(this.ok_lblWzorzec);
            this.Controls.Add(this.ok_btnWykres);
            this.Controls.Add(this.ok_btnResetuj);
            this.Controls.Add(this.ok_btnDemo);
            this.Controls.Add(this.ok_btnTabela);
            this.Controls.Add(this.ok_btnWizPo);
            this.Controls.Add(this.ok_btnWizPrzed);
            this.Controls.Add(this.ok_cbAlgorytm);
            this.Controls.Add(this.ok_lblinfo3);
            this.Controls.Add(this.ok_txtGornaG);
            this.Controls.Add(this.ok_lblinfo4);
            this.Controls.Add(this.ok_txtDolnaG);
            this.Controls.Add(this.ok_lblinfo5);
            this.Controls.Add(this.ok_txtMax);
            this.Controls.Add(this.ok_lblinfo2);
            this.Controls.Add(this.ok_txtMin);
            this.Controls.Add(this.ok_lblinfo1);
            this.Controls.Add(this.ok_lblGruboscLiczbowo);
            this.Controls.Add(this.ok_numericGrubosc);
            this.Controls.Add(this.ok_tbGruboscLinii);
            this.Controls.Add(this.ok_lblGruboscLinii);
            this.Controls.Add(this.ok_cbStylLinii);
            this.Controls.Add(this.ok_lblStylLinii);
            this.Controls.Add(this.ok_lblWziernikLinii);
            this.Controls.Add(this.ok_lblKolorTla);
            this.Controls.Add(this.ok_lblWzierniktla);
            this.Controls.Add(this.ok_btnKolorTla);
            this.Controls.Add(this.ok_btnKolorLinii);
            this.Controls.Add(this.ok_lbl1);
            this.Controls.Add(this.ok_lbl2);
            this.Controls.Add(this.ok_lbl3);
            this.Controls.Add(this.ok_lbl4);
            this.Controls.Add(this.ok_lbl5);
            this.Controls.Add(this.ok_lbl6);
            this.Controls.Add(this.ok_lbl7);
            this.Controls.Add(this.ok_lbl8);
            this.Controls.Add(this.ok_lbl10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1290, 863);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analizator algorytmów sortowania";
            ((System.ComponentModel.ISupportInitialize)(this.ok_tbGruboscLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok_numericGrubosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok_dGWTabelaprzed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok_Wykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btnKolorLinii;
        private System.Windows.Forms.Button ok_btnKolorTla;
        private System.Windows.Forms.Label ok_lblKolorTla;
        private System.Windows.Forms.Label ok_lblWzierniktla;
        private System.Windows.Forms.Label ok_lblWziernikLinii;
        private System.Windows.Forms.Label ok_lblStylLinii;
        private System.Windows.Forms.ComboBox ok_cbStylLinii;
        private System.Windows.Forms.Label ok_lblGruboscLinii;
        private System.Windows.Forms.TrackBar ok_tbGruboscLinii;
        private System.Windows.Forms.NumericUpDown ok_numericGrubosc;
        private System.Windows.Forms.Label ok_lblGruboscLiczbowo;
        private System.Windows.Forms.Label ok_lblinfo1;
        private System.Windows.Forms.TextBox ok_txtMin;
        private System.Windows.Forms.Label ok_lblinfo2;
        private System.Windows.Forms.TextBox ok_txtMax;
        private System.Windows.Forms.Label ok_lblinfo5;
        private System.Windows.Forms.TextBox ok_txtDolnaG;
        private System.Windows.Forms.TextBox ok_txtGornaG;
        private System.Windows.Forms.Label ok_lblinfo4;
        private System.Windows.Forms.Label ok_lblinfo3;
        private System.Windows.Forms.ComboBox ok_cbAlgorytm;
        private System.Windows.Forms.Button ok_btnWizPrzed;
        private System.Windows.Forms.Button ok_btnWizPo;
        private System.Windows.Forms.Button ok_btnTabela;
        private System.Windows.Forms.Button ok_btnDemo;
        private System.Windows.Forms.Button ok_btnResetuj;
        private System.Windows.Forms.Button ok_btnWykres;
        private System.Windows.Forms.Label ok_lblWzorzec;
        private System.Windows.Forms.ColorDialog ok_cdKolorLini;
        private System.Windows.Forms.Panel ok_panel;
        private System.Windows.Forms.Label ok_naglowek;
        private System.Windows.Forms.DataGridView ok_dGWTabelaprzed;
        private System.Windows.Forms.ErrorProvider ok_error;
        private System.Windows.Forms.Label ok_lblKolorLinii;
        private System.Windows.Forms.Label ok_lblKolorLini;
        private System.Windows.Forms.DataGridViewTextBoxColumn ok_TabBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ok_TabAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ok_TabKosztA;
        private System.Windows.Forms.DataVisualization.Charting.Chart ok_Wykres;
        private System.Windows.Forms.Label ok_kolLini2;
        private System.Windows.Forms.Label ok_infoo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer ok_zegar;
        private System.Windows.Forms.Label ok_lbl10;
        private System.Windows.Forms.Label ok_lbl9;
        private System.Windows.Forms.Label ok_lbl8;
        private System.Windows.Forms.Label ok_lbl7;
        private System.Windows.Forms.Label ok_lbl6;
        private System.Windows.Forms.Label ok_lbl5;
        private System.Windows.Forms.Label ok_lbl4;
        private System.Windows.Forms.Label ok_lbl3;
        private System.Windows.Forms.Label ok_lbl2;
        private System.Windows.Forms.Label ok_lbl1;
    }
}

