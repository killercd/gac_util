using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.EnterpriseServices.Internal;
namespace GacUtil
{


    public enum MsgType {
        ERROR,
        NOTIFY

    }
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        public string PathGAC
        {
            get
            {
                return Environment.GetEnvironmentVariable("windir") + "\\assembly";
            }

        }

        public string[] AllDLLS { get; private set; }

        private void BindAutocomplete() {
            AutoCompleteStringCollection Source = new AutoCompleteStringCollection();

            List<String> ActualDllList = new List<String>();
            DataGridViewRowCollection Rows = GacDLLList.Rows;

            foreach (DataGridViewRow row in Rows)
            {
                if (row.Cells.Count > 0)
                {
                    if(row.Cells[0].Value!=null)
                        ActualDllList.Add(ObtainFileName(row.Cells[0].Value.ToString()));

                }
                    
            }
            
            Source.AddRange(ActualDllList.ToArray());
            txtSearch.AutoCompleteCustomSource = Source;
           


        }

        private void LoadDLLFiles() {
           AllDLLS = Directory.GetFiles(PathGAC, "*.dll", SearchOption.AllDirectories);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDLLFiles();
            GacDLLList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

        }
        
        private void BindData(String filter)
        {
            GacDLLList.Columns.Clear();
            GacDLLList.Rows.Clear();
            GacDLLList.Columns.Add("File", "File");
            GacDLLList.Columns[0].Width = this.Width - 40;
            filter = filter.ToLower();
            foreach (String ComponentName in AllDLLS)
            {

                if (GAC.Checked && ComponentName.ToLower().Contains("\\gac\\") && ComponentName.ToLower().Contains(filter))
                {
                    addRow(ComponentName);
                }
                if (GAC_32.Checked && ComponentName.ToLower().Contains("\\gac_32\\") && ComponentName.ToLower().Contains(filter))
                {
                    addRow(ComponentName);
                }
                if (GAC_MSIL.Checked && ComponentName.ToLower().Contains("\\gac_msil\\") && ComponentName.ToLower().Contains(filter))
                {
                    addRow(ComponentName);
                }
                if (chkGac64.Checked && ComponentName.ToLower().Contains("\\gac_64\\") && ComponentName.ToLower().Contains(filter))
                {
                    addRow(ComponentName);
                }
            }
            BindAutocomplete();


        }

        private void addRow(string componentName)
        {
            String[] row = { componentName };
            GacDLLList.Rows.Add(row);
        }

      

        private void GAC_32_CheckedChanged(object sender, EventArgs e)
        {
            BindData(txtSearch.Text.Trim().ToLower());
        }

        private void GAC_CheckedChanged(object sender, EventArgs e)
        {
            BindData(txtSearch.Text.Trim().ToLower());
        }

        private void GAC_MSIL_CheckedChanged(object sender, EventArgs e)
        {
            BindData(txtSearch.Text.Trim().ToLower());
        }
        private void chkGac64_CheckedChanged(object sender, EventArgs e)
        {
            BindData(txtSearch.Text.Trim().ToLower());
        }
        private void btnCerca_Click(object sender, EventArgs e)
        {
            BindData(txtSearch.Text.Trim().ToLower());
        }

        private void btnEsporta_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewSelectedRowCollection CellCollection = GacDLLList.SelectedRows;
                List<String> ListaFile = new List<String>();

                foreach (DataGridViewRow row in CellCollection)
                {
                    ListaFile.Add(row.Cells[0].Value.ToString().Trim());

                }
                FolderBrowserDialog Browser = new FolderBrowserDialog();
                Browser.Description = "Seleziona la cartella dove esportare i moduli";
                
                DialogResult DestinationFolder = Browser.ShowDialog();
                

                if (DestinationFolder== DialogResult.OK)
                {

                    foreach (String ActualFile in ListaFile)
                    {
                        System.IO.File.Delete(Browser.SelectedPath+ObtainFileName(ActualFile));
                        System.IO.File.Copy(ActualFile, Browser.SelectedPath+"\\"+ ObtainFileName(ActualFile));

                    }
                    DisplayMessage(MsgType.NOTIFY, ListaFile.Count + " File copiati!!!");
                }
                
            }
            catch (Exception ex) {
                DisplayMessage(MsgType.ERROR, ex.Message);
            }
            



        }

        private string ObtainFileName(string actualFile)
        {
            if (!string.IsNullOrEmpty(actualFile)) {
                String[] SplitPath = actualFile.Split('\\');
                return SplitPath[SplitPath.Length - 1];
            }

            return "";
        }

        private void DisplayMessage(MsgType msgType, string message)
        {

            if(msgType==MsgType.ERROR)
                System.Windows.Forms.MessageBox.Show("Error: "+message,"Si è verificato un Errore",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
                System.Windows.Forms.MessageBox.Show(message, "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GacDLLList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Publish PublishGac = new Publish();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "dll Files|*.dll";
            dialog.RestoreDirectory = true;

            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    String[] DLLList = dialog.FileNames;
                    foreach (String DllName in DLLList)
                    {
                        PublishGac.GacInstall(DllName);
                        
                    }
                    LoadDLLFiles();
                    DisplayMessage(MsgType.NOTIFY, DLLList.Length+" Moduli installati");
                }
                
            }
            catch (Exception ex) {
                DisplayMessage(MsgType.ERROR, ex.Message);
            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            BindData(txtSearch.Text.Trim().ToLower());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindData(txtSearch.Text.Trim().ToLower());
            }
        }
    }
}
