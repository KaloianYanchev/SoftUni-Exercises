using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UniversityCompetition.Core.Contracts;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories;
using UniversityCompetition.Repositories.Contracts;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Core
{
    public class Controller : IController
    {
        private readonly IRepository<ISubject> subjects;
        private readonly IRepository<IStudent> students;
        private readonly IRepository<IUniversity> universities;

        public Controller()
        {
            subjects = new SubjectRepository();
            students = new StudentRepository();
            universities = new UniversityRepository();
        }

        public string AddStudent(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            if (students.FindByName(fullName) != null)
            {
                return string.Format(OutputMessages.AlreadyAddedStudent, firstName, lastName);
            }

            IStudent student = new Student(students.Models.Count +1 ,firstName, lastName);
            students.AddModel(student);

            return string.Format(OutputMessages.StudentAddedSuccessfully, firstName, lastName, students.GetType().Name);
        }

        public string AddSubject(string subjectName, string subjectType)
        {
            ISubject subject;

            if (subjectType != "TechnicalSubject" && subjectType != "EconomicalSubject" && subjectType != "HumanitySubject")
            {
                return string.Format(OutputMessages.SubjectTypeNotSupported, subjectType);
            }
            if (subjects.FindByName(subjectName) != null)
            {
                return string.Format(OutputMessages.AlreadyAddedSubject, subjectName);
            }

            if (subjectType == "TechnicalSubject")
            {
                subject = new TechnicalSubject(subjects.Models.Count + 1 , subjectName);
            }
            else if (subjectType == "EconomicalSubject")
            {
                subject = new EconomicalSubject(subjects.Models.Count + 1, subjectName);
            }
            else
            {
                subject = new HumanitySubject(subjects.Models.Count + 1, subjectName);
            }

            subjects.AddModel(subject);
            return string.Format(OutputMessages.SubjectAddedSuccessfully, subjectType, subjectName, subjects.GetType().Name);
        }

        public string AddUniversity(string universityName, string category, int capacity, List<string> requiredSubjects)
        {
            if (universities.FindByName(universityName) != null)
            {
                return string.Format(OutputMessages.AlreadyAddedUniversity, universityName);
            }

            List<int> reqSubj = new List<int>();

            foreach (var subject in requiredSubjects)
            {
                ISubject currentSubject = subjects.FindByName(subject);
                reqSubj.Add(currentSubject.Id);
            }

            //List<int> convertedSubjects = requiredSubjects.Select(s => int.Parse(s)).ToList();

            IUniversity university = new University(universities.Models.Count + 1, universityName, category, capacity, reqSubj);
            universities.AddModel(university);
            return string.Format(OutputMessages.UniversityAddedSuccessfully, universityName, universities.GetType().Name);
        }

        public string ApplyToUniversity(string studentName, string universityName)
        {
            string[] fullName = studentName
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string firstName = fullName[0];
            string lastName = fullName[1];

            if (students.FindByName(studentName) == null)
            {
                return string.Format(OutputMessages.StudentNotRegitered, firstName, lastName);
            }
            if (universities.FindByName(universityName) == null)
            {
                return string.Format(OutputMessages.UniversityNotRegitered, universityName);
            }
            
            IStudent student = students.FindByName(studentName);
            IUniversity university = universities.FindByName(universityName);

            bool isPassed = university.RequiredSubjects.All(item => student.CoveredExams.Any(e => e == item));
            if (!isPassed)
            {
                return string.Format(OutputMessages.StudentHasToCoverExams, studentName, university.Name);
            }

            if (student.University == university)
            {
                return string.Format(OutputMessages.StudentAlreadyJoined, firstName, lastName, university.Name);
            }

            student.JoinUniversity(university);
            return string.Format(OutputMessages.StudentSuccessfullyJoined, firstName, lastName, university.Name);
        }

        public string TakeExam(int studentId, int subjectId)
        {
            if (students.FindById(studentId) == null)
            {
                return string.Format(OutputMessages.InvalidStudentId);
            }
            if (subjects.FindById(subjectId) == null)
            {
                return string.Format(OutputMessages.InvalidSubjectId);
            }
            
            IStudent student = students.FindById(studentId);
            ISubject subject = subjects.FindById(subjectId);
        
            if (student.CoveredExams.Contains(subjectId))
            {
                return string.Format(OutputMessages.StudentAlreadyCoveredThatExam, student.FirstName, student.LastName, subject.Name);
            }
        
            student.CoverExam(subject);
            return string.Format(OutputMessages.StudentSuccessfullyCoveredExam, student.FirstName, student.LastName, subject.Name);
        
        }

        public string UniversityReport(int universityId)
        {
            IUniversity university = universities.FindById(universityId);
            int studentCount = students.Models.Where(s => s.University == university).Count();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"*** {university.Name} ***");
            sb.AppendLine($"Profile: {university.Category}");
            sb.AppendLine($"Students admitted: {studentCount}");
            sb.AppendLine($"University vacancy: {university.Capacity - studentCount}");

            return sb.ToString().TrimEnd();
        }
    }
}
