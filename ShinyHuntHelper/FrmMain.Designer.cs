namespace ShinyHuntHelper
{
    partial class FrmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewRE = new System.Windows.Forms.Button();
            this.txtSessionRE = new System.Windows.Forms.TextBox();
            this.lblSessionRE = new System.Windows.Forms.Label();
            this.lblNewRE = new System.Windows.Forms.Label();
            this.txtNewRE = new System.Windows.Forms.TextBox();
            this.btnPopUp = new System.Windows.Forms.Button();
            this.cbxMissTarget = new System.Windows.Forms.ComboBox();
            this.lblMissTarget = new System.Windows.Forms.Label();
            this.txtUnluck = new System.Windows.Forms.TextBox();
            this.lblUnluck = new System.Windows.Forms.Label();
            this.txtGameVersion = new System.Windows.Forms.TextBox();
            this.lblGameVersion = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtPhase = new System.Windows.Forms.TextBox();
            this.lblPhase = new System.Windows.Forms.Label();
            this.btnNotMyShiny = new System.Windows.Forms.Button();
            this.btnShinyGet = new System.Windows.Forms.Button();
            this.lblTarget = new System.Windows.Forms.Label();
            this.gbxGen = new System.Windows.Forms.GroupBox();
            this.rdbGen5 = new System.Windows.Forms.RadioButton();
            this.rdbGen4 = new System.Windows.Forms.RadioButton();
            this.rdbGen3 = new System.Windows.Forms.RadioButton();
            this.rdbGen2 = new System.Windows.Forms.RadioButton();
            this.cbxTarget = new System.Windows.Forms.ComboBox();
            this.txtEncontros = new System.Windows.Forms.TextBox();
            this.lblEncontros = new System.Windows.Forms.Label();
            this.pcbTarget = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbxTeclas = new System.Windows.Forms.GroupBox();
            this.btnSaveHotkeys = new System.Windows.Forms.Button();
            this.txtSubKey = new System.Windows.Forms.TextBox();
            this.lblSubKey = new System.Windows.Forms.Label();
            this.txtAddKey = new System.Windows.Forms.TextBox();
            this.lblAddKey = new System.Windows.Forms.Label();
            this.gbxArquivos = new System.Windows.Forms.GroupBox();
            this.btnSavePathSearch = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.fbdSavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.gbxCredits = new System.Windows.Forms.GroupBox();
            this.lblCredits1 = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTwitter = new System.Windows.Forms.Label();
            this.llbTwitter = new System.Windows.Forms.LinkLabel();
            this.lblTwitch = new System.Windows.Forms.Label();
            this.llbTwich = new System.Windows.Forms.LinkLabel();
            this.lblGit = new System.Windows.Forms.Label();
            this.llbGit = new System.Windows.Forms.LinkLabel();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTarget)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbxTeclas.SuspendLayout();
            this.gbxArquivos.SuspendLayout();
            this.gbxCredits.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(630, 337);
            this.tabMain.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tracker";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewRE);
            this.groupBox1.Controls.Add(this.txtSessionRE);
            this.groupBox1.Controls.Add(this.lblSessionRE);
            this.groupBox1.Controls.Add(this.lblNewRE);
            this.groupBox1.Controls.Add(this.txtNewRE);
            this.groupBox1.Controls.Add(this.btnPopUp);
            this.groupBox1.Controls.Add(this.cbxMissTarget);
            this.groupBox1.Controls.Add(this.lblMissTarget);
            this.groupBox1.Controls.Add(this.txtUnluck);
            this.groupBox1.Controls.Add(this.lblUnluck);
            this.groupBox1.Controls.Add(this.txtGameVersion);
            this.groupBox1.Controls.Add(this.lblGameVersion);
            this.groupBox1.Controls.Add(this.txtLocal);
            this.groupBox1.Controls.Add(this.lblLocal);
            this.groupBox1.Controls.Add(this.txtPhase);
            this.groupBox1.Controls.Add(this.lblPhase);
            this.groupBox1.Controls.Add(this.btnNotMyShiny);
            this.groupBox1.Controls.Add(this.btnShinyGet);
            this.groupBox1.Controls.Add(this.lblTarget);
            this.groupBox1.Controls.Add(this.gbxGen);
            this.groupBox1.Controls.Add(this.cbxTarget);
            this.groupBox1.Controls.Add(this.txtEncontros);
            this.groupBox1.Controls.Add(this.lblEncontros);
            this.groupBox1.Controls.Add(this.pcbTarget);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target";
            // 
            // btnNewRE
            // 
            this.btnNewRE.Location = new System.Drawing.Point(332, 207);
            this.btnNewRE.Name = "btnNewRE";
            this.btnNewRE.Size = new System.Drawing.Size(96, 23);
            this.btnNewRE.TabIndex = 28;
            this.btnNewRE.Text = "Set new RE/SR";
            this.btnNewRE.UseVisualStyleBackColor = true;
            this.btnNewRE.Click += new System.EventHandler(this.btnNewRE_Click);
            // 
            // txtSessionRE
            // 
            this.txtSessionRE.Location = new System.Drawing.Point(453, 209);
            this.txtSessionRE.Name = "txtSessionRE";
            this.txtSessionRE.ReadOnly = true;
            this.txtSessionRE.Size = new System.Drawing.Size(118, 20);
            this.txtSessionRE.TabIndex = 27;
            this.txtSessionRE.Text = "0";
            // 
            // lblSessionRE
            // 
            this.lblSessionRE.AutoSize = true;
            this.lblSessionRE.Location = new System.Drawing.Point(452, 193);
            this.lblSessionRE.Name = "lblSessionRE";
            this.lblSessionRE.Size = new System.Drawing.Size(119, 13);
            this.lblSessionRE.TabIndex = 26;
            this.lblSessionRE.Text = "This Session RE/SR(s):";
            // 
            // lblNewRE
            // 
            this.lblNewRE.AutoSize = true;
            this.lblNewRE.Location = new System.Drawing.Point(199, 193);
            this.lblNewRE.Name = "lblNewRE";
            this.lblNewRE.Size = new System.Drawing.Size(89, 13);
            this.lblNewRE.TabIndex = 24;
            this.lblNewRE.Text = "Set New RE/SR:";
            // 
            // txtNewRE
            // 
            this.txtNewRE.Location = new System.Drawing.Point(202, 209);
            this.txtNewRE.Name = "txtNewRE";
            this.txtNewRE.Size = new System.Drawing.Size(118, 20);
            this.txtNewRE.TabIndex = 23;
            this.txtNewRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewRE_KeyPress);
            // 
            // btnPopUp
            // 
            this.btnPopUp.Location = new System.Drawing.Point(56, 204);
            this.btnPopUp.Name = "btnPopUp";
            this.btnPopUp.Size = new System.Drawing.Size(75, 23);
            this.btnPopUp.TabIndex = 22;
            this.btnPopUp.Text = "Pop Up Image";
            this.btnPopUp.UseVisualStyleBackColor = true;
            this.btnPopUp.Click += new System.EventHandler(this.btnPopUp_Click);
            // 
            // cbxMissTarget
            // 
            this.cbxMissTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxMissTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMissTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMissTarget.FormattingEnabled = true;
            this.cbxMissTarget.Location = new System.Drawing.Point(451, 254);
            this.cbxMissTarget.Name = "cbxMissTarget";
            this.cbxMissTarget.Size = new System.Drawing.Size(121, 21);
            this.cbxMissTarget.TabIndex = 21;
            // 
            // lblMissTarget
            // 
            this.lblMissTarget.AutoSize = true;
            this.lblMissTarget.Location = new System.Drawing.Point(451, 239);
            this.lblMissTarget.Name = "lblMissTarget";
            this.lblMissTarget.Size = new System.Drawing.Size(65, 13);
            this.lblMissTarget.TabIndex = 20;
            this.lblMissTarget.Text = "Miss Target:";
            // 
            // txtUnluck
            // 
            this.txtUnluck.Location = new System.Drawing.Point(455, 161);
            this.txtUnluck.Name = "txtUnluck";
            this.txtUnluck.ReadOnly = true;
            this.txtUnluck.Size = new System.Drawing.Size(100, 20);
            this.txtUnluck.TabIndex = 19;
            // 
            // lblUnluck
            // 
            this.lblUnluck.AutoSize = true;
            this.lblUnluck.Location = new System.Drawing.Point(452, 145);
            this.lblUnluck.Name = "lblUnluck";
            this.lblUnluck.Size = new System.Drawing.Size(55, 13);
            this.lblUnluck.TabIndex = 18;
            this.lblUnluck.Text = "Unluck %:";
            // 
            // txtGameVersion
            // 
            this.txtGameVersion.Location = new System.Drawing.Point(452, 110);
            this.txtGameVersion.Name = "txtGameVersion";
            this.txtGameVersion.Size = new System.Drawing.Size(120, 20);
            this.txtGameVersion.TabIndex = 17;
            this.txtGameVersion.TextChanged += new System.EventHandler(this.txtGameVersion_TextChanged);
            // 
            // lblGameVersion
            // 
            this.lblGameVersion.AutoSize = true;
            this.lblGameVersion.Location = new System.Drawing.Point(452, 94);
            this.lblGameVersion.Name = "lblGameVersion";
            this.lblGameVersion.Size = new System.Drawing.Size(76, 13);
            this.lblGameVersion.TabIndex = 16;
            this.lblGameVersion.Text = "Game Version:";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(329, 110);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(120, 20);
            this.txtLocal.TabIndex = 15;
            this.txtLocal.TextChanged += new System.EventHandler(this.txtLocal_TextChanged);
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(329, 94);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(36, 13);
            this.lblLocal.TabIndex = 14;
            this.lblLocal.Text = "Local:";
            // 
            // txtPhase
            // 
            this.txtPhase.Location = new System.Drawing.Point(331, 161);
            this.txtPhase.Name = "txtPhase";
            this.txtPhase.ReadOnly = true;
            this.txtPhase.Size = new System.Drawing.Size(118, 20);
            this.txtPhase.TabIndex = 13;
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(329, 145);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(40, 13);
            this.lblPhase.TabIndex = 12;
            this.lblPhase.Text = "Phase:";
            // 
            // btnNotMyShiny
            // 
            this.btnNotMyShiny.Location = new System.Drawing.Point(332, 252);
            this.btnNotMyShiny.Name = "btnNotMyShiny";
            this.btnNotMyShiny.Size = new System.Drawing.Size(96, 23);
            this.btnNotMyShiny.TabIndex = 11;
            this.btnNotMyShiny.Text = "Not My Shiny";
            this.btnNotMyShiny.UseVisualStyleBackColor = true;
            this.btnNotMyShiny.Click += new System.EventHandler(this.btnNotMyShiny_Click);
            // 
            // btnShinyGet
            // 
            this.btnShinyGet.Location = new System.Drawing.Point(202, 252);
            this.btnShinyGet.Name = "btnShinyGet";
            this.btnShinyGet.Size = new System.Drawing.Size(97, 23);
            this.btnShinyGet.TabIndex = 10;
            this.btnShinyGet.Text = "Shiny!";
            this.btnShinyGet.UseVisualStyleBackColor = true;
            this.btnShinyGet.Click += new System.EventHandler(this.btnShinyGet_Click);
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(199, 94);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(89, 13);
            this.lblTarget.TabIndex = 9;
            this.lblTarget.Text = "Target Pokémon:";
            // 
            // gbxGen
            // 
            this.gbxGen.Controls.Add(this.rdbGen5);
            this.gbxGen.Controls.Add(this.rdbGen4);
            this.gbxGen.Controls.Add(this.rdbGen3);
            this.gbxGen.Controls.Add(this.rdbGen2);
            this.gbxGen.Location = new System.Drawing.Point(192, 16);
            this.gbxGen.Name = "gbxGen";
            this.gbxGen.Size = new System.Drawing.Size(410, 61);
            this.gbxGen.TabIndex = 8;
            this.gbxGen.TabStop = false;
            this.gbxGen.Text = "Generation";
            // 
            // rdbGen5
            // 
            this.rdbGen5.AutoSize = true;
            this.rdbGen5.Checked = true;
            this.rdbGen5.Location = new System.Drawing.Point(330, 19);
            this.rdbGen5.Name = "rdbGen5";
            this.rdbGen5.Size = new System.Drawing.Size(54, 17);
            this.rdbGen5.TabIndex = 10;
            this.rdbGen5.TabStop = true;
            this.rdbGen5.Text = "Gen 5";
            this.rdbGen5.UseVisualStyleBackColor = true;
            this.rdbGen5.CheckedChanged += new System.EventHandler(this.rdbGen5_CheckedChanged);
            // 
            // rdbGen4
            // 
            this.rdbGen4.AutoSize = true;
            this.rdbGen4.Location = new System.Drawing.Point(233, 19);
            this.rdbGen4.Name = "rdbGen4";
            this.rdbGen4.Size = new System.Drawing.Size(54, 17);
            this.rdbGen4.TabIndex = 9;
            this.rdbGen4.TabStop = true;
            this.rdbGen4.Text = "Gen 4";
            this.rdbGen4.UseVisualStyleBackColor = true;
            this.rdbGen4.CheckedChanged += new System.EventHandler(this.rdbGen4_CheckedChanged);
            // 
            // rdbGen3
            // 
            this.rdbGen3.AutoSize = true;
            this.rdbGen3.Location = new System.Drawing.Point(137, 19);
            this.rdbGen3.Name = "rdbGen3";
            this.rdbGen3.Size = new System.Drawing.Size(54, 17);
            this.rdbGen3.TabIndex = 8;
            this.rdbGen3.TabStop = true;
            this.rdbGen3.Text = "Gen 3";
            this.rdbGen3.UseVisualStyleBackColor = true;
            this.rdbGen3.CheckedChanged += new System.EventHandler(this.rdbGen3_CheckedChanged);
            // 
            // rdbGen2
            // 
            this.rdbGen2.AutoSize = true;
            this.rdbGen2.Location = new System.Drawing.Point(42, 19);
            this.rdbGen2.Name = "rdbGen2";
            this.rdbGen2.Size = new System.Drawing.Size(54, 17);
            this.rdbGen2.TabIndex = 7;
            this.rdbGen2.TabStop = true;
            this.rdbGen2.Text = "Gen 2";
            this.rdbGen2.UseVisualStyleBackColor = true;
            this.rdbGen2.CheckedChanged += new System.EventHandler(this.rdbGen2_CheckedChanged);
            // 
            // cbxTarget
            // 
            this.cbxTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTarget.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbxTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTarget.FormattingEnabled = true;
            this.cbxTarget.Location = new System.Drawing.Point(202, 110);
            this.cbxTarget.Name = "cbxTarget";
            this.cbxTarget.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxTarget.Size = new System.Drawing.Size(121, 21);
            this.cbxTarget.TabIndex = 6;
            this.cbxTarget.SelectedIndexChanged += new System.EventHandler(this.cbxTarget_SelectedIndexChanged);
            // 
            // txtEncontros
            // 
            this.txtEncontros.Location = new System.Drawing.Point(202, 161);
            this.txtEncontros.Name = "txtEncontros";
            this.txtEncontros.ReadOnly = true;
            this.txtEncontros.Size = new System.Drawing.Size(118, 20);
            this.txtEncontros.TabIndex = 5;
            this.txtEncontros.TextChanged += new System.EventHandler(this.txtEncontros_TextChanged);
            // 
            // lblEncontros
            // 
            this.lblEncontros.AutoSize = true;
            this.lblEncontros.Location = new System.Drawing.Point(199, 145);
            this.lblEncontros.Name = "lblEncontros";
            this.lblEncontros.Size = new System.Drawing.Size(55, 13);
            this.lblEncontros.TabIndex = 1;
            this.lblEncontros.Text = "REs/SRs:";
            // 
            // pcbTarget
            // 
            this.pcbTarget.Location = new System.Drawing.Point(6, 16);
            this.pcbTarget.Name = "pcbTarget";
            this.pcbTarget.Size = new System.Drawing.Size(180, 180);
            this.pcbTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbTarget.TabIndex = 0;
            this.pcbTarget.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbxCredits);
            this.tabPage2.Controls.Add(this.gbxTeclas);
            this.tabPage2.Controls.Add(this.gbxArquivos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbxTeclas
            // 
            this.gbxTeclas.Controls.Add(this.btnSaveHotkeys);
            this.gbxTeclas.Controls.Add(this.txtSubKey);
            this.gbxTeclas.Controls.Add(this.lblSubKey);
            this.gbxTeclas.Controls.Add(this.txtAddKey);
            this.gbxTeclas.Controls.Add(this.lblAddKey);
            this.gbxTeclas.Location = new System.Drawing.Point(6, 81);
            this.gbxTeclas.Name = "gbxTeclas";
            this.gbxTeclas.Size = new System.Drawing.Size(610, 74);
            this.gbxTeclas.TabIndex = 1;
            this.gbxTeclas.TabStop = false;
            this.gbxTeclas.Text = "HotKeys";
            // 
            // btnSaveHotkeys
            // 
            this.btnSaveHotkeys.Location = new System.Drawing.Point(529, 14);
            this.btnSaveHotkeys.Name = "btnSaveHotkeys";
            this.btnSaveHotkeys.Size = new System.Drawing.Size(75, 23);
            this.btnSaveHotkeys.TabIndex = 3;
            this.btnSaveHotkeys.Text = "Set Hotkeys";
            this.btnSaveHotkeys.UseVisualStyleBackColor = true;
            this.btnSaveHotkeys.Click += new System.EventHandler(this.btnSaveHotkeys_Click);
            // 
            // txtSubKey
            // 
            this.txtSubKey.Location = new System.Drawing.Point(83, 43);
            this.txtSubKey.Name = "txtSubKey";
            this.txtSubKey.ReadOnly = true;
            this.txtSubKey.Size = new System.Drawing.Size(100, 20);
            this.txtSubKey.TabIndex = 2;
            this.txtSubKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubKey_KeyDown);
            // 
            // lblSubKey
            // 
            this.lblSubKey.AutoSize = true;
            this.lblSubKey.Location = new System.Drawing.Point(19, 50);
            this.lblSubKey.Name = "lblSubKey";
            this.lblSubKey.Size = new System.Drawing.Size(50, 13);
            this.lblSubKey.TabIndex = 1;
            this.lblSubKey.Text = "Subtract:";
            // 
            // txtAddKey
            // 
            this.txtAddKey.Location = new System.Drawing.Point(83, 17);
            this.txtAddKey.Name = "txtAddKey";
            this.txtAddKey.ReadOnly = true;
            this.txtAddKey.Size = new System.Drawing.Size(100, 20);
            this.txtAddKey.TabIndex = 0;
            this.txtAddKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyIncrease_KeyDown);
            // 
            // lblAddKey
            // 
            this.lblAddKey.AutoSize = true;
            this.lblAddKey.Location = new System.Drawing.Point(19, 24);
            this.lblAddKey.Name = "lblAddKey";
            this.lblAddKey.Size = new System.Drawing.Size(29, 13);
            this.lblAddKey.TabIndex = 0;
            this.lblAddKey.Text = "Add:";
            // 
            // gbxArquivos
            // 
            this.gbxArquivos.Controls.Add(this.btnSavePathSearch);
            this.gbxArquivos.Controls.Add(this.txtSavePath);
            this.gbxArquivos.Controls.Add(this.lblDestino);
            this.gbxArquivos.Location = new System.Drawing.Point(6, 6);
            this.gbxArquivos.Name = "gbxArquivos";
            this.gbxArquivos.Size = new System.Drawing.Size(610, 69);
            this.gbxArquivos.TabIndex = 0;
            this.gbxArquivos.TabStop = false;
            this.gbxArquivos.Text = "Arquivos";
            // 
            // btnSavePathSearch
            // 
            this.btnSavePathSearch.Location = new System.Drawing.Point(529, 24);
            this.btnSavePathSearch.Name = "btnSavePathSearch";
            this.btnSavePathSearch.Size = new System.Drawing.Size(75, 19);
            this.btnSavePathSearch.TabIndex = 2;
            this.btnSavePathSearch.Text = "Search";
            this.btnSavePathSearch.UseVisualStyleBackColor = true;
            this.btnSavePathSearch.Click += new System.EventHandler(this.btnSavePathSearch_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(83, 23);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.ReadOnly = true;
            this.txtSavePath.Size = new System.Drawing.Size(440, 20);
            this.txtSavePath.TabIndex = 1;
            this.txtSavePath.Click += new System.EventHandler(this.txtSavePath_Click);
            this.txtSavePath.TextChanged += new System.EventHandler(this.txtSavePath_TextChanged);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(16, 31);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(60, 13);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "Save Path:";
            // 
            // fbdSavePath
            // 
            this.fbdSavePath.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // gbxCredits
            // 
            this.gbxCredits.Controls.Add(this.llbGit);
            this.gbxCredits.Controls.Add(this.lblGit);
            this.gbxCredits.Controls.Add(this.llbTwich);
            this.gbxCredits.Controls.Add(this.lblTwitch);
            this.gbxCredits.Controls.Add(this.llbTwitter);
            this.gbxCredits.Controls.Add(this.lblTwitter);
            this.gbxCredits.Controls.Add(this.lblAutor);
            this.gbxCredits.Controls.Add(this.lblCredits1);
            this.gbxCredits.Location = new System.Drawing.Point(6, 161);
            this.gbxCredits.Name = "gbxCredits";
            this.gbxCredits.Size = new System.Drawing.Size(610, 144);
            this.gbxCredits.TabIndex = 2;
            this.gbxCredits.TabStop = false;
            this.gbxCredits.Text = "Credits";
            // 
            // lblCredits1
            // 
            this.lblCredits1.AutoSize = true;
            this.lblCredits1.Location = new System.Drawing.Point(6, 16);
            this.lblCredits1.Name = "lblCredits1";
            this.lblCredits1.Size = new System.Drawing.Size(105, 13);
            this.lblCredits1.TabIndex = 0;
            this.lblCredits1.Text = "Shiny Hunter Helper:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(16, 40);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(84, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor: Luiz HMS";
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Location = new System.Drawing.Point(19, 62);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(45, 13);
            this.lblTwitter.TabIndex = 2;
            this.lblTwitter.Text = "Twitter: ";
            // 
            // llbTwitter
            // 
            this.llbTwitter.AutoSize = true;
            this.llbTwitter.Location = new System.Drawing.Point(61, 62);
            this.llbTwitter.Name = "llbTwitter";
            this.llbTwitter.Size = new System.Drawing.Size(73, 13);
            this.llbTwitter.TabIndex = 3;
            this.llbTwitter.TabStop = true;
            this.llbTwitter.Text = "@LuizHMS22";
            this.llbTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTwitter_LinkClicked);
            // 
            // lblTwitch
            // 
            this.lblTwitch.AutoSize = true;
            this.lblTwitch.Location = new System.Drawing.Point(19, 90);
            this.lblTwitch.Name = "lblTwitch";
            this.lblTwitch.Size = new System.Drawing.Size(42, 13);
            this.lblTwitch.TabIndex = 4;
            this.lblTwitch.Text = "Twitch:";
            // 
            // llbTwich
            // 
            this.llbTwich.AutoSize = true;
            this.llbTwich.Location = new System.Drawing.Point(61, 90);
            this.llbTwich.Name = "llbTwich";
            this.llbTwich.Size = new System.Drawing.Size(50, 13);
            this.llbTwich.TabIndex = 5;
            this.llbTwich.TabStop = true;
            this.llbTwich.Text = "LuizHMS";
            this.llbTwich.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTwich_LinkClicked);
            // 
            // lblGit
            // 
            this.lblGit.AutoSize = true;
            this.lblGit.Location = new System.Drawing.Point(19, 118);
            this.lblGit.Name = "lblGit";
            this.lblGit.Size = new System.Drawing.Size(43, 13);
            this.lblGit.TabIndex = 6;
            this.lblGit.Text = "GitHub:";
            // 
            // llbGit
            // 
            this.llbGit.AutoSize = true;
            this.llbGit.Location = new System.Drawing.Point(61, 118);
            this.llbGit.Name = "llbGit";
            this.llbGit.Size = new System.Drawing.Size(50, 13);
            this.llbGit.TabIndex = 7;
            this.llbGit.TabStop = true;
            this.llbGit.Text = "LuizHMS";
            this.llbGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGit_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 361);
            this.Controls.Add(this.tabMain);
            this.Name = "FrmMain";
            this.Text = "Shiny Hunt Helper";
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxGen.ResumeLayout(false);
            this.gbxGen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTarget)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbxTeclas.ResumeLayout(false);
            this.gbxTeclas.PerformLayout();
            this.gbxArquivos.ResumeLayout(false);
            this.gbxArquivos.PerformLayout();
            this.gbxCredits.ResumeLayout(false);
            this.gbxCredits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbxArquivos;
        private System.Windows.Forms.Button btnSavePathSearch;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.FolderBrowserDialog fbdSavePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbTarget;
        private System.Windows.Forms.Label lblEncontros;
        private System.Windows.Forms.GroupBox gbxTeclas;
        private System.Windows.Forms.Label lblAddKey;
        private System.Windows.Forms.TextBox txtAddKey;
        private System.Windows.Forms.Label lblSubKey;
        private System.Windows.Forms.TextBox txtSubKey;
        private System.Windows.Forms.TextBox txtEncontros;
        private System.Windows.Forms.Button btnSaveHotkeys;
        private System.Windows.Forms.ComboBox cbxTarget;
        private System.Windows.Forms.RadioButton rdbGen2;
        private System.Windows.Forms.GroupBox gbxGen;
        private System.Windows.Forms.RadioButton rdbGen3;
        private System.Windows.Forms.RadioButton rdbGen5;
        private System.Windows.Forms.RadioButton rdbGen4;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TextBox txtPhase;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Button btnNotMyShiny;
        private System.Windows.Forms.Button btnShinyGet;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtGameVersion;
        private System.Windows.Forms.Label lblGameVersion;
        private System.Windows.Forms.TextBox txtUnluck;
        private System.Windows.Forms.Label lblUnluck;
        private System.Windows.Forms.ComboBox cbxMissTarget;
        private System.Windows.Forms.Label lblMissTarget;
        private System.Windows.Forms.Button btnPopUp;
        private System.Windows.Forms.Button btnNewRE;
        private System.Windows.Forms.TextBox txtSessionRE;
        private System.Windows.Forms.Label lblSessionRE;
        private System.Windows.Forms.Label lblNewRE;
        private System.Windows.Forms.TextBox txtNewRE;
        private System.Windows.Forms.GroupBox gbxCredits;
        private System.Windows.Forms.LinkLabel llbTwitter;
        private System.Windows.Forms.Label lblTwitter;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblCredits1;
        private System.Windows.Forms.LinkLabel llbTwich;
        private System.Windows.Forms.Label lblTwitch;
        private System.Windows.Forms.LinkLabel llbGit;
        private System.Windows.Forms.Label lblGit;
    }
}

