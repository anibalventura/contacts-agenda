
namespace ContactAgenda
{
    partial class ContactsForm
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
            this.components = new System.ComponentModel.Container();
            this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.DgvContacts = new System.Windows.Forms.DataGridView();
            this.BtnEditContact = new System.Windows.Forms.Button();
            this.BtnDeleteContact = new System.Windows.Forms.Button();
            this.BtnAddContact = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MsMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MsItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.TlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContacts)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 4;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMain.Controls.Add(this.DgvContacts, 1, 1);
            this.TlpMain.Controls.Add(this.BtnEditContact, 1, 3);
            this.TlpMain.Controls.Add(this.BtnDeleteContact, 2, 3);
            this.TlpMain.Controls.Add(this.BtnAddContact, 1, 0);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 4;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TlpMain.Size = new System.Drawing.Size(715, 450);
            this.TlpMain.TabIndex = 0;
            // 
            // DgvContacts
            // 
            this.DgvContacts.AllowUserToAddRows = false;
            this.DgvContacts.AllowUserToDeleteRows = false;
            this.DgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TlpMain.SetColumnSpan(this.DgvContacts, 2);
            this.DgvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvContacts.Location = new System.Drawing.Point(110, 115);
            this.DgvContacts.MultiSelect = false;
            this.DgvContacts.Name = "DgvContacts";
            this.DgvContacts.ReadOnly = true;
            this.TlpMain.SetRowSpan(this.DgvContacts, 2);
            this.DgvContacts.RowTemplate.Height = 25;
            this.DgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvContacts.Size = new System.Drawing.Size(494, 218);
            this.DgvContacts.TabIndex = 0;
            this.DgvContacts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContacts_CellClick);
            // 
            // BtnEditContact
            // 
            this.BtnEditContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEditContact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditContact.Location = new System.Drawing.Point(110, 339);
            this.BtnEditContact.Name = "BtnEditContact";
            this.BtnEditContact.Size = new System.Drawing.Size(244, 33);
            this.BtnEditContact.TabIndex = 1;
            this.BtnEditContact.Text = "Edit";
            this.BtnEditContact.UseVisualStyleBackColor = true;
            this.BtnEditContact.Click += new System.EventHandler(this.BtnEditContact_Click);
            // 
            // BtnDeleteContact
            // 
            this.BtnDeleteContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDeleteContact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeleteContact.Location = new System.Drawing.Point(360, 339);
            this.BtnDeleteContact.Name = "BtnDeleteContact";
            this.BtnDeleteContact.Size = new System.Drawing.Size(244, 33);
            this.BtnDeleteContact.TabIndex = 2;
            this.BtnDeleteContact.Text = "Delete";
            this.BtnDeleteContact.UseVisualStyleBackColor = true;
            this.BtnDeleteContact.Click += new System.EventHandler(this.BtnDeleteContact_Click);
            // 
            // BtnAddContact
            // 
            this.TlpMain.SetColumnSpan(this.BtnAddContact, 2);
            this.BtnAddContact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAddContact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddContact.Location = new System.Drawing.Point(110, 76);
            this.BtnAddContact.Name = "BtnAddContact";
            this.BtnAddContact.Size = new System.Drawing.Size(494, 33);
            this.BtnAddContact.TabIndex = 3;
            this.BtnAddContact.Text = "Add new contact";
            this.BtnAddContact.UseVisualStyleBackColor = true;
            this.BtnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MsMain
            // 
            this.MsMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsItemLogout});
            this.MsMain.Name = "MsMain";
            this.MsMain.Size = new System.Drawing.Size(50, 20);
            this.MsMain.Text = "Menu";
            // 
            // MsItemLogout
            // 
            this.MsItemLogout.Name = "MsItemLogout";
            this.MsItemLogout.Size = new System.Drawing.Size(112, 22);
            this.MsItemLogout.Text = "Logout";
            this.MsItemLogout.Click += new System.EventHandler(this.MsItemLogout_Click);
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TlpMain);
            this.Name = "ContactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContactsForm_FormClosed);
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            this.VisibleChanged += new System.EventHandler(this.ContactsForm_VisibleChanged);
            this.TlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvContacts)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.DataGridView DgvContacts;
        private System.Windows.Forms.Button BtnEditContact;
        private System.Windows.Forms.Button BtnDeleteContact;
        private System.Windows.Forms.Button BtnAddContact;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MsMain;
        private System.Windows.Forms.ToolStripMenuItem MsItemLogout;
    }
}