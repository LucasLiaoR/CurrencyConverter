namespace CurrencyConverter
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCurrDepart = new System.Windows.Forms.TextBox();
            this.textBoxCurrArrivee = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.listBoxCurrDepart = new System.Windows.Forms.ListBox();
            this.listBoxCurrArrivee = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCurrDepart
            // 
            this.textBoxCurrDepart.Location = new System.Drawing.Point(82, 69);
            this.textBoxCurrDepart.Name = "textBoxCurrDepart";
            this.textBoxCurrDepart.Size = new System.Drawing.Size(167, 20);
            this.textBoxCurrDepart.TabIndex = 0;
            // 
            // textBoxCurrArrivee
            // 
            this.textBoxCurrArrivee.Location = new System.Drawing.Point(540, 69);
            this.textBoxCurrArrivee.Name = "textBoxCurrArrivee";
            this.textBoxCurrArrivee.Size = new System.Drawing.Size(167, 20);
            this.textBoxCurrArrivee.TabIndex = 1;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(315, 81);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(158, 61);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // listBoxCurrDepart
            // 
            this.listBoxCurrDepart.FormattingEnabled = true;
            this.listBoxCurrDepart.Items.AddRange(new object[] {
            "CAD",
            "HKD",
            "ISK",
            "PHP",
            "DKK",
            "HUF",
            "CZK",
            "AUD",
            "RON",
            "SEK",
            "IDR",
            "INR",
            "BRL",
            "RUB",
            "HRK",
            "JPY",
            "THB",
            "CHF",
            "SGD",
            "PLN",
            "BGN",
            "TRY",
            "CNY",
            "NOK",
            "NZD",
            "ZAR",
            "USD",
            "MXN",
            "ILS",
            "GBP",
            "KRW",
            "MYR"});
            this.listBoxCurrDepart.Location = new System.Drawing.Point(82, 129);
            this.listBoxCurrDepart.Name = "listBoxCurrDepart";
            this.listBoxCurrDepart.Size = new System.Drawing.Size(166, 212);
            this.listBoxCurrDepart.TabIndex = 3;
            // 
            // listBoxCurrArrivee
            // 
            this.listBoxCurrArrivee.FormattingEnabled = true;
            this.listBoxCurrArrivee.Items.AddRange(new object[] {
            "CAD",
            "HKD",
            "ISK",
            "PHP",
            "DKK",
            "HUF",
            "CZK",
            "AUD",
            "RON",
            "SEK",
            "IDR",
            "INR",
            "BRL",
            "RUB",
            "HRK",
            "JPY",
            "THB",
            "CHF",
            "SGD",
            "PLN",
            "BGN",
            "TRY",
            "CNY",
            "NOK",
            "NZD",
            "ZAR",
            "USD",
            "MXN",
            "ILS",
            "GBP",
            "KRW",
            "MYR"});
            this.listBoxCurrArrivee.Location = new System.Drawing.Point(540, 129);
            this.listBoxCurrArrivee.Name = "listBoxCurrArrivee";
            this.listBoxCurrArrivee.Size = new System.Drawing.Size(166, 212);
            this.listBoxCurrArrivee.TabIndex = 4;
            this.listBoxCurrArrivee.SelectedIndexChanged += new System.EventHandler(this.listBoxCurrArrivee_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Devise de départ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Devise d\'arrivée";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCurrArrivee);
            this.Controls.Add(this.listBoxCurrDepart);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.textBoxCurrArrivee);
            this.Controls.Add(this.textBoxCurrDepart);
            this.Name = "Form1";
            this.Text = "Convertisseur de devises";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCurrDepart;
        private System.Windows.Forms.TextBox textBoxCurrArrivee;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ListBox listBoxCurrDepart;
        private System.Windows.Forms.ListBox listBoxCurrArrivee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

