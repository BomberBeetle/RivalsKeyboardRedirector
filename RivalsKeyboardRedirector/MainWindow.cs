
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RawInput_dll;
using vJoyInterfaceWrap;

namespace RivalsKeyboardRedirector
{
    public partial class MainWindow : Form
    {
        public enum ButtonEnum
        {
            A, B, X, Y, L, R, Z, START, DUP, DDOWN, DLEFT, DRIGHT, LSUP, LSDOWN, LSRIGHT, LSLEFT, LSMOD, RSDOWN, RSUP, RSLEFT, RSRIGHT, RSMOD
        }

        IntPtr currentHandle = new IntPtr(0);
        TextBox focusedBox = null;
        RawInput input;
        bool detecting = false;
        Dictionary<IntPtr, Keyboard> keyboards = new Dictionary<IntPtr, Keyboard>();
        vJoy virtualJoy = new vJoy();

        public MainWindow()
        {
            InitializeComponent();
            input = new RawInput(this.Handle, false);
            input.AddMessageFilter();
            input.KeyPressed += OnKeyPressed;
            if (!virtualJoy.vJoyEnabled())
            {
                MessageBox.Show("vJoy is not installed. Exiting program...");
                Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            if (detecting)
            {
                if (!keyboards.ContainsKey(e.KeyPressEvent.DeviceHandle))
                {
                    keyboards.Add(e.KeyPressEvent.DeviceHandle, new Keyboard(e.KeyPressEvent.DeviceHandle, e.KeyPressEvent.DeviceName));
                    comboBox1.Items.Add(e.KeyPressEvent.DeviceHandle);
                }
                vJoyBox.CheckedChanged -= vJoyBox_CheckedChanged;
                vJoyBox.Checked = keyboards[e.KeyPressEvent.DeviceHandle].vJoyEnabled;
                vJoyBox.CheckedChanged += vJoyBox_CheckedChanged;

                LSAutorunBox.CheckedChanged -= LSAutorunBox_CheckedChanged;
                LSAutorunBox.Checked = keyboards[e.KeyPressEvent.DeviceHandle].LSAutoRun;
                LSAutorunBox.CheckedChanged += LSAutorunBox_CheckedChanged;

                //labelCurrentKb.Text = $"Current Keyboard: {e.KeyPressEvent.DeviceHandle.ToString()}";
                currentHandle = e.KeyPressEvent.DeviceHandle;

                comboBox1.SelectedItem = currentHandle;

                /*
                inputBox_A.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.A) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.A] : "";
                inputBox_B.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.B) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.B] : "";
                inputBox_X.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.X) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.X] : "";
                inputBox_Y.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.Y) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.Y] : "";
                inputBox_L.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.Y) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.L] : "";
                inputBox_R.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.Y) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.R] : "";
                inputBox_Z.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.Y) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.Z] : "";
                inputBox_START.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.Y) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.START] : "";

                inputBox_LSUP.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.LSUP) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.LSUP] : "";
                inputBox_LSDOWN.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.LSDOWN) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.LSDOWN] : "";
                inputBox_LSLEFT.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.LSLEFT) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.LSLEFT] : "";
                inputBox_LSRIGHT.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.LSRIGHT) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.LSRIGHT] : "";
                inputBox_LSMOD.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.LSMOD) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.LSMOD] : "";

                inputBox_RSUP.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.RSUP) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.RSUP] : "";
                inputBox_RSDOWN.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.RSDOWN) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.RSDOWN] : "";
                inputBox_RSLEFT.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.RSLEFT) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.RSLEFT] : "";
                inputBox_RSRIGHT.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.RSRIGHT) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.RSRIGHT] : "";

                inputBox_DUP.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.DUP) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.DUP] : "";
                inputBox_DDOWN.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.DDOWN) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.DDOWN] : "";
                inputBox_DLEFT.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.DLEFT) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.DLEFT] : "";
                inputBox_DRIGHT.Text = keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsKey(ButtonEnum.DRIGHT) ? keyboards[e.KeyPressEvent.DeviceHandle].binds[ButtonEnum.DRIGHT] : "";

                LSAutorunBox.Checked = keyboards[e.KeyPressEvent.DeviceHandle].LSAutoRun;
                LSAutorunBox.Checked = keyboards[e.KeyPressEvent.DeviceHandle].RSAutoRun;
                */
                detecting = false;
            }
            label14.Text = $"{e.KeyPressEvent.DeviceHandle.ToString()}_{e.KeyPressEvent.VKeyName}_{(e.KeyPressEvent.Message == 256 ? "PRESS" : "RELEASE") }";
            if (focusedBox != null)
            {
                if(focusedBox == inputBox_LSUP)
                {
                    keyboards[currentHandle].binds[ButtonEnum.LSUP] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_LSDOWN)
                {
                    keyboards[currentHandle].binds[ButtonEnum.LSDOWN] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_LSLEFT)
                {
                    keyboards[currentHandle].binds[ButtonEnum.LSLEFT] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_LSRIGHT)
                {
                    keyboards[currentHandle].binds[ButtonEnum.LSRIGHT] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_LSMOD)
                {
                    keyboards[currentHandle].binds[ButtonEnum.LSMOD] = e.KeyPressEvent.VKeyName;
                }

                else if (focusedBox == inputBox_RSUP)
                {
                    keyboards[currentHandle].binds[ButtonEnum.RSUP] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_RSDOWN)
                {
                    keyboards[currentHandle].binds[ButtonEnum.RSDOWN] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_RSLEFT)
                {
                    keyboards[currentHandle].binds[ButtonEnum.RSLEFT] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_RSRIGHT)
                {
                    keyboards[currentHandle].binds[ButtonEnum.RSRIGHT] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_A)
                {
                    keyboards[currentHandle].binds[ButtonEnum.A] = e.KeyPressEvent.VKeyName;
                }

                else if (focusedBox == inputBox_B)
                {
                    keyboards[currentHandle].binds[ButtonEnum.B] = e.KeyPressEvent.VKeyName;
                }

                else if (focusedBox == inputBox_X)
                {
                    keyboards[currentHandle].binds[ButtonEnum.X] = e.KeyPressEvent.VKeyName;
                }

                else if (focusedBox == inputBox_Y)
                {
                    keyboards[currentHandle].binds[ButtonEnum.Y] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_Z)
                {
                    keyboards[currentHandle].binds[ButtonEnum.Z] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_L)
                {
                    keyboards[currentHandle].binds[ButtonEnum.L] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_R)
                {
                    keyboards[currentHandle].binds[ButtonEnum.R] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_START)
                {
                    keyboards[currentHandle].binds[ButtonEnum.START] = e.KeyPressEvent.VKeyName;
                }

                else if (focusedBox == inputBox_DUP)
                {
                    keyboards[currentHandle].binds[ButtonEnum.DUP] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_DDOWN)
                {
                    keyboards[currentHandle].binds[ButtonEnum.DDOWN] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_DLEFT)
                {
                    keyboards[currentHandle].binds[ButtonEnum.DLEFT] = e.KeyPressEvent.VKeyName;
                }
                else if (focusedBox == inputBox_DRIGHT)
                {
                    keyboards[currentHandle].binds[ButtonEnum.DRIGHT] = e.KeyPressEvent.VKeyName;
                }

                focusedBox.Text = e.KeyPressEvent.VKeyName;
                focusedBox = null;
                label1.Focus();
            }
            else
            {
                if (keyboards.ContainsKey(e.KeyPressEvent.DeviceHandle))
                {
                    if (keyboards[e.KeyPressEvent.DeviceHandle].binds.ContainsValue(e.KeyPressEvent.VKeyName))
                    {
                        var button = keyboards[e.KeyPressEvent.DeviceHandle].binds.FirstOrDefault(x => x.Value == e.KeyPressEvent.VKeyName).Key;
                        switch (button)
                        {
                            case ButtonEnum.A:
                                virtualJoy.SetBtn(e.KeyPressEvent.Message == 256, keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, 1);
                                break;
                            case ButtonEnum.B:
                                virtualJoy.SetBtn(e.KeyPressEvent.Message == 256, keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, 2);
                                break;
                            case ButtonEnum.X:
                                virtualJoy.SetBtn(e.KeyPressEvent.Message == 256, keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, 3);
                                break;
                            case ButtonEnum.Y:
                                virtualJoy.SetBtn(e.KeyPressEvent.Message == 256, keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, 4);
                                break;

                            case ButtonEnum.L:
                                virtualJoy.SetAxis(e.KeyPressEvent.Message == 256 ? 32768 : 0, keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_Z);
                                break;
                            case ButtonEnum.R:
                                virtualJoy.SetAxis(e.KeyPressEvent.Message == 256 ? 32768 : 0, keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_RZ);
                                break;
                            case ButtonEnum.Z:
                                virtualJoy.SetBtn(e.KeyPressEvent.Message == 256, keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, 5);
                                break;
                            case ButtonEnum.START:
                                virtualJoy.SetBtn(e.KeyPressEvent.Message == 256, keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, 8);
                                break;

                            case ButtonEnum.LSUP:
                                if (e.KeyPressEvent.Message == 256)
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].LSUP = 1;
                                }
                                else
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].LSUP = 0;
                                }
                                virtualJoy.SetAxis(keyboards[e.KeyPressEvent.DeviceHandle].GetLSY(), keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_Y);
                                break;
                            case ButtonEnum.LSDOWN:
                                if (e.KeyPressEvent.Message == 256)
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].LSDOWN = 1;
                                }
                                else
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].LSDOWN = 0;
                                }
                                virtualJoy.SetAxis(keyboards[e.KeyPressEvent.DeviceHandle].GetLSY(), keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_Y);
                                break;
                            case ButtonEnum.LSLEFT:
                                if (e.KeyPressEvent.Message == 256)
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].LSLEFT = 1;
                                }
                                else
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].LSLEFT = 0;
                                }
                                virtualJoy.SetAxis(keyboards[e.KeyPressEvent.DeviceHandle].GetLSX(), keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_X);
                                break;
                            case ButtonEnum.LSRIGHT:
                                if (e.KeyPressEvent.Message == 256)
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].LSRIGHT = 1;
                                }
                                else
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].LSRIGHT = 0;
                                }
                                virtualJoy.SetAxis(keyboards[e.KeyPressEvent.DeviceHandle].GetLSX(), keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_X);
                                break;
                            case ButtonEnum.LSMOD:
                                if (keyboards[e.KeyPressEvent.DeviceHandle].LSAutoRun) { 
                                    if (e.KeyPressEvent.Message == 256)
                                    {
                                        keyboards[e.KeyPressEvent.DeviceHandle].LSMOD = 2;
                                    }
                                    else
                                    {
                                        keyboards[e.KeyPressEvent.DeviceHandle].LSMOD = 1;
                                    }
                                }
                                else
                                {
                                    if (e.KeyPressEvent.Message == 256)
                                    {
                                        keyboards[e.KeyPressEvent.DeviceHandle].LSMOD = 1;
                                    }
                                    else
                                    {
                                        keyboards[e.KeyPressEvent.DeviceHandle].LSMOD = 2;
                                    }
                                }
                                break;

                            case ButtonEnum.RSUP:
                                if (e.KeyPressEvent.Message == 256)
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].RSUP = 1;
                                }
                                else
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].RSUP = 0;
                                }
                                virtualJoy.SetAxis(keyboards[e.KeyPressEvent.DeviceHandle].GetRSY(), keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_RY);
                                break;
                            case ButtonEnum.RSDOWN:
                                if (e.KeyPressEvent.Message == 256)
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].RSDOWN = 1;
                                }
                                else
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].RSDOWN = 0;
                                }
                                virtualJoy.SetAxis(keyboards[e.KeyPressEvent.DeviceHandle].GetRSY(), keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_RY);
                                break;
                            case ButtonEnum.RSLEFT:
                                if (e.KeyPressEvent.Message == 256)
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].RSLEFT = 1;
                                }
                                else
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].RSLEFT = 0;
                                }
                                virtualJoy.SetAxis(keyboards[e.KeyPressEvent.DeviceHandle].GetRSX(), keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_RX);
                                break;

                            case ButtonEnum.RSRIGHT:
                                if (e.KeyPressEvent.Message == 256)
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].RSRIGHT = 1;
                                }
                                else
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].RSRIGHT = 0;
                                }
                                virtualJoy.SetAxis(keyboards[e.KeyPressEvent.DeviceHandle].GetRSX(), keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_RX);
                                break;

                            case ButtonEnum.DUP:
                                /*
                                if (e.KeyPressEvent.Message == 256)
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].DUP = 1;
                                }
                                else
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].DUP = 0;
                                }
                                virtualJoy.SetAxis(keyboards[e.KeyPressEvent.DeviceHandle].GetDY(), keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_SL0);
                                break;
                                */
                                virtualJoy.SetBtn(e.KeyPressEvent.Message == 256, keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, 9);
                                break;
                            case ButtonEnum.DDOWN:
                                /*
                                if (e.KeyPressEvent.Message == 256)
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].DDOWN = 1;
                                }
                                else
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].DDOWN = 0;
                                }
                                virtualJoy.SetAxis(keyboards[e.KeyPressEvent.DeviceHandle].GetDY(), keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_SL0);
                                break;
                                */
                                virtualJoy.SetBtn(e.KeyPressEvent.Message == 256, keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, 10);
                                break;
                            case ButtonEnum.DLEFT:
                                /*
                                if (e.KeyPressEvent.Message == 256)
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].DLEFT = 1;
                                }
                                else
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].DLEFT = 0;
                                }
                                virtualJoy.SetAxis(keyboards[e.KeyPressEvent.DeviceHandle].GetDX(), keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_SL1);
                                break;
                                */
                                virtualJoy.SetBtn(e.KeyPressEvent.Message == 256, keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, 11);
                                break;
                            case ButtonEnum.DRIGHT:
                                /*
                                if (e.KeyPressEvent.Message == 256)
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].DRIGHT = 1;
                                }
                                else
                                {
                                    keyboards[e.KeyPressEvent.DeviceHandle].DRIGHT = 0;
                                }
                                virtualJoy.SetAxis(keyboards[e.KeyPressEvent.DeviceHandle].GetDX(), keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, HID_USAGES.HID_USAGE_SL1);
                                */
                                virtualJoy.SetBtn(e.KeyPressEvent.Message == 256, keyboards[e.KeyPressEvent.DeviceHandle].vJoyId, 12);
                                break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detecting = true;
        }

        private void InputBoxClick(object sender, EventArgs e)
        {
            if (currentHandle != new IntPtr(0))
            {
                try
                {
                    focusedBox = (TextBox)sender;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Non-Critical Exception: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You have to select a Keyboard by clicking \"Detect Keyboard\" and pressing any key on the desired keyboard before setting keybinds.");
            }
        }

        private void vJoyBox_CheckedChanged(object sender, EventArgs e)
        {
            if(currentHandle != new IntPtr(0))
            {
                if (!keyboards[currentHandle].vJoyEnabled)
                {
                    bool acquiredDevice = false;
                    for(uint i = 1; i <= 16; i++)
                    {
                        if (virtualJoy.GetVJDStatus(i) == VjdStat.VJD_STAT_FREE)
                        {
                            virtualJoy.AcquireVJD(i);
                            keyboards[currentHandle].vJoyEnabled = true;
                            keyboards[currentHandle].vJoyId = i;
                            acquiredDevice = true;
                            virtualJoy.SetAxis(16384, keyboards[currentHandle].vJoyId, HID_USAGES.HID_USAGE_X);
                            virtualJoy.SetAxis(16384, keyboards[currentHandle].vJoyId, HID_USAGES.HID_USAGE_Y);
                            virtualJoy.SetAxis(16384, keyboards[currentHandle].vJoyId, HID_USAGES.HID_USAGE_RX);
                            virtualJoy.SetAxis(16384, keyboards[currentHandle].vJoyId, HID_USAGES.HID_USAGE_RY);
                            virtualJoy.SetAxis(1, keyboards[currentHandle].vJoyId, HID_USAGES.HID_USAGE_Z);
                            MessageBox.Show($"Acquired vJoy device {i}.");
                            break;
                        }
                    }
                    if (!acquiredDevice)
                    {
                        MessageBox.Show("vJoy device acquisition failed: There are no free devices.");
                        vJoyBox.CheckedChanged -= vJoyBox_CheckedChanged;
                        vJoyBox.Checked = false;
                        vJoyBox.CheckedChanged += vJoyBox_CheckedChanged;
                    }
                }

                else
                {
                    virtualJoy.RelinquishVJD(keyboards[currentHandle].vJoyId);
                    MessageBox.Show($"Relinquished vJoy device {keyboards[currentHandle].vJoyId}.");
                    keyboards[currentHandle].vJoyId = 17;
                    keyboards[currentHandle].vJoyEnabled = false;
                }
            }
            else
            {
                MessageBox.Show("You have to select a Keyboard by clicking \"Detect Keyboard\" and pressing any key on the desired keyboard before changing settings.");
                vJoyBox.CheckedChanged -= vJoyBox_CheckedChanged;
                vJoyBox.Checked = false;
                vJoyBox.CheckedChanged += vJoyBox_CheckedChanged;
            }
        }

        private void LSAutorunBox_CheckedChanged(object sender, EventArgs e)
        {
            if (currentHandle != new IntPtr(0))
            {
                keyboards[currentHandle].LSAutoRun = LSAutorunBox.Checked;
            }
            else
            {
                MessageBox.Show("You have to select a Keyboard by clicking \"Detect Keyboard\" and pressing any key on the desired keyboard before changing settings.");
                LSAutorunBox.CheckedChanged -= LSAutorunBox_CheckedChanged;
                LSAutorunBox.Checked = false;
                LSAutorunBox.CheckedChanged += LSAutorunBox_CheckedChanged;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentHandle = (IntPtr)comboBox1.SelectedItem;
            vJoyBox.CheckedChanged -= vJoyBox_CheckedChanged;
            vJoyBox.Checked = keyboards[currentHandle].vJoyEnabled;
            vJoyBox.CheckedChanged += vJoyBox_CheckedChanged;

            LSAutorunBox.CheckedChanged -= LSAutorunBox_CheckedChanged;
            LSAutorunBox.Checked = keyboards[currentHandle].LSAutoRun;
            LSAutorunBox.CheckedChanged += LSAutorunBox_CheckedChanged;

            //labelCurrentKb.Text = $"Current Keyboard: {currentHandle.ToString()}";

            inputBox_A.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.A) ? keyboards[currentHandle].binds[ButtonEnum.A] : "";
            inputBox_B.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.B) ? keyboards[currentHandle].binds[ButtonEnum.B] : "";
            inputBox_X.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.X) ? keyboards[currentHandle].binds[ButtonEnum.X] : "";
            inputBox_Y.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.Y) ? keyboards[currentHandle].binds[ButtonEnum.Y] : "";
            inputBox_L.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.Y) ? keyboards[currentHandle].binds[ButtonEnum.L] : "";
            inputBox_R.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.Y) ? keyboards[currentHandle].binds[ButtonEnum.R] : "";
            inputBox_Z.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.Y) ? keyboards[currentHandle].binds[ButtonEnum.Z] : "";
            inputBox_START.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.Y) ? keyboards[currentHandle].binds[ButtonEnum.START] : "";


            inputBox_LSUP.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.LSUP) ? keyboards[currentHandle].binds[ButtonEnum.LSUP] : "";
            inputBox_LSDOWN.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.LSDOWN) ? keyboards[currentHandle].binds[ButtonEnum.LSDOWN] : "";
            inputBox_LSLEFT.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.LSLEFT) ? keyboards[currentHandle].binds[ButtonEnum.LSLEFT] : "";
            inputBox_LSRIGHT.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.LSRIGHT) ? keyboards[currentHandle].binds[ButtonEnum.LSRIGHT] : "";
            inputBox_LSMOD.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.LSMOD) ? keyboards[currentHandle].binds[ButtonEnum.LSMOD] : "";

            inputBox_RSUP.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.RSUP) ? keyboards[currentHandle].binds[ButtonEnum.RSUP] : "";
            inputBox_RSDOWN.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.RSDOWN) ? keyboards[currentHandle].binds[ButtonEnum.RSDOWN] : "";
            inputBox_RSLEFT.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.RSLEFT) ? keyboards[currentHandle].binds[ButtonEnum.RSLEFT] : "";
            inputBox_RSRIGHT.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.RSRIGHT) ? keyboards[currentHandle].binds[ButtonEnum.RSRIGHT] : "";

            inputBox_DUP.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.DUP) ? keyboards[currentHandle].binds[ButtonEnum.DUP] : "";
            inputBox_DDOWN.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.DDOWN) ? keyboards[currentHandle].binds[ButtonEnum.DDOWN] : "";
            inputBox_DLEFT.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.DLEFT) ? keyboards[currentHandle].binds[ButtonEnum.DLEFT] : "";
            inputBox_DRIGHT.Text = keyboards[currentHandle].binds.ContainsKey(ButtonEnum.DRIGHT) ? keyboards[currentHandle].binds[ButtonEnum.DRIGHT] : "";

            LSAutorunBox.Checked = keyboards[currentHandle].LSAutoRun;
            LSAutorunBox.Checked = keyboards[currentHandle].RSAutoRun;
        }
    }
}