using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yaffle
{
    public partial class frmYaffle : Form
    {
        private CYaffleCore _yc = new CYaffleCore();

        public frmYaffle()
        {
            InitializeComponent();
        }

 
        private void lvwOutput_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lvwOutput_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                _yc.Series = txtSeriesName.Text.Trim();
                _yc.Season = Convert.ToInt32(txtSeason.Text.Trim());
                _yc.Episode = Convert.ToInt32(txtBaseEpisode.Text.Trim());

                foreach (string file in files)
                {
                    _yc.addOriginalFile(file);
                }

                refreshDisplay();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _yc.reset();
            refreshDisplay();
        }

        private void refreshDisplay()
        {
            txtSeriesName.Text = _yc.Series;
            txtSeason.Text = _yc.Season.ToString();
            txtBaseEpisode.Text = _yc.Episode.ToString();

            lvwOutput.Items.Clear();
            
            List<CFile> files = _yc.getFiles();
            foreach (CFile file in files)
            {
                ListViewItem lvItem = new ListViewItem(file.OriginalName);
                lvItem.SubItems.Add(Path.GetFileName(file.UpdatedName));
                lvwOutput.Items.Add(lvItem);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            List<CFile> files = _yc.getFiles();
            foreach (CFile file in files)
            {
                File.Move(file.OriginalName, file.UpdatedName);
            }

            MessageBox.Show("Work complete!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _yc.reset();
            refreshDisplay();            
        }
    }
}
