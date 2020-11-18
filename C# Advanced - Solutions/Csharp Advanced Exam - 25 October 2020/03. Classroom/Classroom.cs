using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        private Classroom()
        {
            this.students = new List<Student>();
        }

        public Classroom(int capacity)
            : this()
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; set; }

        public int Count { get { return this.students.Count; } }

        public string RegisterStudent(Student student)
        {
            if (this.students.Count + 1 <= this.Capacity)
            {
                this.students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student student = this.students
                .FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (student != null)
            {
                this.students.Remove(student);
                return $"Dismissed student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            Student[] student = this.students.Where(s => s.Subject == subject).ToArray();

            StringBuilder sb = new StringBuilder();

            if (student.Length != 0)
            {
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var currStudent in student)
                {
                    sb.AppendLine($"{currStudent.FirstName} {currStudent.LastName}").ToString();
                }

                return sb.ToString().TrimEnd();
            }
            else
            {
                sb.Append("No students enrolled for the subject");
                return sb.ToString().TrimEnd();
            }
        }

        public int GetStudentsCount()
        {
            return this.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = this.students
                .FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            return student;
        }
    }
}
