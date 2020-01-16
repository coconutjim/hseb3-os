#include <windows.h>
#include <tlhelp32.h>
#include <tchar.h>
#include <iostream>


using namespace std;

//  Forward declarations:
BOOL GetProcessList();
void clear();
void extendIntArray(int* array, int length);
void extendStringArray(char** arr, int length);
void shrinkIntArray(int* array, int length);
void shrinkStringArray(char** arr, int length);

int currCount = 1000;

char ** procNames = new char*[currCount];
int * procIds = new int[currCount];
int * procPriorClass = new int[currCount];
int * procThreadCounts = new int[currCount];

void clear() {
	for (int i = 0; i < currCount; ++i) {
		delete[] procNames[i];
	}
	delete[] procNames;
	delete[] procIds;
	delete[] procPriorClass;
	delete[] procThreadCounts;
}


BOOL GetProcessList()
{
	HANDLE hProcessSnap;
	HANDLE hProcess;
	PROCESSENTRY32 pe32;
	DWORD dwPriorityClass;

	// Take a snapshot of all processes in the system.
	hProcessSnap = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);
	if (hProcessSnap == INVALID_HANDLE_VALUE)
	{
		clear();
		return(FALSE);
	}

	// Set the size of the structure before using it.
	pe32.dwSize = sizeof(PROCESSENTRY32);

	// Retrieve information about the first process,
	// and exit if unsuccessful
	if (!Process32First(hProcessSnap, &pe32)) {
		CloseHandle(hProcessSnap);          // clean the snapshot object
		clear();
		return(FALSE);
	}

	for (int i = 0; i < currCount; ++i) {
		procIds[i] = -1;
	}

	// Now walk the snapshot of processes, and
	// display information about each process in turn
	int index = 0;
	do
	{
		if (index >= currCount) {
			extendStringArray(procNames, currCount);
			extendIntArray(procIds, currCount);
			extendIntArray(procPriorClass, currCount);
			extendIntArray(procThreadCounts, currCount);
			currCount *= 2;
		}
		WCHAR* lol = pe32.szExeFile;
		size_t outputSize = 100; 
		char* outputString = new char[outputSize];
		size_t charsConverted = 0;
		wcstombs_s(&charsConverted, outputString, outputSize, lol, outputSize - 1);
		outputString[charsConverted] = '\0';
		procNames[index] = outputString;
		dwPriorityClass = 0;
		hProcess = OpenProcess(PROCESS_ALL_ACCESS, FALSE, pe32.th32ProcessID);
		if (hProcess == NULL) {

		}
		else
		{
			dwPriorityClass = GetPriorityClass(hProcess);
			if (!dwPriorityClass) {

			}
			CloseHandle(hProcess);
		}
		procIds[index] = pe32.th32ProcessID;
		procThreadCounts[index] = pe32.cntThreads;
		if (dwPriorityClass) {
			procPriorClass[index] =  dwPriorityClass;
		}
		else {
			procPriorClass[index] = -1;
		}
		++index;
	} while (Process32Next(hProcessSnap, &pe32));
	currCount = index;
	shrinkStringArray(procNames, currCount);
	shrinkIntArray(procIds, currCount);
	shrinkIntArray(procPriorClass, currCount);
	shrinkIntArray(procThreadCounts, currCount);
	CloseHandle(hProcessSnap);
	return(TRUE);
}

void extendIntArray(int* arr, int length) {
	int * temp = new int[length];
	for (int i = 0; i < length; ++ i) {
		temp[i] = arr[i];
	}
	arr = new int[length * 2];
	for (int i = 0; i < length; ++i) {
		arr[i] = temp[i];
	}
	delete[] temp;
}

void extendStringArray(char** arr, int length) {
	char** temp = new char*[length];
	for (int i = 0; i < length; ++i) {
		temp[i] = arr[i];
	}
	arr = new char*[length * 2];
	for (int i = 0; i < length; ++i) {
		arr[i] = temp[i];
	}
	delete[] temp;
}

void shrinkIntArray(int* arr, int length) {
	int * temp = new int[length];
	for (int i = 0; i < length; ++i) {
		temp[i] = arr[i];
	}
	arr = new int[length];
	for (int i = 0; i < length; ++i) {
		arr[i] = temp[i];
	}
	delete[] temp;
}

void shrinkStringArray(char** arr, int length) {
	char** temp = new char*[length];
	for (int i = 0; i < length; ++i) {
		temp[i] = arr[i];
	}
	arr = new char*[length];
	for (int i = 0; i < length; ++i) {
		arr[i] = temp[i];
	}
	delete[] temp;
}

extern "C" __declspec(dllexport)  void __cdecl  doWork() {
	GetProcessList();
}

extern "C" __declspec(dllexport)  int __cdecl  getCount() {
	return currCount;
}

extern "C" __declspec(dllexport)  int* __cdecl  getIds() {
	return procIds;
}

extern "C" __declspec(dllexport)  char** __cdecl  getNames() {
	return procNames;
}

extern "C" __declspec(dllexport)  int* __cdecl  getPrCls() {
	return procPriorClass;
}

extern "C" __declspec(dllexport)  int* __cdecl  getThrdCnt() {
	return procThreadCounts;
}

extern "C" __declspec(dllexport)  void __cdecl  clearMemory() {
	clear();
}


