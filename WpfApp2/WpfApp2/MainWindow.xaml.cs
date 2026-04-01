using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !listNames.Items.Contains(txtName.Text))
            {
                listNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
            else {

                MessageBox.Show("输入的值不合法或值已经存在");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // 1. 逻辑判断：检查用户是否在列表里选中了东西
            // listNames.SelectedIndex 如果等于 -1，表示什么都没选
            if (listNames.SelectedIndex != -1)
            {
                // 2. 执行动作：从集合中移除选中的那一项
                // RemoveAt 是 List 常用方法，根据“索引号”删除
                listNames.Items.RemoveAt(listNames.SelectedIndex);
            }
            else
            {
                // 3. 反馈：如果没选，弹窗提示
                MessageBox.Show("请先选中一个名字再删除哦！");
            }
        }
    }
}