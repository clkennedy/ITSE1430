namespace CharacterCreator.Winforms
{
    partial class NewCharacterForm
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
            this.trackBarStrength = new System.Windows.Forms.TrackBar();
            this.labelStrength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClassType
            // 
            this.comboBoxClassType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassType.FormattingEnabled = true;
            this.comboBoxClassType.Location = new System.Drawing.Point(12, 67);
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
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(12, 105);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRace.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 29);
            this.textBoxName.MaxLength = 15;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(12, 52);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(32, 13);
            this.labelClass.TabIndex = 5;
            this.labelClass.Text = "Class";
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Location = new System.Drawing.Point(12, 91);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(33, 13);
            this.labelRace.TabIndex = 6;
            this.labelRace.Text = "Race";
            // 
            // textBoxBio
            // 
            this.textBoxBio.Location = new System.Drawing.Point(15, 145);
            this.textBoxBio.MaxLength = 400;
            this.textBoxBio.Multiline = true;
            this.textBoxBio.Name = "textBoxBio";
            this.textBoxBio.Size = new System.Drawing.Size(168, 193);
            this.textBoxBio.TabIndex = 3;
            // 
            // labelBio
            // 
            this.labelBio.AutoSize = true;
            this.labelBio.Location = new System.Drawing.Point(12, 129);
            this.labelBio.Name = "labelBio";
            this.labelBio.Size = new System.Drawing.Size(54, 13);
            this.labelBio.TabIndex = 8;
            this.labelBio.Text = "Biography";
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(197, 312);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // trackBarStrength
            // 
            this.trackBarStrength.Location = new System.Drawing.Point(135, 29);
            this.trackBarStrength.Maximum = 100;
            this.trackBarStrength.Minimum = 1;
            this.trackBarStrength.Name = "trackBarStrength";
            this.trackBarStrength.Size = new System.Drawing.Size(145, 45);
            this.trackBarStrength.TabIndex = 10;
            this.trackBarStrength.Value = 50;
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Location = new System.Drawing.Point(184, 13);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(47, 13);
            this.labelStrength.TabIndex = 11;
            this.labelStrength.Text = "Strength";
            // 
            // NewCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 350);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.trackBarStrength);
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
            this.Name = "NewCharacterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Character";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStrength)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBarStrength;
        private System.Windows.Forms.Label labelStrength;
    }
}