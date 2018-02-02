namespace LoginForm
{
    partial class Login
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surfBtn = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.webPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.formMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addlinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksPanel = new System.Windows.Forms.Panel();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(130, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // surfBtn
            // 
            this.surfBtn.Location = new System.Drawing.Point(12, 53);
            this.surfBtn.Name = "surfBtn";
            this.surfBtn.Size = new System.Drawing.Size(130, 23);
            this.surfBtn.TabIndex = 1;
            this.surfBtn.Text = "Начать";
            this.surfBtn.UseVisualStyleBackColor = true;
            this.surfBtn.Click += new System.EventHandler(this.SurfBtn_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(444, 325);
            this.webBrowser.TabIndex = 2;
            // 
            // webPanel
            // 
            this.webPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webPanel.Controls.Add(this.webBrowser);
            this.webPanel.Location = new System.Drawing.Point(148, 27);
            this.webPanel.Name = "webPanel";
            this.webPanel.Size = new System.Drawing.Size(444, 325);
            this.webPanel.TabIndex = 3;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMenu,
            this.linksMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(604, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // formMenu
            // 
            this.formMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem,
            this.closeMenuItem});
            this.formMenu.Name = "formMenu";
            this.formMenu.Size = new System.Drawing.Size(57, 20);
            this.formMenu.Text = "Форма";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItem.Text = "Выйти";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // linksMenu
            // 
            this.linksMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addlinkMenuItem,
            this.editMenuItem,
            this.deleteMenuItem});
            this.linksMenu.Name = "linksMenu";
            this.linksMenu.Size = new System.Drawing.Size(62, 20);
            this.linksMenu.Text = "Ссылки";
            // 
            // addlinkMenuItem
            // 
            this.addlinkMenuItem.Name = "addlinkMenuItem";
            this.addlinkMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addlinkMenuItem.Text = "Добавить";
            this.addlinkMenuItem.Click += new System.EventHandler(this.addlinkMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editMenuItem.Text = "Редактировать";
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteMenuItem.Text = "Удалить";
            // 
            // linksPanel
            // 
            this.linksPanel.AutoScroll = true;
            this.linksPanel.Location = new System.Drawing.Point(12, 46);
            this.linksPanel.Name = "linksPanel";
            this.linksPanel.Size = new System.Drawing.Size(130, 291);
            this.linksPanel.TabIndex = 5;
            this.linksPanel.Visible = false;
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeMenuItem.Text = "Закрыть";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 349);
            this.Controls.Add(this.webPanel);
            this.Controls.Add(this.surfBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.linksPanel);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Login";
            this.Text = "Login";
            this.webPanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button surfBtn;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel webPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem formMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linksMenu;
        private System.Windows.Forms.ToolStripMenuItem addlinkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.Panel linksPanel;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
    }
}

