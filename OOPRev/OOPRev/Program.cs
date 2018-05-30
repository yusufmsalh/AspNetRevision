using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRev
{
  
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //#region Value Type : int,all numeric Data Types,Date ,Char
            //int x = -1;
            //ChangeX(x);// X didn't Change
            //Console.WriteLine("value is " + x);
            //ChangeXByRef(ref x);// X Changed
            //Console.WriteLine("value is " + x);
            //#endregion

            //#region Reference Type : string
            //string y = "Old Vlaue";
            //ChangeY(y);// Y didn't change
            //Console.WriteLine("string value passing by value " + y);
            //ChangeYByref(y);// Y  changed
            //Console.WriteLine("string value after passing by ref " + y);
            //#endregion

            //#region Reference Type :Class
            //MyClass m = new MyClass();
            //m.z = -1;
            //ChangeClass(m);
            //Console.WriteLine("Class value is " + m.z); // changed
            //ChangeClassByref( ref m);
            //Console.WriteLine("Class value is " + m.z); // changed
            //#endregion 
            #endregion

            #region Array 
            #region Array of  ValueType
            //int[] myarr = new int[] { 1, 2, 3 };
            //changeArray(myarr);
            //PrintArray(myarr);//Value Change :as Array is ref type
            //Console.WriteLine();
            #endregion
            #region Array of Reference Type
            //MyClass obj1 = new MyClass(5);
            //MyClass[] myClassArr = new MyClass[] { obj1, obj1, obj1 };
            //changeArrayOfRefType(myClassArr);
            //PrintArrayOfMyClass(myClassArr);// changed as array is ref type
            #endregion

            #endregion
            #region  Struct 

            #region Struct of Value Type
            //MyStruct myStruct = new MyStruct(5);
            //ChangeMyStruct(myStruct);
            //Console.WriteLine("Struct Value is " + myStruct.x);
            #endregion
            #region Struct of Reference Type
            //MyStructOfClass m = new MyStructOfClass(5);
            //ChangeMyStructofRefType(m);
            //Console.WriteLine("Struct Value is " + m.x.z);

            #endregion
            #endregion

            #region Object
            //object y1 = 5;
            //ChangeMyObject(y1);
            //Console.WriteLine("Changed Value " + y1);
            //object y2 =new  MyClass(5);
            //ChangeMyObject(y2);
            //Console.WriteLine("Changed Value " + y2);//print classname


            #endregion
            #region Var
            //var x1 = "5";
            //ChangeMyVar(x1);
            #endregion
            Console.Read();

        }

        private static void ChangeMyVar(string x1)
        {
            throw new NotImplementedException();
        }

        private static void ChangeMyVar(int x1)
        {
            
        }

        private static void ChangeMyObject(object y1)
        {
            y1 = 0;
        }

        private static void ChangeMyStructofRefType(MyStructOfClass myStruct)
        {
          myStruct.x.z = 0;
        }

        private static void ChangeMyStruct(MyStruct myStruct)
        {
            myStruct.x = 0;
        }

        private static void PrintArrayOfMyClass(MyClass[] myClassArr)
        {
            foreach (MyClass item in myClassArr)
            {
                Console.Write(item.z + ",");
            }
        }

        private static void PrintArray(int[] myarr)
        {
            foreach (int item in myarr)
            {
                Console.Write(item + ","); 
            }
        }

        private static void changeArrayOfRefType(MyClass[] myClassArr)
        {
            for (int i = 0; i < myClassArr.Length; i++)
            {
                myClassArr[i].z = 0;
            }
        }
        private static void changeArray(int[] myarr)
        {
            for (int i=0;i<myarr.Length;i++)
            {
                myarr[i] = 0;
            }
        }
        private static void ChangeClassByref(ref MyClass m)
        {
            m.z = 9;
        }
        private static void ChangeYByref(string y)
        {
            y = "Changed in local";
        }
        private static void ChangeXByRef(ref int x)
        {
            x = 5;
        }
        private static void ChangeX(int x)
        {
            x = 5;
        }
        private static void ChangeY(string y)
        {
            y = "Changed in local";
        }
        private static void ChangeClass(MyClass m)
        {
            m.z =0;
        }


    }
 
}
