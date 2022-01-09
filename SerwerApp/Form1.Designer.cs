namespace SerwerApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MessageList = new System.Windows.Forms.ListBox();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.btnSendServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAdressIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNickSerwer = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // MessageList
            // 
            this.MessageList.FormattingEnabled = true;
            this.MessageList.Location = new System.Drawing.Point(257, 13);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(345, 212);
            this.MessageList.TabIndex = 0;
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(257, 231);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(345, 20);
            this.MessageText.TabIndex = 1;
            // 
            // btnSendServer
            // 
            this.btnSendServer.Location = new System.Drawing.Point(527, 257);
            this.btnSendServer.Name = "btnSendServer";
            this.btnSendServer.Size = new System.Drawing.Size(75, 23);
            this.btnSendServer.TabIndex = 2;
            this.btnSendServer.Text = "Wyślij";
            this.btnSendServer.UseVisualStyleBackColor = true;
            this.btnSendServer.Click += new System.EventHandler(this.btnSendServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serwer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nick";
            // 
            // textAdressIP
            // 
            this.textAdressIP.Location = new System.Drawing.Point(91, 86);
            this.textAdressIP.Name = "textAdressIP";
            this.textAdressIP.Size = new System.Drawing.Size(145, 20);
            this.textAdressIP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres IP";
            // 
            // txtNickSerwer
            // 
            this.txtNickSerwer.Location = new System.Drawing.Point(91, 56);
            this.txtNickSerwer.Name = "txtNickSerwer";
            this.txtNickSerwer.Size = new System.Drawing.Size(145, 20);
            this.txtNickSerwer.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 293);
            this.Controls.Add(this.txtNickSerwer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAdressIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendServer);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.MessageList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MessageList;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Button btnSendServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAdressIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNickSerwer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

