using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace gettingProcesses
{

    public partial class Form1 : Form
    {

        [DllImport("get_processes.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static void doWork();

        [DllImport("get_processes.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static int getCount();

        [DllImport("get_processes.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static IntPtr getNames();

        [DllImport("get_processes.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static IntPtr getIds();

        [DllImport("get_processes.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static IntPtr getPrCls();

        [DllImport("get_processes.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static IntPtr getThrdCnt();

        [DllImport("get_processes.dll", CallingConvention = CallingConvention.Cdecl)]
        private extern static void clearMemory();


        /** Processes from CSharp */
        private List<ProcessInfo> processesCSharp;

        /** Processes from CPlusPlus */
        private List<ProcessInfo> processesCPlusPlus;

        public Form1()
        {
            InitializeComponent();
            buttonRefresh_Click(this, null);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            setProcessesCSharp();
            setProcessesCPlusPlus();
            this.Enabled = true;
        }

        private void setProcessesCSharp()
        {
            listBoxProcessesSharp.Items.Clear();
            Stopwatch stopWatch = Stopwatch.StartNew();
            List<Process> list = Process.GetProcesses().ToList<Process>();
            processesCSharp = new List<ProcessInfo>();
            foreach (var process in list)
            {
                processesCSharp.Add(new ProcessInfo(process));
                listBoxProcessesSharp.Items.Add(process.ProcessName);
            } 
            stopWatch.Stop();
            long frequency = Stopwatch.Frequency;
            long time = 1000000L * stopWatch.ElapsedTicks / frequency;
            listBoxProcessesSharp.SelectedIndex = -1;
            labelProcessCountCS.Text = "Количество процессов: " + processesCSharp.Count;
            labelTimeCS.Text = "Затраченное время: " + time + " мкс";
            labelISC.Text = "Информация: ";
            labelInfoSharp.Text = "";
        }

        private void setProcessesCPlusPlus()
        {
            listBoxProcessesPlusPlus.Items.Clear();
            Stopwatch stopWatch = Stopwatch.StartNew();
            doWork();
            int count = getCount();

            IntPtr ptrNames = getNames();
            string[] names = new string[count];
            for (int i = 0; i < count; ++i)
            {
                names[i] = Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(ptrNames, 4 * i));
            }

            int[] Ids = getIntArrayFromDLL(getIds(), count);
            int[] PC = getIntArrayFromDLL(getPrCls(), count);
            int[] TC = getIntArrayFromDLL(getThrdCnt(), count);
            processesCPlusPlus = new List<ProcessInfo>();
            for (int i = 0; i < count; ++i)
            {
                processesCPlusPlus.Add(new ProcessInfo(names[i], Ids[i], PC[i], TC[i]));
                listBoxProcessesPlusPlus.Items.Add(names[i]);
            }
            stopWatch.Stop();
            long frequency = Stopwatch.Frequency;
            long time = 1000000L * stopWatch.ElapsedTicks / frequency;
            listBoxProcessesPlusPlus.SelectedIndex = -1;
            labelProcessCountCPP.Text = "Количество процессов: " + processesCPlusPlus.Count;
            labelTimeCPP.Text = "Затраченное время: " + time + " мкс";
            labelICPP.Text = "Информация: ";
            labelInfoPlusPlus.Text = "";
            //clearMemory();
        }

        private int[] getIntArrayFromDLL(IntPtr ptr, int length)
        {
            int[] result = new int[length];
            Marshal.Copy(ptr, result, 0, length);
            return result;
        } 

        private void listBoxProcessesCSharp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProcessesSharp.SelectedIndex == -1)
            {
                labelISC.Text = "Информация: ";
                return;
            }
            labelISC.Text = "Информация: " + listBoxProcessesSharp.Items[listBoxProcessesSharp.SelectedIndex];
            labelInfoSharp.Text = processesCSharp[listBoxProcessesSharp.SelectedIndex].ToString();
        }

        private void listBoxProcessesPlusPlus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProcessesPlusPlus.SelectedIndex == -1)
            {
                labelICPP.Text = "Информация: ";
                return;
            }
            labelICPP.Text = "Информация: " + listBoxProcessesPlusPlus.Items[listBoxProcessesPlusPlus.SelectedIndex];
            labelInfoPlusPlus.Text = processesCPlusPlus[listBoxProcessesPlusPlus.SelectedIndex].ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа показывает списки действующих процессов, полученные двумя способами: " + 
                "\n1) С помощью встроенных утилит языка C# \n2) С помощью Win32 API (реализовано динамической " + 
                "подключаемой библиотекой, написанной на языке C++) \n\n Автор: Осипов Лев Игоревич, студент " +
                "3-го курса группы 301ПИ(1).", "О программе");
        }

    }
}
