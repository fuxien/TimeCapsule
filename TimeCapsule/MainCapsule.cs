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
    public partial class TimeCapsule : Form
    {
        List<NoteModel> nowNotes;
        List<NoteModel> futureNotes;
        List<NoteModel> pastNotes;
        public TimeCapsule()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNote.Text))
            {
                NoteModel noteModel = new NoteModel(txtNote.Text,displayDateTimePicker.Value.Date,DateTime.Now);
                noteModel.Save();
                LoadNotes();
                txtNote.Text = "";
            }
            
        }

        private void TimeCapsule_Load(object sender, EventArgs e)
        {
            displayDateTimePicker.MinDate = DateTime.Now.AddDays(1);
            LoadNotes();
            DataGridViewsSetup();
            
        }
        private void DataGridViewsSetup()
        {
            pastDataGridView.Columns[4].Visible = false;
            pastDataGridView.Columns[1].Visible = false;
            futureDataGridView.Columns[4].Visible = false;
            futureDataGridView.Columns[1].Visible = false;
            nowDataGridView.Columns[4].Visible = false;
            nowDataGridView.Columns[1].Visible = false;
            pastDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            futureDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            nowDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadNotes() {
            LoadNowNotes(DateTime.Now.Date.ToString().Split(' ')[0].Split('.'));
            LoadPastNotes(DateTime.Now.Date.ToString().Split(' ')[0].Split('.'));
            LoadFutureNotes(DateTime.Now.Date.ToString().Split(' ')[0].Split('.'));

            tabPage1.Text = "NOW (" + nowNotes.Count.ToString() + ")";
            tabPage2.Text = "PAST (" + pastNotes.Count.ToString() + ")";
            tabPage3.Text = "FUTURE (" + futureNotes.Count.ToString() + ")";
        }

        private void LoadPastNotes(string[] parsedDate)
        {
            pastNotes = NoteModel.SelectQuery(null, new Dictionary<string, object> { { "display_date", parsedDate[2] + "." + parsedDate[1] + "." + parsedDate[0] } }, "display_date<@display_date and unread=1 order by created_at");
            pastDataGridView.DataSource = pastNotes;
        }
        private void LoadFutureNotes(string[] parsedDate)
        {
            futureNotes = NoteModel.SelectQuery(null, new Dictionary<string, object> { { "display_date", parsedDate[2] + "." + parsedDate[1] + "." + parsedDate[0] } }, "display_date>@display_date and unread=1 order by display_date");
            futureDataGridView.DataSource = futureNotes;
        }
        private void LoadNowNotes(string[] parsedDate)
        {
            nowNotes = NoteModel.SelectQuery(null, new Dictionary<string, object> { { "display_date", parsedDate[2]+"."+parsedDate[1]+"."+parsedDate[0] } }, "display_date=@display_date and unread=1 order by created_at");
            nowDataGridView.DataSource = nowNotes;
        }

        private void nowDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex < 0)
            { 
                NoteModel noteModel = nowNotes[e.RowIndex];
                ShowReadForm(noteModel);
            }
        }

        private void pastDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex < 0)
            {
                NoteModel noteModel = pastNotes[e.RowIndex];
                ShowReadForm(noteModel);
            }
        }

        private void ShowReadForm(NoteModel noteModel)
        {
            ReadNoteForm readNoteForm = new ReadNoteForm(noteModel);
            readNoteForm.ShowDialog();
            noteModel.unread = 0;
            noteModel.Save();
            LoadNotes();
        }
    }
}
