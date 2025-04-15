namespace FA_18C_WAB_P
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewGroup listViewGroup1 = new ListViewGroup("A/A Weapons", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem("AIM-9X");
            ListViewItem listViewItem2 = new ListViewItem("AIM-9M");
            ListViewItem listViewItem3 = new ListViewItem("AIM-9L");
            TreeNode treeNode1 = new TreeNode("AIM-9X");
            TreeNode treeNode2 = new TreeNode("AIM-9L");
            TreeNode treeNode3 = new TreeNode("A/A", new TreeNode[] { treeNode1, treeNode2 });
            comboBox1 = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            colorDialog1 = new ColorDialog();
            listView1 = new ListView();
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "AIM-9X", "AIM-9L", "AIM-9M", "TCMI Pod" });
            comboBox1.Location = new Point(68, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // listView1
            // 
            listViewGroup1.Header = "A/A Weapons";
            listViewGroup1.Name = "A/A Weapons";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(406, 77);
            listView1.Name = "listView1";
            listView1.Size = new Size(340, 249);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(144, 306);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "AIM-9X";
            treeNode2.Name = "Node2";
            treeNode2.Text = "AIM-9L";
            treeNode3.Name = "Node0";
            treeNode3.Text = "A/A";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3 });
            treeView1.Size = new Size(182, 146);
            treeView1.TabIndex = 2;
            treeView1.AfterSelect += treeView1_AfterSelect_1;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Name = "Test";
            Text = "Test";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ColorDialog colorDialog1;
        private ListView listView1;
        private TreeView treeView1;
    }
}