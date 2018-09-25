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
            this.strScrollBar = new System.Windows.Forms.HScrollBar();
            this.strScoreLabel = new System.Windows.Forms.Label();
            this.intelScoreLabel = new System.Windows.Forms.Label();
            this.intelScrollBar = new System.Windows.Forms.HScrollBar();
            this.intelLabel = new System.Windows.Forms.Label();
            this.dexScoreLabel = new System.Windows.Forms.Label();
            this.dexScrollBar = new System.Windows.Forms.HScrollBar();
            this.dexLabel = new System.Windows.Forms.Label();
            this.conScoreLabel = new System.Windows.Forms.Label();
            this.conScrollBar = new System.Windows.Forms.HScrollBar();
            this.conLabel = new System.Windows.Forms.Label();
            this.wisScorLabel = new System.Windows.Forms.Label();
            this.wisScrollBar = new System.Windows.Forms.HScrollBar();
            this.wisLabel = new System.Windows.Forms.Label();
            this.charScoreLabel = new System.Windows.Forms.Label();
            this.charScrollBar = new System.Windows.Forms.HScrollBar();
            this.charLabel = new System.Windows.Forms.Label();
            this.luckScoreLabel = new System.Windows.Forms.Label();
            this.luckLabel = new System.Windows.Forms.Label();
            this.luckScrollBar = new System.Windows.Forms.HScrollBar();
            this.errorLabel = new System.Windows.Forms.Label();
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
            this.labelStrength.Location = new System.Drawing.Point(144, 23);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(47, 13);
            this.labelStrength.TabIndex = 11;
            this.labelStrength.Text = "Strength";
            // 
            // strScrollBar
            // 
            this.strScrollBar.LargeChange = 1;
            this.strScrollBar.Location = new System.Drawing.Point(147, 39);
            this.strScrollBar.Name = "strScrollBar";
            this.strScrollBar.Size = new System.Drawing.Size(127, 10);
            this.strScrollBar.TabIndex = 4;
            this.strScrollBar.TabStop = true;
            this.strScrollBar.Value = 50;
            this.strScrollBar.ValueChanged += new System.EventHandler(this.StrengthScrollBarValueChanged);
            // 
            // strScoreLabel
            // 
            this.strScoreLabel.AutoSize = true;
            this.strScoreLabel.Location = new System.Drawing.Point(236, 23);
            this.strScoreLabel.Name = "strScoreLabel";
            this.strScoreLabel.Size = new System.Drawing.Size(19, 13);
            this.strScoreLabel.TabIndex = 13;
            this.strScoreLabel.Text = "50";
            // 
            // intelScoreLabel
            // 
            this.intelScoreLabel.AutoSize = true;
            this.intelScoreLabel.Location = new System.Drawing.Point(236, 55);
            this.intelScoreLabel.Name = "intelScoreLabel";
            this.intelScoreLabel.Size = new System.Drawing.Size(19, 13);
            this.intelScoreLabel.TabIndex = 16;
            this.intelScoreLabel.Text = "50";
            // 
            // intelScrollBar
            // 
            this.intelScrollBar.LargeChange = 1;
            this.intelScrollBar.Location = new System.Drawing.Point(147, 72);
            this.intelScrollBar.Name = "intelScrollBar";
            this.intelScrollBar.Size = new System.Drawing.Size(127, 10);
            this.intelScrollBar.TabIndex = 5;
            this.intelScrollBar.TabStop = true;
            this.intelScrollBar.Value = 50;
            this.intelScrollBar.ValueChanged += new System.EventHandler(this.IntellegenceScrollBarValueChanged);
            // 
            // intelLabel
            // 
            this.intelLabel.AutoSize = true;
            this.intelLabel.Location = new System.Drawing.Point(144, 55);
            this.intelLabel.Name = "intelLabel";
            this.intelLabel.Size = new System.Drawing.Size(65, 13);
            this.intelLabel.TabIndex = 14;
            this.intelLabel.Text = "Intellegence";
            // 
            // dexScoreLabel
            // 
            this.dexScoreLabel.AutoSize = true;
            this.dexScoreLabel.Location = new System.Drawing.Point(236, 83);
            this.dexScoreLabel.Name = "dexScoreLabel";
            this.dexScoreLabel.Size = new System.Drawing.Size(19, 13);
            this.dexScoreLabel.TabIndex = 19;
            this.dexScoreLabel.Text = "50";
            // 
            // dexScrollBar
            // 
            this.dexScrollBar.LargeChange = 1;
            this.dexScrollBar.Location = new System.Drawing.Point(147, 100);
            this.dexScrollBar.Name = "dexScrollBar";
            this.dexScrollBar.Size = new System.Drawing.Size(127, 10);
            this.dexScrollBar.TabIndex = 6;
            this.dexScrollBar.TabStop = true;
            this.dexScrollBar.Value = 50;
            this.dexScrollBar.ValueChanged += new System.EventHandler(this.DexterityScrollBarValueChanged);
            // 
            // dexLabel
            // 
            this.dexLabel.AutoSize = true;
            this.dexLabel.Location = new System.Drawing.Point(144, 83);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(48, 13);
            this.dexLabel.TabIndex = 17;
            this.dexLabel.Text = "Dexterity";
            // 
            // conScoreLabel
            // 
            this.conScoreLabel.AutoSize = true;
            this.conScoreLabel.Location = new System.Drawing.Point(236, 114);
            this.conScoreLabel.Name = "conScoreLabel";
            this.conScoreLabel.Size = new System.Drawing.Size(19, 13);
            this.conScoreLabel.TabIndex = 22;
            this.conScoreLabel.Text = "50";
            // 
            // conScrollBar
            // 
            this.conScrollBar.LargeChange = 1;
            this.conScrollBar.Location = new System.Drawing.Point(147, 131);
            this.conScrollBar.Name = "conScrollBar";
            this.conScrollBar.Size = new System.Drawing.Size(127, 10);
            this.conScrollBar.TabIndex = 7;
            this.conScrollBar.TabStop = true;
            this.conScrollBar.Value = 50;
            this.conScrollBar.ValueChanged += new System.EventHandler(this.ConstitutionScrollBarValueChanged);
            // 
            // conLabel
            // 
            this.conLabel.AutoSize = true;
            this.conLabel.Location = new System.Drawing.Point(144, 114);
            this.conLabel.Name = "conLabel";
            this.conLabel.Size = new System.Drawing.Size(62, 13);
            this.conLabel.TabIndex = 20;
            this.conLabel.Text = "Constitution";
            // 
            // wisScorLabel
            // 
            this.wisScorLabel.AutoSize = true;
            this.wisScorLabel.Location = new System.Drawing.Point(236, 146);
            this.wisScorLabel.Name = "wisScorLabel";
            this.wisScorLabel.Size = new System.Drawing.Size(19, 13);
            this.wisScorLabel.TabIndex = 25;
            this.wisScorLabel.Text = "50";
            // 
            // wisScrollBar
            // 
            this.wisScrollBar.LargeChange = 1;
            this.wisScrollBar.Location = new System.Drawing.Point(147, 163);
            this.wisScrollBar.Name = "wisScrollBar";
            this.wisScrollBar.Size = new System.Drawing.Size(127, 10);
            this.wisScrollBar.TabIndex = 8;
            this.wisScrollBar.TabStop = true;
            this.wisScrollBar.Value = 50;
            this.wisScrollBar.ValueChanged += new System.EventHandler(this.WisdomScrollBarValueChanged);
            // 
            // wisLabel
            // 
            this.wisLabel.AutoSize = true;
            this.wisLabel.Location = new System.Drawing.Point(144, 146);
            this.wisLabel.Name = "wisLabel";
            this.wisLabel.Size = new System.Drawing.Size(45, 13);
            this.wisLabel.TabIndex = 23;
            this.wisLabel.Text = "Wisdom";
            // 
            // charScoreLabel
            // 
            this.charScoreLabel.AutoSize = true;
            this.charScoreLabel.Location = new System.Drawing.Point(236, 175);
            this.charScoreLabel.Name = "charScoreLabel";
            this.charScoreLabel.Size = new System.Drawing.Size(19, 13);
            this.charScoreLabel.TabIndex = 28;
            this.charScoreLabel.Text = "50";
            // 
            // charScrollBar
            // 
            this.charScrollBar.LargeChange = 1;
            this.charScrollBar.Location = new System.Drawing.Point(147, 191);
            this.charScrollBar.Name = "charScrollBar";
            this.charScrollBar.Size = new System.Drawing.Size(127, 10);
            this.charScrollBar.TabIndex = 9;
            this.charScrollBar.TabStop = true;
            this.charScrollBar.Value = 50;
            this.charScrollBar.ValueChanged += new System.EventHandler(this.CharismaScrollBarValueChanged);
            // 
            // charLabel
            // 
            this.charLabel.AutoSize = true;
            this.charLabel.Location = new System.Drawing.Point(144, 175);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(50, 13);
            this.charLabel.TabIndex = 26;
            this.charLabel.Text = "Charisma";
            // 
            // luckScoreLabel
            // 
            this.luckScoreLabel.AutoSize = true;
            this.luckScoreLabel.Location = new System.Drawing.Point(236, 207);
            this.luckScoreLabel.Name = "luckScoreLabel";
            this.luckScoreLabel.Size = new System.Drawing.Size(19, 13);
            this.luckScoreLabel.TabIndex = 30;
            this.luckScoreLabel.Text = "10";
            // 
            // luckLabel
            // 
            this.luckLabel.AutoSize = true;
            this.luckLabel.Location = new System.Drawing.Point(144, 207);
            this.luckLabel.Name = "luckLabel";
            this.luckLabel.Size = new System.Drawing.Size(31, 13);
            this.luckLabel.TabIndex = 29;
            this.luckLabel.Text = "Luck";
            // 
            // luckScrollBar
            // 
            this.luckScrollBar.Enabled = false;
            this.luckScrollBar.LargeChange = 1;
            this.luckScrollBar.Location = new System.Drawing.Point(148, 220);
            this.luckScrollBar.Name = "luckScrollBar";
            this.luckScrollBar.Size = new System.Drawing.Size(127, 10);
            this.luckScrollBar.TabIndex = 10;
            this.luckScrollBar.TabStop = true;
            this.luckScrollBar.Value = 10;
            this.luckScrollBar.ValueChanged += new System.EventHandler(this.LuckScrollBarValueChanged);
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
            // NewCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.ControlBox = false;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.luckScrollBar);
            this.Controls.Add(this.luckScoreLabel);
            this.Controls.Add(this.luckLabel);
            this.Controls.Add(this.charScoreLabel);
            this.Controls.Add(this.charScrollBar);
            this.Controls.Add(this.charLabel);
            this.Controls.Add(this.wisScorLabel);
            this.Controls.Add(this.wisScrollBar);
            this.Controls.Add(this.wisLabel);
            this.Controls.Add(this.conScoreLabel);
            this.Controls.Add(this.conScrollBar);
            this.Controls.Add(this.conLabel);
            this.Controls.Add(this.dexScoreLabel);
            this.Controls.Add(this.dexScrollBar);
            this.Controls.Add(this.dexLabel);
            this.Controls.Add(this.intelScoreLabel);
            this.Controls.Add(this.intelScrollBar);
            this.Controls.Add(this.intelLabel);
            this.Controls.Add(this.strScoreLabel);
            this.Controls.Add(this.strScrollBar);
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
            this.Name = "NewCharacterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Character";
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
        private System.Windows.Forms.HScrollBar strScrollBar;
        private System.Windows.Forms.Label strScoreLabel;
        private System.Windows.Forms.Label intelScoreLabel;
        private System.Windows.Forms.HScrollBar intelScrollBar;
        private System.Windows.Forms.Label intelLabel;
        private System.Windows.Forms.Label dexScoreLabel;
        private System.Windows.Forms.HScrollBar dexScrollBar;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.Label conScoreLabel;
        private System.Windows.Forms.HScrollBar conScrollBar;
        private System.Windows.Forms.Label conLabel;
        private System.Windows.Forms.Label wisScorLabel;
        private System.Windows.Forms.HScrollBar wisScrollBar;
        private System.Windows.Forms.Label wisLabel;
        private System.Windows.Forms.Label charScoreLabel;
        private System.Windows.Forms.HScrollBar charScrollBar;
        private System.Windows.Forms.Label charLabel;
        private System.Windows.Forms.Label luckScoreLabel;
        private System.Windows.Forms.Label luckLabel;
        private System.Windows.Forms.HScrollBar luckScrollBar;
        private System.Windows.Forms.Label errorLabel;
    }
}