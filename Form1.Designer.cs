using System;

namespace Combobox
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.annoCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TestoVisualizzatoBtn = new System.Windows.Forms.Button();
            this.RigaTxt = new System.Windows.Forms.TextBox();
            this.PosElementoSelezionatoBtn = new System.Windows.Forms.Button();
            this.TestoElementoSelezionatoBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RemoveAtBtn = new System.Windows.Forms.Button();
            this.NumRigaUD = new System.Windows.Forms.NumericUpDown();
            this.estraiRigaNBtn = new System.Windows.Forms.Button();
            this.AggiungiDopoNBtn = new System.Windows.Forms.Button();
            this.aggiungiInFondoBtn = new System.Windows.Forms.Button();
            this.elimina = new System.Windows.Forms.Button();
            this.varieBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cittàCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumRigaUD)).BeginInit();
            this.SuspendLayout();
            // 
            // annoCB
            // 
            this.annoCB.FormattingEnabled = true;
            this.annoCB.Items.AddRange(new object[] {
            "1930",
            "1931"});
            this.annoCB.Location = new System.Drawing.Point(31, 35);
            this.annoCB.Name = "annoCB";
            this.annoCB.Size = new System.Drawing.Size(150, 21);
            this.annoCB.TabIndex = 0;
            this.annoCB.Tag = "";
            this.annoCB.SelectedIndexChanged += new System.EventHandler(this.annoCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anno nascita";
            // 
            // TestoVisualizzatoBtn
            // 
            this.TestoVisualizzatoBtn.Location = new System.Drawing.Point(224, 9);
            this.TestoVisualizzatoBtn.Name = "TestoVisualizzatoBtn";
            this.TestoVisualizzatoBtn.Size = new System.Drawing.Size(201, 23);
            this.TestoVisualizzatoBtn.TabIndex = 2;
            this.TestoVisualizzatoBtn.Text = "TESTO VISUALIZZATO";
            this.TestoVisualizzatoBtn.UseVisualStyleBackColor = true;
            this.TestoVisualizzatoBtn.Click += new System.EventHandler(this.TestoVisualizzatoBtn_Click);
            // 
            // RigaTxt
            // 
            this.RigaTxt.Location = new System.Drawing.Point(224, 213);
            this.RigaTxt.Name = "RigaTxt";
            this.RigaTxt.Size = new System.Drawing.Size(201, 20);
            this.RigaTxt.TabIndex = 3;
            // 
            // PosElementoSelezionatoBtn
            // 
            this.PosElementoSelezionatoBtn.Location = new System.Drawing.Point(224, 38);
            this.PosElementoSelezionatoBtn.Name = "PosElementoSelezionatoBtn";
            this.PosElementoSelezionatoBtn.Size = new System.Drawing.Size(201, 23);
            this.PosElementoSelezionatoBtn.TabIndex = 4;
            this.PosElementoSelezionatoBtn.Text = "POS. ELEMENTO SELEZIONATO";
            this.PosElementoSelezionatoBtn.UseVisualStyleBackColor = true;
            this.PosElementoSelezionatoBtn.Click += new System.EventHandler(this.PosElementoSelezionatoBtn_Click);
            // 
            // TestoElementoSelezionatoBtn
            // 
            this.TestoElementoSelezionatoBtn.Location = new System.Drawing.Point(224, 67);
            this.TestoElementoSelezionatoBtn.Name = "TestoElementoSelezionatoBtn";
            this.TestoElementoSelezionatoBtn.Size = new System.Drawing.Size(201, 23);
            this.TestoElementoSelezionatoBtn.TabIndex = 5;
            this.TestoElementoSelezionatoBtn.Text = "TESTO ELEMENTO SELEZIONATO";
            this.TestoElementoSelezionatoBtn.UseVisualStyleBackColor = true;
            this.TestoElementoSelezionatoBtn.Click += new System.EventHandler(this.TestoElementoSelezionatoBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(114, 138);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(108, 23);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "ELIMINA TUTTE";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveAtBtn
            // 
            this.RemoveAtBtn.Location = new System.Drawing.Point(114, 167);
            this.RemoveAtBtn.Name = "RemoveAtBtn";
            this.RemoveAtBtn.Size = new System.Drawing.Size(108, 23);
            this.RemoveAtBtn.TabIndex = 7;
            this.RemoveAtBtn.Text = "ELIMINA RIGA";
            this.RemoveAtBtn.UseVisualStyleBackColor = true;
            this.RemoveAtBtn.Click += new System.EventHandler(this.RemoveAtBtn_Click);
            // 
            // NumRigaUD
            // 
            this.NumRigaUD.Location = new System.Drawing.Point(180, 213);
            this.NumRigaUD.Name = "NumRigaUD";
            this.NumRigaUD.Size = new System.Drawing.Size(42, 20);
            this.NumRigaUD.TabIndex = 8;
            this.NumRigaUD.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // estraiRigaNBtn
            // 
            this.estraiRigaNBtn.Location = new System.Drawing.Point(238, 138);
            this.estraiRigaNBtn.Name = "estraiRigaNBtn";
            this.estraiRigaNBtn.Size = new System.Drawing.Size(108, 23);
            this.estraiRigaNBtn.TabIndex = 9;
            this.estraiRigaNBtn.Text = "ESTRAI RIGA";
            this.estraiRigaNBtn.UseVisualStyleBackColor = true;
            this.estraiRigaNBtn.Click += new System.EventHandler(this.estraiRigaNBtn_Click);
            // 
            // AggiungiDopoNBtn
            // 
            this.AggiungiDopoNBtn.Location = new System.Drawing.Point(364, 138);
            this.AggiungiDopoNBtn.Name = "AggiungiDopoNBtn";
            this.AggiungiDopoNBtn.Size = new System.Drawing.Size(145, 23);
            this.AggiungiDopoNBtn.TabIndex = 10;
            this.AggiungiDopoNBtn.Text = "AGGIUNGI DOPO RIGA N";
            this.AggiungiDopoNBtn.UseVisualStyleBackColor = true;
            this.AggiungiDopoNBtn.Click += new System.EventHandler(this.AggiungiDopoNBtn_Click);
            // 
            // aggiungiInFondoBtn
            // 
            this.aggiungiInFondoBtn.Location = new System.Drawing.Point(364, 167);
            this.aggiungiInFondoBtn.Name = "aggiungiInFondoBtn";
            this.aggiungiInFondoBtn.Size = new System.Drawing.Size(145, 23);
            this.aggiungiInFondoBtn.TabIndex = 11;
            this.aggiungiInFondoBtn.Text = "AGGIUNGI IN FONDO";
            this.aggiungiInFondoBtn.UseVisualStyleBackColor = true;
            this.aggiungiInFondoBtn.Click += new System.EventHandler(this.aggiungiInFondoBtn_Click);
            // 
            // elimina
            // 
            this.elimina.Location = new System.Drawing.Point(238, 167);
            this.elimina.Name = "elimina";
            this.elimina.Size = new System.Drawing.Size(108, 23);
            this.elimina.TabIndex = 12;
            this.elimina.Text = "ELIMINA";
            this.elimina.UseVisualStyleBackColor = true;
            this.elimina.Click += new System.EventHandler(this.elimina_Click);
            // 
            // varieBtn
            // 
            this.varieBtn.Location = new System.Drawing.Point(31, 234);
            this.varieBtn.Name = "varieBtn";
            this.varieBtn.Size = new System.Drawing.Size(75, 23);
            this.varieBtn.TabIndex = 13;
            this.varieBtn.Text = "VARIE";
            this.varieBtn.UseVisualStyleBackColor = true;
            this.varieBtn.Click += new System.EventHandler(this.varieBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(514, 230);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(35, 27);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // cittàCB
            // 
            this.cittàCB.FormattingEnabled = true;
            this.cittàCB.Items.AddRange(new object[] {
            "Milano",
            "Napoli",
            "Palermo",
            "Roma"});
            this.cittàCB.Location = new System.Drawing.Point(29, 103);
            this.cittàCB.Name = "cittàCB";
            this.cittàCB.Size = new System.Drawing.Size(77, 21);
            this.cittàCB.TabIndex = 15;
            this.cittàCB.SelectedIndexChanged += new System.EventHandler(this.cittàCB_SelectedIndexChanged);
            this.cittàCB.SelectionChangeCommitted += new System.EventHandler(this.cittàCB_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "AGGIUNGI";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 269);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cittàCB);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.varieBtn);
            this.Controls.Add(this.elimina);
            this.Controls.Add(this.aggiungiInFondoBtn);
            this.Controls.Add(this.AggiungiDopoNBtn);
            this.Controls.Add(this.estraiRigaNBtn);
            this.Controls.Add(this.NumRigaUD);
            this.Controls.Add(this.RemoveAtBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.TestoElementoSelezionatoBtn);
            this.Controls.Add(this.PosElementoSelezionatoBtn);
            this.Controls.Add(this.RigaTxt);
            this.Controls.Add(this.TestoVisualizzatoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.annoCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumRigaUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.ComboBox annoCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TestoVisualizzatoBtn;
        private System.Windows.Forms.TextBox RigaTxt;
        private System.Windows.Forms.Button PosElementoSelezionatoBtn;
        private System.Windows.Forms.Button TestoElementoSelezionatoBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button RemoveAtBtn;
        private System.Windows.Forms.NumericUpDown NumRigaUD;
        private System.Windows.Forms.Button estraiRigaNBtn;
        private System.Windows.Forms.Button AggiungiDopoNBtn;
        private System.Windows.Forms.Button aggiungiInFondoBtn;
        private System.Windows.Forms.Button elimina;
        private System.Windows.Forms.Button varieBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cittàCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        public EventHandler richTextBox1_TextChanged { get; private set; }
    }
}

