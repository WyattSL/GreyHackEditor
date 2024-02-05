using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace GreyHackEditor
{
    public partial class Form1 : Form
    {
        // This shall be updated whenever the game updates it's database.
        public const int DeleteVersion = 285;

        public Form1()
        {
            InitializeComponent();
            this.pathBox.ReadOnly = true;
            this.dbTab.Visible = false;
        }
        public class Procs
        {
            public int PID { get; set; }
            public float cpuUsed { get; set; }
            public bool isProtected { get; set; }
            public bool isScript { get; set; }
            public bool isTerminal { get; set; }
            public string nombreProceso { get; set; }
            public string nombreUser { get; set; }
            public float ramUsedMb { get; set; }
            public object remoteNetIDs { get; set; }
            public int remotePID { get; set; }
            public object? routerNetID { get; set; }
        }
        /*
        public class ConfigOSNetworkLan
        {
            public string clientID { get; set; }
            public bool disabledNetwork { get; set; }
            public List<string> idxLocalIPs { get; set; }
            public List<ConfigOSNPC> idxNpcs { get; set; }
            public List<string> idxPublicIPs { get; set; }
            public bool missionCreated { get; set; }
            public KeyValuePair<string, ConfigOSMissionPart> missionParts { get; set; }
            public int netSpeed { get; set; }
            public KeyValuePair<string, List<string>> npcUserNames { get; set; }
            public string publicIP { get; set; }
            public ConfigOSRouterDevice routerDevice { get; set; }
            public int seed { get; set; }
            public int typePlace { get; set; }
            public KeyValuePair<string, List<string>> userBankIds { get; set; }

        }
        /*
        public class ConfigOSPersona
        {
            public string ID { get; set; }
            public string apellido { get; set; }
            public string computerNetID { get; set; }
            public List<object> currentTraces { get; set; }
            public int edad { get; set; }
        }
        */
        public class ConfigOSCredential
        {
            public string encPassword { get; set; }
            public string password { get; set; }
            public string userName { get; set; }
        }
        public class ConfigOS
        {
            public int activeNetCard { get; set; }
            public string coinName { get; set; }
            public string coinPass { get; set; }
            public string? ctfCreds { get; set; }
            public int cupones { get; set; }
            public string ipLocal { get; set; }
            public string ipPublica { get; set; }
            public bool isRented { get; set; }
            public string? ispGatewayEth { get; set; }
            public string? ispLocalIpEth { get; set; }
            public string origIpPublica { get; set; }
            public string pcName { get; set; }
            public List<JsonNode> personas { get; set; }
            public string playerID { get; set; }
            public JsonNode puertos { get; set; }
            public string rentalHomeIP { get; set; }
            public bool saved { get; set; }
            public JsonNode savedNetworks { get; set; }
            public JsonNode servicos { get; set; }
            public ConfigOSCredential? userBank { get; set; }
            public ConfigOSCredential? userMail { get; set; }
            public string walletID { get; set; }
            public string? backupFirewall { get; set; }
            public string? backupPassRootRented { get; set; }
            public string? backupPorts { get; set; }
            public string? backupRented { get; set; }
            public bool? isHomeNetwork { get; set; }
            public JsonNode? networkLan { get; set; }
            public JsonNode? reverseShells { get; set; }
            public string? routerPassword { get; set; }

        }
        public class UserKarma
        {
            public int karma { get; set; }
            public int pendingMission { get; set; }
            public List<JsonNode> previousKarma { get; set; }
        }
        public class User
        {
            public List<string> grupos { get; set; }
            public bool isDeletable { get; set; }
            public UserKarma karma { get; set; }
            public string nombreUsuario { get; set; }
            public string passPlano { get; set; }
            public string password { get; set; }
            public int totalExp { get; set; }
        }
        public class BankTransaction
        {
            public int cantidad { get; set; }
            public string cuenta { get; set; }
            public string fecha { get; set; }
            public string motivo { get; set; }
            public bool success { get; set; }
        }
        public class BankTransactions
        {
            public string account { get; set; }
            public bool isPlayer { get; set; }
            public float dinero { get; set; }
            public string password { get; set; }
            public List<BankTransaction> transacciones { get; set; }
        }
        public class FileSystemThing
        {
            public string group { get; set; }
            public bool isDefaultContent { get; set; }
            public bool isProtected { get; set; }
            public string missionID { get; set; }
            public string nombre { get; set; } // path
            public string owner { get; set; }
            public object permisos { get; set; } // permissions
            public string process { get; set; }
            public string serverPath { get; set; }
            public int size { get; set; }
            public int typeFile { get; set; }
            public string comando { get; set; }
        }
        public class FileSystemFile : FileSystemThing
        {
            public bool allowImport { get; set; }
            public string ID { get; set; }
            public string? desc { get; set; }
            public JsonNode? helperImport { get; set; }
            public bool isBinario { get; set; }
            public bool isEditedOtherPlayer { get; set; }
            public string origOwnerID { get; set; }
            public int precio { get; set; }
            public bool saved { get; set; }
        }
        public class FileSystemFolder : FileSystemThing
        {
            public List<FileSystemFolder> folders { get; set; }
            public List<FileSystemFile> files { get; set; }
        }
        public class HardwareBase
        {
            public string ID { get; set; }
            public float health { get; set; }
            public int precio { get; set; }
            public int quality { get; set; }
            public float reqPower { get; set; }
            public string name { get; set; }
        }
        public class HardwareCPU : HardwareBase
        {
            public int numCores { get; set; }
            public string socket { get; set; }
            public float speed { get; set; }
        }
        public class HardwareGPU : HardwareBase
        {
            public int hashrate { get; set; }
        }
        public class HardwareHardDisk : HardwareBase
        {
            public int actualSpeed { get; set; }
            public int affectPerformance { get; set; }
            public int performance { get; set; }
            public int speed { get; set; }
            public int totalSize { get; set; }
        }
        public class HardwareMotherBoard : HardwareBase
        {
            public string cpuSocket { get; set; }
            public int maxRamSocket { get; set; }
            public int numCpus { get; set; }
            public int numPci { get; set; }
            public int numRamSockets { get; set; }
            public int ramModel { get; set; }
        }
        public class HardwareNetworkDevice : HardwareBase
        {
            public string bssidAp { get; set; }
            public string essidAp { get; set; }
            public bool isWifi { get; set; }
            public bool monitorSupport { get; set; }
            public bool monitorEnabled { get; set; }
        }
        public class HardwarePowerSupply : HardwareBase
        {
            public int power { get; set; }
        }
        public class HardwareRam : HardwareBase
        {
            public int memory;
            public int ramModel;
        }
        public class HardwareContainer
        {
            public List<HardwareCPU> cpus { get; set; }
            public HardwareGPU gpu { get; set; }
            public HardwareHardDisk hardDisk { get; set; }
            public HardwareMotherBoard motherBoard { get; set; }
            public List<HardwareNetworkDevice> networkDevices { get; set; }
            public HardwarePowerSupply powerSupply { get; set; }
            public List<HardwareRam> rams { get; set; }

            // Ensures that the HardwareContainer is properly configured.
            // Returns a empty list if valid, or a list of strings with errors.
            public List<string> Validate()
            {
                List<string> problems = new List<string>();
                foreach (HardwareCPU i in this.cpus)
                {
                    if (i.socket != this.motherBoard.cpuSocket) problems.Add("CPU " + i.name + " is of socket " + i.socket + " but motherboard is socket " + this.motherBoard.cpuSocket);
                }
                if (this.cpus.Count > this.motherBoard.numCpus) problems.Add("There are " + this.cpus.Count + " CPUs, but motherboard only has " + this.motherBoard.numCpus + " slots");
                return problems;
            }
        }

        private SqliteConnection GetConnection()
        {
            return new SqliteConnection("Data Source=" + this.pathBox.Text);
        }
        private string MD5(string s)
        {
            using var provider = System.Security.Cryptography.MD5.Create();
            StringBuilder builder = new StringBuilder();

            foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                builder.Append(b.ToString("x2").ToLower());

            return builder.ToString();
        }

        private void CorruptDatabaseError(string? s)
        {
            if (s == null) s = "";
            MessageBox.Show(@"There was an issue processing this database file. \n" + s, "Horrific Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ShowDatabaseLockedError()
        {
            MessageBox.Show(@"The database appears to be locked. Please ensure that the game is not using the database. If the game is not open, try restarting this program.", "Horrific Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // https://stackoverflow.com/questions/47256792/c-sharp-how-to-detect-if-sqlite-db-is-locked
        public bool IsDatabaseLocked()
        {
            bool locked = true;
            SqliteConnection connection = GetConnection();
            connection.Open();

            try
            {
                SqliteCommand beginCommand = connection.CreateCommand();
                beginCommand.CommandText = "BEGIN EXCLUSIVE"; // tries to acquire the lock
                                                              // CommandTimeout is set to 0 to get error immediately if DB is locked 
                                                              // otherwise it will wait for 30 sec by default
                beginCommand.CommandTimeout = 0;
                beginCommand.ExecuteNonQuery();

                SqliteCommand commitCommand = connection.CreateCommand();
                commitCommand.CommandText = "COMMIT"; // releases the lock immediately
                commitCommand.ExecuteNonQuery();
                locked = false;
            }
            catch (SqliteException)
            {
                // database is locked error
            }
            finally
            {
                connection.Close();
            }

            return locked;
        }


        private void pathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Steam\\steam\\steamapps\\common\\Grey Hack\\Grey Hack_Data";
            ofd.Filter = "SQLite Database Files (*.db)|*.db";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() != DialogResult.OK) return;
            this.pathBox.Text = ofd.FileName;

            using (var connection = GetConnection())
            {
                connection.Open();

                var command2 = connection.CreateCommand();
                command2.CommandText =
                    @"
                        SELECT DeleteVersion,Clock
                        FROM InfoGen
                    ";
                int thisVersion;
                string curTime;
                using (var reader = command2.ExecuteReader())
                {
                    if (reader.FieldCount <= 0)
                    {
                        CorruptDatabaseError("Error while retrieving InfoGen");
                        return;
                    }
                    reader.Read();
                    thisVersion = reader.GetInt32(0);
                    curTime = reader.GetString(1);
                }

                if (thisVersion != DeleteVersion)
                {
                    DialogResult res = MessageBox.Show(
                        @"This tool is designed for use with database version " + DeleteVersion.ToString() + ". The target database is version " + thisVersion.ToString() + ".\n" +
                         "Usage of this tool on an outdated database - or one newer than this tool is designed for - can corrupt the database.", "Warning: Database Version Mismatch",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (res == DialogResult.Cancel) return;
                }

                var command = connection.CreateCommand();
                command.CommandText =
                    @"
                        SELECT Users, ConfigOS
                        FROM Computer
                        WHERE IsPlayer = 1
                    ";

                string usersJson;
                string configosJson;

                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    usersJson = reader.GetString(0);
                    configosJson = reader.GetString(1);
                }

                ConfigOS? cos = JsonSerializer.Deserialize<ConfigOS>(configosJson);
                List<User>? usl = JsonSerializer.Deserialize<List<User>>(usersJson);

                if (cos != null && usl != null && usl.Count >= 2)
                {
                    this.compData.Text = usl[1].nombreUsuario + "@" + cos.pcName;
                }
                else
                {
                    this.compData.Text = "horrible error";
                }
                if (curTime != null)
                {
                    curTime = curTime.Replace("\"", "");
                    DateTime d;
                    if (DateTime.TryParse(curTime, out d))
                    {
                        this.dbTime.Text = d.ToString();
                    }
                    else
                    {
                        this.dbTime.Text = "failed to parse";
                    }
                }
                else
                {
                    this.dbTime.Text = "horrible error";
                }

                this.dbTab.Visible = true;
                this.computerComboBox.Items.Clear();

                var command3 = connection.CreateCommand();
                command3.CommandText = @"
                    SELECT ConfigOS
                    FROM Computer
                    ORDER BY IsPlayer DESC
                ";
                using (var reader = command3.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var configjson = reader.GetString(0);
                        if (configjson == null) continue;
                        var cons = JsonSerializer.Deserialize<ConfigOS>(configjson);
                        if (cons == null) continue;
                        string s = cons.pcName + " @ " + cons.ipPublica + " : " + cons.ipLocal;
                        this.computerComboBox.Items.Add(s);
                    }
                }
                this.computerComboBox.SelectedIndex = 0;
                this.bankComboBox.Items.Clear();

                var command4 = connection.CreateCommand();
                command4.CommandText = @"
                    SELECT Transactions, User, Password
                    FROM BankAccounts
                ";
                using (var reader = command4.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var un = reader.GetString(1);
                        //var pw = reader.GetString(2);
                        var transJson = reader.GetString(0);
                        if (transJson == null || un == null) continue;
                        var trans = JsonSerializer.Deserialize<BankTransactions>(transJson);
                        if (trans == null) continue;
                        string s = un + " $" + trans.dinero;
                        this.bankComboBox.Items.Add(s);
                    }
                }
                this.bankComboBox.SelectedIndex = 0;

                connection.Close();
            }

            // Input Handlers
            bankBalanceBox.LostFocus += applyBankBalanceBox;
            bankPasswordBox.LostFocus += applyBankPasswordBox;
        }


        private void TagUpdate(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c.Tag == "HasPassword" && c is TextBox) ((TextBox)c).UseSystemPasswordChar = hidePasswords.Checked;
                if (c.HasChildren) TagUpdate(c.Controls);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/WyattSL/GreyHackEditor",
                    UseShellExecute = true
                });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hidePasswords_CheckedChanged(object sender, EventArgs e)
        {
            TagUpdate(this.Controls);
        }
        private void computerComboxBox_SelectedIndexChange(object sender, EventArgs e)
        {

        }

        private string bankActiveUsername;
        private BankTransactions bankActiveTransactions;

        private void bankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string boxText = this.bankComboBox.Text;
            string username = boxText.Split(" $")[0];
            this.bankActiveUsername = username;
            using (var connection = GetConnection())
            {
                connection.Open();

                var command1 = connection.CreateCommand();
                command1.CommandText = "SELECT Transactions,User,Password FROM BankAccounts WHERE User = $user";
                command1.Parameters.AddWithValue("$user", username);
                var reader = command1.ExecuteReader();
                reader.Read();
                var transjson = reader.GetString(0);
                var user = reader.GetString(1);
                var pass = reader.GetString(2);
                if (transjson == null || pass == null)
                {
                    CorruptDatabaseError("Error while retrieving bank information.");
                    return;
                }
                var transactions = JsonSerializer.Deserialize<BankTransactions>(transjson);
                this.bankActiveTransactions = transactions;
                this.bankBalanceBox.Value = (decimal)transactions.dinero;
                this.bankPasswordBox.Text = pass;

                foreach (BankTransaction t in transactions.transacciones)
                {
                    this.bankTransactionList.Text += "$" + t.cantidad + " to " + t.cuenta + " on " + t.fecha + " for " + t.motivo + ".\n";
                }

                connection.Close();
            }
        }

        private async void applyBankBalanceBox(object sender, EventArgs e)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                if (IsDatabaseLocked())
                {
                    ShowDatabaseLockedError();
                    return;
                }

                this.bankActiveTransactions.dinero = (float)this.bankBalanceBox.Value;
                string transStr = JsonSerializer.Serialize<BankTransactions>(this.bankActiveTransactions);

                var command1 = connection.CreateCommand();
                command1.CommandText = "UPDATE BankAccounts SET Transactions = $trans WHERE User = $user";
                command1.Parameters.AddWithValue("$trans", transStr);
                command1.Parameters.AddWithValue("$user", this.bankActiveUsername);

                command1.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void applyBankPasswordBox(object sender, EventArgs e)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                var command1 = connection.CreateCommand();
                command1.CommandText = "UPDATE BankAccounts SET Password = $pass WHERE User = $user";
                command1.Parameters.AddWithValue("$pass", this.bankPasswordBox.Text);
                command1.Parameters.AddWithValue("$user", this.bankActiveUsername);

                command1.ExecuteNonQuery();

                var command2 = connection.CreateCommand();
                command2.CommandText = "SELECT ConfigOS FROM Computer WHERE IsPlayer = 1";
                var reader2 = command2.ExecuteReader();
                reader2.Read();
                string cosJson = reader2.GetString(0);
                ConfigOS cos = JsonSerializer.Deserialize<ConfigOS>(cosJson);
                cos.userBank.password = this.bankPasswordBox.Text;
                cos.userBank.encPassword = MD5(this.bankPasswordBox.Text);

                var command3 = connection.CreateCommand();
                command3.CommandText = "UPDATE Computer SET ConfigOS = $cos WHERE IsPlayer = 1";
                command3.Parameters.AddWithValue("$cos", JsonSerializer.Serialize<ConfigOS>(cos));

                command3.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void computerUsersTable_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e == null) return;
            string n = this.computerUsersTable.Columns[e.ColumnIndex].Name;
            if (n == "karma" || n == "xp")
            {
                int newInteger;
                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger) || newInteger < 0) {
                    e.Cancel = true;
                    computerUsersTable.Rows[e.RowIndex].ErrorText = "The "+n+" value must be a number greater than 0.";
                } else
                {
                    computerUsersTable.Rows[e.RowIndex].ErrorText = null;
                }
            }
        }
    }
}
