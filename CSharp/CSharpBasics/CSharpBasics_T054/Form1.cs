using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasics_T054
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                String TypeName = this.textBox1.Text;
                Type T = Type.GetType(TypeName);
                foreach (MethodInfo method in T.GetMethods())
                {
                    listBox1.Items.Add(method.ReturnType + " "+ method.Name);
                }

                foreach (ConstructorInfo constructor in T.GetConstructors())
                {
                    listBox3.Items.Add(constructor.ToString());
                }
                foreach (PropertyInfo prop in T.GetProperties())
                {
                    listBox2.Items.Add(prop.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while finding the type: "+ ex.Message);
            }

        }
    }
}
