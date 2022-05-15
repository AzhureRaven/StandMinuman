﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StandMinuman
{
	public partial class FormMasterTopping : Form
	{
		DataTable dt;
		public FormMasterTopping()
		{
			InitializeComponent();
		}

		private void kembaliKeMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public void loadTopping()
        {
			string status;
            if (comboBoxAktif.SelectedIndex == 0)
            {
				status = "where status <> 2";
            }
            else if(comboBoxAktif.SelectedIndex == 1)
            {
				status = "where status = 1";
			}
            else
            {
				status = "where status = 0";
			}
			string query = "SELECT id_topping AS 'Id', nama AS 'Nama', harga AS 'Harga', STATUS AS 'Status' from topping "+status;
			if (textBoxSearch.Text != "")
			{
				query += " and nama like '%" + textBoxSearch.Text + "%'";
			}
			try
			{
				MySqlCommand cmd = new MySqlCommand(query, Koneksi.getConn());
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				dt = new DataTable();
				da.Fill(dt);
				dataGridViewTopping.DataSource = null;
				dataGridViewTopping.DataSource = dt;
			}
			catch (Exception)
			{
				MessageBox.Show("Gagal Load Table Minuman!");
			}
		}

		private void FormMasterTopping_Load(object sender, EventArgs e)
		{
			comboBoxAktif.SelectedIndex = 0;
			loadTopping();
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
			loadTopping();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
			Clear();
        }

		public void Clear()
        {
			numericUpDownHarga.Value = 0;
			textBoxId.Text = "";
			textBoxNama.Text = "";
			textBoxSearch.Text = "";
			buttonDelete.Text = "Delete";
			buttonDelete.Enabled = false;
			buttonUpdate.Enabled = false;
			btnInsert.Enabled = true;
		}

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                if (textBoxNama.Text != "")
                {
                    try
                    {
						MySqlCommand cmd = new MySqlCommand();

						cmd.Connection = Koneksi.getConn();

						cmd.CommandText = "INSERT INTO topping VALUES (0,@nama, @harga, 1)";
						cmd.Parameters.Add(new MySqlParameter("@nama", textBoxNama.Text));
						cmd.Parameters.Add(new MySqlParameter("@harga", Convert.ToInt32(numericUpDownHarga.Value.ToString())));
					
						cmd.ExecuteNonQuery();

                        MessageBox.Show("Insert berhasil!");
						Clear();
						ClearSearch();
					}
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                        
                    }
					
				}
                else
                {
                    MessageBox.Show("Isikan nama topping!");
                }
            }
            else
            {
                MessageBox.Show("Dalam mode edit! Hapus seleksi dulu!");
            }
        }

        private void dataGridViewTopping_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dataGridViewTopping.Rows[e.RowIndex].Cells[0].Value.ToString() != "1")
                {
					textBoxId.Text = dataGridViewTopping.Rows[e.RowIndex].Cells[0].Value.ToString();
					textBoxNama.Text = dataGridViewTopping.Rows[e.RowIndex].Cells[1].Value.ToString();
					numericUpDownHarga.Value = Convert.ToInt32(dataGridViewTopping.Rows[e.RowIndex].Cells[2].Value.ToString());
					int status = Convert.ToInt32(dataGridViewTopping.Rows[e.RowIndex].Cells[3].Value.ToString());
					if (status == 0)
					{
						buttonDelete.Text = "Restore";
					}
					else
					{
						buttonDelete.Text = "Delete";
					}
					buttonDelete.Enabled = true;
					buttonUpdate.Enabled = true;
					btnInsert.Enabled = false;
				}
                else
                {
                    MessageBox.Show("No Topping tidak boleh di edit!");
                }
				
			}
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
				if (textBoxNama.Text != "")
				{
					if (textBoxId.Text != "1")
					{
						try
						{
							MySqlCommand cmd = new MySqlCommand();

							cmd.Connection = Koneksi.getConn();

							cmd.CommandText = "UPDATE topping set nama = @nama, harga = @harga WHERE id_topping = "+textBoxId.Text;
							cmd.Parameters.Add(new MySqlParameter("@nama", textBoxNama.Text));
							cmd.Parameters.Add(new MySqlParameter("@harga", Convert.ToInt32(numericUpDownHarga.Value.ToString())));

							cmd.ExecuteNonQuery();

							MessageBox.Show("Update berhasil!");
							Clear();
							ClearSearch();
						}
						catch (Exception a)
						{
							MessageBox.Show(a.Message);

						}
					}
					else
					{
						MessageBox.Show("No Topping tidak boleh di edit!");
					}
				}
				else
				{
					MessageBox.Show("Isikan nama topping!");
				}
			}
            else
            {
				MessageBox.Show("Dalam mode tambah! Pilih topping dulu!");
			}
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
			if(buttonDelete.Text == "Delete")
            {
                if (textBoxId.Text != "1")
                {
					try
					{
						MySqlCommand cmd = new MySqlCommand();

						cmd.Connection = Koneksi.getConn();

						cmd.CommandText = "UPDATE topping set status = 0 WHERE id_topping = " + textBoxId.Text;

						cmd.ExecuteNonQuery();

						MessageBox.Show("Topping dihapus!");
						Clear();
						ClearSearch();
					}
					catch (Exception a)
					{
						MessageBox.Show(a.Message);

					}
				}
                else
                {
					MessageBox.Show("No Topping tidak boleh di delete!");
				}
            }
            else
            {
				try
				{
					MySqlCommand cmd = new MySqlCommand();

					cmd.Connection = Koneksi.getConn();

					cmd.CommandText = "UPDATE topping set status = 1 WHERE id_topping = " + textBoxId.Text;

					cmd.ExecuteNonQuery();

					MessageBox.Show("Topping dikembalikan!");
					Clear();
					ClearSearch();
				}
				catch (Exception a)
				{
					MessageBox.Show(a.Message);

				}
			}
        }

        private void comboBoxAktif_SelectedIndexChanged(object sender, EventArgs e)
        {
			loadTopping();
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
			ClearSearch();
        }

		public void ClearSearch()
        {
			textBoxSearch.Text = "";
			comboBoxAktif.SelectedIndex = 0;
			loadTopping();
        }

    }
}