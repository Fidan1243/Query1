using Newtonsoft.Json;
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

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person item = new Person
            {
                Name = nameBox.Text,
                Surname = snameBox.Text,
                BirthDate = DateBox.Value,
                Email = MailBox.Text,
                Phone = PhoneBox.Text
            };
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"{item.Name}.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, item);
                }
            }
            MessageBox.Show($"Added at C:../Debug/{item.Name}.json");
        }
    }
}
