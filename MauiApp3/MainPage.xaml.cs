using System.Collections.ObjectModel;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public class task
        {
            public string tsk { get; set; }
        }
        public ObservableCollection<task> Tasklist { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Tasklist = new ObservableCollection<task>();
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string addtask = taskentry.Text;
            taskentry.Text = "";
            if (addtask != null && addtask != "")
            {
                Tasklist.Add(new task { tsk = addtask });

            }
        }
    }
}
