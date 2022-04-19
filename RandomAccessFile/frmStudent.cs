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

namespace RandomAccessFile
{
    public partial class frmStudent : Form
    {
        public int pos = 0;
        private StreamReader file;
        private StreamWriter fileOut;
        FileStream fn;
        BinaryReader br;
        student stu;
        String fileName = "StudentData.dat";
        FileStream fout;
        BinaryWriter bw;
        public frmStudent()
        {
            InitializeComponent();
            ReadCount();
            stu = new student();
        }

        private void ReadCount()
        {
            try
            {
                string count = "";
                if(File.Exists("RecordCount.txt"))
                {
                    file = new StreamReader("RecordCount.txt");
                    while((count = file.ReadLine()) != null)
                    {
                        pos = Convert.ToInt32(count);
                    }
                }
                file.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occured accessing " +
                    "the file");
            }
   
        }
        private void RecordCount()
        {
            try
            {
                fileOut = new StreamWriter("RecordCount.txt");
                fileOut.WriteLine(pos);
                fileOut.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("The following error has occured: " 
                    + ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addRecord();
        }
        
        private void addRecord()
        {
            stu.Stnumber = this.txtNumber.Text;
            stu.Stname = this.txtName.Text;
            stu.Test = Convert.ToDouble(this.txtTest.Text);
            stu.Assignment = Convert.ToDouble(
                this.txtAssignment.Text);
            pos += 1; // update position

            writeToFile("StudentData.dat", stu, pos, stu.size);
            RecordCount();
            MessageBox.Show("Student information captured " +
                "successfully");
        }

        private void writeToFile(string filename, 
            student obj, int pos, int size)
        {
            fout = new FileStream(filename, FileMode.Append,
                FileAccess.Write);
            bw = new BinaryWriter(fout);
            fout.Position = pos * size;
            bw.Write(obj.Stnumber);
            bw.Write(obj.Stname);
            bw.Write(obj.Test.ToString());
            bw.Write(obj.Assignment.ToString());
            bw.Close();
            fout.Close();
        }

        private void btnSearchRec_Click(object sender, EventArgs e)
        {
            try
            {
                this.lstReport.Items.Clear();
                fn = new FileStream(fileName, FileMode.Open,
                    FileAccess.Read);
                br = new BinaryReader(fn);
                int positionInFile = Convert.ToInt32(
                    this.txtRecord.Text);
                fn.Seek(positionInFile * stu.size, 0);
                stu.Stnumber = br.ReadString().ToString();
                stu.Stname = br.ReadString().ToString();
                stu.Test = Convert.ToDouble(br.ReadString().ToString());
                stu.Assignment = Convert.ToDouble(
                    br.ReadString().ToString());

                this.lstReport.Items.Add("STUDENT NUMBER: " +
                    stu.Stnumber);
                this.lstReport.Items.Add("STUDENT NAME: " + 
                    stu.Stname);
                this.lstReport.Items.Add("AVERAGE: " + (stu.Test +
                    stu.Assignment) / 2 + "%");
                this.lstReport.Items.Add("--------------------------------------");

                br.Close();
                fn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry that record cannot be retrieved!");
            }
        }

        private void btnSearchNum_Click(object sender, EventArgs e)
        {
            try
            {
                this.lstReport.Items.Clear();
                String filename = "StudentData.dat";
                string sn = (this.txtNumber.Text);
                fn = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fn);

                for (int x = 1; x <= pos; x++)
                {
                    fn.Seek(x * stu.size, 0);
                    stu.Stnumber = br.ReadString().ToString();
                    if (stu.Stnumber == sn)
                    {
                        stu.Stname = br.ReadString().ToString();
                        stu.Test = Convert.ToDouble(br.ReadString().ToString());
                        stu.Assignment = Convert.ToDouble(br.ReadString().ToString());

                        this.lstReport.Items.Add("STUDENT NUMBER: " + stu.Stnumber);
                        this.lstReport.Items.Add("STUDENT NAME: " + stu.Stname);
                        this.lstReport.Items.Add("AVERAGE: " + (stu.Test + stu.Assignment) / 2 + "%");
                        this.lstReport.Items.Add("--------------------------------------");

                    }
                }
                br.Close();
                fn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry that record cannot be retrieved!");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                this.lstReport.Items.Clear();
                String filename = "StudentData.dat";
               
                fn = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fn);

                for (int x = 1; x <= pos; x++)
                {
                        fn.Seek(x * stu.size, 0);
                        
                        stu.Stnumber = br.ReadString().ToString();
                        stu.Stname = br.ReadString().ToString();
                        stu.Test = Convert.ToDouble(br.ReadString().ToString());
                        stu.Assignment = Convert.ToDouble(br.ReadString().ToString());

                        this.lstReport.Items.Add("STUDENT NUMBER: " + stu.Stnumber);
                        this.lstReport.Items.Add("STUDENT NAME: " + stu.Stname);
                        this.lstReport.Items.Add("AVERAGE: " + (stu.Test + stu.Assignment) / 2 + "%");
                        this.lstReport.Items.Add("--------------------------------------");

                }
                br.Close();
                fn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry that record cannot be retrieved!");
            }
        
        }
    }
}
