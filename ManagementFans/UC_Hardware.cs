using OpenHardwareMonitor.Hardware;
using OpenHardwareMonitor.Hardware.CPU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManagementFans
{
    public partial class UC_Hardware : UserControl
    {
        private Computer computer;
        private ImageList imageListIcon;
        public UC_Hardware()
        {
            InitializeComponent();

            // Initialisation de OpenHardwareMonitor
            computer = new Computer();
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.RAMEnabled = true;
            computer.HDDEnabled = true;
            computer.FanControllerEnabled = true;
            computer.Open();

            LV_InfoHardware.View = View.Details;
            LV_InfoHardware.HeaderStyle = ColumnHeaderStyle.None;
            LV_InfoHardware.Columns.Add("H_info", 350); // Colonne pour le texte

            // Initialisation de l'ImageList
            imageListIcon = new ImageList();
            imageListIcon.ImageSize = new Size(16, 16); // Taille des images

            // Affectation de l'ImageList au contrôle ListView
            LV_InfoHardware.SmallImageList = imageListIcon;

        }

        private void UC_Hardware_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                // Efface les éléments précédents
                LV_InfoHardware.Items.Clear();

                imageListIcon.Images.Add(Properties.Resources.cpu);
                imageListIcon.Images.Add(Properties.Resources.gpu);
                imageListIcon.Images.Add(Properties.Resources.ram);
                imageListIcon.Images.Add(Properties.Resources.hdd);
                imageListIcon.Images.Add(Properties.Resources.fan);
                imageListIcon.Images.Add(Properties.Resources.thermometre);

                LV_InfoHardware.Items.Add(new ListViewItem("######### CPU #########", 0));
                // Ajoute les informations CPU
                foreach (var hardware in computer.Hardware)
                {
                    if (hardware.HardwareType == HardwareType.CPU)
                    {
                        hardware.Update();
                        LV_InfoHardware.Items.Add($"CPU: {hardware.Name}");
                        LV_InfoHardware.Items.Add($"ID: {hardware.Identifier}");
                        foreach (var sensor in hardware.Sensors)
                        {
                            LV_InfoHardware.Items.Add($"Name sensor: {sensor.Name}");
                            LV_InfoHardware.Items.Add($"Type: {sensor.SensorType}");
                            LV_InfoHardware.Items.Add($"Value: {sensor.Value}");
                            if (sensor.SensorType == SensorType.Temperature)
                            {
                                LV_InfoHardware.Items.Add($"Temperature: {sensor.Value}°C");
                            }
                            if (sensor.SensorType == SensorType.Clock)
                            {
                                LV_InfoHardware.Items.Add($"Clock: {sensor.Value}");
                            }
                        }
                    }
                }

                LV_InfoHardware.Items.Add(new ListViewItem("######### GPU #########", 1));
                // Ajoute les informations GPU
                foreach (var hardware in computer.Hardware)
                {
                    if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAti)
                    {
                        hardware.Update();
                        LV_InfoHardware.Items.Add($"GPU: {hardware.Name}");
                        LV_InfoHardware.Items.Add($"ID: {hardware.Identifier}");
                        foreach (var sensor in hardware.Sensors)
                        {
                            LV_InfoHardware.Items.Add($"Name sensor: {sensor.Name}");
                            if (sensor.SensorType == SensorType.Temperature)
                            {
                                LV_InfoHardware.Items.Add($"Temperature: {sensor.Value}°C");
                            }
                            if (sensor.SensorType == SensorType.Voltage)
                            {
                                LV_InfoHardware.Items.Add($"Voltage: {sensor.Value} V");
                            }
                            if (sensor.SensorType == SensorType.Power)
                            {
                                LV_InfoHardware.Items.Add($"Power: {sensor.Value}");
                            }
                            if (sensor.SensorType == SensorType.Clock)
                            {
                                LV_InfoHardware.Items.Add($"Clock: {sensor.Value}");
                            }
                        }
                    }
                }

                LV_InfoHardware.Items.Add(new ListViewItem("######### RAM #########", 2));
                // Ajoute les informations RAM
                foreach (var hardware in computer.Hardware)
                {
                    if (hardware.HardwareType == HardwareType.RAM)
                    {
                        hardware.Update();
                        LV_InfoHardware.Items.Add($"RAM: {hardware.Name}");
                        LV_InfoHardware.Items.Add($"ID: {hardware.Identifier}");
                        foreach (var sensor in hardware.Sensors)
                        {
                            LV_InfoHardware.Items.Add($"Name sensor: {sensor.Name}");
                            if (sensor.SensorType == SensorType.Data)
                            {
                                LV_InfoHardware.Items.Add($"Used Memory: {sensor.Value} MB");
                            }
                            if (sensor.SensorType == SensorType.Temperature)
                            {
                                LV_InfoHardware.Items.Add($"Temperature: {sensor.Value}°C");
                            }
                        }
                    }
                }

                LV_InfoHardware.Items.Add(new ListViewItem("######### HDD #########", 3));
                // Ajoute les informations HDD
                foreach (var hardware in computer.Hardware)
                {
                    if (hardware.HardwareType == HardwareType.HDD)
                    {
                        hardware.Update();
                        LV_InfoHardware.Items.Add($"HDD: {hardware.Name}");
                        LV_InfoHardware.Items.Add($"ID: {hardware.Identifier}");
                        foreach (var sensor in hardware.Sensors)
                        {
                            LV_InfoHardware.Items.Add($"Name sensor: {sensor.Name}");
                            if (sensor.SensorType == SensorType.Load)
                            {
                                LV_InfoHardware.Items.Add($"Used space: {sensor.Value}");
                            }
                            if (sensor.SensorType == SensorType.Temperature)
                            {
                                LV_InfoHardware.Items.Add($"Temperature: {sensor.Value}°C");
                            }
                        }
                    }
                }

                LV_InfoHardware.Items.Add(new ListViewItem("######### FAN #########", 4));
                // Ajoute les informations sur les ventilateurs (Fans)
                ManagementObjectSearcher fanSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Fan");
                foreach (ManagementObject fan in fanSearcher.Get())
                {
                    string fanName = fan["Name"].ToString();
                    string fanDeviceID = fan["DeviceID"] != null ? fan["DeviceID"].ToString() : "N/A";
                    string fanDescription = fan["Description"] != null ? fan["Description"].ToString() : "N/A";
                    string fanStatus = fan["Status"] != null ? fan["Status"].ToString() : "N/A";
                    string desiredSpeed = fan["DesiredSpeed"] != null ? fan["DesiredSpeed"].ToString() : "N/A";

                    // Gérer le cas où la propriété VariableSpeed n'existe pas
                    bool? variableSpeed = fan["VariableSpeed"] as bool?;
                    string fanVariableSpeed = variableSpeed.HasValue ? (variableSpeed.Value ? "Yes" : "No") : "N/A";

                    LV_InfoHardware.Items.Add($"Fan Name: {fanName}");
                    LV_InfoHardware.Items.Add($"Device ID: {fanDeviceID}");
                    LV_InfoHardware.Items.Add($"Description: {fanDescription}");
                    LV_InfoHardware.Items.Add($"Variable Speed: {fanVariableSpeed}");
                    LV_InfoHardware.Items.Add($"Status: {fanStatus}");
                    LV_InfoHardware.Items.Add($"Desired Speed: {desiredSpeed}");
                }

                LV_InfoHardware.Items.Add(new ListViewItem("######### Temperature #########", 5));
                // Obtenir les informations sur les sondes de température
                ManagementObjectSearcher tempSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_TemperatureProbe");
                foreach (ManagementObject tempProbe in tempSearcher.Get())
                {
                    string tempDeviceID = tempProbe["DeviceID"] != null ? tempProbe["DeviceID"].ToString() : "N/A";
                    string tempName = tempProbe["Name"] != null ? tempProbe["Name"].ToString() : "N/A";
                    string tempDescription = tempProbe["Description"] != null ? tempProbe["Description"].ToString() : "N/A";
                    string tempMaxReadable = tempProbe["MaxReadable"] != null ? tempProbe["MaxReadable"].ToString() : "N/A";
                    string tempMinReadable = tempProbe["MinReadable"] != null ? tempProbe["MinReadable"].ToString() : "N/A";
                    string tempCurrentReading = tempProbe["CurrentReading"] != null ? tempProbe["CurrentReading"].ToString() : "N/A";
                    string tempNominalReading = tempProbe["NominalReading"] != null ? tempProbe["NominalReading"].ToString() : "N/A";
                    string tempNormalMax = tempProbe["NormalMax"] != null ? tempProbe["NormalMax"].ToString() : "N/A";
                    string tempNormalMin = tempProbe["NormalMin"] != null ? tempProbe["NormalMin"].ToString() : "N/A";

                    LV_InfoHardware.Items.Add($"Device ID: {tempDeviceID}");
                    LV_InfoHardware.Items.Add($"Name: {tempName}");
                    LV_InfoHardware.Items.Add($"Description: {tempDescription}");
                    LV_InfoHardware.Items.Add($"Max Readable: {tempMaxReadable}");
                    LV_InfoHardware.Items.Add($"Min Readable: {tempMinReadable}");
                    LV_InfoHardware.Items.Add($"Current Reading: {tempCurrentReading}");
                    LV_InfoHardware.Items.Add($"Nominal Reading: {tempNominalReading}");
                    LV_InfoHardware.Items.Add($"Normal Max: {tempNormalMax}");
                    LV_InfoHardware.Items.Add($"Normal Min: {tempNormalMin}");
                }
            }
        }

        private void LV_InfoHardware_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C) // Vérifie si Ctrl + C est pressé
            {
                if (LV_InfoHardware.SelectedItems != null)
                {
                    string data = "";
                    foreach (var item in LV_InfoHardware.SelectedItems)
                    {
                        data += item.ToString() + Environment.NewLine; // Ajoute le texte de l'élément avec un saut de ligne
                    }
                    Clipboard.SetText(data); // Copie le texte sélectionné dans le presse-papiers
                }
            }
        }

        private void BTN_menu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void UC_Hardware_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Visible = false;
            }
        }
    }
}