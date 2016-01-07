namespace L_IckEtS_EF
{
    partial class TicketEdit
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
            this.pinned_state = new System.Windows.Forms.Label();
            this.pinned_priority = new System.Windows.Forms.Label();
            this.pinned_description = new System.Windows.Forms.Label();
            this.pinned_created = new System.Windows.Forms.Label();
            this.pinnedc_losed = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.created = new System.Windows.Forms.Label();
            this.closed = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.info_requests = new System.Windows.Forms.ListView();
            this.request_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.request_created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.request_response_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.request_admin_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // pinned_state
            // 
            this.pinned_state.AutoSize = true;
            this.pinned_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_state.Location = new System.Drawing.Point(12, 9);
            this.pinned_state.Name = "pinned_state";
            this.pinned_state.Size = new System.Drawing.Size(37, 13);
            this.pinned_state.TabIndex = 0;
            this.pinned_state.Text = "State";
            // 
            // pinned_priority
            // 
            this.pinned_priority.AutoSize = true;
            this.pinned_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_priority.Location = new System.Drawing.Point(12, 34);
            this.pinned_priority.Name = "pinned_priority";
            this.pinned_priority.Size = new System.Drawing.Size(46, 13);
            this.pinned_priority.TabIndex = 1;
            this.pinned_priority.Text = "Priority";
            // 
            // pinned_description
            // 
            this.pinned_description.AutoSize = true;
            this.pinned_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_description.Location = new System.Drawing.Point(12, 68);
            this.pinned_description.Name = "pinned_description";
            this.pinned_description.Size = new System.Drawing.Size(71, 13);
            this.pinned_description.TabIndex = 2;
            this.pinned_description.Text = "Description";
            // 
            // pinned_created
            // 
            this.pinned_created.AutoSize = true;
            this.pinned_created.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_created.Location = new System.Drawing.Point(12, 239);
            this.pinned_created.Name = "pinned_created";
            this.pinned_created.Size = new System.Drawing.Size(51, 13);
            this.pinned_created.TabIndex = 3;
            this.pinned_created.Text = "Created";
            // 
            // pinnedc_losed
            // 
            this.pinnedc_losed.AutoSize = true;
            this.pinnedc_losed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinnedc_losed.Location = new System.Drawing.Point(147, 239);
            this.pinnedc_losed.Name = "pinnedc_losed";
            this.pinnedc_losed.Size = new System.Drawing.Size(45, 13);
            this.pinnedc_losed.TabIndex = 4;
            this.pinnedc_losed.Text = "Closed";
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(109, 9);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(163, 13);
            this.state.TabIndex = 5;
            // 
            // priority
            // 
            this.priority.Location = new System.Drawing.Point(109, 34);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(163, 13);
            this.priority.TabIndex = 6;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(109, 68);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(160, 143);
            this.description.TabIndex = 7;
            // 
            // created
            // 
            this.created.Location = new System.Drawing.Point(69, 239);
            this.created.Name = "created";
            this.created.Size = new System.Drawing.Size(72, 13);
            this.created.TabIndex = 8;
            // 
            // closed
            // 
            this.closed.Location = new System.Drawing.Point(198, 239);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(71, 13);
            this.closed.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(275, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 12;
            this.button3.Text = "Resolve";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // info_requests
            // 
            this.info_requests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.request_id,
            this.request_created,
            this.request_response_date,
            this.request_admin_id});
            this.info_requests.Location = new System.Drawing.Point(15, 255);
            this.info_requests.Name = "info_requests";
            this.info_requests.Size = new System.Drawing.Size(335, 129);
            this.info_requests.TabIndex = 13;
            this.info_requests.UseCompatibleStateImageBehavior = false;
            this.info_requests.View = System.Windows.Forms.View.Details;
            // 
            // request_id
            // 
            this.request_id.Text = "ID";
            this.request_id.Width = 40;
            // 
            // request_created
            // 
            this.request_created.Text = "Created";
            this.request_created.Width = 64;
            // 
            // request_response_date
            // 
            this.request_response_date.Text = "Responded";
            this.request_response_date.Width = 78;
            // 
            // request_admin_id
            // 
            this.request_admin_id.Text = "Admin";
            // 
            // TicketEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(362, 396);
            this.Controls.Add(this.info_requests);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closed);
            this.Controls.Add(this.created);
            this.Controls.Add(this.description);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.state);
            this.Controls.Add(this.pinnedc_losed);
            this.Controls.Add(this.pinned_created);
            this.Controls.Add(this.pinned_description);
            this.Controls.Add(this.pinned_priority);
            this.Controls.Add(this.pinned_state);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "TicketEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pinned_state;
        private System.Windows.Forms.Label pinned_priority;
        private System.Windows.Forms.Label pinned_description;
        private System.Windows.Forms.Label pinned_created;
        private System.Windows.Forms.Label pinnedc_losed;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label priority;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label created;
        private System.Windows.Forms.Label closed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView info_requests;
        private System.Windows.Forms.ColumnHeader request_id;
        private System.Windows.Forms.ColumnHeader request_created;
        private System.Windows.Forms.ColumnHeader request_response_date;
        private System.Windows.Forms.ColumnHeader request_admin_id;

    }
}