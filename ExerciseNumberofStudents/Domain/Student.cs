using System;

namespace ExerciseNumberofStudents.Domain
{
    internal class Student
    {
        public int Id { get; set; }

        public Student()
        {
        }

        public Student(int id)
        {
            Id = id;
        }

        //Imprimir os dados
        public override string ToString()
        {
            return $"-{Id}";
        }

        public void AddStudent(HashSet<Student> student, int id)
        {
            student.Add(new Student(id));
        }
    }
}
