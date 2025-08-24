namespace Project1
{
    partial class Funiture
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
            label1 = new Label();
            label2 = new Label();
            roomPanel = new Panel();
            furnitureCatalog = new ListBox();
            propertyGrid = new PropertyGrid();
            rotateLeftButton = new Button();
            rotateRightButton = new Button();
            changeBgButton = new Button();
            deleteButton = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "가구목록";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 264);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "텍스트라벨";
            // 
            // roomPanel
            // 
            roomPanel.Location = new Point(166, 12);
            roomPanel.Name = "roomPanel";
            roomPanel.Size = new Size(876, 636);
            roomPanel.TabIndex = 1;
            roomPanel.Paint += roomPanel_Paint;
            roomPanel.MouseDown += roomPanel_MouseDown;
            roomPanel.MouseMove += roomPanel_MouseMove;
            roomPanel.MouseUp += roomPanel_MouseUp;
            // 
            // furnitureCatalog
            // 
            furnitureCatalog.FormattingEnabled = true;
            furnitureCatalog.ItemHeight = 15;
            furnitureCatalog.Location = new Point(11, 43);
            furnitureCatalog.Name = "furnitureCatalog";
            furnitureCatalog.Size = new Size(148, 394);
            furnitureCatalog.TabIndex = 2;
            // 
            // propertyGrid
            // 
            propertyGrid.Location = new Point(12, 87);
            propertyGrid.Name = "propertyGrid";
            propertyGrid.Size = new Size(139, 174);
            propertyGrid.TabIndex = 3;
            // 
            // rotateLeftButton
            // 
            rotateLeftButton.Location = new Point(11, 457);
            rotateLeftButton.Name = "rotateLeftButton";
            rotateLeftButton.Size = new Size(67, 66);
            rotateLeftButton.TabIndex = 4;
            rotateLeftButton.Text = "좌회전";
            rotateLeftButton.UseVisualStyleBackColor = true;
            rotateLeftButton.Click += rotateLeftButton_Click;
            // 
            // rotateRightButton
            // 
            rotateRightButton.Location = new Point(84, 457);
            rotateRightButton.Name = "rotateRightButton";
            rotateRightButton.Size = new Size(75, 66);
            rotateRightButton.TabIndex = 4;
            rotateRightButton.Text = "우회전";
            rotateRightButton.UseVisualStyleBackColor = true;
            rotateRightButton.Click += rotateRightButton_Click;
            // 
            // changeBgButton
            // 
            changeBgButton.Location = new Point(11, 529);
            changeBgButton.Name = "changeBgButton";
            changeBgButton.Size = new Size(67, 71);
            changeBgButton.TabIndex = 4;
            changeBgButton.Text = "평면도";
            changeBgButton.UseVisualStyleBackColor = true;
            changeBgButton.Click += changeBgButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(84, 529);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(76, 71);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "삭제";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 606);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(148, 42);
            btnExit.TabIndex = 6;
            btnExit.Text = "나가기";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Funiture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 702);
            Controls.Add(furnitureCatalog);
            Controls.Add(btnExit);
            Controls.Add(deleteButton);
            Controls.Add(changeBgButton);
            Controls.Add(rotateRightButton);
            Controls.Add(rotateLeftButton);
            Controls.Add(roomPanel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(propertyGrid);
            Name = "Funiture";
            Text = "Funiture";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel roomPanel;
        private ListBox furnitureCatalog;
        private PropertyGrid propertyGrid;
        private Button rotateLeftButton;
        private Button rotateRightButton;
        private Button changeBgButton;
        private Button deleteButton;
        private Button btnExit;
    }
}