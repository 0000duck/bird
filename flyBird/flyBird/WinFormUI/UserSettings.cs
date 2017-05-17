using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using flyBird.Contacts;

namespace flyBird.WinFormUI
{
    public partial class UserSettings : UserControl
    {
        private MainForm mainForm;
        public UserSettings(MainForm mf)
        {
            InitializeComponent();
            myProfile = ContactsStore.getInstance().getMyProfile();
            loadExisting();
            mainForm = mf;
        }

        private Contact myProfile;
        private string dp = "";
        private string contactsPath = "Contacts";


        private void loadExisting()
        {
            Console.WriteLine("name: " + myProfile.name);
            nameText.Text = myProfile.name;
            
            if (myProfile.displayProfile != "")
            {
                Console.WriteLine("contact pic added to contact");
                userPicture.Image = Image.FromFile(myProfile.displayProfile);
                dp = myProfile.displayProfile;
            }
        }


        private void choosePicBtn_Click(object sender, EventArgs e)
        {
            string filePath;
            using (OpenFileDialog o = new OpenFileDialog())
            {
                o.Filter = "Image Files (*.jpg*,.jpg,*.jpeg,*.png,*.gif;)|*.jpg;*.jpeg;*.png;*.gif;";
                o.Multiselect = false;

                if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    filePath = o.FileName;
                    Image im = Image.FromFile(filePath);
                    userPicture.Image = im;
                    Console.WriteLine(filePath);

                    string imageName = Path.GetFileName(filePath);
                    System.IO.Directory.CreateDirectory(contactsPath);

                    dp = contactsPath+"\\" + imageName;
                    
                    // File.SetAttributes(contactsPath, FileAttributes.Normal);

                    File.Copy(filePath, dp, true);

                    Console.WriteLine("contact path:" + Path.GetFullPath(dp) + "\nfile path: " + filePath);
                }
            }
        }

        private void saveChangesBtn_Click_1(object sender, EventArgs e)
        {
            string name = nameText.Text;

            string displayProfile = dp;

            ContactsStore.getInstance().updateMyProfile(ContactBuilder.GetMacAddress(),name,dp);

            mainForm.setMyProfileDetails();
            mainForm.backPic_Click(sender,e);
        }

        private void nameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                saveChangesBtn_Click_1(sender,EventArgs.Empty);
            }
        }
    }
}