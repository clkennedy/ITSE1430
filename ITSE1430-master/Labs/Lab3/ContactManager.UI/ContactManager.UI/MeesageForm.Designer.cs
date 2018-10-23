namespace ContactManager.UI
{
    partial class MessageForm
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
            this.lName = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(19, 23);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(43, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Subject";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(19, 66);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(50, 13);
            this.lEmail.TabIndex = 1;
            this.lEmail.Text = "Message";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(22, 39);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(283, 20);
            this.tbSubject.TabIndex = 2;
            this.tbSubject.TextChanged += new System.EventHandler(this.OnTextBoxChange);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(22, 83);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(283, 213);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.TextChanged += new System.EventHandler(this.OnTextBoxChange);
            // 
            // bSend
            // 
            this.bSend.Enabled = false;
            this.bSend.Location = new System.Drawing.Point(22, 302);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(145, 23);
            this.bSend.TabIndex = 4;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.OnSave);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(173, 302);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(132, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 336);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lName);
            this.MaximumSize = new System.Drawing.Size(350, 375);
            this.MinimumSize = new System.Drawing.Size(350, 375);
            this.Name = "MessageForm";
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}