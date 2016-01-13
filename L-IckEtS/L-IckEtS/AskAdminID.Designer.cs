namespace L_IckEtS_EF
{
    partial class AskAdminID
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
            this.pinned_id = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pinned_id
            // 
            this.pinned_id.AutoSize = true;
            this.pinned_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinned_id.Location = new System.Drawing.Point(12, 9);
            this.pinned_id.Name = "pinned_id";
            this.pinned_id.Size = new System.Drawing.Size(63, 16);
            this.pinned_id.TabIndex = 0;
            this.pinned_id.Text = "Your ID:";
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(81, 5);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(131, 20);
            this.id_text.TabIndex = 1;
            this.id_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // AskAdminID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 49);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.pinned_id);
            this.Name = "AskAdminID";
            this.Text = "AskAdminID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pinned_id;
        private System.Windows.Forms.TextBox id_text;
    }
}