using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCapsule
{
    public partial class ReadNoteForm : Form
    {
        private NoteModel noteModel;
        public ReadNoteForm(NoteModel noteModel)
        {
            this.noteModel = noteModel;
            InitializeComponent();
        }

        private void ReadNoteForm_Load(object sender, EventArgs e)
        {
            lblDisplay.Text = noteModel.display_date.ToString().Split(' ')[0];
            lblNote.Text = noteModel.note;
            lblCreated.Text =noteModel.created_at.ToString().Split(' ')[0]; 
        }

        private void ReadNoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form kapatılmadan önce yapılacak işlemler burada olacak
            DialogResult result = MessageBox.Show("Are you sure you want to close the form?\nIf you close the form,You can't read the note again. ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kullanıcı "Hayır" butonuna bastıysa formun kapanmasını engelle
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Formun kapatılmasını iptal et
            }
        }
    }
}
