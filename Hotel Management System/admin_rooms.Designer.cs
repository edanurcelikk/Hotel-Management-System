
namespace Hotel_Management_System
{
    partial class admin_rooms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rooms_clearBtn = new System.Windows.Forms.Button();
            this.rooms_deleteBtn = new System.Windows.Forms.Button();
            this.rooms_updateBtn = new System.Windows.Forms.Button();
            this.rooms_addBtn = new System.Windows.Forms.Button();
            this.rooms_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rooms_picture = new System.Windows.Forms.PictureBox();
            this.rooms_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rooms_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rooms_roomName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rooms_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rooms_roomID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(28, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 301);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room\'s Data";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(20, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(729, 236);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rooms_clearBtn);
            this.panel2.Controls.Add(this.rooms_deleteBtn);
            this.panel2.Controls.Add(this.rooms_updateBtn);
            this.panel2.Controls.Add(this.rooms_addBtn);
            this.panel2.Controls.Add(this.rooms_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.rooms_status);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rooms_price);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rooms_roomName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rooms_type);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rooms_roomID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(28, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 231);
            this.panel2.TabIndex = 1;
            // 
            // rooms_clearBtn
            // 
            this.rooms_clearBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rooms_clearBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rooms_clearBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rooms_clearBtn.Location = new System.Drawing.Point(357, 177);
            this.rooms_clearBtn.Name = "rooms_clearBtn";
            this.rooms_clearBtn.Size = new System.Drawing.Size(126, 39);
            this.rooms_clearBtn.TabIndex = 18;
            this.rooms_clearBtn.Text = "CLEAR";
            this.rooms_clearBtn.UseVisualStyleBackColor = false;
            this.rooms_clearBtn.Click += new System.EventHandler(this.rooms_clearBtn_Click);
            // 
            // rooms_deleteBtn
            // 
            this.rooms_deleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rooms_deleteBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rooms_deleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rooms_deleteBtn.Location = new System.Drawing.Point(357, 121);
            this.rooms_deleteBtn.Name = "rooms_deleteBtn";
            this.rooms_deleteBtn.Size = new System.Drawing.Size(126, 39);
            this.rooms_deleteBtn.TabIndex = 17;
            this.rooms_deleteBtn.Text = "DELETE";
            this.rooms_deleteBtn.UseVisualStyleBackColor = false;
            this.rooms_deleteBtn.Click += new System.EventHandler(this.rooms_deleteBtn_Click);
            // 
            // rooms_updateBtn
            // 
            this.rooms_updateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rooms_updateBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rooms_updateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rooms_updateBtn.Location = new System.Drawing.Point(357, 64);
            this.rooms_updateBtn.Name = "rooms_updateBtn";
            this.rooms_updateBtn.Size = new System.Drawing.Size(126, 39);
            this.rooms_updateBtn.TabIndex = 16;
            this.rooms_updateBtn.Text = "UPDATE";
            this.rooms_updateBtn.UseVisualStyleBackColor = false;
            this.rooms_updateBtn.Click += new System.EventHandler(this.rooms_updateBtn_Click);
            // 
            // rooms_addBtn
            // 
            this.rooms_addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rooms_addBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rooms_addBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rooms_addBtn.Location = new System.Drawing.Point(357, 9);
            this.rooms_addBtn.Name = "rooms_addBtn";
            this.rooms_addBtn.Size = new System.Drawing.Size(126, 39);
            this.rooms_addBtn.TabIndex = 15;
            this.rooms_addBtn.Text = "ADD";
            this.rooms_addBtn.UseVisualStyleBackColor = false;
            this.rooms_addBtn.Click += new System.EventHandler(this.rooms_addBtn_Click);
            // 
            // rooms_importBtn
            // 
            this.rooms_importBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rooms_importBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rooms_importBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rooms_importBtn.Location = new System.Drawing.Point(574, 173);
            this.rooms_importBtn.Name = "rooms_importBtn";
            this.rooms_importBtn.Size = new System.Drawing.Size(129, 39);
            this.rooms_importBtn.TabIndex = 14;
            this.rooms_importBtn.Text = "IMPORT";
            this.rooms_importBtn.UseVisualStyleBackColor = false;
            this.rooms_importBtn.Click += new System.EventHandler(this.rooms_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.rooms_picture);
            this.panel3.Location = new System.Drawing.Point(574, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 139);
            this.panel3.TabIndex = 13;
            // 
            // rooms_picture
            // 
            this.rooms_picture.Location = new System.Drawing.Point(0, 0);
            this.rooms_picture.Name = "rooms_picture";
            this.rooms_picture.Size = new System.Drawing.Size(129, 139);
            this.rooms_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rooms_picture.TabIndex = 14;
            this.rooms_picture.TabStop = false;
            // 
            // rooms_status
            // 
            this.rooms_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rooms_status.FormattingEnabled = true;
            this.rooms_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Occupied"});
            this.rooms_status.Location = new System.Drawing.Point(146, 181);
            this.rooms_status.Name = "rooms_status";
            this.rooms_status.Size = new System.Drawing.Size(164, 26);
            this.rooms_status.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(66, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status:";
            // 
            // rooms_price
            // 
            this.rooms_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rooms_price.Location = new System.Drawing.Point(146, 140);
            this.rooms_price.Name = "rooms_price";
            this.rooms_price.Size = new System.Drawing.Size(164, 24);
            this.rooms_price.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(77, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price:";
            // 
            // rooms_roomName
            // 
            this.rooms_roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rooms_roomName.Location = new System.Drawing.Point(146, 97);
            this.rooms_roomName.Name = "rooms_roomName";
            this.rooms_roomName.Size = new System.Drawing.Size(164, 24);
            this.rooms_roomName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Room Name:";
            // 
            // rooms_type
            // 
            this.rooms_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rooms_type.FormattingEnabled = true;
            this.rooms_type.Items.AddRange(new object[] {
            "Single Room",
            "Double Room"});
            this.rooms_type.Location = new System.Drawing.Point(146, 55);
            this.rooms_type.Name = "rooms_type";
            this.rooms_type.Size = new System.Drawing.Size(164, 26);
            this.rooms_type.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(78, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type:";
            // 
            // rooms_roomID
            // 
            this.rooms_roomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rooms_roomID.Location = new System.Drawing.Point(146, 14);
            this.rooms_roomID.Name = "rooms_roomID";
            this.rooms_roomID.Size = new System.Drawing.Size(164, 24);
            this.rooms_roomID.TabIndex = 3;
            this.rooms_roomID.TextChanged += new System.EventHandler(this.rooms_roomID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room ID:";
            // 
            // admin_rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "admin_rooms";
            this.Size = new System.Drawing.Size(839, 599);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rooms_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rooms_roomID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox rooms_picture;
        private System.Windows.Forms.ComboBox rooms_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rooms_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rooms_roomName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rooms_type;
        private System.Windows.Forms.Button rooms_importBtn;
        private System.Windows.Forms.Button rooms_clearBtn;
        private System.Windows.Forms.Button rooms_deleteBtn;
        private System.Windows.Forms.Button rooms_updateBtn;
        private System.Windows.Forms.Button rooms_addBtn;
    }
}
