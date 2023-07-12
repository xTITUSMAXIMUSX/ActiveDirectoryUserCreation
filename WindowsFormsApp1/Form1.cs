using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using Newtonsoft.Json;

[Flags]
public enum UserFlagsEnum : int
{
    UF_SCRIPT = 0x0001,
    UF_ACCOUNTDISABLE = 0x0002,
    UF_HOMEDIR_REQUIRED = 0x0008,
    UF_LOCKOUT = 0x0010,
    UF_PASSWD_NOTREQD = 0x0020,
    UF_PASSWD_CANT_CHANGE = 0x0040,
    UF_ENCRYPTED_TEXT_PASSWORD_ALLOWED = 0x0080,
    UF_TEMP_DUPLICATE_ACCOUNT = 0x0100,
    UF_NORMAL_ACCOUNT = 0x0200,
    UF_INTERDOMAIN_TRUST_ACCOUNT = 0x0800,
    UF_WORKSTATION_TRUST_ACCOUNT = 0x1000,
    UF_SERVER_TRUST_ACCOUNT = 0x2000,
    UF_DONT_EXPIRE_PASSWD = 0x10000,
    UF_MNS_LOGON_ACCOUNT = 0x20000,
    UF_SMARTCARD_REQUIRED = 0x40000,
    UF_TRUSTED_FOR_DELEGATION = 0x80000,
    UF_NOT_DELEGATED = 0x100000,
    UF_USE_DES_KEY_ONLY = 0x200000,
    UF_DONT_REQUIRE_PREAUTH = 0x400000,
    UF_PASSWORD_EXPIRED = 0x800000,
    UF_TRUSTED_TO_AUTHENTICATE_FOR_DELEGATION = 0x1000000
}


namespace ActiveDirectoryUserCreationApp
{
    public partial class ActiveDirectoryTool : Form
    {
        private List<UserConfiguration> configurations; // List to hold the static data from the configuration file
        private string configFile = "config.json"; // Path to the JSON configuration file
        private ServerConfiguration serverConfiguration; // Hold the server configuration details

        public ActiveDirectoryTool()
        {
            InitializeComponent();

            // Set column headers for the DataGridView
            dataGridViewConfigurations.Columns.Add("Name", "Configuration Name");
            dataGridViewConfigurations.Columns.Add("UserEnabled", "Enabled");
            dataGridViewConfigurations.Columns.Add("UserCannotChangePassword", "Cannot Change Password");
            dataGridViewConfigurations.Columns.Add("UserMustChangePassword", "Change Password Next Logon");
            dataGridViewConfigurations.Columns.Add("l", "City");
            dataGridViewConfigurations.Columns.Add("co", "Company");
            dataGridViewConfigurations.Columns.Add("Country", "Country");
            dataGridViewConfigurations.Columns.Add("Department", "Department");
            dataGridViewConfigurations.Columns.Add("Description", "Description");
            dataGridViewConfigurations.Columns.Add("physicaldeliveryofficename", "Office");
            dataGridViewConfigurations.Columns.Add("telephoneNumber", "Telephone Number");
            dataGridViewConfigurations.Columns.Add("wWWHomePage", "Web Page");
            dataGridViewConfigurations.Columns.Add("Mail", "Email Address");
            dataGridViewConfigurations.Columns.Add("streetAddress", "Street Address");
            dataGridViewConfigurations.Columns.Add("postOfficeBox", "PO Box");
            dataGridViewConfigurations.Columns.Add("St", "State");
            dataGridViewConfigurations.Columns.Add("postalCode", "Zip Code");
            dataGridViewConfigurations.Columns.Add("Container", "OU");
            dataGridViewConfigurations.Columns.Add("profilePath", "Profile Path");
            dataGridViewConfigurations.Columns.Add("scriptPath", "Logon script");
            dataGridViewConfigurations.Columns.Add("homeDirectory", "Local path");
            dataGridViewConfigurations.Columns.Add("homeDrive", "Connect");
            dataGridViewConfigurations.Columns.Add("title", "Job Title");
            dataGridViewConfigurations.Columns.Add("manager", "Manager");
            dataGridViewConfigurations.Columns.Add("homePhone", "Home Phone");
            dataGridViewConfigurations.Columns.Add("pager", "Pager");
            dataGridViewConfigurations.Columns.Add("Mobile", "Mobile");
            dataGridViewConfigurations.Columns.Add("facsimileTelephoneNumber", "Fax");
            dataGridViewConfigurations.Columns.Add("ipPhone", "IP Phone");
            dataGridViewConfigurations.Columns.Add("userPrincipalName", "UPN Suffix");
            // Load the static data from the configuration files
            LoadConfigurations();
            LoadServerConfiguration();
        }

