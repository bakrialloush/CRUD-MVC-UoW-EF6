using CRUD_UoW.Interfaces;
using CRUD_UoW.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CRUD_UoW.Forms
{
    public partial class MainForm : Form
    {
        private readonly IUoW _uow;
        int id;

        public MainForm(IUoW uow)
        {
            InitializeComponent();
            _uow = uow;
            LoadGrids();
        }

        private void LoadGrids()
        {
            id = 0;
            gridAuth.DataSource = _uow.Authors.GetAll().ToList();
            gridPost.DataSource = _uow.Posts.GetAll().ToList();
            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
            btnEditAuth.Enabled = btnEditPost.Enabled = false;
            textAuthName.Text = textPostTitle.Text = "";
        }

        private void BtnAddAuth_Click(object sender, EventArgs e)
        {
            try
            {
                _uow.Authors.Add(new Author
                {
                    Name = textAuthName.Text,
                });
                _uow.Save();
                LoadGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void BtnAddPost_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)gridAuth.SelectedRows[0].Cells["Id"].Value;
                var auth = _uow.Authors.GetSingle(id);
                _uow.Posts.Add(new Post
                {
                    Title = textPostTitle.Text,
                    Auth = auth,
                });
                _uow.Save();
                LoadGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void BtnDelAuth_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)gridAuth.SelectedRows[0].Cells["Id"].Value;
                _uow.Authors.Delete(id);
                _uow.Save();
                LoadGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void BtnDelPost_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)gridPost.SelectedRows[0].Cells["Id"].Value;
                _uow.Posts.Delete(id);
                _uow.Save();
                LoadGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void GridAuth_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var auth = _uow.Authors.GetSingle((int)gridAuth["Id", e.RowIndex].Value);
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

        private void GridPost_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var post = _uow.Posts.GetSingle((int)gridPost["Id", e.RowIndex].Value);
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

        private void BtnEditAuth_Click(object sender, EventArgs e)
        {
            try
            {
                var auth = _uow.Authors.GetSingle(id);
                auth.Name = textAuthName.Text;
                _uow.Authors.Update(auth);
                _uow.Save();
                LoadGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void BtnEditPost_Click(object sender, EventArgs e)
        {
            try
            {
                var auth = _uow.Authors.GetSingle((int)gridAuth.SelectedRows[0].Cells["Id"].Value);
                var post = _uow.Posts.GetSingle(id);
                post.Title = textPostTitle.Text;
                post.Auth = auth;
                _uow.Posts.Update(post);
                _uow.Save();
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
