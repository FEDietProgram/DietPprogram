using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFEDiet
{
    public partial class FormAboutUs : Form
    {
        public FormAboutUs()
        {
            InitializeComponent();
        }

        private void FormAboutUs_Load(object sender, EventArgs e)
        {
            rtxtAboutUs.Text = "Her yaş grubu ve cinsiyet için gerekli sağlık bakanlığı tarafından onaylanmış veriler ile beslenme düzeni hakkında kullanıcıya geri bildirimler yaparak öğünlerinde dikkat etmesi gereken noktaları kullanıcılara bildiriyor. Bunların dışında kullanıcı istediği öğün, gün, hafta veya ay için önceki bilgilerini FEDiet için özel olarak ünlü yazılımcılar Fatma Eraslan ve Esra Yazıcı tarafından oluşturulmuş güvenilir veri tabanı sistemi ve ileri teknoloji programlama araçları sayesinde görüntüleyip gerekli düzenlemeleri yapabiliyor. Kullanıcının beslenme düzeni ile hedefine yaklaşım yüzdesinin düzenli olarak güncellenebilmesi kullanıcının uygulamayı rahatça kullanabilmesini sağlamaktadır.";
        }
    }
}
