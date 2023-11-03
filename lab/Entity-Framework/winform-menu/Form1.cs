namespace winform_menu {
    public partial class Form1 : Form {
        public Form1() {
            // Make the Form an MDI parent.
            this.IsMdiContainer = true;


  
          

            MenuStrip ms = new MenuStrip();
            ToolStripMenuItem windowMenu = new ToolStripMenuItem("Window");
            ToolStripMenuItem windowNewMenu = new ToolStripMenuItem("New", null, new EventHandler(windowNewMenu_Click));
            ToolStripMenuItem windowNewMenu1 = new ToolStripMenuItem("File", null, new EventHandler(windowNewMenu_Click));
            windowMenu.DropDownItems.Add(windowNewMenu);
            windowMenu.DropDownItems.Add(windowNewMenu1);


            ms.MdiWindowListItem = windowMenu;

            ms.Items.Add(windowMenu);

            ms.Dock = DockStyle.Top;


            this.Controls.Add(ms);
        }

        void windowNewMenu_Click(object sender, EventArgs e) {
            Form f = new Form();
            f.MdiParent = this;
            f.Text = "Form - " + this.MdiChildren.Length.ToString();
            f.Show();
        }
    }
}