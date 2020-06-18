using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;

namespace BLT.Components
{
    public partial class PersonComboBox : UserControl
    {
        ICollection<PersonOld> source;

        public PersonComboBox()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBox.DisplayMember = "DisplayName";
        }

        [Browsable(true)]
        public ICollection<PersonOld> Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                comboBox.DataSource = source;
            }
        }

        [Browsable(true)]
        public override string Text
        {
            get
            {
                return label.Text;
            }
            set
            {
                Int32 oldWidth = label.Width;
                
                label.Text = value;

                Int32 diff = label.Width - oldWidth;

                comboBox.Location = new Point(comboBox.Location.X + diff, comboBox.Location.Y);
                comboBox.Width -= diff;
            }
        }

        public PersonOld SelectedPerson
        {
            get
            {
                return ((PersonOld)this.comboBox.SelectedItem);
            }
            set
            {
                if (this.source.Contains(value))
                {
                    this.comboBox.SelectedItem = value;
                }
            }
        }

        public Int32 SelectedID
        {
            get
            {
                return SelectedPerson.ID;
            }
        }
    }
}
