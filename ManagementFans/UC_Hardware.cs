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

namespace ManagementFans
{
    public partial class UC_Hardware : UserControl
    {
        private Computer computer;
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
        }

        private void UC_Hardware_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                // Efface les éléments précédents
                LB_InfoHardware.Items.Clear();

                LB_InfoHardware.Items.Add($"##### CPU #####");
                // Ajoute les informations CPU
                foreach (var hardware in computer.Hardware)
                {
                    if (hardware.HardwareType == HardwareType.CPU)
                    {
                        hardware.Update();
                        LB_InfoHardware.Items.Add($"CPU: {hardware.Name}");
                        LB_InfoHardware.Items.Add($"ID: {hardware.Identifier}");
                        foreach (var sensor in hardware.Sensors)
                        {
                            LB_InfoHardware.Items.Add($"Name sensor: {sensor.Name}");
                            LB_InfoHardware.Items.Add($"Type: {sensor.SensorType}");
                            LB_InfoHardware.Items.Add($"Value: {sensor.Value}");
                            if (sensor.SensorType == SensorType.Temperature)
                            {
                                LB_InfoHardware.Items.Add($"Temperature: {sensor.Value}°C");
                            }
                            if (sensor.SensorType == SensorType.Clock)
                            {
                                LB_InfoHardware.Items.Add($"Clock: {sensor.Value}");
                            }
                        }
                    }
                }

                // Ajoute les informations GPU
                foreach (var hardware in computer.Hardware)
                {
                    if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAti)
                    {
                        hardware.Update();
                        LB_InfoHardware.Items.Add($"GPU: {hardware.Name}");
                        LB_InfoHardware.Items.Add($"ID: {hardware.Identifier}");
                        foreach (var sensor in hardware.Sensors)
                        {
                            LB_InfoHardware.Items.Add($"Name sensor: {sensor.Name}");
                            if (sensor.SensorType == SensorType.Temperature)
                            {
                                LB_InfoHardware.Items.Add($"Temperature: {sensor.Value}°C");
                            }
                            if (sensor.SensorType == SensorType.Voltage)
                            {
                                LB_InfoHardware.Items.Add($"Voltage: {sensor.Value} V");
                            }
                            if (sensor.SensorType == SensorType.Power)
                            {
                                LB_InfoHardware.Items.Add($"Power: {sensor.Value}");
                            }
                            if (sensor.SensorType == SensorType.Clock)
                            {
                                LB_InfoHardware.Items.Add($"Clock: {sensor.Value}");
                            }
                        }
                    }
                }

                // Ajoute les informations RAM
                foreach (var hardware in computer.Hardware)
                {
                    if (hardware.HardwareType == HardwareType.RAM)
                    {
                        hardware.Update();
                        LB_InfoHardware.Items.Add($"RAM: {hardware.Name}");
                        LB_InfoHardware.Items.Add($"ID: {hardware.Identifier}");
                        foreach (var sensor in hardware.Sensors)
                        {
                            LB_InfoHardware.Items.Add($"Name sensor: {sensor.Name}");
                            if (sensor.SensorType == SensorType.Data)
                            {
                                LB_InfoHardware.Items.Add($"Used Memory: {sensor.Value} MB");
                            }
                            if (sensor.SensorType == SensorType.Temperature)
                            {
                                LB_InfoHardware.Items.Add($"Temperature: {sensor.Value}°C");
                            }
                        }
                    }
                }

                // Ajoute les informations HDD
                foreach (var hardware in computer.Hardware)
                {
                    if (hardware.HardwareType == HardwareType.HDD)
                    {
                        hardware.Update();
                        LB_InfoHardware.Items.Add($"HDD: {hardware.Name}");
                        LB_InfoHardware.Items.Add($"ID: {hardware.Identifier}");
                        foreach (var sensor in hardware.Sensors)
                        {
                            LB_InfoHardware.Items.Add($"Name sensor: {sensor.Name}");
                            if (sensor.SensorType == SensorType.Load)
                            {
                                LB_InfoHardware.Items.Add($"Used space: {sensor.Value}");
                            }
                            if (sensor.SensorType == SensorType.Temperature)
                            {
                                LB_InfoHardware.Items.Add($"Temperature: {sensor.Value}°C");
                            }
                        }
                    }
                }

                // Ajoute les informations sur les ventilateurs (Fans)
                LB_InfoHardware.Items.Add("Fans:");
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

                    LB_InfoHardware.Items.Add($"Fan Name: {fanName}");
                    LB_InfoHardware.Items.Add($"Device ID: {fanDeviceID}");
                    LB_InfoHardware.Items.Add($"Description: {fanDescription}");
                    LB_InfoHardware.Items.Add($"Variable Speed: {fanVariableSpeed}");
                    LB_InfoHardware.Items.Add($"Status: {fanStatus}");
                    LB_InfoHardware.Items.Add($"Desired Speed: {desiredSpeed}");
                }
            }

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

                LB_InfoHardware.Items.Add($"Device ID: {tempDeviceID}");
                LB_InfoHardware.Items.Add($"Name: {tempName}");
                LB_InfoHardware.Items.Add($"Description: {tempDescription}");
                LB_InfoHardware.Items.Add($"Max Readable: {tempMaxReadable}");
                LB_InfoHardware.Items.Add($"Min Readable: {tempMinReadable}");
                LB_InfoHardware.Items.Add($"Current Reading: {tempCurrentReading}");
                LB_InfoHardware.Items.Add($"Nominal Reading: {tempNominalReading}");
                LB_InfoHardware.Items.Add($"Normal Max: {tempNormalMax}");
                LB_InfoHardware.Items.Add($"Normal Min: {tempNormalMin}");
            }
        }

        private void LB_InfoHardware_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C) // Vérifie si Ctrl + C est pressé
            {
                if (LB_InfoHardware.SelectedItem != null)
                {
                    string data = "";
                    foreach (var item in LB_InfoHardware.SelectedItems)
                    {
                        data += item.ToString() + Environment.NewLine; // Ajoute le texte de l'élément avec un saut de ligne
                    }
                    Clipboard.SetText(data); // Copie le texte sélectionné dans le presse-papiers
                }
            }
        }
    }
}