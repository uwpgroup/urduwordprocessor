using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using System.IO;

namespace UrduWordProcessor
{
    public partial class FacebookPublishForm : Form
    {
        // Attributes declaration
        string photoPath;
        FacebookClient fb;
        public string AccessToken { set; get; }
        public string Type { set; get; }
        public string PageID { set; get; }

        // Constructor declaration
        public FacebookPublishForm()
        {
            InitializeComponent();
            photoPath = "";
        }

        // Method declaration
        /// <summary>
        /// This method posts to Facebook wall
        /// </summary>
        private void postToWall()
        {
            try
            {
                FacebookClient fb = new FacebookClient(AccessToken);

                if (photoPath.Equals(""))
                {
                    dynamic result = fb.Post("me/feed", new { message = textBox1.Text });
                    string id = result.id.ToString();
                    if (!id.Equals(""))
                        MessageBox.Show("Successfuly Posted!");
                }
                else
                {
                    Stream stream = File.OpenRead(photoPath);
                    dynamic result = fb.Post("me/photos",
                                        new
                                        {
                                            message = textBox1.Text,
                                            file = new FacebookMediaStream
                                            {
                                                ContentType = "image/" + photoPath.Substring(photoPath.Length - 3, 3),
                                                FileName = Path.GetFileName(photoPath)
                                            }.SetValue(stream)
                                        });
                    string id = result.id.ToString();
                    if (!id.Equals(""))
                        MessageBox.Show("Successfuly Posted!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// This method posts to facebook page
        /// </summary>
        private void postToPage()
        {
            try
            {
                FacebookClient fb = new FacebookClient(AccessToken);

                if (photoPath.Equals(""))
                {
                    dynamic result = fb.Post("feed/" + PageID, new { message = textBox1.Text });
                    string id = result.id.ToString();
                    if (!id.Equals(""))
                        MessageBox.Show("Successfuly Posted!");
                }
                else
                {
                    Stream stream = File.OpenRead(photoPath);
                    dynamic result = fb.Post(PageID + "?id=" + PageID + "&sk=photos_stream",
                                        new
                                        {
                                            message = textBox1.Text,
                                            file = new FacebookMediaStream
                                            {
                                                ContentType = "image/" + photoPath.Substring(photoPath.Length - 3, 3),
                                                FileName = Path.GetFileName(photoPath)
                                            }.SetValue(stream)
                                        });
                    string id = result.id.ToString();
                    if (!id.Equals(""))
                        MessageBox.Show("Successfuly Posted!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
        // Event Listeners
        private void checkBoxPhotoUpload_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPhotoUpload.Checked == true)
                buttonBrowse.Enabled = true;
            else
                buttonBrowse.Enabled = false;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                photoPath = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(photoPath);
            }
        }

        private void buttonPostToFB_Click(object sender, EventArgs e)
        {
            if (Type.Equals("wall"))
            {
                postToWall();
            }
            else if (Type.Equals("page"))
            {
                postToPage();
            }
        }
    }
}
