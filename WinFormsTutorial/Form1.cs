using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFormsTutorial
{
    public partial class Form1 : Form
    {
        //initialised variables
        ColorDialog colorDialog1 = new ColorDialog();
        private const string FOLDER = "C:\\Users\\Public\\Pictures\\Sample Pictures";
        private const string FOLDER2 = "C:\\Users\\Rachel Griffiths\\Pictures\\Wallpapers\\Mass Effect";
        private string[] _picturesToDisplayRight;
        private string[] _picturesToDisplayLeft;
        private int _currentDisplayIndexRight = 0;
        private int _currentDisplayIndexLeft = 0;
        string jpeg = "*.jpg";
        
        private System.Timers.Timer _timer;

        public Form1()
        {
            

            InitializeComponent();
            if (Directory.Exists(FOLDER))
            {
                _picturesToDisplayLeft = Directory.GetFiles(FOLDER, jpeg);
                
                _picturesToDisplayRight = Directory.GetFiles(FOLDER,jpeg);
                UpdateImage();
            }
            else
            {
                _picturesToDisplayLeft = Directory.GetFiles(FOLDER2, jpeg);
               
                _picturesToDisplayRight = Directory.GetFiles(FOLDER2,jpeg);
                UpdateImage();
            }

            _timer = new System.Timers.Timer(10000);

            _timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);

            _timer.AutoReset = true;

            _timer.Enabled = true;

            
        }







        //methods 

        private void Timer_Elapsed(object sender, EventArgs e)
        {
          if (chkPauseRight.Checked == false && chkPauseLeft.Checked == false)
            {
                MoveBothImages();
            }

           else
           {
             if (chkPauseRight.Checked == false){
            MoveNextImageRight();
            }
            if(chkPauseLeft.Checked == false){
            MoveNextImageLeft();
            }
          }
        }

        private void MoveBothImages()
        {
            _currentDisplayIndexLeft++;
            _currentDisplayIndexRight++;
            
            if (_currentDisplayIndexLeft >= _picturesToDisplayLeft.Length)
            {
                _currentDisplayIndexLeft = 0;
            }
          

            if (_currentDisplayIndexRight >= _picturesToDisplayRight.Length)
            {
                _currentDisplayIndexRight = 0;
            }
            UpdateImage();
       }

        private void MoveNextImageLeft()
        {
            _currentDisplayIndexLeft++;

            if (_currentDisplayIndexLeft >= _picturesToDisplayLeft.Length)
                _currentDisplayIndexLeft = 0;

            UpdateImage();
            
        }

        private void MovePreviousImageLeft()
        {
            _currentDisplayIndexLeft--;

            if (_currentDisplayIndexLeft < 0)
                _currentDisplayIndexLeft = (_picturesToDisplayLeft.Length - 1);

            UpdateImage();
            
        }

        private void MoveNextImageRight()
        {
            _currentDisplayIndexRight++;

            if (_currentDisplayIndexRight >= _picturesToDisplayRight.Length) 
                _currentDisplayIndexRight = 0;

            UpdateImage();
           
        }

        private void MovePreviousImageRight()
        {
            _currentDisplayIndexRight--;

            if (_currentDisplayIndexRight < 0)
                _currentDisplayIndexRight = (_picturesToDisplayRight.Length-1);

            UpdateImage();
            
        }
        //key methods

          delegate void UpdateStatusCallback(string currentImageLeft, string currentImageRight);

        private void UpdateStatus(string currentImageLeft, string currentImageRight)
        {
            if (lblStatusLeft.InvokeRequired || lblStatusRight.InvokeRequired)
            {
                UpdateStatusCallback callback = new UpdateStatusCallback(UpdateStatus);
                Invoke(callback, currentImageLeft, currentImageRight);
            }
            else
            {
                lblStatusLeft.Text = "Showing: " + currentImageLeft;
                lblStatusRight.Text = "Showing: " + currentImageRight; //this is causing the exception when the timer runs out.
            }
        }

        private void updateCurrentFilePath(int side) //updates the main directory if the user manually selects a file using the show button
        {
            String currentFile = openFileDialog1.FileName;
            FileInfo fileInfo = new FileInfo(currentFile);
            string dirFullPath = fileInfo.DirectoryName;
                       
            if (side == 2) //right
            {
                
                _picturesToDisplayRight = Directory.GetFiles(dirFullPath, jpeg);
               

            }
            else if (side == 1) //left
            {
                
                _picturesToDisplayLeft = Directory.GetFiles(dirFullPath, jpeg);
                
            }
            
        }

        private void UpdateImage()
        {
            String currentImageFile = _picturesToDisplayLeft[_currentDisplayIndexLeft];
            String currentImageFile2 = _picturesToDisplayRight[_currentDisplayIndexRight];

            pictureBox1.Load(currentImageFile);
            pictureBox2.Load(currentImageFile2);
        
            UpdateStatus(currentImageFile, currentImageFile2);
        }

        //button events - LEFT

        private void btnShowLeft_Click(object sender, EventArgs e)
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        int side = 1; // 1 = left
                        updateCurrentFilePath(side);
                        _timer.Stop();
                        _timer.Start();
                        pictureBox1.Load(openFileDialog1.FileName);
                        lblStatusLeft.Text = "Showing: " + openFileDialog1.FileName;
                    }
                }

        private void btnClearLeft_Click(object sender, EventArgs e)
                {
                    pictureBox1.Image = null;
                }


        private void btnNextLeft_Click(object sender, EventArgs e)
        {
            MoveNextImageLeft();
            _timer.Stop();
            _timer.Start();
        }

        private void btnPreviousLeft_Click(object sender, EventArgs e)
        {
            MovePreviousImageLeft();
            _timer.Stop();
            _timer.Start();
        }


        private void checkBoxLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLeft.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }



        //button events - RIGHT


        private void showButton_Click(object sender, EventArgs e) //on click open a file search dialog box. Open picture at that file name in picturebox1
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                int side = 2; // 2 = right
                updateCurrentFilePath(side);
                _timer.Stop();
                _timer.Start();
                pictureBox2.Load(openFileDialog1.FileName);
                lblStatusRight.Text = "Showing: " + openFileDialog1.FileName;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MoveNextImageRight();
            _timer.Stop();
            _timer.Start();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            MovePreviousImageRight();
            _timer.Stop();
            _timer.Start();
        }

       
    }
}
