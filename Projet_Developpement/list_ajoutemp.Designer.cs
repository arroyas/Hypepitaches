namespace Projet_Developpement
{
    partial class list_ajoutemp
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
            System.Windows.Forms.Label eMP_ADRESSELabel;
            System.Windows.Forms.Label eMP_CPLabel;
            System.Windows.Forms.Label eMP_IDLabel;
            System.Windows.Forms.Label eMP_MAILLabel;
            System.Windows.Forms.Label eMP_NOMLabel;
            System.Windows.Forms.Label eMP_PRENOMLabel;
            System.Windows.Forms.Label eMP_SEXELabel;
            System.Windows.Forms.Label eMP_TELLabel;
            System.Windows.Forms.Label eMP_VILLELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_ajoutemp));
            this.bs_emp = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eMPLOYEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_sexe = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.bs_serv = new System.Windows.Forms.BindingSource(this.components);
            this.cb_service = new System.Windows.Forms.ComboBox();
            this.tRAVAILLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bs_metier = new System.Windows.Forms.BindingSource(this.components);
            this.mETIERComboBox = new System.Windows.Forms.ComboBox();
            this.sIGNEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.PictureBox();
            this.bs_dip = new System.Windows.Forms.BindingSource(this.components);
            this.cb_dip1 = new System.Windows.Forms.ComboBox();
            this.bt_ajouterDiplome = new System.Windows.Forms.Button();
            this.cb_dip2 = new System.Windows.Forms.ComboBox();
            this.cb_dip3 = new System.Windows.Forms.ComboBox();
            this.tb_compter1 = new System.Windows.Forms.TextBox();
            this.bs_comp = new System.Windows.Forms.BindingSource(this.components);
            this.tb_compter2 = new System.Windows.Forms.TextBox();
            this.cb_comp3 = new System.Windows.Forms.ComboBox();
            this.cb_comp2 = new System.Windows.Forms.ComboBox();
            this.bt_ajouterComp = new System.Windows.Forms.Button();
            this.cb_comp1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_reset1 = new System.Windows.Forms.Button();
            this.bt_reset2 = new System.Windows.Forms.Button();
            eMP_ADRESSELabel = new System.Windows.Forms.Label();
            eMP_CPLabel = new System.Windows.Forms.Label();
            eMP_IDLabel = new System.Windows.Forms.Label();
            eMP_MAILLabel = new System.Windows.Forms.Label();
            eMP_NOMLabel = new System.Windows.Forms.Label();
            eMP_PRENOMLabel = new System.Windows.Forms.Label();
            eMP_SEXELabel = new System.Windows.Forms.Label();
            eMP_TELLabel = new System.Windows.Forms.Label();
            eMP_VILLELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs_emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEBindingNavigator)).BeginInit();
            this.eMPLOYEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_serv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAVAILLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_metier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGNEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_dip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_comp)).BeginInit();
            this.SuspendLayout();
            // 
            // eMP_ADRESSELabel
            // 
            eMP_ADRESSELabel.AutoSize = true;
            eMP_ADRESSELabel.Location = new System.Drawing.Point(29, 47);
            eMP_ADRESSELabel.Name = "eMP_ADRESSELabel";
            eMP_ADRESSELabel.Size = new System.Drawing.Size(87, 13);
            eMP_ADRESSELabel.TabIndex = 1;
            eMP_ADRESSELabel.Text = "EMP ADRESSE:";
            // 
            // eMP_CPLabel
            // 
            eMP_CPLabel.AutoSize = true;
            eMP_CPLabel.Location = new System.Drawing.Point(29, 73);
            eMP_CPLabel.Name = "eMP_CPLabel";
            eMP_CPLabel.Size = new System.Drawing.Size(50, 13);
            eMP_CPLabel.TabIndex = 3;
            eMP_CPLabel.Text = "EMP CP:";
            // 
            // eMP_IDLabel
            // 
            eMP_IDLabel.AutoSize = true;
            eMP_IDLabel.Location = new System.Drawing.Point(29, 99);
            eMP_IDLabel.Name = "eMP_IDLabel";
            eMP_IDLabel.Size = new System.Drawing.Size(47, 13);
            eMP_IDLabel.TabIndex = 5;
            eMP_IDLabel.Text = "EMP ID:";
            // 
            // eMP_MAILLabel
            // 
            eMP_MAILLabel.AutoSize = true;
            eMP_MAILLabel.Location = new System.Drawing.Point(29, 125);
            eMP_MAILLabel.Name = "eMP_MAILLabel";
            eMP_MAILLabel.Size = new System.Drawing.Size(61, 13);
            eMP_MAILLabel.TabIndex = 7;
            eMP_MAILLabel.Text = "EMP MAIL:";
            // 
            // eMP_NOMLabel
            // 
            eMP_NOMLabel.AutoSize = true;
            eMP_NOMLabel.Location = new System.Drawing.Point(29, 151);
            eMP_NOMLabel.Name = "eMP_NOMLabel";
            eMP_NOMLabel.Size = new System.Drawing.Size(61, 13);
            eMP_NOMLabel.TabIndex = 9;
            eMP_NOMLabel.Text = "EMP NOM:";
            // 
            // eMP_PRENOMLabel
            // 
            eMP_PRENOMLabel.AutoSize = true;
            eMP_PRENOMLabel.Location = new System.Drawing.Point(29, 177);
            eMP_PRENOMLabel.Name = "eMP_PRENOMLabel";
            eMP_PRENOMLabel.Size = new System.Drawing.Size(83, 13);
            eMP_PRENOMLabel.TabIndex = 11;
            eMP_PRENOMLabel.Text = "EMP PRENOM:";
            // 
            // eMP_SEXELabel
            // 
            eMP_SEXELabel.AutoSize = true;
            eMP_SEXELabel.Location = new System.Drawing.Point(29, 203);
            eMP_SEXELabel.Name = "eMP_SEXELabel";
            eMP_SEXELabel.Size = new System.Drawing.Size(64, 13);
            eMP_SEXELabel.TabIndex = 13;
            eMP_SEXELabel.Text = "EMP SEXE:";
            // 
            // eMP_TELLabel
            // 
            eMP_TELLabel.AutoSize = true;
            eMP_TELLabel.Location = new System.Drawing.Point(29, 229);
            eMP_TELLabel.Name = "eMP_TELLabel";
            eMP_TELLabel.Size = new System.Drawing.Size(56, 13);
            eMP_TELLabel.TabIndex = 15;
            eMP_TELLabel.Text = "EMP TEL:";
            // 
            // eMP_VILLELabel
            // 
            eMP_VILLELabel.AutoSize = true;
            eMP_VILLELabel.Location = new System.Drawing.Point(29, 255);
            eMP_VILLELabel.Name = "eMP_VILLELabel";
            eMP_VILLELabel.Size = new System.Drawing.Size(65, 13);
            eMP_VILLELabel.TabIndex = 17;
            eMP_VILLELabel.Text = "EMP VILLE:";
            // 
            // bs_emp
            // 
            this.bs_emp.DataSource = typeof(Projet_Developpement.EMPLOYE);
            // 
            // eMPLOYEBindingNavigator
            // 
            this.eMPLOYEBindingNavigator.AddNewItem = null;
            this.eMPLOYEBindingNavigator.BindingSource = this.bs_emp;
            this.eMPLOYEBindingNavigator.CountItem = null;
            this.eMPLOYEBindingNavigator.DeleteItem = null;
            this.eMPLOYEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.eMPLOYEBindingNavigatorSaveItem});
            this.eMPLOYEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eMPLOYEBindingNavigator.MoveFirstItem = null;
            this.eMPLOYEBindingNavigator.MoveLastItem = null;
            this.eMPLOYEBindingNavigator.MoveNextItem = null;
            this.eMPLOYEBindingNavigator.MovePreviousItem = null;
            this.eMPLOYEBindingNavigator.Name = "eMPLOYEBindingNavigator";
            this.eMPLOYEBindingNavigator.PositionItem = null;
            this.eMPLOYEBindingNavigator.Size = new System.Drawing.Size(749, 25);
            this.eMPLOYEBindingNavigator.TabIndex = 0;
            this.eMPLOYEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // eMPLOYEBindingNavigatorSaveItem
            // 
            this.eMPLOYEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eMPLOYEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPLOYEBindingNavigatorSaveItem.Image")));
            this.eMPLOYEBindingNavigatorSaveItem.Name = "eMPLOYEBindingNavigatorSaveItem";
            this.eMPLOYEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eMPLOYEBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // tb_adresse
            // 
            this.tb_adresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_emp, "EMP_ADRESSE", true));
            this.tb_adresse.Location = new System.Drawing.Point(122, 44);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(100, 20);
            this.tb_adresse.TabIndex = 2;
            // 
            // tb_cp
            // 
            this.tb_cp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_emp, "EMP_CP", true));
            this.tb_cp.Location = new System.Drawing.Point(122, 70);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(100, 20);
            this.tb_cp.TabIndex = 4;
            // 
            // tb_id
            // 
            this.tb_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_emp, "EMP_ID", true));
            this.tb_id.Location = new System.Drawing.Point(122, 96);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 6;
            // 
            // tb_mail
            // 
            this.tb_mail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_emp, "EMP_MAIL", true));
            this.tb_mail.Location = new System.Drawing.Point(122, 122);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(100, 20);
            this.tb_mail.TabIndex = 8;
            // 
            // tb_nom
            // 
            this.tb_nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_emp, "EMP_NOM", true));
            this.tb_nom.Location = new System.Drawing.Point(122, 148);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 20);
            this.tb_nom.TabIndex = 10;
            // 
            // tb_prenom
            // 
            this.tb_prenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_emp, "EMP_PRENOM", true));
            this.tb_prenom.Location = new System.Drawing.Point(122, 174);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(100, 20);
            this.tb_prenom.TabIndex = 12;
            // 
            // tb_sexe
            // 
            this.tb_sexe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_emp, "EMP_SEXE", true));
            this.tb_sexe.Location = new System.Drawing.Point(122, 200);
            this.tb_sexe.Name = "tb_sexe";
            this.tb_sexe.Size = new System.Drawing.Size(100, 20);
            this.tb_sexe.TabIndex = 14;
            // 
            // tb_tel
            // 
            this.tb_tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_emp, "EMP_TEL", true));
            this.tb_tel.Location = new System.Drawing.Point(122, 226);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(100, 20);
            this.tb_tel.TabIndex = 16;
            // 
            // tb_ville
            // 
            this.tb_ville.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_emp, "EMP_VILLE", true));
            this.tb_ville.Location = new System.Drawing.Point(122, 252);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(100, 20);
            this.tb_ville.TabIndex = 18;
            // 
            // bs_serv
            // 
            this.bs_serv.DataSource = typeof(Projet_Developpement.SERVICE);
            // 
            // cb_service
            // 
            this.cb_service.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tRAVAILLEBindingSource, "LeService", true));
            this.cb_service.DataSource = this.bs_serv;
            this.cb_service.DisplayMember = "SERVICE_DESIGNATION";
            this.cb_service.FormattingEnabled = true;
            this.cb_service.Location = new System.Drawing.Point(344, 251);
            this.cb_service.Name = "cb_service";
            this.cb_service.Size = new System.Drawing.Size(167, 21);
            this.cb_service.TabIndex = 20;
            this.cb_service.ValueMember = "EST_GERE_PAR";
            // 
            // tRAVAILLEBindingSource
            // 
            this.tRAVAILLEBindingSource.DataSource = typeof(Projet_Developpement.TRAVAILLE);
            // 
            // bs_metier
            // 
            this.bs_metier.DataSource = typeof(Projet_Developpement.METIER);
            // 
            // mETIERComboBox
            // 
            this.mETIERComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.sIGNEBindingSource, "LesMetiers", true));
            this.mETIERComboBox.DataSource = this.bs_metier;
            this.mETIERComboBox.DisplayMember = "METIER_NOM";
            this.mETIERComboBox.FormattingEnabled = true;
            this.mETIERComboBox.Location = new System.Drawing.Point(344, 307);
            this.mETIERComboBox.Name = "mETIERComboBox";
            this.mETIERComboBox.Size = new System.Drawing.Size(167, 21);
            this.mETIERComboBox.TabIndex = 21;
            this.mETIERComboBox.ValueMember = "METIER_DETAILS";
            // 
            // sIGNEBindingSource
            // 
            this.sIGNEBindingSource.DataSource = typeof(Projet_Developpement.SIGNE);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Diplômes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Métier";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(607, 345);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(34, 34);
            this.btn_save.TabIndex = 25;
            this.btn_save.TabStop = false;
            // 
            // bs_dip
            // 
            this.bs_dip.DataSource = typeof(Projet_Developpement.DIPLOME);
            // 
            // cb_dip1
            // 
            this.cb_dip1.DisplayMember = "DIPLOME_ID";
            this.cb_dip1.FormattingEnabled = true;
            this.cb_dip1.Items.AddRange(new object[] {
            ""});
            this.cb_dip1.Location = new System.Drawing.Point(344, 46);
            this.cb_dip1.Name = "cb_dip1";
            this.cb_dip1.Size = new System.Drawing.Size(182, 21);
            this.cb_dip1.TabIndex = 26;
            this.cb_dip1.ValueMember = "DIPLOME_ID";
            this.cb_dip1.SelectedIndexChanged += new System.EventHandler(this.cb_dip1_SelectedIndexChanged);
            // 
            // bt_ajouterDiplome
            // 
            this.bt_ajouterDiplome.Location = new System.Drawing.Point(289, 65);
            this.bt_ajouterDiplome.Name = "bt_ajouterDiplome";
            this.bt_ajouterDiplome.Size = new System.Drawing.Size(33, 29);
            this.bt_ajouterDiplome.TabIndex = 27;
            this.bt_ajouterDiplome.Text = "+";
            this.bt_ajouterDiplome.UseVisualStyleBackColor = true;
            this.bt_ajouterDiplome.Click += new System.EventHandler(this.bt_ajouterDiplome_Click);
            // 
            // cb_dip2
            // 
            this.cb_dip2.DisplayMember = "DIPLOME_ID";
            this.cb_dip2.FormattingEnabled = true;
            this.cb_dip2.Items.AddRange(new object[] {
            ""});
            this.cb_dip2.Location = new System.Drawing.Point(344, 73);
            this.cb_dip2.Name = "cb_dip2";
            this.cb_dip2.Size = new System.Drawing.Size(182, 21);
            this.cb_dip2.TabIndex = 28;
            this.cb_dip2.ValueMember = "DIPLOME_ID";
            this.cb_dip2.Visible = false;
            this.cb_dip2.SelectedIndexChanged += new System.EventHandler(this.cb_dip2_SelectedIndexChanged);
            // 
            // cb_dip3
            // 
            this.cb_dip3.DisplayMember = "DIPLOME_ID";
            this.cb_dip3.FormattingEnabled = true;
            this.cb_dip3.Items.AddRange(new object[] {
            ""});
            this.cb_dip3.Location = new System.Drawing.Point(344, 100);
            this.cb_dip3.Name = "cb_dip3";
            this.cb_dip3.Size = new System.Drawing.Size(182, 21);
            this.cb_dip3.TabIndex = 29;
            this.cb_dip3.ValueMember = "DIPLOME_ID";
            this.cb_dip3.Visible = false;
            this.cb_dip3.SelectedIndexChanged += new System.EventHandler(this.cb_dip3_SelectedIndexChanged);
            // 
            // tb_compter1
            // 
            this.tb_compter1.Location = new System.Drawing.Point(532, 49);
            this.tb_compter1.Name = "tb_compter1";
            this.tb_compter1.Size = new System.Drawing.Size(25, 20);
            this.tb_compter1.TabIndex = 30;
            this.tb_compter1.Visible = false;
            // 
            // bs_comp
            // 
            this.bs_comp.DataSource = typeof(Projet_Developpement.COMPETENCE);
            // 
            // tb_compter2
            // 
            this.tb_compter2.Location = new System.Drawing.Point(532, 145);
            this.tb_compter2.Name = "tb_compter2";
            this.tb_compter2.Size = new System.Drawing.Size(25, 20);
            this.tb_compter2.TabIndex = 44;
            this.tb_compter2.Visible = false;
            // 
            // cb_comp3
            // 
            this.cb_comp3.DisplayMember = "DIPLOME_ID";
            this.cb_comp3.FormattingEnabled = true;
            this.cb_comp3.Items.AddRange(new object[] {
            ""});
            this.cb_comp3.Location = new System.Drawing.Point(344, 196);
            this.cb_comp3.Name = "cb_comp3";
            this.cb_comp3.Size = new System.Drawing.Size(182, 21);
            this.cb_comp3.TabIndex = 43;
            this.cb_comp3.ValueMember = "DIPLOME_ID";
            this.cb_comp3.Visible = false;
            this.cb_comp3.SelectedIndexChanged += new System.EventHandler(this.cb_comp3_SelectedIndexChanged);
            // 
            // cb_comp2
            // 
            this.cb_comp2.DisplayMember = "DIPLOME_ID";
            this.cb_comp2.FormattingEnabled = true;
            this.cb_comp2.Items.AddRange(new object[] {
            ""});
            this.cb_comp2.Location = new System.Drawing.Point(344, 169);
            this.cb_comp2.Name = "cb_comp2";
            this.cb_comp2.Size = new System.Drawing.Size(182, 21);
            this.cb_comp2.TabIndex = 42;
            this.cb_comp2.ValueMember = "DIPLOME_ID";
            this.cb_comp2.Visible = false;
            this.cb_comp2.SelectedIndexChanged += new System.EventHandler(this.cb_comp2_SelectedIndexChanged);
            // 
            // bt_ajouterComp
            // 
            this.bt_ajouterComp.Location = new System.Drawing.Point(289, 161);
            this.bt_ajouterComp.Name = "bt_ajouterComp";
            this.bt_ajouterComp.Size = new System.Drawing.Size(33, 29);
            this.bt_ajouterComp.TabIndex = 41;
            this.bt_ajouterComp.Text = "+";
            this.bt_ajouterComp.UseVisualStyleBackColor = true;
            this.bt_ajouterComp.Click += new System.EventHandler(this.bt_ajouterComp_Click_1);
            // 
            // cb_comp1
            // 
            this.cb_comp1.DisplayMember = "DIPLOME_ID";
            this.cb_comp1.FormattingEnabled = true;
            this.cb_comp1.Items.AddRange(new object[] {
            ""});
            this.cb_comp1.Location = new System.Drawing.Point(344, 142);
            this.cb_comp1.Name = "cb_comp1";
            this.cb_comp1.Size = new System.Drawing.Size(182, 21);
            this.cb_comp1.TabIndex = 40;
            this.cb_comp1.ValueMember = "DIPLOME_ID";
            this.cb_comp1.SelectedIndexChanged += new System.EventHandler(this.cb_comp1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Compétences";
            // 
            // bt_reset1
            // 
            this.bt_reset1.Location = new System.Drawing.Point(302, 98);
            this.bt_reset1.Name = "bt_reset1";
            this.bt_reset1.Size = new System.Drawing.Size(20, 23);
            this.bt_reset1.TabIndex = 45;
            this.bt_reset1.Text = "button1";
            this.bt_reset1.UseVisualStyleBackColor = true;
            this.bt_reset1.Click += new System.EventHandler(this.bt_reset1_Click);
            // 
            // bt_reset2
            // 
            this.bt_reset2.Location = new System.Drawing.Point(302, 193);
            this.bt_reset2.Name = "bt_reset2";
            this.bt_reset2.Size = new System.Drawing.Size(20, 23);
            this.bt_reset2.TabIndex = 46;
            this.bt_reset2.Text = "button2";
            this.bt_reset2.UseVisualStyleBackColor = true;
            this.bt_reset2.Click += new System.EventHandler(this.bt_reset2_Click);
            // 
            // list_ajoutemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 574);
            this.Controls.Add(this.bt_reset2);
            this.Controls.Add(this.bt_reset1);
            this.Controls.Add(this.tb_compter2);
            this.Controls.Add(this.cb_comp3);
            this.Controls.Add(this.cb_comp2);
            this.Controls.Add(this.bt_ajouterComp);
            this.Controls.Add(this.cb_comp1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_compter1);
            this.Controls.Add(this.cb_dip3);
            this.Controls.Add(this.cb_dip2);
            this.Controls.Add(this.bt_ajouterDiplome);
            this.Controls.Add(this.cb_dip1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mETIERComboBox);
            this.Controls.Add(this.cb_service);
            this.Controls.Add(eMP_ADRESSELabel);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(eMP_CPLabel);
            this.Controls.Add(this.tb_cp);
            this.Controls.Add(eMP_IDLabel);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(eMP_MAILLabel);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(eMP_NOMLabel);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(eMP_PRENOMLabel);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(eMP_SEXELabel);
            this.Controls.Add(this.tb_sexe);
            this.Controls.Add(eMP_TELLabel);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(eMP_VILLELabel);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.eMPLOYEBindingNavigator);
            this.Name = "list_ajoutemp";
            this.Text = "list_ajoutemp";
            ((System.ComponentModel.ISupportInitialize)(this.bs_emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEBindingNavigator)).EndInit();
            this.eMPLOYEBindingNavigator.ResumeLayout(false);
            this.eMPLOYEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_serv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAVAILLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_metier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGNEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_dip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_comp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_emp;
        private System.Windows.Forms.BindingNavigator eMPLOYEBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eMPLOYEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_sexe;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.BindingSource bs_serv;
        private System.Windows.Forms.ComboBox cb_service;
        private System.Windows.Forms.BindingSource tRAVAILLEBindingSource;
        private System.Windows.Forms.BindingSource bs_metier;
        private System.Windows.Forms.ComboBox mETIERComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource sIGNEBindingSource;
        private System.Windows.Forms.PictureBox btn_save;
        private System.Windows.Forms.BindingSource bs_dip;
        private System.Windows.Forms.ComboBox cb_dip1;
        private System.Windows.Forms.Button bt_ajouterDiplome;
        private System.Windows.Forms.ComboBox cb_dip2;
        private System.Windows.Forms.ComboBox cb_dip3;
        private System.Windows.Forms.TextBox tb_compter1;
        private System.Windows.Forms.BindingSource bs_comp;
        private System.Windows.Forms.TextBox tb_compter2;
        private System.Windows.Forms.ComboBox cb_comp3;
        private System.Windows.Forms.ComboBox cb_comp2;
        private System.Windows.Forms.Button bt_ajouterComp;
        private System.Windows.Forms.ComboBox cb_comp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_reset1;
        private System.Windows.Forms.Button bt_reset2;
    }
}