using CRUD_UoW.Controllers;
using CRUD_UoW.Models;
using System;
using System.Windows.Forms;

namespace CRUD_UoW.Views
{
    public partial class MainForm : Form
    {
        DBContext context;
        AuthorsController authors;
        PostsController posts;
        int id = -1;

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
            gridAuth.DataSource = authors.GetList();
            gridPost.DataSource = posts.GetList();
            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
            btnEditAuth.Enabled = false;
            btnEditPost.Enabled = false;
            textAuthName.Text = "";
            textPostTitle.Text = "";
            id = -1;
        }

        private void btnAddAuth_Click(object sender, EventArgs e)
        {
            authors.Add(new Author
            {
                Name = textAuthName.Text,
            });
            LoadGrids();
        }

        private void btnAddPost_Click(object sender, EventArgs e)
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

        private void btnDelAuth_Click(object sender, EventArgs e)
        {
            int id = (int)gridAuth.SelectedRows[0].Cells["Id"].Value;
            authors.Delete(id);
            LoadGrids();
        }

        private void btnDelPost_Click(object sender, EventArgs e)
        {
            int id = (int)gridPost.SelectedRows[0].Cells["Id"].Value;
            posts.Delete(id);
            LoadGrids();
        }

        private void gridAuth_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void gridPost_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnEditAuth_Click(object sender, EventArgs e)
        {
            var auth = authors.GetSingle(id);
            auth.Name = textAuthName.Text;
            authors.Update(auth);
            LoadGrids();
        }

        private void btnEditPost_Click(object sender, EventArgs e)
        {
            var auth = authors.GetSingle((int)gridAuth.SelectedRows[0].Cells["Id"].Value);
            var post = posts.GetSingle(id);
            post.Title = textPostTitle.Text;
            post.Auth = auth;
            posts.Update(post);
            LoadGrids();
            textPostTitle.Focus();
        }
    }
}
