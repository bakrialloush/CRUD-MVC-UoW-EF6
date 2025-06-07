namespace CRUD_UoW.Forms
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
            this.btnAddAuth = new System.Windows.Forms.Button();
            this.textAuthName = new System.Windows.Forms.TextBox();
            this.gridAuth = new System.Windows.Forms.DataGridView();
            this.gridPost = new System.Windows.Forms.DataGridView();
            this.textPostTitle = new System.Windows.Forms.TextBox();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.btnDelAuth = new System.Windows.Forms.Button();
            this.btnDelPost = new System.Windows.Forms.Button();
            this.btnEditAuth = new System.Windows.Forms.Button();
            this.btnEditPost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPost)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAuth
            // 
            this.btnAddAuth.Location = new System.Drawing.Point(21, 58);
            this.btnAddAuth.Name = "btnAddAuth";
            this.btnAddAuth.Size = new System.Drawing.Size(151, 23);
            this.btnAddAuth.TabIndex = 0;
            this.btnAddAuth.Text = "Add Auth";
            this.btnAddAuth.UseVisualStyleBackColor = true;
            this.btnAddAuth.Click += new System.EventHandler(this.BtnAddAuth_Click);
            // 
            // textAuthName
            // 
            this.textAuthName.Location = new System.Drawing.Point(21, 32);
            this.textAuthName.Name = "textAuthName";
            this.textAuthName.Size = new System.Drawing.Size(451, 20);
            this.textAuthName.TabIndex = 1;
            // 
            // gridAuth
            // 
            this.gridAuth.AllowUserToAddRows = false;
            this.gridAuth.AllowUserToDeleteRows = false;
            this.gridAuth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuth.Location = new System.Drawing.Point(21, 87);
            this.gridAuth.MultiSelect = false;
            this.gridAuth.Name = "gridAuth";
            this.gridAuth.ReadOnly = true;
            this.gridAuth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAuth.Size = new System.Drawing.Size(451, 323);
            this.gridAuth.TabIndex = 2;
            this.gridAuth.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAuth_CellDoubleClick);
            // 
            // gridPost
            // 
            this.gridPost.AllowUserToAddRows = false;
            this.gridPost.AllowUserToDeleteRows = false;
            this.gridPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPost.Location = new System.Drawing.Point(478, 87);
            this.gridPost.MultiSelect = false;
            this.gridPost.Name = "gridPost";
            this.gridPost.ReadOnly = true;
            this.gridPost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPost.Size = new System.Drawing.Size(451, 323);
            this.gridPost.TabIndex = 5;
            this.gridPost.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPost_CellDoubleClick);
            // 
            // textPostTitle
            // 
            this.textPostTitle.Location = new System.Drawing.Point(478, 32);
            this.textPostTitle.Name = "textPostTitle";
            this.textPostTitle.Size = new System.Drawing.Size(451, 20);
            this.textPostTitle.TabIndex = 4;
            // 
            // btnAddPost
            // 
            this.btnAddPost.Location = new System.Drawing.Point(478, 58);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(156, 23);
            this.btnAddPost.TabIndex = 3;
            this.btnAddPost.Text = "Add Post";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.BtnAddPost_Click);
            // 
            // btnDelAuth
            // 
            this.btnDelAuth.Location = new System.Drawing.Point(319, 58);
            this.btnDelAuth.Name = "btnDelAuth";
            this.btnDelAuth.Size = new System.Drawing.Size(153, 23);
            this.btnDelAuth.TabIndex = 6;
            this.btnDelAuth.Text = "Delete Auth";
            this.btnDelAuth.UseVisualStyleBackColor = true;
            this.btnDelAuth.Click += new System.EventHandler(this.BtnDelAuth_Click);
            // 
            // btnDelPost
            // 
            this.btnDelPost.Location = new System.Drawing.Point(781, 58);
            this.btnDelPost.Name = "btnDelPost";
            this.btnDelPost.Size = new System.Drawing.Size(148, 23);
            this.btnDelPost.TabIndex = 7;
            this.btnDelPost.Text = "Delete Post";
            this.btnDelPost.UseVisualStyleBackColor = true;
            this.btnDelPost.Click += new System.EventHandler(this.BtnDelPost_Click);
            // 
            // btnEditAuth
            // 
            this.btnEditAuth.Location = new System.Drawing.Point(178, 58);
            this.btnEditAuth.Name = "btnEditAuth";
            this.btnEditAuth.Size = new System.Drawing.Size(135, 23);
            this.btnEditAuth.TabIndex = 8;
            this.btnEditAuth.Text = "Update Auth";
            this.btnEditAuth.UseVisualStyleBackColor = true;
            this.btnEditAuth.Click += new System.EventHandler(this.BtnEditAuth_Click);
            // 
            // btnEditPost
            // 
            this.btnEditPost.Location = new System.Drawing.Point(640, 58);
            this.btnEditPost.Name = "btnEditPost";
            this.btnEditPost.Size = new System.Drawing.Size(135, 23);
            this.btnEditPost.TabIndex = 9;
            this.btnEditPost.Text = "Update Post";
            this.btnEditPost.UseVisualStyleBackColor = true;
            this.btnEditPost.Click += new System.EventHandler(this.BtnEditPost_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.btnEditPost);
            this.Controls.Add(this.btnEditAuth);
            this.Controls.Add(this.btnDelPost);
            this.Controls.Add(this.btnDelAuth);
            this.Controls.Add(this.gridPost);
            this.Controls.Add(this.textPostTitle);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.gridAuth);
            this.Controls.Add(this.textAuthName);
            this.Controls.Add(this.btnAddAuth);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridAuth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAuth;
        private System.Windows.Forms.TextBox textAuthName;
        private System.Windows.Forms.DataGridView gridAuth;
        private System.Windows.Forms.DataGridView gridPost;
        private System.Windows.Forms.TextBox textPostTitle;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.Button btnDelAuth;
        private System.Windows.Forms.Button btnDelPost;
        private System.Windows.Forms.Button btnEditAuth;
        private System.Windows.Forms.Button btnEditPost;
    }
}