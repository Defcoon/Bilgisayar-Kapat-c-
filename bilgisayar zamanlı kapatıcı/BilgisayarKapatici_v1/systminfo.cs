using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;


namespace BilgisayarKapatici_v1
{
    public partial class systminfo : Form
    {
        public systminfo()
        {
            InitializeComponent();
            string[] tablo = { "Processor", "BaseBoard", "DiskDrive", "VideoController", "PhysicalMedia", "BIOS", "OperatingSystem" };
            comboBox1.Items.AddRange(tablo);
            //Hangi donanım birimini seçeceğimizi belirlemek için combobox1 i dolduruyoruz.
            string[] ozellik = { "ProcessorId", "Product", "Manufacturer", "Signature", "Caption", "SerialNumber", "Version" };
            comboBox2.Items.AddRange(ozellik);
            //Hangi donanım özelliğini seçeceğimizi belirlemek için combobox2 i dolduruyoruz.
            //Unutmayalım ki bazı donanım özellikleri sadece belli donanımda görüntülenir.Örneğin
            //Processor(işlemci)-Processorid(işlemciid) ile çalışır.
        }

        private void systminfo_Load(object sender, EventArgs e)
        {
            
        }
        private static string Getir(string TableName, string MethodName)
        {
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * from Win32_" + TableName);
            //ManagementObjectSearcher sınıfımız bize Win32 tablosundaki bilgileri bularak çekmemizi sağlıyor.
            foreach (ManagementObject MO in MOS.Get())
            //foreach döngüsü ile çekilen yönetim öğeleri arasından sadece istediklerimizi seçiyoruz.
            {
                try
                {
                    return MO[MethodName].ToString();
                    //Sadece istenen özellik bulunup geri döndürülüyor.
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message);
                }
            }
            return "";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            label5.Text = Getir(comboBox1.Text, comboBox2.Text);
            //Combobox da seçilen veriler Getir Fonksiyonuna gönderiliyor.
        }
    }
}
