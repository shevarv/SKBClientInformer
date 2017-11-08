using System;
using System.Threading;
using System.Windows.Forms;
using ShevarvProject.SKBClientInformerDataBaseNamespace;

namespace ShevarvProject.SKBClientInformerNamespace
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private async void  OkButton_Click(object sender, EventArgs e)
        {
            SqlExpression sq = new SqlExpression();
            await sq.SelectData(IdTextBox.Text, NameTextBox.Text, EDRPOUTextBox.Text, SkbIdTextBox.Text);
            CbUserGrid.DataSource = sq.Dt;
            ProgBar.Value = 0;
            do
            {
                if (ProgBar.Value < ProgBar.Maximum)
                {
                    ProgBar.Value += ProgBar.Step;
                    Thread.Sleep(100);
                }
                else
                {
                    ProgBar.Value = 100;
                    break;
                }
            } while (true);
            ProgBar.Value = 0;
        }



        private void MoveButton_Click(object sender, EventArgs e)
        {
            switch ((string) SearchPanel.Tag)
            {
                case "Close":
                {
                    SearchPanel.Tag = "Open";
                    MoveButton.Text = ">>";
                    SearchPanel.Width += 300;
                    break;
                }
                case "Open":
                {
                    SearchPanel.Tag = "Close";
                    MoveButton.Text = "<<";
                    SearchPanel.Width -= 300;
                    break;
                }
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'p')
            {
                MoveButton_Click(sender, e);
            }
        }

        private void CbUserGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InfoPanel.Visible = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            InfoPanel.Visible = false;
        }
    }
}
