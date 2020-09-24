using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tests
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //2
        //public readonly static int test = 10;
        //public const int test_const = 20;
        private void button1_Click(object sender, EventArgs e)
        {
           // test = 11;//присваивание значение доступному только для чтения статическому полю допускается только с статическом конструкторе или в инициализаторе переменных
           // test_const = 21;//левая часть выражения должна быть переменной, свойством или индексатором
            variableKey key = new variableKey();
            
            values Eleven = new values(12);            
            label1.Text = Eleven.GetValue(key.KeyInteger());
            button1.Text = Eleven.GetValue(key.KeyString());
        }
        
    }

}
class variableKey
{
    string keyS = "string";
    string keyI = "int";
    public string KeyString()
    {
        return this.keyS.ToString();
    }
    public string KeyInteger()
    {
        return this.keyI.ToString();
    }
}
class values //класс
{
    public int test = 10;
    public string test_string = "20";
    

    public string GetValue(string key)
    {
        if (key == "int") return this.test.ToString();
        if (key == "string") return this.test_string;
        return "";
    }
    public values(int twelvty)// коструктор 1
    {
        this.test = twelvty;
    }
}
