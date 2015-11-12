using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // vogliamo evitare di pre-caricare l'app con
            // anni successivi al 2002 e posteriori al 1930

            int annoOggi = DateTime.Now.Year;
            int annoIniziale = annoOggi - 82;
            int annoFinale = annoOggi - 12;

            // aggiungiamo i vari anni alla combobox
            for (int anno = annoFinale; anno >= annoIniziale; anno--)
                annoCB.Items.Add(anno);

            // faccio in modo di precaricare un valore in partenza
            // nella combobox (in questo caso il primo)
            annoCB.SelectedIndex=0;

            // adesso configuro il numeric up/down al caricamento
            NumRigaUD.Minimum = 0; // valore numerico di partenza
            NumRigaUD.Maximum = annoCB.Items.Count - 1; // valore numerico finale


        }

        private void TestoVisualizzatoBtn_Click(object sender, EventArgs e)
        {
            // quando clicco sul bottone, il valore nella textbox
            // anno nascita verrà ricopiato sulla textbox RigaTxt
            RigaTxt.Text = annoCB.Text;
        }

        private void PosElementoSelezionatoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(annoCB.SelectedIndex.ToString());
        }

        private void TestoElementoSelezionatoBtn_Click(object sender, EventArgs e)
        {
            // non dobbiamo per scontato che ci sia un elemento selezionato
            // quindi ciclo if
            
            if(annoCB.SelectedIndex>-1)
                RigaTxt.Text = annoCB.Items[annoCB.SelectedIndex].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            annoCB.Items.Clear();
        }

        private void RemoveAtBtn_Click(object sender, EventArgs e)
        {
            // rimuovo dalla lista l'elemento di posizione dettata
            // dal valore presente in NumRigaUD
            annoCB.Items.RemoveAt((int)NumRigaUD.Value);
        }

        private void estraiRigaNBtn_Click(object sender, EventArgs e)
        {
            // aggiungo sulla textbox RigaTxt l'elemento di posizione selezionato
            // nella UD
            RigaTxt.Text = annoCB.Items[(int)NumRigaUD.Value].ToString();
        }

        private void AggiungiDopoNBtn_Click(object sender, EventArgs e)
        {
            annoCB.Items.Insert((int)NumRigaUD.Value + 1, RigaTxt.Text);
            NumRigaUD.Maximum++;
        }

        private void aggiungiInFondoBtn_Click(object sender, EventArgs e)
        {
            annoCB.Items.Add(RigaTxt.Text);
            NumRigaUD.Maximum++;
        }

        private void elimina_Click(object sender, EventArgs e)
        {
            annoCB.Items.Remove(Convert.ToInt32(RigaTxt.Text));
        }

        private void varieBtn_Click(object sender, EventArgs e)
        {

            /*
            // è possibile aggiungere a un CB una lista di un range di valori
            string[] giorniSettimana = { "Lunedi", "Martedi", "ecc." };
            annoCB.Items.AddRange(giorniSettimana);
            */


            // voglio caricare il contenuto di un file di testo
            // tramite l'utilizzo di un richTextBox
            // il file "ElencoEmail.txt" va copiato dentro debug
            richTextBox1.LoadFile("ElencoEmail.txt", RichTextBoxStreamType.PlainText);

            // le righe lette dal file verranno inserite nel CB
            // annoCB.Items.AddRange(richTextBox1.Lines);
            annoCB.Items.AddRange(richTextBox1.Text.Split(';'));

            /* il seguente è un metodo migliore per copiare il contenuto
            di un file di testo nella CB senza bisogno di utilizzare una
            richtextbox

            annoCB.Items.AddRange(new StreamReader("ElencoEmail.txt").ReadToEnd().Split(';');
            */

            /* se volessi cercare una chiave in un elenco
            if(annoCB.Items.Contains("prova@prova.it"))
                MessageBox.Show("Trovata alla posizione"+ annoCB.Items.IndexOf("prova@prova.it");
            */
        }

        private void cittàCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cittàCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("Indice elemento selezionato: " + cittàCB.SelectedIndex);
        }

        private void annoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Indice elemento selezionato: " + annoCB.SelectedIndex);
        }
    }
}