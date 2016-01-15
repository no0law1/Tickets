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
            this.type = new System.Windows.Forms.Label();
            this.pinned_type = new System.Windows.Forms.Label();
            this.closed = new System.Windows.Forms.Label();
            this.created = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.pinnedc_losed = new System.Windows.Forms.Label();
            this.pinned_created = new System.Windows.Forms.Label();
            this.pinned_description = new System.Windows.Forms.Label();
            this.pinned_priority = new System.Windows.Forms.Label();
            this.pinned_details_state = new System.Windows.Forms.Label();
            this.ticket_requests = new System.Windows.Forms.TabPage();
            this.info_requests = new System.Windows.Forms.ListView();
            this.request_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.request_created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.request_response_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.request_admin_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticket_actions = new System.Windows.Forms.TabPage();
            this.action_type = new System.Windows.Forms.Label();
            this.pinned_action_type = new System.Windows.Forms.Label();
            this.actions_list = new System.Windows.Forms.ListView();
            this.action_note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.action_admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.action_order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.action_ended = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticket_resolve = new System.Windows.Forms.TabPage();
            this.steps_list = new System.Windows.Forms.ListBox();
            this.pinned_steps = new System.Windows.Forms.Label();
            this.state_list = new System.Windows.Forms.ListBox();
            this.pinned_state = new System.Windows.Forms.Label();
            this.submit_action = new System.Windows.Forms.Button();
            this.note = new System.Windows.Forms.TextBox();
            this.pinned_note = new System.Windows.Forms.Label();
            this.export = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ticket_details.SuspendLayout();
            this.ticket_requests.SuspendLayout();
            this.ticket_actions.SuspendLayout();
            this.ticket_resolve.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ticket_details);
            this.tabControl1.Controls.Add(this.ticket_requests);
            this.tabControl1.Controls.Add(this.ticket_actions);
            this.tabControl1.Controls.Add(this.ticket_resolve);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 249);
            this.tabControl1.TabIndex = 0;
            // 
            // ticket_details
            // 
            this.ticket_details.Controls.Add(this.type);
            this.ticket_details.Controls.Add(this.pinned_type);
            this.ticket_details.Controls.Add(this.closed);
            this.ticket_details.Controls.Add(this.created);
            this.ticket_details.Controls.Add(this.description);
            this.ticket_details.Controls.Add(this.priority);
            this.ticket_details.Controls.Add(this.state);
            this.ticket_details.Controls.Add(this.pinnedc_losed);
            this.ticket_details.Controls.Add(this.pinned_created);
            this.ticket_details.Controls.Add(this.pinned_description);
            this.ticket_details.Controls.Add(this.pinned_priority);
            this.ticket_details.Controls.Add(this.pinned_details_state);
            this.ticket_details.Location = new System.Drawing.Point(4, 22);
            this.ticket_details.Name = "ticket_details";
            this.ticket_details.Padding = new System.Windows.Forms.Padding(3);
            this.ticket_details.Size = new System.Drawing.Size(276, 223);
            this.ticket_details.TabIndex = 0;
            this.ticket_details.Text = "Details";
            this.ticket_details.UseVisualStyleBackColor = true;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(95, 47);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(163, 13);
            this.type.TabIndex = 12;
            // 
            // pinned_type
            // 
            this.pinned_type.AutoSize = true;
            this.pinned_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_type.Location = new System.Drawing.Point(8, 47);
            this.pinned_type.Name = "pinned_type";
            this.pinned_type.Size = new System.Drawing.Size(35, 13);
            this.pinned_type.TabIndex = 11;
            this.pinned_type.Text = "Type";
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
            this.description.Location = new System.Drawing.Point(95, 72);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(160, 119);
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
            this.pinned_description.Location = new System.Drawing.Point(8, 72);
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
            // pinned_details_state
            // 
            this.pinned_details_state.AutoSize = true;
            this.pinned_details_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_details_state.Location = new System.Drawing.Point(8, 3);
            this.pinned_details_state.Name = "pinned_details_state";
            this.pinned_details_state.Size = new System.Drawing.Size(37, 13);
            this.pinned_details_state.TabIndex = 0;
            this.pinned_details_state.Text = "State";
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
            this.info_requests.FullRowSelect = true;
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
            this.ticket_actions.Controls.Add(this.action_type);
            this.ticket_actions.Controls.Add(this.pinned_action_type);
            this.ticket_actions.Controls.Add(this.actions_list);
            this.ticket_actions.Location = new System.Drawing.Point(4, 22);
            this.ticket_actions.Name = "ticket_actions";
            this.ticket_actions.Padding = new System.Windows.Forms.Padding(3);
            this.ticket_actions.Size = new System.Drawing.Size(276, 223);
            this.ticket_actions.TabIndex = 3;
            this.ticket_actions.Text = "Actions";
            this.ticket_actions.UseVisualStyleBackColor = true;
            // 
            // action_type
            // 
            this.action_type.AutoSize = true;
            this.action_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_type.Location = new System.Drawing.Point(58, 13);
            this.action_type.Name = "action_type";
            this.action_type.Size = new System.Drawing.Size(0, 16);
            this.action_type.TabIndex = 2;
            // 
            // pinned_action_type
            // 
            this.pinned_action_type.AutoSize = true;
            this.pinned_action_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_action_type.Location = new System.Drawing.Point(8, 13);
            this.pinned_action_type.Name = "pinned_action_type";
            this.pinned_action_type.Size = new System.Drawing.Size(48, 16);
            this.pinned_action_type.TabIndex = 1;
            this.pinned_action_type.Text = "Type:";
            // 
            // actions_list
            // 
            this.actions_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.action_note,
            this.action_admin,
            this.action_order,
            this.action_ended});
            this.actions_list.FullRowSelect = true;
            this.actions_list.Location = new System.Drawing.Point(8, 43);
            this.actions_list.Name = "actions_list";
            this.actions_list.Size = new System.Drawing.Size(260, 174);
            this.actions_list.TabIndex = 0;
            this.actions_list.UseCompatibleStateImageBehavior = false;
            this.actions_list.View = System.Windows.Forms.View.Details;
            // 
            // action_note
            // 
            this.action_note.Text = "Note";
            // 
            // action_admin
            // 
            this.action_admin.Text = "Admin";
            // 
            // action_order
            // 
            this.action_order.Text = "Order";
            // 
            // action_ended
            // 
            this.action_ended.Text = "Finished";
            // 
            // ticket_resolve
            // 
            this.ticket_resolve.Controls.Add(this.steps_list);
            this.ticket_resolve.Controls.Add(this.pinned_steps);
            this.ticket_resolve.Controls.Add(this.state_list);
            this.ticket_resolve.Controls.Add(this.pinned_state);
            this.ticket_resolve.Controls.Add(this.submit_action);
            this.ticket_resolve.Controls.Add(this.note);
            this.ticket_resolve.Controls.Add(this.pinned_note);
            this.ticket_resolve.Controls.Add(this.export);
            this.ticket_resolve.Controls.Add(this.remove);
            this.ticket_resolve.Location = new System.Drawing.Point(4, 22);
            this.ticket_resolve.Name = "ticket_resolve";
            this.ticket_resolve.Padding = new System.Windows.Forms.Padding(3);
            this.ticket_resolve.Size = new System.Drawing.Size(276, 223);
            this.ticket_resolve.TabIndex = 1;
            this.ticket_resolve.Text = "Resolve";
            this.ticket_resolve.UseVisualStyleBackColor = true;
            // 
            // steps_list
            // 
            this.steps_list.FormattingEnabled = true;
            this.steps_list.Location = new System.Drawing.Point(48, 80);
            this.steps_list.Name = "steps_list";
            this.steps_list.Size = new System.Drawing.Size(134, 56);
            this.steps_list.TabIndex = 22;
            // 
            // pinned_steps
            // 
            this.pinned_steps.AutoSize = true;
            this.pinned_steps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_steps.Location = new System.Drawing.Point(8, 77);
            this.pinned_steps.Name = "pinned_steps";
            this.pinned_steps.Size = new System.Drawing.Size(39, 13);
            this.pinned_steps.TabIndex = 21;
            this.pinned_steps.Text = "Steps";
            // 
            // state_list
            // 
            this.state_list.FormattingEnabled = true;
            this.state_list.Items.AddRange(new object[] {
            "In Progress",
            "Closed"});
            this.state_list.Location = new System.Drawing.Point(48, 146);
            this.state_list.Name = "state_list";
            this.state_list.Size = new System.Drawing.Size(134, 30);
            this.state_list.TabIndex = 20;
            // 
            // pinned_state
            // 
            this.pinned_state.AutoSize = true;
            this.pinned_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_state.Location = new System.Drawing.Point(8, 146);
            this.pinned_state.Name = "pinned_state";
            this.pinned_state.Size = new System.Drawing.Size(37, 13);
            this.pinned_state.TabIndex = 19;
            this.pinned_state.Text = "State";
            // 
            // submit_action
            // 
            this.submit_action.Location = new System.Drawing.Point(193, 182);
            this.submit_action.Name = "submit_action";
            this.submit_action.Size = new System.Drawing.Size(75, 35);
            this.submit_action.TabIndex = 1;
            this.submit_action.Text = "Submit";
            this.submit_action.UseVisualStyleBackColor = true;
            this.submit_action.Click += new System.EventHandler(this.submit_action_Click);
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(48, 6);
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(220, 68);
            this.note.TabIndex = 14;
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
            // TicketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "TicketDetails";
            this.tabControl1.ResumeLayout(false);
            this.ticket_details.ResumeLayout(false);
            this.ticket_details.PerformLayout();
            this.ticket_requests.ResumeLayout(false);
            this.ticket_actions.ResumeLayout(false);
            this.ticket_actions.PerformLayout();
            this.ticket_resolve.ResumeLayout(false);
            this.ticket_resolve.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ticket_details;
        private System.Windows.Forms.TabPage ticket_resolve;
        private System.Windows.Forms.Label pinned_details_state;
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
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.Label pinned_note;
        private System.Windows.Forms.Button submit_action;
        private System.Windows.Forms.Label pinned_state;
        private System.Windows.Forms.ListBox state_list;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label pinned_type;
        private System.Windows.Forms.TabPage ticket_actions;
        private System.Windows.Forms.Label action_type;
        private System.Windows.Forms.Label pinned_action_type;
        private System.Windows.Forms.ListView actions_list;
        private System.Windows.Forms.ColumnHeader action_note;
        private System.Windows.Forms.ColumnHeader action_admin;
        private System.Windows.Forms.ColumnHeader action_order;
        private System.Windows.Forms.ColumnHeader action_ended;
        private System.Windows.Forms.ListBox steps_list;
        private System.Windows.Forms.Label pinned_steps;
    }
}