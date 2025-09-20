namespace Lab5_LauzCarlStephen;

public partial class Student : Form {
    public Student() {
        InitializeComponent();
    }

    private void addBtn_Click(object sender, EventArgs e) {
        // Part2
        
        // Get user input
        string id = idInput.Text;
        string name = nameInput.Text;
        string course = courseInput.Text;
        
        // Validate inputs
        if(id == "" || name == "" || course == "") {
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        // Create a new ListViewItem with the input data
        ListViewItem item = new ListViewItem(id);
        item.SubItems.Add(name);
        item.SubItems.Add(course);
        // Add the item to the ListView
        studentTable.Items.Add(item);
        ClearInputs();
    }
    
    public void ClearInputs() {
        idInput.Text = "";
        nameInput.Text = "";
        courseInput.SelectedIndex = -1; // Deselect any selected item
    }
}