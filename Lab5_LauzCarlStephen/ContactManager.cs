namespace Lab5_LauzCarlStephen;

public partial class ContactManager : Form {
    public ContactManager() {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
        // Get input values
        string name = nameInput.Text;
        string number = numberInput.Text;
        string email = emailInput.Text;
        
        // Validate inputs
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(number) || string.IsNullOrWhiteSpace(email)) {
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Store values in the ListView
        var item = new ListViewItem(new[] { name, number, email });
        contactTable.Items.Add(item);
        
        // Clear input fields
        ClearInputs();
    }
    
    public void ClearInputs() {
        nameInput.Text = "";
        numberInput.Text = "";
        emailInput.Text = "";
    }
    
    private void deleteBtn_Click(object sender, EventArgs e) {
        if (contactTable.SelectedItems.Count == 0) {
            MessageBox.Show("Please select a contact to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        contactTable.Items.Remove(contactTable.SelectedItems[0]);
        ClearInputs();
    }
}