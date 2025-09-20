namespace Lab5_LauzCarlStephen;

public partial class TO_DO : Form {
    private int idNum = 0;
    public TO_DO() {
        InitializeComponent();
    }

    private void addtaskbtn_Click(object sender, EventArgs e) {
        string taskText = taskInput.Text; 
        idNum++; // Increment evey time button is clicked
        
        // Validate input
        if(string.IsNullOrWhiteSpace(taskText)) {
            MessageBox.Show("Please enter a valid task.");
            return;
        }
        
        // Add the task to the ListView
       ListViewItem item = new ListViewItem(idNum.ToString());
       item.SubItems.Add(taskText);
       
       taskInput.Clear(); // Clear the input box after adding the task
       listView1.Items.Add(item);
       
    }
}