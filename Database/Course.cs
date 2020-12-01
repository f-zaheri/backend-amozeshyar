using System;
using System.Collections.Generic;

namespace Amozeshyar.Database
{
    public class Course : DBObject
    {
        public Manager Manager { get; set; }
        public int ManagerId { get; set; }
        public Field Field { get; set; }
        public int FieldId { get; set; }
        public Professor Professor { get; set; }
        public int ProfessorId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string DayAndHoursOfWeeks { get; set; }
        public double Payment { get; set; }
        public ICollection<Register> Registers { get; set; }
    }
}