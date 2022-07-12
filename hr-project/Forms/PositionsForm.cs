using hr_project.Data;
using hr_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hr_project.Forms
{
    public partial class PositionsForm : Form
    {
        private int? _idPosition = null;
        public PositionsForm()
        {
            InitializeComponent();
        }

        private void PositionsForm_Load(object sender, EventArgs e)
        {
            using (var context = new hrDBContext())
            {
                var positions = context.Positions.ToList<Position>();

                PositionsGridView.Rows.Clear();

                foreach (var position in positions)
                {
                    string[] dataOut =
                    {
                        position.Id.ToString(),
                        position.JobTitle
                    };
                    PositionsGridView.Rows.Add(dataOut);
                }
            }
        }

        private void AddPositionButton_Click(object sender, EventArgs e)
        {
            if (PositionAddingTextBox.Text == "")
            {
                MessageBox.Show("Enter some name of position before adding");
                return;
            }
            using (var context = new hrDBContext())
            {
                Position position = new Position()
                {
                    JobTitle = PositionAddingTextBox.Text
                };

                context.Positions.Add(position);
                context.SaveChanges();

                PositionsForm_Load(sender, e);
            }
        }

        private void PositionsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            _idPosition = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

            PositionNameTextBox.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (_idPosition is null)
            {
                MessageBox.Show("Pick some position in grid");
                return;
            }

            using (var context = new hrDBContext())
            {
                var position = context.
                    Positions.FirstOrDefault(i => i.Id == _idPosition);

                position.JobTitle = PositionNameTextBox.Text;

                context.Positions.Update(position);
                context.SaveChanges();

                PositionsForm_Load(sender, e);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_idPosition is null)
            {
                MessageBox.Show("Pick some position in grid");
                return;
            }

            using (var context = new hrDBContext())
            {
                var position = context.
                    Positions.FirstOrDefault(i => i.Id == _idPosition);

                context.Positions.Remove(position);
                context.SaveChanges();

                PositionNameTextBox.Text = "";
                _idPosition = null;

                PositionsForm_Load(sender, e);
            }
        }
    }
}
