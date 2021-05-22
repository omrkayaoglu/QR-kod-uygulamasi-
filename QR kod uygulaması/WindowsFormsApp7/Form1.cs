using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //İndirdiğimiz kütüphaneden QRCodeEncoder adındaki class tan QR adında eleman oluşturduk.
        QRCodeEncoder QR = new QRCodeEncoder();
        //İndirdiğimiz kütüphaneden Image adındaki class tan Resim adında eleman çağırdık.
        Image Resim;
        //Label oluşturduk,oluşturcağımız QR ın içeriğini yazdığımız yer.
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        //Buton oluşturduk, butona tıkladığımızda içindeki kodlar aktif oluyor.
        private void button1_Click(object sender, EventArgs e)
        {
            //QR elemanının Encode metodunu Resim elemanına atadık. 
            Resim = QR.Encode(textBox1.Text);
            //Forma yerleştirdiğimiz picture box içine gelecek olan resmi enetgre ettik.
            pictureBox1.Image = Resim;
        }
    }
}
