using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace gettingProcesses
{
    class ProcessInfo
    {
        /** Indicates whether the process is from C# or C++*/
        private bool fromCSharp;

        private string name;

        private int id;

        private string priorityClassCSharp;

        private int priorityClassCPlusPlus;

        private int threadCount;

        public ProcessInfo(Process process)
        {
            fromCSharp = true;
            name = process.ProcessName;
            id = process.Id;
            try
            {
                priorityClassCSharp = process.PriorityClass.ToString();
            }
            catch (Win32Exception)
            {
                priorityClassCSharp = "недоступно";
            }
            threadCount = process.Threads.Count;
        }

        public ProcessInfo(string name, int id, int priorCls, int thrdCnt)
        {
            fromCSharp = false;
            this.name = name;
            this.id = id;
            priorityClassCPlusPlus = priorCls;
            threadCount = thrdCnt;
        }

        public override string ToString()
        {
            return "Идентификатор процесса: " + id + "\nКласс приоритета: " +
                (fromCSharp ? priorityClassCSharp : (priorityClassCPlusPlus == -1?
                "недоступно" : priorityClassCPlusPlus.ToString())) + 
                "\nКоличество потоков: " + threadCount;
        }

    }
}
