using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_FMGordillo
{
    public partial class Form1 : Form
    {

        BindingList<AlumnoMateriaList> list = new BindingList<AlumnoMateriaList>();
        List<string> _items = new List<string>();

        public Form1()
        {
            InitializeComponent();

            this.comboBox_materia_nombre.DataSource = new[] { "Taller de Computacion VI",
                "Computacion Avanzada", "Seguridad e Integracion de Sistemas",
                "Tecnologia e Innovacion", "Matematica Discreta II"
            };
            this.comboBox_materia_nota.DataSource = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }



        private void button1_Click(object sender, EventArgs e)
        {

            //list.Add(new AlumnoMateriaList()
            _items.Add(this.comboBox_materia_nombre.GetItemText(this.comboBox_materia_nombre.SelectedItem).ToString() + "  |  " + 
               this.dateTimePicker_materia_fecha.Value.ToShortDateString() + "  |  " +
               this.comboBox_materia_nota.GetItemText(this.comboBox_materia_nota.SelectedItem));

            this.listBox_alumno_materia.DataSource = null;
            this.listBox_alumno_materia.DataSource = _items;
            /*
            this.listBox_alumno_materia.DataSource = new[] {
                this.comboBox_materia_nombre.GetItemText(this.comboBox_materia_nombre.SelectedItem),
                this.dateTimePicker_materia_fecha.Value.ToShortDateString(),    
                this.comboBox_materia_nota.GetItemText(this.comboBox_materia_nota.SelectedItem),
            };*/
        }
    }

    internal class AlumnoMateriaList : INotifyPropertyChanged
    {
        string nombreMateria = string.Empty;
        string fechaMateria = string.Empty;
        string notaMateria = string.Empty;

        public string NombreMateria
        {
            get { return nombreMateria; }
            set
            {
                if (value != nombreMateria)
                {
                    nombreMateria = value;
                    OnPropertyChanged("NombreMateria");
                }
            }
        }
        public string FechaMateria
        {
            get { return fechaMateria; }
            set
            {
                if (value != fechaMateria)
                {
                    fechaMateria = value;
                    OnPropertyChanged("FechaMateria");
                }
            }
        }
        public string NotaMateria
        {
            get { return notaMateria; }
            set
            {
                if (value != notaMateria)
                {
                    notaMateria = value;
                    OnPropertyChanged("NotaMateria");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
