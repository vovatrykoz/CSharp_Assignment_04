namespace A4_Volodymyr_Alt
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCostPerPers = new System.Windows.Forms.TextBox();
            this.txtGuestNum = new System.Windows.Forms.TextBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstGuestList = new System.Windows.Forms.ListBox();
            this.grpInviteGuests = new System.Windows.Forms.GroupBox();
            this.txtLstName = new System.Windows.Forms.TextBox();
            this.txtFrstName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblGuestNum = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpInviteGuests.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCostPerPers);
            this.groupBox1.Controls.Add(this.txtGuestNum);
            this.groupBox1.Controls.Add(this.btnCreateList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Party";
            // 
            // txtCostPerPers
            // 
            this.txtCostPerPers.Location = new System.Drawing.Point(223, 76);
            this.txtCostPerPers.Name = "txtCostPerPers";
            this.txtCostPerPers.Size = new System.Drawing.Size(100, 20);
            this.txtCostPerPers.TabIndex = 4;
            // 
            // txtGuestNum
            // 
            this.txtGuestNum.Location = new System.Drawing.Point(223, 37);
            this.txtGuestNum.Name = "txtGuestNum";
            this.txtGuestNum.Size = new System.Drawing.Size(100, 20);
            this.txtGuestNum.TabIndex = 3;
            // 
            // btnCreateList
            // 
            this.btnCreateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateList.Location = new System.Drawing.Point(115, 116);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(115, 36);
            this.btnCreateList.TabIndex = 2;
            this.btnCreateList.Text = "Create List";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost per person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number of Guests";
            // 
            // lstGuestList
            // 
            this.lstGuestList.FormattingEnabled = true;
            this.lstGuestList.Location = new System.Drawing.Point(449, 12);
            this.lstGuestList.Name = "lstGuestList";
            this.lstGuestList.Size = new System.Drawing.Size(316, 329);
            this.lstGuestList.TabIndex = 1;
            // 
            // grpInviteGuests
            // 
            this.grpInviteGuests.Controls.Add(this.txtLstName);
            this.grpInviteGuests.Controls.Add(this.txtFrstName);
            this.grpInviteGuests.Controls.Add(this.btnAdd);
            this.grpInviteGuests.Controls.Add(this.label3);
            this.grpInviteGuests.Controls.Add(this.label4);
            this.grpInviteGuests.Location = new System.Drawing.Point(16, 181);
            this.grpInviteGuests.Name = "grpInviteGuests";
            this.grpInviteGuests.Size = new System.Drawing.Size(342, 163);
            this.grpInviteGuests.TabIndex = 2;
            this.grpInviteGuests.TabStop = false;
            this.grpInviteGuests.Text = "Invite a Guest";
            // 
            // txtLstName
            // 
            this.txtLstName.Location = new System.Drawing.Point(223, 76);
            this.txtLstName.Name = "txtLstName";
            this.txtLstName.Size = new System.Drawing.Size(100, 20);
            this.txtLstName.TabIndex = 4;
            // 
            // txtFrstName
            // 
            this.txtFrstName.Location = new System.Drawing.Point(223, 37);
            this.txtFrstName.Name = "txtFrstName";
            this.txtFrstName.Size = new System.Drawing.Size(100, 20);
            this.txtFrstName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(115, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Frist Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Number of Guests";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Location = new System.Drawing.Point(239, 370);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalCost.Size = new System.Drawing.Size(100, 23);
            this.lblTotalCost.TabIndex = 5;
            this.lblTotalCost.Text = "lblTotalCost";
            // 
            // lblGuestNum
            // 
            this.lblGuestNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGuestNum.Location = new System.Drawing.Point(239, 408);
            this.lblGuestNum.Name = "lblGuestNum";
            this.lblGuestNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGuestNum.Size = new System.Drawing.Size(100, 20);
            this.lblGuestNum.TabIndex = 6;
            this.lblGuestNum.Text = "lblGuestNum";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(462, 389);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(107, 39);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(617, 389);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblGuestNum);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpInviteGuests);
            this.Controls.Add(this.lstGuestList);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Party Organiser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpInviteGuests.ResumeLayout(false);
            this.grpInviteGuests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCostPerPers;
        private System.Windows.Forms.TextBox txtGuestNum;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstGuestList;
        private System.Windows.Forms.GroupBox grpInviteGuests;
        private System.Windows.Forms.TextBox txtLstName;
        private System.Windows.Forms.TextBox txtFrstName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblGuestNum;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
    }
}

