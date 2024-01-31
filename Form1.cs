using System.Net;
using WpfApp6.Services;
using WpfApp6.Services.Launch;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateINI.WriteToConfig("Auth", "Email", EmailBox.Text);
            UpdateINI.WriteToConfig("Auth", "Password", PasswordBox.Text);
            UpdateINI.WriteToConfig("Auth", "Path", PathBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Path69 = UpdateINI.ReadValue("Auth", "Path");
                if (Path69 != "NONE") // NONE THE BEST RESPONSE!
                {
                    //MessageBox.Show(Path69);
                    if (File.Exists(System.IO.Path.Join(Path69, "FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe")))
                    {
                        if (UpdateINI.ReadValue("Auth", "Email") == "NONE" || UpdateINI.ReadValue("Auth", "Password") == "NONE")
                        {
                            MessageBox.Show("Please Add Your no info Info In Settings");
                            return;
                        }
                        WebClient OMG = new WebClient();
                        OMG.DownloadFile("yourdll", Path.Combine(Path69, "Engine\\Binaries\\ThirdParty\\NVIDIA\\NVaftermath\\Win64", "GFSDK_Aftermath_Lib.x64.dll"));
                        //AntiCheat.Start(Path69);
                        PSBasics.Start(Path69, "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -noeac -fromfl=be -fltoken=h1cdhchd10150221h130eB56 -skippatchcheck", UpdateINI.ReadValue("Auth", "Email"), UpdateINI.ReadValue("Auth", "Password"));
                        FakeAC.Start(Path69, "FortniteClient-Win64-Shipping_BE.exe", $"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -noeac -fromfl=be -fltoken=h1cdhchd10150221h130eB56 -skippatchcheck", "r");
                        FakeAC.Start(Path69, "FortniteLauncher.exe", $"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -noeac -fromfl=be -fltoken=h1cdhchd10150221h130eB56 -skippatchcheck", "dsf");
                        PSBasics._FortniteProcess.WaitForExit();
                        try
                        {
                            FakeAC._FNLauncherProcess.Close();
                            FakeAC._FNAntiCheatProcess.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("There Been A Error Closing");
                        }



                        //Injector.Start(PSBasics._FortniteProcess.Id, Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "EonCurl.dll"));
                    }
                    else
                    {
                        MessageBox.Show("no info"); // INV
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }

        }
    }
}
