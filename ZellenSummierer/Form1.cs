using System.Diagnostics;
namespace ZellenSummierer
{
    public partial class Form1 : Form
    {
        string path;
        List<string> liste = new List<string>();
        string[] listarr;
        double summe = 0;
        public Form1()
        {
            

            InitializeComponent();
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);

        }

        private void listView1_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
            string path = item.Text;
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "excel"; // "EXCEL.EXE" also works
            ps.Arguments = path;
            ps.UseShellExecute = true;
            Process.Start(ps);
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            if(liste.Count > 0)
            {
                liste.Clear();
                Array.Clear(listarr);
                summe = 0;
                listView1.Items.Clear();
            }
            
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                labelPfad.Text = dialog.SelectedPath;
            path = dialog.SelectedPath;
            liste = FileListe(path);

           // fileListBox.DataSource = liste;
        }
        public List<string> FileListe(string path)
        {
            listarr = Directory.GetFiles(path);
            foreach(string _file in listarr)
            {
                if (_file.Substring(_file.Length -3) == "ods")
                {
                    liste.Add(_file);
                }
            }
            return liste;
        }

        private void buttonSumme_Click(object sender, EventArgs e)
        {
            
                foreach (string _file in liste)
                {
                    double test = OsdReader.TotalBruto(@_file);
                    ListViewItem item = new ListViewItem(_file);
                    item.SubItems.Add(test.ToString() + " €");
                    listView1.Items.Add(item);
                    summe += test;
                    
                }
            textBoxSumme.Text = Math.Round(summe,2).ToString() + " €";
            label1.Text = $"{liste.Count} Rechnungen gefunden";
        }
        
      
            
        }
    }
