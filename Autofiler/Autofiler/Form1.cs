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

namespace AutoFiler
{
    
    
    public partial class Form1 : Form
    {
        System.String StartingDirectory;
        System.String DestinationDirectory;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Confirm Button
        {

            setStartingDirectory(textBox1.Text);//saves directory into a string
            
            Console.WriteLine("Directory: {0}", StartingDirectory);
        }

        private void button2_Click(object sender, EventArgs e) //Cancel Button
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Start directory text box
        {
         
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//End directory text box
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        void setStartingDirectory(string original)
        {
            StartingDirectory = @original;
            if(Directory.Exists(StartingDirectory))
            {
                Console.WriteLine("Directory exists");
                setDestinationDirectory(textBox2.Text);//creates new directory at this location
            }
            else
            {

                Console.WriteLine("Directory does not exist");
                InvalidDirectory error = new InvalidDirectory();
                error.ShowDialog();
                
            }

        }
        void setDestinationDirectory(string NewDir)
        {
            DestinationDirectory = @NewDir;
            //Directory.CreateDirectory(DestinationDirectory); //Creates new directory at that location

        }

    }


}
