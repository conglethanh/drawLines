using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGraphics
{
    public partial class HDSD : Form
    {
        public HDSD()
        {
            InitializeComponent();
            lb_HDSD.Text = "-     Nút Input Line: nhập vào điểm đầu và điểm cuối của đường thẳng cần vẽ và chọn thuật toán để vẽ\n"
                          +"-     Nút Input Circle: nhập vào tâm và bán kính đường tròn\n"
                          +"-     Nút Input Ellipse: nhập vào tâm, độ dài bán trục lớn (a) và bán trục nhỏ (b)\n"
                          +"-     Nút Input Parabol: nhập vào đỉnh parabol và hệ số a tương ứng CT: y=a(x-x0)^2 +y0\n"
                          +"-     Nút Input Hyperbol: nhập vào tâm, độ dài trục thực (a) và độ dài trục ảo (b)\n\n"
                          +"-     ListBox: chứa đối tượng để vẽ, nếu chọn 'All' sẽ vẽ tất cả các đường với Input đã nhập, nếu chưa\n"
                          +"nhập input từ các nút trên thì sẽ vẽ với thông số mặc định. Nếu chọn 'Line' sẽ vẽ đường thẳng, tương tự\n"
                          +"với những item còn lại\n\n"
                          +"-     Nút Draw: tiến hành vẽ \n"
                          +"-     Nút Clear: xóa tất cả hình đã vẽ\n\n"
                          +"Quy trình vẽ một đối tượng đường: Nhập input -> Chọn item cần vẽ từ ListBox -> Nhấn nút 'Draw'.\n"
                          +"Nếu muốn vẽ ngay lập tức với thông số mặc định mà không cần input: Chọn item từ ListBox -> 'Draw'.\n\n"
                          +"Tính năng random đối tượng và tính thời gian chạy (đối tượng có chữ Time) hoặc độ sai số (Accuracy):\n"
                          +"-     Nhấn 'Random Options' -> Chọn đối tượng muốn Random (Time - Line, Time - Circle, ...) \n"
                          +" để đo thời gian chạy hoặc (Accuracy - Line) để tính độ sai số giữa điểm thực của đường thẳng và pixel\n"
                          + "-> Chọn số đối tượng -> OK -> Nhấn nút 'Statistic' để tiến hành chạy random vẽ ra các đường. \n"
                          +"Khi chạy xong sẽ thông báo thời gian chạy hoặc độ sai số của các thuật toán.";
        }

        private void lb_HDSD_Click(object sender, EventArgs e)
        {

        }

        private void HDSD_Load(object sender, EventArgs e)
        {

        }
    }
}