        private void LoadConfigurations()
        {
            try
            {
                // Read the JSON configuration file
                string json = File.ReadAllText(configFile);

                // Deserialize the JSON into a dynamic object
                dynamic configData = JsonConvert.DeserializeObject(json);

                // Deserialize the user configurations
                configurations = JsonConvert.DeserializeObject<List<UserConfiguration>>(configData.configurations.ToString());

                // Clear existing data in the ComboBox and DataGridView
                comboBoxConfigurations.Items.Clear();
                dataGridViewConfigurations.Rows.Clear();

                // Add each configuration to the ComboBox and DataGridView
                foreach (UserConfiguration configuration in configurations)
                {
                    comboBoxConfigurations.Items.Add(configuration.Name);
                    dataGridViewConfigurations.Rows.Add(configuration.Name, configuration.UserEnabled, configuration.UserCannotChangePassword, configuration.UserMustChangePassword, configuration.Properties["l"],  configuration.Properties["Company"], configuration.Properties["co"], 
                        configuration.Properties["Department"], configuration.Properties["Description"], configuration.Properties["physicaldeliveryofficename"], configuration.Properties["telephoneNumber"],
                        configuration.Properties["wWWHomePage"], configuration.Properties["Mail"], configuration.Properties["streetAddress"], configuration.Properties["postOfficeBox"], configuration.Properties["St"], 
                        configuration.Properties["postalCode"], configuration.Container, configuration.Properties["profilePath"], configuration.Properties["scriptPath"], configuration.Properties["homeDirectory"],
                        configuration.Properties["homeDrive"], configuration.Properties["title"], configuration.Properties["manager"],
                        configuration.Properties["homePhone"], configuration.Properties["pager"], configuration.Properties["Mobile"], configuration.Properties["facsimileTelephoneNumber"], configuration.Properties["ipPhone"], configuration.Properties["userPrincipalName"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load configurations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadServerConfiguration()
        {
            try
            {
                // Read the JSON server configuration file
                string serverConfigFile = "serverConfig.json";
                string json = File.ReadAllText(serverConfigFile);

                // Deserialize the JSON into a ServerConfiguration object
                serverConfiguration = JsonConvert.DeserializeObject<ServerConfiguration>(json);

                // Access the server configuration properties
                string serverFqdn = serverConfiguration.serverFqdn;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load server configuration details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string firstName = txtfirstName.Text;
            string lastName = txtlastName.Text;
            string fullName = firstName + " " + lastName;

            // Check if the username or password is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both a username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected configuration from the dropdown menu
            string selectedConfiguration = comboBoxConfigurations.SelectedItem as string;

            // Find the selected configuration in the list of configurations
            UserConfiguration configuration = configurations.Find(c => c.Name == selectedConfiguration);

            if (configuration == null)
            {
                MessageBox.Show("Invalid configuration selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create the domain context with the provided admin credentials
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, serverConfiguration.serverFqdn, configuration.Container))
                {
                    // Check if the user already exists
                    UserPrincipal existingUser = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, username);
                    if (existingUser != null)
                    {
                        MessageBox.Show("User already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Create a new user principal object
                    using (UserPrincipal user = new UserPrincipal(context))
                    {
                        // Set the user properties from the selected configuration
                        user.SamAccountName = username;
                        user.GivenName = firstName;
                        user.Surname = lastName;
                        user.SetPassword(password);
                        user.DisplayName = fullName;
                        user.Enabled = configuration.UserEnabled;
                        user.UserCannotChangePassword = configuration.UserCannotChangePassword;

                        if (configuration.UserMustChangePassword == true)
                        {
                            UserPrincipal.Current.ExpirePasswordNow();
                        }
                        // Save the user to Active Directory
                        user.Save();

                        // Get the underlying DirectoryEntry object for the user
                        DirectoryEntry directoryEntry = user.GetUnderlyingObject() as DirectoryEntry;


                        // Set additional properties from the configuration
                        foreach (KeyValuePair<string, string> property in configuration.Properties)
                        {
                            if (!string.IsNullOrEmpty(property.Value))
                            {
                                // Set the property only if it has a non-empty value
                                directoryEntry.Properties[property.Key].Value = property.Value;
                            }
                        }

                        // Set the UPNSuffix property
                        if (configuration.Properties.ContainsKey("userPrincipalName"))
                        {
                            string upnSuffix = configuration.Properties["userPrincipalName"];

                            // Append the UPNSuffix to the username to form the UserPrincipalName
                            string userPrincipalName = $"{username}@{upnSuffix}";
                            directoryEntry.Properties["userPrincipalName"].Value = userPrincipalName;
                        }

                        // Set the manager property if specified in the configuration
                        if (configuration.Properties.ContainsKey("manager"))
                        {
                            string managerValue = configuration.Properties["manager"];


                            // Check if the manager value is not empty
                            if (!string.IsNullOrEmpty(managerValue))
                            {
                                try
                                {
                                    // Find the manager user by SamAccountName
                                    UserPrincipal managerUser = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, managerValue);

                                    if (managerUser == null)
                                    {
                                        MessageBox.Show("Invalid manager username specified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    // Set the manager property
                                    directoryEntry.Properties["manager"].Value = managerUser.DistinguishedName;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("An error occurred while retrieving the manager: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        // Save the changes to the DirectoryEntry
                        directoryEntry.CommitChanges();
                    }
                }

                MessageBox.Show("User created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSaveConfiguration_Click(object sender, EventArgs e)
        {
            string newConfigurationName = txtNewConfigurationName.Text;
            string newCityValue = txtNewCityValue.Text;
            string newUPNSuffixValue = txtUPNSuffixValue.Text;
            string newCompanyValue = txtNewCompanyValue.Text;
            string newCountryValue = txtNewCountryValue.Text;
            string newMailValue = txtNewMailValue.Text;
            string newNewDepartmentValue = txtNewDepartmentValue.Text;
            string newDescriptionValue = txtNewDescriptionValue.Text;
            string newContainerValue = txtNewContainerValue.Text;
            string newOfficeValue = txtNewOfficeValue.Text; 
            string newTelephoneValue = txtNewTelephoneValue.Text;
            string newWebPageValue = txtNewWebPageValue.Text;
            string newStreetValue = txtStreetValue.Text;
            string newPOBoxValue = txtPOBoxValue.Text;
            string newStateValue = txtStateValue.Text;
            string newZipValue = txtZipValue.Text;
            string newProfilePathValue = txtprofilePathValue.Text;
            string newScriptPathValue = txtscriptPathValue.Text;
            string newHomeDirectoryValue = txthomeDirectoryValue.Text;
            string newConnectValue = txtConnectValue.Text;
            string newTitleValue = txtTitleValue.Text;
            string newManagerValue = txtManagerValue.Text;
            string newHomeValue = txtHomePhoneValue.Text;
            string newPagerValue = txtPagerValue.Text;
            string newMobileValue = txtMobileValue.Text;
            string newFaxValue = txtFaxValue.Text;
            string newIPPhoneValue = txtIPPhoneValue.Text;
            bool newEnabled = chbxEnabled.Checked;
            bool newUserCannotChangePassword = chbxCannotChangePassword.Checked;
            bool newUserMustChangePassword = chbxChangePasswordLogon.Checked;

            // Validate the container field
            if (string.IsNullOrEmpty(newContainerValue))
            {
                MessageBox.Show("Please enter a value for the OU field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the container field
            if (string.IsNullOrEmpty(newUPNSuffixValue))
            {
                MessageBox.Show("Please enter a value for the UPN Suffix field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validate teh container field for the proper syntax
            if (!IsValidContainerFormat(newContainerValue))
            {
                MessageBox.Show("Invalid container format. Please enter a valid OU and DC components separated by commas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserConfiguration newConfiguration = new UserConfiguration
            {
                Name = newConfigurationName,
                Container = newContainerValue,
                UserEnabled = newEnabled,
                UserCannotChangePassword = newUserCannotChangePassword,
                UserMustChangePassword = newUserMustChangePassword,
                Properties = new Dictionary<string, string>
        {
            { "l", newCityValue },
            { "userPrincipalName", newUPNSuffixValue },
            { "Company", newCompanyValue },
            { "co", newCountryValue },
            { "Department", newNewDepartmentValue },
            { "Description", newDescriptionValue },
            { "Mail", newMailValue },
            { "physicaldeliveryofficename", newOfficeValue },
            { "telephoneNumber", newTelephoneValue },
            { "wWWHomePage", newWebPageValue },
            { "streetAddress",  newStreetValue},
            { "postOfficeBox",  newPOBoxValue},
            { "St",  newStateValue},
            { "postalCode",  newZipValue},
            { "profilePath",  newProfilePathValue},
            { "scriptPath",  newScriptPathValue},
            { "homeDirectory",  newHomeDirectoryValue},
            { "homeDrive",  newConnectValue},
            { "title",  newTitleValue},
            { "manager",  newManagerValue},
            { "homePhone",  newHomeValue},
            { "pager",  newPagerValue},
            { "Mobile",  newMobileValue},
            { "facsimileTelephoneNumber",  newFaxValue},
            { "ipPhone",  newIPPhoneValue},
        }
            };

            configurations.Add(newConfiguration);

            try
            {
                // Serialize the updated list to JSON
                string json = JsonConvert.SerializeObject(configurations, Formatting.Indented);

                // Write the JSON back to the configuration file
                File.WriteAllText(configFile, json);

                // Update the dropdown menu with the new configuration
                comboBoxConfigurations.Items.Add(newConfigurationName);

                // Add the new configuration to the DataGridView
                dataGridViewConfigurations.Rows.Add(newConfigurationName, newEnabled, newUserCannotChangePassword, newUserMustChangePassword, newCityValue, newCompanyValue, newCountryValue, newNewDepartmentValue,
                    newDescriptionValue, newOfficeValue, newTelephoneValue, newWebPageValue, newMailValue, newStreetValue, newPOBoxValue,
                    newStateValue, newZipValue, newContainerValue, newProfilePathValue, newScriptPathValue, newHomeDirectoryValue, newConnectValue,
                    newTitleValue, newManagerValue, newHomeValue, newPagerValue, newMobileValue, newFaxValue, newIPPhoneValue, newUPNSuffixValue);

                MessageBox.Show("Configuration saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields after saving
                txtNewConfigurationName.Text = string.Empty;
                txtNewCityValue.Text = string.Empty;
                txtNewCompanyValue.Text = string.Empty;
                txtNewMailValue.Text = string.Empty;
                txtNewDepartmentValue.Text = string.Empty;
                txtNewDescriptionValue.Text = string.Empty;
                txtNewContainerValue.Text = string.Empty;
                txtNewOfficeValue.Text = string.Empty;
                txtNewTelephoneValue.Text = string.Empty;
                txtNewWebPageValue.Text = string.Empty;
                txtprofilePathValue.Text = string.Empty;
                txtscriptPathValue.Text = string.Empty;
                txthomeDirectoryValue.Text = string.Empty;
                txtConnectValue.Text = string.Empty;
                txtTitleValue.Text = string.Empty;
                txtManagerValue.Text = string.Empty;
                txtHomePhoneValue.Text = string.Empty;
                txtPagerValue.Text = string.Empty;
                txtMobileValue.Text = string.Empty;
                txtFaxValue.Text = string.Empty;
                txtIPPhoneValue.Text = string.Empty;
                chbxCannotChangePassword.Text = bool.FalseString;
                chbxEnabled.Text = bool.FalseString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save configuration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveConfiguration_Click(object sender, EventArgs e)
        {
            string selectedConfiguration = comboBoxConfigurations.SelectedItem as string;

            UserConfiguration configuration = configurations.Find(c => c.Name == selectedConfiguration);

            if (configuration == null)
            {
                MessageBox.Show("Invalid configuration selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            configurations.Remove(configuration);

            try
            {
                // Serialize the updated list to JSON
                string json = JsonConvert.SerializeObject(configurations, Formatting.Indented);

                // Write the JSON back to the configuration file
                File.WriteAllText(configFile, json);

                // Remove the configuration from the dropdown menu
                comboBoxConfigurations.Items.Remove(selectedConfiguration);

                // Remove the configuration from the DataGridView
                foreach (DataGridViewRow row in dataGridViewConfigurations.Rows)
                {
                    if (row.Cells["Name"].Value.ToString() == selectedConfiguration)
                    {
                        dataGridViewConfigurations.Rows.Remove(row);
                        break;
                    }
                }

                MessageBox.Show("Configuration removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to remove configuration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewConfigurations_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewConfigurations.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridViewConfigurations.Columns.Count)
            {
                DataGridViewCell cell = dataGridViewConfigurations.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string columnName = dataGridViewConfigurations.Columns[e.ColumnIndex].Name;
                string editedValue = cell.Value?.ToString(); // Use null conditional operator to handle null values

                string configurationName = dataGridViewConfigurations.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                UserConfiguration configuration = configurations.Find(c => c.Name == configurationName);

                if (configuration != null)
                {
                    if (columnName == "Enabled")
                    {
                        bool editedBoolValue;
                        if (bool.TryParse(editedValue, out editedBoolValue))
                        {
                            configuration.UserEnabled = editedBoolValue;
                            // Update the configuration in the JSON file
                            UpdateConfigurationsFile();
                        }
                        else
                        {
                            MessageBox.Show("Invalid value for 'Enabled'. Please enter either 'true' or 'false'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (columnName == "UserCannotChangePassword")
                    {
                        bool editedBoolValue;
                        if (bool.TryParse(editedValue, out editedBoolValue))
                        {
                            configuration.UserCannotChangePassword = editedBoolValue;
                            // Update the configuration in the JSON file
                            UpdateConfigurationsFile();
                        }
                        else
                        {
                            MessageBox.Show("Invalid value for 'UserCannotChangePassword'. Please enter either 'true' or 'false'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (columnName == "UserMustChangePassword")
                    {
                        bool editedBoolValue;
                        if (bool.TryParse(editedValue, out editedBoolValue))
                        {
                            configuration.UserMustChangePassword = editedBoolValue;
                            // Update the configuration in the JSON file
                            UpdateConfigurationsFile();
                        }
                        else
                        {
                            MessageBox.Show("Invalid value for 'UserMustChangePassword'. Please enter either 'true' or 'false'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (columnName == "Container")
                    {
                        if (!IsValidContainerFormat(editedValue))
                        {
                            MessageBox.Show("Invalid container format. Please enter a valid OU and DC components separated by commas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string existingValue = configuration.Container;

                            if (!string.Equals(existingValue, editedValue))
                            {
                                configuration.Container = editedValue;
                                // Update the configuration in the JSON file
                                UpdateConfigurationsFile();
                            }
                        }
                    }
                    else if (configuration.Properties.ContainsKey(columnName))
                    {
                        string existingValue = configuration.Properties[columnName];

                        if (!string.Equals(existingValue, editedValue))
                        {
                            configuration.Properties[columnName] = editedValue;
                            // Update the configuration in the JSON file
                            UpdateConfigurationsFile();
                        }
                    }
                }
            }
        }

        private void UpdateConfigurationsFile()
        {
            try
            {
                // Serialize the configurations list to JSON
                string json = JsonConvert.SerializeObject(configurations, Formatting.Indented);

                // Create a wrapper object to hold the configurations array
                var configData = new { configurations = configurations };

                // Serialize the wrapper object to JSON
                string wrappedJson = JsonConvert.SerializeObject(configData, Formatting.Indented);

                // Write the JSON back to the configuration file
                File.WriteAllText(configFile, wrappedJson);

                MessageBox.Show("Configuration updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update configuration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private bool IsValidContainerFormat(string container)
        {
            // Perform your validation logic here
            // For example, you can check if the container has valid OU and DC components separated by commas

            // Sample validation logic: Container should have valid OU and DC components separated by commas
            string[] components = container.Split(',');
            foreach (string component in components)
            {
                string trimmedComponent = component.Trim();

                // Validate OU component
                if (trimmedComponent.StartsWith("OU=") && trimmedComponent.Length > 3)
                {
                    string ouValue = trimmedComponent.Substring(3);
                    if (!ouValue.All(c => char.IsLetterOrDigit(c)))
                    {
                        return false;
                    }
                }
                // Validate DC component
                else if (trimmedComponent.StartsWith("DC=") && trimmedComponent.Length > 3)
                {
                    string dcValue = trimmedComponent.Substring(3);
                    if (!dcValue.All(c => char.IsLetterOrDigit(c) || c == '.'))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }






        // Class representing the server configuration
        public class ServerConfiguration
        {
            public string serverFqdn { get; set; }
        }

        // Class representing the user configuration
        public class UserConfiguration
        {
            public string Name { get; set; }
            public string Container { get; set; }
            public bool UserEnabled { get; set; }
            public bool UserCannotChangePassword { get; set; }
            public bool UserMustChangePassword { get; set; }
            public Dictionary<string, string> Properties { get; set; }
        }
    }
}