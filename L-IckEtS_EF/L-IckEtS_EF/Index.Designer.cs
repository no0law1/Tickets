namespace L_IckEtS_EF
{
    partial class Index
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
            this.techs = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tickets = new System.Windows.Forms.TabPage();
            this.edit_ticket = new System.Windows.Forms.Button();
            this.ticket_list = new System.Windows.Forms.ListView();
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.show_non_closed = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.techs.SuspendLayout();
            this.tickets.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // techs
            // 
            this.techs.Controls.Add(this.button1);
            this.techs.Location = new System.Drawing.Point(4, 22);
            this.techs.Name = "techs";
            this.techs.Padding = new System.Windows.Forms.Padding(3);
            this.techs.Size = new System.Drawing.Size(418, 328);
            this.techs.TabIndex = 1;
            this.techs.Text = "Administration";
            this.techs.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Assign an Admin to a Ticket";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tickets
            // 
            this.tickets.AccessibleName = "";
            this.tickets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tickets.Controls.Add(this.edit_ticket);
            this.tickets.Controls.Add(this.ticket_list);
            this.tickets.Controls.Add(this.show_non_closed);
            this.tickets.Location = new System.Drawing.Point(4, 22);
            this.tickets.Name = "tickets";
            this.tickets.Padding = new System.Windows.Forms.Padding(3);
            this.tickets.Size = new System.Drawing.Size(418, 328);
            this.tickets.TabIndex = 0;
            this.tickets.Text = "Tickets";
            this.tickets.UseVisualStyleBackColor = true;
            // 
            // edit_ticket
            // 
            this.edit_ticket.Location = new System.Drawing.Point(6, 291);
            this.edit_ticket.Name = "edit_ticket";
            this.edit_ticket.Size = new System.Drawing.Size(89, 27);
            this.edit_ticket.TabIndex = 5;
            this.edit_ticket.Text = "Edit";
            this.edit_ticket.UseVisualStyleBackColor = true;
            this.edit_ticket.Click += new System.EventHandler(this.edit_ticket_Click);
            // 
            // ticket_list
            // 
            this.ticket_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code,
            this.state,
            this.created,
            this.closed,
            this.priority,
            this.admin});
            this.ticket_list.FullRowSelect = true;
            this.ticket_list.Location = new System.Drawing.Point(6, 6);
            this.ticket_list.MultiSelect = false;
            this.ticket_list.Name = "ticket_list";
            this.ticket_list.Size = new System.Drawing.Size(402, 279);
            this.ticket_list.TabIndex = 4;
            this.ticket_list.UseCompatibleStateImageBehavior = false;
            this.ticket_list.View = System.Windows.Forms.View.Details;
            // 
            // code
            // 
            this.code.Text = "Code";
            // 
            // state
            // 
            this.state.Text = "State";
            // 
            // created
            // 
            this.created.Text = "Created";
            this.created.Width = 75;
            // 
            // closed
            // 
            this.closed.Text = "Closed";
            this.closed.Width = 75;
            // 
            // priority
            // 
            this.priority.Text = "Priority";
            this.priority.Width = 67;
            // 
            // admin
            // 
            this.admin.Text = "Admin";
            // 
            // show_non_closed
            // 
            this.show_non_closed.AutoSize = true;
            this.show_non_closed.Checked = true;
            this.show_non_closed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.show_non_closed.Location = new System.Drawing.Point(247, 301);
            this.show_non_closed.Name = "show_non_closed";
            this.show_non_closed.Size = new System.Drawing.Size(164, 17);
            this.show_non_closed.TabIndex = 3;
            this.show_non_closed.Text = "Show only non closed tickets";
            this.show_non_closed.UseVisualStyleBackColor = true;
            this.show_non_closed.CheckedChanged += new System.EventHandler(this.show_non_closed_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tickets);
            this.tabControl1.Controls.Add(this.techs);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 376);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.Text = "Index";
            this.techs.ResumeLayout(false);
            this.tickets.ResumeLayout(false);
            this.tickets.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage techs;
        private System.Windows.Forms.TabPage tickets;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListView ticket_list;
        private System.Windows.Forms.CheckBox show_non_closed;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader created;
        private System.Windows.Forms.ColumnHeader closed;
        private System.Windows.Forms.ColumnHeader priority;
        private System.Windows.Forms.ColumnHeader admin;
        private System.Windows.Forms.Button edit_ticket;
        private System.Windows.Forms.Button button1;

    }
}