using CRUD_UoW.Controllers;
using CRUD_UoW.Models;
using System;
using System.Windows.Forms;

namespace CRUD_UoW.Forms
{
    public partial class MainForm : Form
    {
        DBContext context;
        AuthorsController authors;
        PostsController posts;
        int id;

        public MainForm()
        {
            InitializeComponent();
            context = new DBContext();
            authors = new AuthorsController(context);
            posts = new PostsController(context);
            LoadGrids();
        }

        private void LoadGrids()
        {
            id = 0;
            gridAuth.DataSource = authors.GetList();
            gridPost.DataSource = posts.GetList();
            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
            btnEditAuth.Enabled = btnEditPost.Enabled = false;
            textAuthName.Text = textPostTitle.Text = "";
        }

        private void btnAddAuth_Click(object sender, EventArgs e)
        {
            try
            {
                authors.Add(new Author
                {
                    Name = textAuthName.Text,
                });
                LoadGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)gridAuth.SelectedRows[0].Cells["Id"].Value;
                var auth = authors.GetSingle(id);
                posts.Add(new Post
                {
                    Title = textPostTitle.Text,
                    Auth = auth,
                });
                LoadGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void btnDelAuth_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)gridAuth.SelectedRows[0].Cells["Id"].Value;
                authors.Delete(id);
                LoadGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void btnDelPost_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)gridPost.SelectedRows[0].Cells["Id"].Value;
                posts.Delete(id);
                LoadGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void gridAuth_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var auth = authors.GetSingle((int)gridAuth["Id", e.RowIndex].Value);
                if (auth != null)
                {
                    id = auth.Id;
                    textAuthName.Text = auth.Name;
                }
                foreach (Control control in Controls)
                {
                    control.Enabled = false;
                }
                btnEditAuth.Enabled = true;
                textAuthName.Enabled = true;
                textAuthName.SelectAll();
                textAuthName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void gridPost_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var post = posts.GetSingle((int)gridPost["Id", e.RowIndex].Value);
                if (post != null)
                {
                    id = post.Id;
                    textPostTitle.Text = post.Title;
                }
                foreach (Control control in Controls)
                {
                    control.Enabled = false;
                }
                gridAuth.Enabled = true;
                btnEditPost.Enabled = true;
                textPostTitle.Enabled = true;
                textPostTitle.SelectAll();
                textPostTitle.Focus();
                textAuthName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void btnEditAuth_Click(object sender, EventArgs e)
        {
            try
            {
                var auth = authors.GetSingle(id);
                auth.Name = textAuthName.Text;
                authors.Update(auth);
                LoadGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void btnEditPost_Click(object sender, EventArgs e)
        {
            try
            {
                var auth = authors.GetSingle((int)gridAuth.SelectedRows[0].Cells["Id"].Value);
                var post = posts.GetSingle(id);
                post.Title = textPostTitle.Text;
                post.Auth = auth;
                posts.Update(post);
                LoadGrids();
                textPostTitle.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
    }
}
