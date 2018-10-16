namespace CharacterCreator.Winforms
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.comboBoxClassType = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelRace = new System.Windows.Forms.Label();
            this.textBoxBio = new System.Windows.Forms.TextBox();
            this.labelBio = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.labelStrength = new System.Windows.Forms.Label();
            this.intelLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.conLabel = new System.Windows.Forms.Label();
            this.wisLabel = new System.Windows.Forms.Label();
            this.charLabel = new System.Windows.Forms.Label();
            this.luckLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPointsAvail = new System.Windows.Forms.Label();
            this.nudStrength = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudIntellegence = new System.Windows.Forms.NumericUpDown();
            this.nudDexterity = new System.Windows.Forms.NumericUpDown();
            this.nudConstitution = new System.Windows.Forms.NumericUpDown();
            this.nudWisdom = new System.Windows.Forms.NumericUpDown();
            this.nudCharisma = new System.Windows.Forms.NumericUpDown();
            this.nudLuck = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntellegence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWisdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuck)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClassType
            // 
            this.comboBoxClassType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassType.FormattingEnabled = true;
            this.comboBoxClassType.Location = new System.Drawing.Point(12, 57);
            this.comboBoxClassType.Name = "comboBoxClassType";
            this.comboBoxClassType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClassType.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(197, 283);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonOnClick);
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(12, 95);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRace.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 19);
            this.textBoxName.MaxLength = 15;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.NameTextBoxChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(12, 42);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(32, 13);
            this.labelClass.TabIndex = 5;
            this.labelClass.Text = "Class";
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Location = new System.Drawing.Point(12, 81);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(33, 13);
            this.labelRace.TabIndex = 6;
            this.labelRace.Text = "Race";
            // 
            // textBoxBio
            // 
            this.textBoxBio.Location = new System.Drawing.Point(15, 135);
            this.textBoxBio.MaxLength = 400;
            this.textBoxBio.Multiline = true;
            this.textBoxBio.Name = "textBoxBio";
            this.textBoxBio.Size = new System.Drawing.Size(118, 193);
            this.textBoxBio.TabIndex = 3;
            // 
            // labelBio
            // 
            this.labelBio.AutoSize = true;
            this.labelBio.Location = new System.Drawing.Point(12, 119);
            this.labelBio.Name = "labelBio";
            this.labelBio.Size = new System.Drawing.Size(54, 13);
            this.labelBio.TabIndex = 8;
            this.labelBio.Text = "Biography";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(197, 312);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonOnClick);
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Location = new System.Drawing.Point(168, 26);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(47, 13);
            this.labelStrength.TabIndex = 11;
            this.labelStrength.Text = "Strength";
            // 
            // intelLabel
            // 
            this.intelLabel.AutoSize = true;
            this.intelLabel.Location = new System.Drawing.Point(150, 53);
            this.intelLabel.Name = "intelLabel";
            this.intelLabel.Size = new System.Drawing.Size(65, 13);
            this.intelLabel.TabIndex = 14;
            this.intelLabel.Text = "Intellegence";
            // 
            // dexLabel
            // 
            this.dexLabel.AutoSize = true;
            this.dexLabel.Location = new System.Drawing.Point(167, 83);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(48, 13);
            this.dexLabel.TabIndex = 17;
            this.dexLabel.Text = "Dexterity";
            // 
            // conLabel
            // 
            this.conLabel.AutoSize = true;
            this.conLabel.Location = new System.Drawing.Point(153, 109);
            this.conLabel.Name = "conLabel";
            this.conLabel.Size = new System.Drawing.Size(62, 13);
            this.conLabel.TabIndex = 20;
            this.conLabel.Text = "Constitution";
            // 
            // wisLabel
            // 
            this.wisLabel.AutoSize = true;
            this.wisLabel.Location = new System.Drawing.Point(170, 138);
            this.wisLabel.Name = "wisLabel";
            this.wisLabel.Size = new System.Drawing.Size(45, 13);
            this.wisLabel.TabIndex = 23;
            this.wisLabel.Text = "Wisdom";
            // 
            // charLabel
            // 
            this.charLabel.AutoSize = true;
            this.charLabel.Location = new System.Drawing.Point(165, 167);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(50, 13);
            this.charLabel.TabIndex = 26;
            this.charLabel.Text = "Charisma";
            // 
            // luckLabel
            // 
            this.luckLabel.AutoSize = true;
            this.luckLabel.Location = new System.Drawing.Point(183, 196);
            this.luckLabel.Name = "luckLabel";
            this.luckLabel.Size = new System.Drawing.Size(31, 13);
            this.luckLabel.TabIndex = 29;
            this.luckLabel.Text = "Luck";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(46, 3);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(34, 13);
            this.errorLabel.TabIndex = 32;
            this.errorLabel.Text = "Name";
            this.errorLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Available points:";
            // 
            // labelPointsAvail
            // 
            this.labelPointsAvail.AutoSize = true;
            this.labelPointsAvail.Location = new System.Drawing.Point(254, 228);
            this.labelPointsAvail.Name = "labelPointsAvail";
            this.labelPointsAvail.Size = new System.Drawing.Size(13, 13);
            this.labelPointsAvail.TabIndex = 34;
            this.labelPointsAvail.Text = "0";
            // 
            // nudStrength
            // 
            this.nudStrength.Location = new System.Drawing.Point(221, 21);
            this.nudStrength.Name = "nudStrength";
            this.nudStrength.Size = new System.Drawing.Size(51, 20);
            this.nudStrength.TabIndex = 4;
            this.nudStrength.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudStrength.ValueChanged += new System.EventHandler(this.AttributValueChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // nudIntellegence
            // 
            this.nudIntellegence.Location = new System.Drawing.Point(221, 50);
            this.nudIntellegence.Name = "nudIntellegence";
            this.nudIntellegence.Size = new System.Drawing.Size(51, 20);
            this.nudIntellegence.TabIndex = 5;
            this.nudIntellegence.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudIntellegence.ValueChanged += new System.EventHandler(this.AttributValueChanged);
            // 
            // nudDexterity
            // 
            this.nudDexterity.Location = new System.Drawing.Point(221, 78);
            this.nudDexterity.Name = "nudDexterity";
            this.nudDexterity.Size = new System.Drawing.Size(51, 20);
            this.nudDexterity.TabIndex = 6;
            this.nudDexterity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudDexterity.ValueChanged += new System.EventHandler(this.AttributValueChanged);
            // 
            // nudConstitution
            // 
            this.nudConstitution.Location = new System.Drawing.Point(221, 107);
            this.nudConstitution.Name = "nudConstitution";
            this.nudConstitution.Size = new System.Drawing.Size(51, 20);
            this.nudConstitution.TabIndex = 7;
            this.nudConstitution.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudConstitution.ValueChanged += new System.EventHandler(this.AttributValueChanged);
            // 
            // nudWisdom
            // 
            this.nudWisdom.Location = new System.Drawing.Point(221, 136);
            this.nudWisdom.Name = "nudWisdom";
            this.nudWisdom.Size = new System.Drawing.Size(51, 20);
            this.nudWisdom.TabIndex = 8;
            this.nudWisdom.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudWisdom.ValueChanged += new System.EventHandler(this.AttributValueChanged);
            // 
            // nudCharisma
            // 
            this.nudCharisma.Location = new System.Drawing.Point(221, 165);
            this.nudCharisma.Name = "nudCharisma";
            this.nudCharisma.Size = new System.Drawing.Size(51, 20);
            this.nudCharisma.TabIndex = 9;
            this.nudCharisma.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCharisma.ValueChanged += new System.EventHandler(this.AttributValueChanged);
            // 
            // nudLuck
            // 
            this.nudLuck.Enabled = false;
            this.nudLuck.Location = new System.Drawing.Point(221, 194);
            this.nudLuck.Name = "nudLuck";
            this.nudLuck.Size = new System.Drawing.Size(51, 20);
            this.nudLuck.TabIndex = 10;
            this.nudLuck.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLuck.ValueChanged += new System.EventHandler(this.AttributValueChanged);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.ControlBox = false;
            this.Controls.Add(this.nudLuck);
            this.Controls.Add(this.nudCharisma);
            this.Controls.Add(this.nudWisdom);
            this.Controls.Add(this.nudConstitution);
            this.Controls.Add(this.nudDexterity);
            this.Controls.Add(this.nudIntellegence);
            this.Controls.Add(this.nudStrength);
            this.Controls.Add(this.labelPointsAvail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.luckLabel);
            this.Controls.Add(this.charLabel);
            this.Controls.Add(this.wisLabel);
            this.Controls.Add(this.conLabel);
            this.Controls.Add(this.dexLabel);
            this.Controls.Add(this.intelLabel);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.labelBio);
            this.Controls.Add(this.textBoxBio);
            this.Controls.Add(this.labelRace);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxRace);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.comboBoxClassType);
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "CharacterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Character";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntellegence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWisdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClassType;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelRace;
        private System.Windows.Forms.TextBox textBoxBio;
        private System.Windows.Forms.Label labelBio;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label intelLabel;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.Label conLabel;
        private System.Windows.Forms.Label wisLabel;
        private System.Windows.Forms.Label charLabel;
        private System.Windows.Forms.Label luckLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPointsAvail;
        private System.Windows.Forms.NumericUpDown nudStrength;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown nudLuck;
        private System.Windows.Forms.NumericUpDown nudCharisma;
        private System.Windows.Forms.NumericUpDown nudWisdom;
        private System.Windows.Forms.NumericUpDown nudConstitution;
        private System.Windows.Forms.NumericUpDown nudDexterity;
        private System.Windows.Forms.NumericUpDown nudIntellegence;
    }
}