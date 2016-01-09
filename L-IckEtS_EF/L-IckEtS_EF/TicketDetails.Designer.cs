namespace L_IckEtS_EF
{
    partial class TicketDetails
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ticket_details = new System.Windows.Forms.TabPage();
            this.closed = new System.Windows.Forms.Label();
            this.created = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.pinnedc_losed = new System.Windows.Forms.Label();
            this.pinned_created = new System.Windows.Forms.Label();
            this.pinned_description = new System.Windows.Forms.Label();
            this.pinned_priority = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ticket_requests = new System.Windows.Forms.TabPage();
            this.info_requests = new System.Windows.Forms.ListView();
            this.request_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.request_created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.request_response_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.request_admin_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticket_actions = new System.Windows.Forms.TabPage();
            this.export = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.pinned_note = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.to_close = new System.Windows.Forms.CheckBox();
            this.subimt_action = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ticket_details.SuspendLayout();
            this.ticket_requests.SuspendLayout();
            this.ticket_actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ticket_details);
            this.tabControl1.Controls.Add(this.ticket_requests);
            this.tabControl1.Controls.Add(this.ticket_actions);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 249);
            this.tabControl1.TabIndex = 0;
            // 
            // ticket_details
            // 
            this.ticket_details.Controls.Add(this.closed);
            this.ticket_details.Controls.Add(this.created);
            this.ticket_details.Controls.Add(this.description);
            this.ticket_details.Controls.Add(this.priority);
            this.ticket_details.Controls.Add(this.state);
            this.ticket_details.Controls.Add(this.pinnedc_losed);
            this.ticket_details.Controls.Add(this.pinned_created);
            this.ticket_details.Controls.Add(this.pinned_description);
            this.ticket_details.Controls.Add(this.pinned_priority);
            this.ticket_details.Controls.Add(this.label1);
            this.ticket_details.Location = new System.Drawing.Point(4, 22);
            this.ticket_details.Name = "ticket_details";
            this.ticket_details.Padding = new System.Windows.Forms.Padding(3);
            this.ticket_details.Size = new System.Drawing.Size(276, 223);
            this.ticket_details.TabIndex = 0;
            this.ticket_details.Text = "Details";
            this.ticket_details.UseVisualStyleBackColor = true;
            // 
            // closed
            // 
            this.closed.Location = new System.Drawing.Point(194, 198);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(71, 13);
            this.closed.TabIndex = 10;
            // 
            // created
            // 
            this.created.Location = new System.Drawing.Point(65, 198);
            this.created.Name = "created";
            this.created.Size = new System.Drawing.Size(72, 13);
            this.created.TabIndex = 9;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(95, 48);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(160, 143);
            this.description.TabIndex = 8;
            // 
            // priority
            // 
            this.priority.Location = new System.Drawing.Point(95, 25);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(163, 13);
            this.priority.TabIndex = 7;
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(95, 3);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(163, 13);
            this.state.TabIndex = 6;
            // 
            // pinnedc_losed
            // 
            this.pinnedc_losed.AutoSize = true;
            this.pinnedc_losed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinnedc_losed.Location = new System.Drawing.Point(143, 198);
            this.pinnedc_losed.Name = "pinnedc_losed";
            this.pinnedc_losed.Size = new System.Drawing.Size(45, 13);
            this.pinnedc_losed.TabIndex = 5;
            this.pinnedc_losed.Text = "Closed";
            // 
            // pinned_created
            // 
            this.pinned_created.AutoSize = true;
            this.pinned_created.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_created.Location = new System.Drawing.Point(8, 198);
            this.pinned_created.Name = "pinned_created";
            this.pinned_created.Size = new System.Drawing.Size(51, 13);
            this.pinned_created.TabIndex = 4;
            this.pinned_created.Text = "Created";
            // 
            // pinned_description
            // 
            this.pinned_description.AutoSize = true;
            this.pinned_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_description.Location = new System.Drawing.Point(8, 48);
            this.pinned_description.Name = "pinned_description";
            this.pinned_description.Size = new System.Drawing.Size(71, 13);
            this.pinned_description.TabIndex = 3;
            this.pinned_description.Text = "Description";
            // 
            // pinned_priority
            // 
            this.pinned_priority.AutoSize = true;
            this.pinned_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_priority.Location = new System.Drawing.Point(8, 25);
            this.pinned_priority.Name = "pinned_priority";
            this.pinned_priority.Size = new System.Drawing.Size(46, 13);
            this.pinned_priority.TabIndex = 2;
            this.pinned_priority.Text = "Priority";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "State";
            // 
            // ticket_requests
            // 
            this.ticket_requests.Controls.Add(this.info_requests);
            this.ticket_requests.Location = new System.Drawing.Point(4, 22);
            this.ticket_requests.Name = "ticket_requests";
            this.ticket_requests.Padding = new System.Windows.Forms.Padding(3);
            this.ticket_requests.Size = new System.Drawing.Size(276, 223);
            this.ticket_requests.TabIndex = 2;
            this.ticket_requests.Text = "Requests";
            this.ticket_requests.UseVisualStyleBackColor = true;
            // 
            // info_requests
            // 
            this.info_requests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.request_id,
            this.request_created,
            this.request_response_date,
            this.request_admin_id});
            this.info_requests.Location = new System.Drawing.Point(8, 6);
            this.info_requests.Name = "info_requests";
            this.info_requests.Size = new System.Drawing.Size(260, 211);
            this.info_requests.TabIndex = 14;
            this.info_requests.UseCompatibleStateImageBehavior = false;
            this.info_requests.View = System.Windows.Forms.View.Details;
            // 
            // request_id
            // 
            this.request_id.Text = "ID";
            this.request_id.Width = 45;
            // 
            // request_created
            // 
            this.request_created.Text = "Created";
            this.request_created.Width = 71;
            // 
            // request_response_date
            // 
            this.request_response_date.Text = "Responded";
            this.request_response_date.Width = 83;
            // 
            // request_admin_id
            // 
            this.request_admin_id.Text = "Admin";
            this.request_admin_id.Width = 47;
            // 
            // ticket_actions
            // 
            this.ticket_actions.Controls.Add(this.subimt_action);
            this.ticket_actions.Controls.Add(this.to_close);
            this.ticket_actions.Controls.Add(this.textBox1);
            this.ticket_actions.Controls.Add(this.pinned_note);
            this.ticket_actions.Controls.Add(this.export);
            this.ticket_actions.Controls.Add(this.remove);
            this.ticket_actions.Location = new System.Drawing.Point(4, 22);
            this.ticket_actions.Name = "ticket_actions";
            this.ticket_actions.Padding = new System.Windows.Forms.Padding(3);
            this.ticket_actions.Size = new System.Drawing.Size(276, 223);
            this.ticket_actions.TabIndex = 1;
            this.ticket_actions.Text = "Resolve";
            this.ticket_actions.UseVisualStyleBackColor = true;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(8, 182);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 35);
            this.export.TabIndex = 12;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(100, 182);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 35);
            this.remove.TabIndex = 11;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // pinned_note
            // 
            this.pinned_note.AutoSize = true;
            this.pinned_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_note.Location = new System.Drawing.Point(8, 3);
            this.pinned_note.Name = "pinned_note";
            this.pinned_note.Size = new System.Drawing.Size(34, 13);
            this.pinned_note.TabIndex = 13;
            this.pinned_note.Text = "Note";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 68);
            this.textBox1.TabIndex = 14;
            // 
            // to_close
            // 
            this.to_close.AutoSize = true;
            this.to_close.Location = new System.Drawing.Point(188, 80);
            this.to_close.Name = "to_close";
            this.to_close.Size = new System.Drawing.Size(85, 17);
            this.to_close.TabIndex = 15;
            this.to_close.Text = "Close Ticket";
            this.to_close.UseVisualStyleBackColor = true;
            // 
            // subimt_action
            // 
            this.subimt_action.Location = new System.Drawing.Point(193, 182);
            this.subimt_action.Name = "subimt_action";
            this.subimt_action.Size = new System.Drawing.Size(75, 35);
            this.subimt_action.TabIndex = 1;
            this.subimt_action.Text = "Submit";
            this.subimt_action.UseVisualStyleBackColor = true;
            // 
            // TicketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "TicketDetails";
            this.tabControl1.ResumeLayout(false);
            this.ticket_details.ResumeLayout(false);
            this.ticket_details.PerformLayout();
            this.ticket_requests.ResumeLayout(false);
            this.ticket_actions.ResumeLayout(false);
            this.ticket_actions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ticket_details;
        private System.Windows.Forms.TabPage ticket_actions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pinned_priority;
        private System.Windows.Forms.Label pinned_description;
        private System.Windows.Forms.Label pinned_created;
        private System.Windows.Forms.Label pinnedc_losed;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label priority;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label created;
        private System.Windows.Forms.Label closed;
        private System.Windows.Forms.TabPage ticket_requests;
        private System.Windows.Forms.ListView info_requests;
        private System.Windows.Forms.ColumnHeader request_id;
        private System.Windows.Forms.ColumnHeader request_created;
        private System.Windows.Forms.ColumnHeader request_response_date;
        private System.Windows.Forms.ColumnHeader request_admin_id;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pinned_note;
        private System.Windows.Forms.Button subimt_action;
        private System.Windows.Forms.CheckBox to_close;
    }
}