using Entities.Concretes;
using Entities.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes
{
    public class MSSQLContext:DbContext
    {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Connection Database
			optionsBuilder.UseSqlServer(@"Server = PYSHARP; Database = StudentInformationSystemDB; Trusted_Connection = true");
		}

		// Match objects with tables in database

		// Entities
		public DbSet<AcademicUnitType> AcademicUnitTypes { get; set; }
		public DbSet<AcademicUnit> AcademicUnits { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<Denotation> Denotations { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Exam> Exams { get; set; }
		public DbSet<ExamType> ExamTypes { get; set; }
		public DbSet<ForeignStudent> ForeignStudents { get; set; }
		public DbSet<Lecture> Lectures { get; set; }
		public DbSet<LetterGrade> LetterGrades { get; set; }
		public DbSet<LetterGradeType> LetterGradeTypes { get; set; }
		public DbSet<Login> Logins { get; set; }
		public DbSet<Person> Persons { get; set; }
		public DbSet<Semester> Semesters { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<TakingLecture> TakingLectures { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<TypeOfEducation> TypeOfEducations { get; set; }

		// Views
		public DbSet<ContactDetaiView> ContactsDetail { get; set; }
		public DbSet<DepartmentDetailView> DepartmentsDetail { get; set; }
		public DbSet<ExamDetailView> ExamsDetail { get; set; }
		public DbSet<ForeignStudentDetailView> ForeignStudentsDetail { get; set; }
		public DbSet<LectureDetailView> LecturesDetail { get; set; }
		public DbSet<LetterGradeDetailView> LetterGradesDetail { get; set; }
		public DbSet<PersonDetailView> PersonsDetail { get; set; }
		public DbSet<StudentDetailView> StudentsDetail{ get; set; }
		public DbSet<TakingLectureDetailView> TakingLecturesDetail { get; set; }
		public DbSet<TeacherDetailView> TeachersDetail { get; set; }
	}
}
