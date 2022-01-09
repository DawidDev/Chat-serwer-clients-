namespace ClientApp
{
    partial class Client
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
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.MessageListClient = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSendClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSerwerIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(257, 231);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(345, 20);
            this.TextMessage.TabIndex = 0;
            // 
            // MessageListClient
            // 
            this.MessageListClient.FormattingEnabled = true;
            this.MessageListClient.Location = new System.Drawing.Point(257, 13);
            this.MessageListClient.Name = "MessageListClient";
            this.MessageListClient.Size = new System.Drawing.Size(345, 212);
            this.MessageListClient.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(18, 228);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Połącz";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSendClient
            // 
            this.btnSendClient.Location = new System.Drawing.Point(527, 257);
            this.btnSendClient.Name = "btnSendClient";
            this.btnSendClient.Size = new System.Drawing.Size(75, 23);
            this.btnSendClient.TabIndex = 3;
            this.btnSendClient.Text = "Wyślij";
            this.btnSendClient.UseVisualStyleBackColor = true;
            this.btnSendClient.Click += new System.EventHandler(this.btnSendClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nick";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(91, 60);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(145, 20);
            this.txtNick.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Klient serwera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP serwera";
            // 
            // textSerwerIP
            // 
            this.textSerwerIP.Location = new System.Drawing.Point(91, 86);
            this.textSerwerIP.Name = "textSerwerIP";
            this.textSerwerIP.Size = new System.Drawing.Size(145, 20);
            this.textSerwerIP.TabIndex = 8;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 295);
            this.Controls.Add(this.textSerwerIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendClient);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.MessageListClient);
            this.Controls.Add(this.TextMessage);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.ListBox MessageListClient;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSendClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSerwerIP;
    }
}

