namespace Lab5_LauzCarlStephen;
using System.Drawing;
public partial class Product : Form {
    private ImageList imageList;

    public Product() {
        InitializeComponent();

        // Initialize the ImageList
        imageList = new ImageList();
        imageList.ImageSize = new Size(32, 32); // size of icons

        // Load images (make sure these files exist in your project folder)
        imageList.Images.Add("laptop", Image.FromFile(@"D:\C#\Lab5_LauzCarlStephen\Lab5_LauzCarlStephen\Assets\laptop.jpg"));
        imageList.Images.Add("phone", Image.FromFile(@"D:\C#\Lab5_LauzCarlStephen\Lab5_LauzCarlStephen\Assets\smartphone.jpeg"));
        imageList.Images.Add("tablet", Image.FromFile(@"D:\C#\Lab5_LauzCarlStephen\Lab5_LauzCarlStephen\Assets\tablet.jpeg"));
        imageList.Images.Add("monitor", Image.FromFile(@"D:\C#\Lab5_LauzCarlStephen\Lab5_LauzCarlStephen\Assets\monitor.jpeg"));
        imageList.Images.Add("keyboard", Image.FromFile(@"D:\C#\Lab5_LauzCarlStephen\Lab5_LauzCarlStephen\Assets\keyboard.jpeg"));

        // Assign image list to the ListView
        listView1.SmallImageList = imageList; // for details view
        listView1.LargeImageList = imageList; // if you want large icon view
    }

    private void showBtn_Click(object sender, EventArgs e) {
        listView1.Items.Clear();

        // Create items with text + image keys
      var items = new ListViewItem[] {
            new ListViewItem(new string[] { "P001", "Laptop" }, "laptop"),
            new ListViewItem(new string[] { "P002", "Smartphone" }, "phone"),
            new ListViewItem(new string[] { "P003", "Tablet" }, "tablet"),
            new ListViewItem(new string[] { "P004", "Monitor" }, "monitor"),
            new ListViewItem(new string[] { "P005", "Keyboard" }, "keyboard")
        };

        listView1.Items.AddRange(items);
    }

    private void hidePrd_Click(object sender, EventArgs e) {
       listView1.Items.Clear();
    }
}
