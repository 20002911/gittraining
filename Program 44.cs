using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace project
{
    class program
    {
        static void Main(string[] args)
        {
            inputDetails();
        }

        public static void inputDetails(){
            string[,] EmpDetails = new string[5,3];
            int [,] EmpSalary= new int[5,7];
            for(int i=0;i<5;i++){
                Console.WriteLine("Enter EmpCode");
                EmpDetails[i, 0] = Console.ReadLine();    // EmpCode
                Console.WriteLine("Enter EmpName");
                EmpDetails[i, 1] = Console.ReadLine();    // EmpName
                Console.WriteLine("Enter ContactNo");
                EmpDetails[i, 2] = Console.ReadLine();    // EmpContactNo

               
                EmpSalary[i,0] = Int32.Parse(EmpDetails[i, 0]);
                Console.WriteLine("Enter Basic");
                EmpSalary[i,1] = Int32.Parse(Console.ReadLine());  //basic salary
                Console.WriteLine("Enter DA");
                EmpSalary[i,2] = Int32.Parse(Console.ReadLine()); //DA
                Console.WriteLine("Enter HRA");
                EmpSalary[i,3] = Int32.Parse(Console.ReadLine()); //HRA

                EmpSalary[i,4] = GetGrossSalary(EmpSalary[i,1], EmpSalary[i,2], EmpSalary[i,3]);

                Console.WriteLine("Enter TDS");
                EmpSalary[i,5] = Int32.Parse(Console.ReadLine());    // TDS

                EmpSalary[i,6] = GetNetSalary(EmpSalary[i,5], EmpSalary[i,4]);

            }
        }
        public static int GetGrossSalary(int iBasic, int iDA, int iHRA)
        {
        return (iBasic + iDA + iHRA);
        }
        public static int GetNetSalary(int iTDS, int iGrossSalary)
        {
        return (iGrossSalary - iTDS);
        }


//
void PrintDetailsByID()
    {
      int ndx = GetIndxForID();
      if (ndx == -1)
        Console.WriteLine("Invalid Code...please try again");
      else
        PrintDetails(ndx);
    }
    }
}