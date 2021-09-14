using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        private GlobalKeyboardHook mGlobalKeyboardHook = null;
        private GlobalKeyboardHook.HookProc mKeyboardProc = null;
        private int mDelayTime = 100;
        private Stopwatch mStopwatch;

        InputSimulator mInputSimulator = new InputSimulator();
        bool mActive = false;
        List<double> mClickTimeList = null;
        List <Color> mColorList = new List<Color>() { Color.Red, Color.Green, Color.Blue };
        int mColorIndex = 0;

        public MainForm()
        {
            InitializeComponent();

            mDelayTime = (int)mNUDTicksDelay.Value;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (mGlobalKeyboardHook == null)
            {
                // Hooks only into specified Keys (here "A" and "B").
                mGlobalKeyboardHook = new GlobalKeyboardHook(new Keys[] { Keys.F7 });

                // Hooks into all keys.
                //@@mGlobalKeyboardHook = new GlobalKeyboardHook();
                mGlobalKeyboardHook.KeyboardPressed += OnKeyPressed;

                //Hold reference so that GC does not collect it
                mKeyboardProc = mGlobalKeyboardHook.KeyboardProc;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopClicker();
            DestroyGlobalKeyboardHook();

            Properties.Settings.Default.Save();
        }

        private void DestroyGlobalKeyboardHook()
        {
            if (mGlobalKeyboardHook != null)
            {
                mKeyboardProc = null;
                mGlobalKeyboardHook.Dispose();
                mGlobalKeyboardHook = null;
            }
        }

        private void StartClicker()
        {
            double numOfSeconds = 0;
            mClickTimeList = new List<double>();

            try
            {
                mStopwatch = new Stopwatch();
                mStopwatch.Start();

                mActive = true;
                while (mActive)
                {
                    mInputSimulator.Mouse.LeftButtonClick();
                    mClickTimeList.Add(mStopwatch.ElapsedMilliseconds / 1000.0);

                    if(mClickTimeList.Count() > 200)
                    {
                        mClickTimeList.RemoveAt(0);
                    }

                    if (mClickTimeList.Count > 1)
                    {
                        numOfSeconds = mClickTimeList.Last();
                        mLabelSeconds.Text = $"{numOfSeconds:0.00} sec";
                        double numClicksPerSecond = mClickTimeList.Count() / (mClickTimeList.Last() - mClickTimeList.First());
                        mLabelNumOfClicks.Text = $"{numClicksPerSecond:0.00} click/second";
                    }
                    Application.DoEvents();
                    Thread.Sleep(mDelayTime);
                }

                mStopwatch.Stop();
            }
            catch
            {
                DestroyGlobalKeyboardHook();
            }
            finally
            {
                if(mClickTimeList != null)
                {
                    mClickTimeList.Clear();
                    mClickTimeList = null;
                }
            }

            mLabelSeconds.Text = $"{numOfSeconds:0.00} sec";
            mLabelNumOfClicks.Text = "0.00 click/second";
            Application.DoEvents();
        }

        private void StopClicker()
        {
            mActive = false;
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
            {
                /*@@
                // Now you can access both, the key and virtual code
                Keys loggedKey = e.KeyboardData.Key;
                int loggedVkCode = e.KeyboardData.VirtualCode;
                @@*/

                if (mActive == false)
                {
                    StartClicker();
                }
                else
                {
                    StopClicker();
                }
            }
        }

        private void mButtonTest_Click(object sender, EventArgs e)
        {
            mPanelTest.BackColor = mColorList[mColorIndex++];
            if(mColorIndex >= mColorList.Count)
            {
                mColorIndex = 0;
            }
        }

        private void mButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mNUDTicksDelay_ValueChanged(object sender, EventArgs e)
        {
            mDelayTime = (int)mNUDTicksDelay.Value;
            if (mClickTimeList != null)
            {
                mClickTimeList.Clear();
            }
        }
    }
}
