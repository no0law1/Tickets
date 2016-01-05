namespace L_IckEtS
{
    partial class App
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
            this.non_closed = new System.Windows.Forms.Button();
            this.assign = new System.Windows.Forms.Button();
            this.insert_action = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.export_info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // non_closed
            // 
            this.non_closed.Location = new System.Drawing.Point(12, 12);
            this.non_closed.Name = "non_closed";
            this.non_closed.Size = new System.Drawing.Size(260, 35);
            this.non_closed.TabIndex = 1;
            this.non_closed.Text = "LIST NON CLOSED TICKETS";
            this.non_closed.UseVisualStyleBackColor = true;
            this.non_closed.Click += new System.EventHandler(this.non_closed_Click);
            // 
            // assign
            // 
            this.assign.Location = new System.Drawing.Point(12, 53);
            this.assign.Name = "assign";
            this.assign.Size = new System.Drawing.Size(260, 35);
            this.assign.TabIndex = 2;
            this.assign.Text = "ASSIGN A TECH";
            this.assign.UseVisualStyleBackColor = true;
            this.assign.Click += new System.EventHandler(this.assign_Click);
            // 
            // insert_action
            // 
            this.insert_action.Location = new System.Drawing.Point(12, 94);
            this.insert_action.Name = "insert_action";
            this.insert_action.Size = new System.Drawing.Size(260, 35);
            this.insert_action.TabIndex = 3;
            this.insert_action.Text = "INSERT AN ACTION TO A TICKET";
            this.insert_action.UseVisualStyleBackColor = true;
            this.insert_action.Click += new System.EventHandler(this.insert_action_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(12, 135);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(260, 35);
            this.remove.TabIndex = 4;
            this.remove.Text = "REMOVE A TICKET";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // export_info
            // 
            this.export_info.Location = new System.Drawing.Point(12, 176);
            this.export_info.Name = "export_info";
            this.export_info.Size = new System.Drawing.Size(260, 35);
            this.export_info.TabIndex = 5;
            this.export_info.Text = "EXPORT TICKET INFO";
            this.export_info.UseVisualStyleBackColor = true;
            this.export_info.Click += new System.EventHandler(this.export_info_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 225);
            this.Controls.Add(this.export_info);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.insert_action);
            this.Controls.Add(this.assign);
            this.Controls.Add(this.non_closed);
            this.Name = "App";
            this.Text = "L-IckEtS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button non_closed;
        private System.Windows.Forms.Button assign;
        private System.Windows.Forms.Button insert_action;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button export_info;


    }
}

