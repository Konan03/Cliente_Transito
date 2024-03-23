namespace ClienteTransito
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGet = new Button();
            btnPost = new Button();
            txtGet = new TextBox();
            txtPost = new TextBox();
            SuspendLayout();
            // 
            // btnGet
            // 
            btnGet.Location = new Point(420, 98);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(94, 29);
            btnGet.TabIndex = 0;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(420, 156);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(94, 29);
            btnPost.TabIndex = 1;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // txtGet
            // 
            txtGet.Location = new Point(121, 98);
            txtGet.Name = "txtGet";
            txtGet.Size = new Size(269, 27);
            txtGet.TabIndex = 2;
            // 
            // txtPost
            // 
            txtPost.Location = new Point(124, 157);
            txtPost.Name = "txtPost";
            txtPost.Size = new Size(266, 27);
            txtPost.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPost);
            Controls.Add(txtGet);
            Controls.Add(btnPost);
            Controls.Add(btnGet);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGet;
        private Button btnPost;
        private TextBox txtGet;
        private TextBox txtPost;
    }
}
