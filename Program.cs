using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // List<string> list=new List<string>()
            // {
            //     "C# Tutorials", "VB.NET Tutorials","Learn C++","MVC Tutorials","Java" 
            // };
            // var res=from l in list where l.Contains("Tutorials") select l;
            // foreach(var item in res)
            // {
            //     Console.WriteLine(item);
            // }
            IList<Student> studentList = new List<Student>() { 
            new Student() { StudentID = 1,StandardID=101, StudentName = "Abi", Age = 13,Salary=45000} ,
            new Student() { StudentID = 2,StandardID=101, StudentName = "Aarthi",  Age = 21,Salary=50000 } ,
            new Student() { StudentID = 3,StandardID=102, StudentName = "Devadharshini",  Age = 20,Salary=32000} ,
            new Student() { StudentID = 4,StandardID=103, StudentName = "Surya" , Age = 20,Salary=21000} ,
            new Student() { StudentID = 5,StandardID=102, StudentName = "Ram" , Age = 13 ,Salary=12000} 
            };

            IList<Standard> standardList=new List<Standard>(){
                new Standard(){StandardID=101,StandardName="Satndard 1"},
                new Standard(){ StandardID=102,StandardName="Satndard 2"},
                new Standard(){ StandardID=103,StandardName="Satndard 3"}
                };
                // var join=studentList.Join(standardList,student=>student.StudentID,standard=>standard.StudentID,(Student,Standard)=>new
                // {
                //     StudentName=Student.StudentName,
                //     StandardName=Standard.StandardName

                // });
                // var join=from s in studentList join st in standardList on s.StudentID equals st.StudentID select new
                // {
                //         StudentName=s.StudentName,
                //         StandardName=st.StandardName
                // };
                // foreach(var obj in join)
                // {
                //     Console.WriteLine("{0}-{1}",obj.StudentName,obj.StandardName);
                // }

            //     var groupJoin=standardList.GroupJoin(studentList,std=>std.StandardID,s=>s.StandardID,(std,StudentsGroup)=>new
            //     {
            //         Students=StudentsGroup,
            //         StandardFullName=std.StandardName
            //     });

            // var GroupJoin=from s in standardList join std in studentList on s.StandardID equals std.StandardID into studentGroup select new
            // {
            //      Students=studentGroup,
            //     StandardFullName=s.StandardName
            // };
            // foreach(var item in GroupJoin)
            // {
            //     Console.WriteLine(item.StandardFullName);
            //     foreach(var stud in item.Students)
            //     {
            //         Console.WriteLine(stud.StudentName);
            //     }
            // }

            	// string commaSeparatedStudentNames = studentList.Aggregate<Student, string>(
                //                         "Student Names: ",  // seed value
                //                         (str, s) => str += s.StudentName + "," ); 
                // Console.WriteLine(commaSeparatedStudentNames); 
                // int sumogAge=studentList.Aggregate<Student,int>(0,(age,s)=>age+=s.Age);
                // Console.WriteLine(sumogAge);

        // string commaseparatedStudentNames = studentList.Aggregate<Student, string,string>(
        //                                     String.Empty, // seed value
        //                                     (str, s) => str += s.StudentName + ",", 
        //                                     str => str.Substring(0,str.Length - 1 ));

		// Console.WriteLine(commaseparatedStudentNames);
        //  var avgAge=studentList.Average(s=>s.Age);
        //  Console.WriteLine(avgAge);

        // var totalAge=(from a in studentList select a.Age).Count();
        // Console.WriteLine(totalAge);
        // var totalStudents=studentList.Count();
        // Console.WriteLine("Total Students:{0}",totalStudents);
        // var adultStudent=studentList.Count(s=>s.Age>=18);
        // Console.WriteLine("Number of Adult Students:{0}",adultStudent);

        // var MaxAge=studentList.Max(s=>s.Age);
        // Console.WriteLine("Oldest Age:{0}",MaxAge);

        // var MaxiAge=studentList.Max();
        // Console.WriteLine("Student Id:{0},Student Name:{1},Student Age:{2}",MaxiAge.StudentID,MaxiAge.StudentName,MaxiAge.Age);
    
        Console.WriteLine("First Elment:{0}",studentList.First().StudentID);
        Console.WriteLine("First Elment:{0}",studentList.FirstOrDefault().StudentName);
        Console.WriteLine("First Elment:{0}",studentList.First().Salary);
        
        
        


            // var groupByresult=from g in studentList group g by g.Age;
            // foreach(var ag in groupByresult)
            // {
            //     Console.WriteLine("Age:{0}",ag.Key);
        
            // foreach(Student s in ag)
            // {
            //     Console.WriteLine("Student Name:{0}",s.StudentName);
            // }
            // }
            // var GroupbyResult=studentList.GroupBy(s=>s.Age);
            // foreach(var ag in GroupbyResult)
            // {
            //     Console.WriteLine("Age:{0}",ag.Key);
        
            // foreach(Student s in ag)
            // {
            //     Console.WriteLine("Student Name:{0}",s.StudentName);
            // }
            // }
           
            // var filter=from f in studentList where f.Age >12 && f.Age<20 select f.StudentName;
        //    var studentsInDescOrder = studentList.OrderByDescending(s => s.Age);
        //    var orderby=from i in studentList orderby i.StudentName ,i.Age select new{i.StudentName,i.Age};

        //      foreach(var j in orderby)
        //     {
        //          Console.WriteLine("Name:{0},Age:{1}",j.StudentName,j.Age);
        //       }
        //       var thenbyresult=studentList.OrderBy(s=>s.StudentName).ThenBy(s=>s.Age);
        //       var thenbyDescresult=studentList.OrderBy(s=>s.StudentName).OrderByDescending(s=>s.Age);
        //       Console.Write("ThenBy \n");
        //       foreach(var std in thenbyresult)
        //       {
        //         Console.WriteLine(" Name:{0},age:{1}",std.StudentName,std.Age);
        //       }
        //       Console.Write("OrderByDescending \n");
        //       foreach(var st in thenbyDescresult)
        //       {
        //         Console.WriteLine(" Name:{0},age:{1}",st.StudentName,st.Age);
        //       }


            // List<int> list1=new List<int>()
            // {
            //     13,21,18,20,15,25,19
            // };
            // var result=from s in list1 where s>12 && s<20 select s;
            //  foreach(var i in result)
            // {
            //     Console.WriteLine(i);
            // }
            // var filterResult=list1.Where((s,i) => {
            //     if(i%2==0)
            //         return true;
            //     return false;
            // });
            // foreach(var r in filterResult)
            // {
            //     Console.WriteLine(r);
            // }
            // IList mixedList = new ArrayList(){
            //     "Aarthi",21,"sumathi","Saminathan",52,46};
            //     var result1=from i in mixedList.OfType<string>() select i;
            //     var result2=from i in mixedList.OfType<int>() select i;
            // foreach(var item in result2)
            // {
            //     Console.WriteLine(item);
            // }



        }
}  
} 

