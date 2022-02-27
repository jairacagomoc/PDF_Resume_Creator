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
using Newtonsoft.Json;

namespace PDF_Resume_Creator
{
    public partial class Form1 : Form
    {
        private readonly string _path = $"C:\\Documents\\5th 1st Sem\\Object-Oriented Programming\\PDF_Resume_Creator\\PDF_Resume_Creator\\Resume.json;";
        
        public Form1()
        {
            InitializeComponent();
           
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                richTextBox1.Text = jsonFromFile;

                var resumeFromJson = JsonConvert.DeserializeObject< Resume >(jsonFromFile);
            }
            catch(Exception ex)
            {
                //ignored
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Resume
    {
        public List<BASIC_INFORMATION> BASIC_INFORMATION { get; set; }
        public List <EDUCATIONAL_BACKGROUND> EDUCATIONAL_BACKGROUND { get; set; }
        public List <SKILLS> SKILLS { get; set; }
    }
    public class BASIC_INFORMATION
    {
        public Name Name { get; set; }
        public Address Address { get; set; }
        public Birthday Birthday { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
    }
    public class Name
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
    public class Address
    {
        public string FirstName { get; set; }
    }
    public class Birthday
    {
        public string FirstName { get; set; }
    }
    public class EDUCATIONAL_BACKGROUND
    {
    public List <Tertiary> Tertiary { get; set; }
    public List <Secondary> Secondary { get; set; }
}
    public class Tertiary
    {
        public string School { get; set; }
        public int Year_Graduated { get; set; }
    }
    public class Secondary
    {
        public string School { get; set; }
        public int Year_Graduated { get; set; }
    }
    public class SKILLS
{
    public string Computer_Literate { get; set; }
    public string Others { get; set; }
}

}
