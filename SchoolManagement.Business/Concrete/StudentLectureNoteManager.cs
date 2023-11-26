using SchoolManagement.Business.Abstract;
using SchoolManagement.Core.Constants;
using SchoolManagement.Core.Results;
using SchoolManagement.DataAccess.Abstract;
using SchoolManagement.DataAccess.Concrete;
using SchoolManagement.Entities;
using SchoolManagement.Entities.Contract;
using SchoolManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Business.Concrete
{
    public class StudentLectureNoteManager : IStudentLectureNoteService
    {
        IStudentLectureNote _studentLectureNote;
        public StudentLectureNoteManager(IStudentLectureNote studentLectureNote)
        {
            _studentLectureNote = studentLectureNote;
        }

        public IResult Add(StudentLectureNote contract)
        {
            _studentLectureNote.Add(contract);
            return new SuccessResult(Messages.StudentLectureNoteAdded);
        }

        public IResult Delete(int id)
        {
            StudentLectureNote note = GetById(id).Data;
            if (note != null)
            {
                _studentLectureNote.Delete(note);
                return new SuccessResult(Messages.DeleteLectureNoteById);
            }
            else
            {
                return new ErrorResult(ErrorMessages.LectureNoteNotDeleted);
            }

        }

        public IDataResult<List<StudentLectureNote>> GetAll()
        {
            List<StudentLectureNote> notes = _studentLectureNote.GetAll();

            if (notes != null && notes.Count != 0)
            {
                return new SuccessDataResult<List<StudentLectureNote>>(notes, Messages.StudentLectureNotesListed);
            }
            else
            {
                return new ErrorDataResult<List<StudentLectureNote>>(notes, ErrorMessages.StudentLectureNotesNotFound);
            }
        }

        public IDataResult<List<StudentLectureNoteDto>> GetAllNotesByStudent(int studentId)
        {
            if (studentId == 0)
            {
                return new ErrorDataResult<List<StudentLectureNoteDto>>(ErrorMessages.StudentIdIsNull);
            }
            return _studentLectureNote.GetAllNotesByStudent(studentId);
        }

        public IDataResult<StudentLectureNote> GetById(int id)
        {
            StudentLectureNote note = _studentLectureNote.Get(p => p.Id == id);
            if (note == null)
            {
                return new ErrorDataResult<StudentLectureNote>(ErrorMessages.LectureNotesNotFound);
            }
            else
            {
                return new SuccessDataResult<StudentLectureNote>(note, Messages.GetLectureNoteById);
            }
        }

        public IResult Update(StudentLectureNote note)
        {
            _studentLectureNote.Update(note);
            return new SuccessResult(Messages.StudentLectureNoteAdded);
        }
    }
}
