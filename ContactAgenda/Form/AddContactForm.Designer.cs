
namespace ContactAgenda
{
    partial class AddContactForm
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
            this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.LblName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.LblWorkNumber = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.TxtBxLastName = new System.Windows.Forms.TextBox();
            this.TxtBxAddress = new System.Windows.Forms.TextBox();
            this.TxtBxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.TxtBxWorkNumber = new System.Windows.Forms.MaskedTextBox();
            this.TlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 4;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TlpMain.Controls.Add(this.LblName, 1, 1);
            this.TlpMain.Controls.Add(this.LblLastName, 1, 2);
            this.TlpMain.Controls.Add(this.LblAddress, 1, 3);
            this.TlpMain.Controls.Add(this.LblPhoneNumber, 1, 4);
            this.TlpMain.Controls.Add(this.LblWorkNumber, 1, 5);
            this.TlpMain.Controls.Add(this.BtnSave, 1, 6);
            this.TlpMain.Controls.Add(this.BtnCancel, 2, 6);
            this.TlpMain.Controls.Add(this.TxtBxName, 2, 1);
            this.TlpMain.Controls.Add(this.TxtBxLastName, 2, 2);
            this.TlpMain.Controls.Add(this.TxtBxAddress, 2, 3);
            this.TlpMain.Controls.Add(this.TxtBxPhoneNumber, 2, 4);
            this.TlpMain.Controls.Add(this.TxtBxWorkNumber, 2, 5);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 8;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.Size = new System.Drawing.Size(609, 450);
            this.TlpMain.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(248, 56);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(53, 21);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // LblLastName
            // 
            this.LblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLastName.Location = new System.Drawing.Point(218, 112);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(83, 21);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Last name";
            // 
            // LblAddress
            // 
            this.LblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAddress.Location = new System.Drawing.Point(231, 168);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(70, 21);
            this.LblAddress.TabIndex = 2;
            this.LblAddress.Text = "Address";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPhoneNumber.Location = new System.Drawing.Point(184, 224);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(117, 21);
            this.LblPhoneNumber.TabIndex = 3;
            this.LblPhoneNumber.Text = "Phone number";
            // 
            // LblWorkNumber
            // 
            this.LblWorkNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblWorkNumber.AutoSize = true;
            this.LblWorkNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblWorkNumber.Location = new System.Drawing.Point(191, 280);
            this.LblWorkNumber.Name = "LblWorkNumber";
            this.LblWorkNumber.Size = new System.Drawing.Size(110, 21);
            this.LblWorkNumber.TabIndex = 4;
            this.LblWorkNumber.Text = "Work number";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(94, 339);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(207, 33);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Location = new System.Drawing.Point(307, 339);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(207, 33);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtBxName
            // 
            this.TxtBxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxName.Location = new System.Drawing.Point(307, 59);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(207, 29);
            this.TxtBxName.TabIndex = 7;
            // 
            // TxtBxLastName
            // 
            this.TxtBxLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxLastName.Location = new System.Drawing.Point(307, 115);
            this.TxtBxLastName.Name = "TxtBxLastName";
            this.TxtBxLastName.Size = new System.Drawing.Size(207, 29);
            this.TxtBxLastName.TabIndex = 8;
            // 
            // TxtBxAddress
            // 
            this.TxtBxAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxAddress.Location = new System.Drawing.Point(307, 171);
            this.TxtBxAddress.Name = "TxtBxAddress";
            this.TxtBxAddress.Size = new System.Drawing.Size(207, 29);
            this.TxtBxAddress.TabIndex = 9;
            // 
            // TxtBxPhoneNumber
            // 
            this.TxtBxPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxPhoneNumber.Location = new System.Drawing.Point(307, 227);
            this.TxtBxPhoneNumber.Mask = "(999) 000-0000";
            this.TxtBxPhoneNumber.Name = "TxtBxPhoneNumber";
            this.TxtBxPhoneNumber.Size = new System.Drawing.Size(207, 29);
            this.TxtBxPhoneNumber.TabIndex = 10;
            // 
            // TxtBxWorkNumber
            // 
            this.TxtBxWorkNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBxWorkNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBxWorkNumber.Location = new System.Drawing.Point(307, 283);
            this.TxtBxWorkNumber.Mask = "(999) 000-0000";
            this.TxtBxWorkNumber.Name = "TxtBxWorkNumber";
            this.TxtBxWorkNumber.Size = new System.Drawing.Size(207, 29);
            this.TxtBxWorkNumber.TabIndex = 11;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.TlpMain);
            this.Name = "AddContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Contact";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddContactForm_FormClosed);
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            this.TlpMain.ResumeLayout(false);
            this.TlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.Label LblWorkNumber;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.TextBox TxtBxLastName;
        private System.Windows.Forms.TextBox TxtBxAddress;
        private System.Windows.Forms.MaskedTextBox TxtBxPhoneNumber;
        private System.Windows.Forms.MaskedTextBox TxtBxWorkNumber;
    }
}