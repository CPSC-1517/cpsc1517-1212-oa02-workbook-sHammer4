using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo02b
{
    internal class Course
    {
        #region Readonly Data Fields
        public readonly string CourseNo;
        public readonly string CourseName;
        public readonly List<string> Students = new List<string>();
        #endregion

        #region Readonly Property
        public int StudentCount
        {
            get { return Students.Count; }
        }
        #endregion

        #region Constructors
        public Course(string courseNo, string courseName)
        {
            //Validate that courseNo is not null or not empty,
            //Must contain exactly 8 characters
            //First 4 characters are letters and the last 4 are digits
            if (string.IsNullOrEmpty(courseNo))
            {
                throw new ArgumentNullException("CourseNo is required");
            }
            if(courseNo.Length != 8)
            {
                throw new ArgumentException("CourseNo must contain exactly 8 characters");
            }
            CourseNo = courseNo;

            //Validate that courseName is not null or an empty string
            if (string.IsNullOrEmpty(courseName))
            {
                throw new ArgumentNullException("CourseName is requried");
            }
            CourseName = courseName;
        }
        #endregion


        #region Instance-Level Methods
        public void AddStudent(string name)
        {
            Students.Add(name);
        }
        public void RemoveStudent(string name)
        {
            Students.Remove(name);
        }

        public bool SavetoFile(string filePath)
        {
            bool success;
            //Write to the file the CourseNo and CourseName
            //Write the name of all the students in the course
            try
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.WriteLine(CourseNo);
                    writer.WriteLine(CourseName);
                    foreach (string currentStudent in Students)
                    {
                        writer.WriteLine(currentStudent);
                    }
                    success = true;
                }
            }
            catch
            {
                success = false;
            }

            return success;
        }

        public bool LoadFromFile(string filePath)
        {
            bool success;
            //Read the CourseNo and CourseName then all the students in the course
            try
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    var CourseNo = reader.ReadLine();
                    var CourseName = reader.ReadLine();
                    while (reader.EndOfStream == false)
                    {
                        string? lineData = reader.ReadLine();
                        if (lineData != null && !string.IsNullOrEmpty(lineData))
                        {
                            Students.Add(lineData);
                        }
                    }
                }
                success = true;
            }
            catch
            {
                success = false;
            }

            return success;
        }
        #endregion
    }
}
