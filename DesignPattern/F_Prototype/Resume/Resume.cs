using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.F_Prototype.Resume
{
    internal class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperience workExperience;

        private Resume(WorkExperience workExperience)
        {
            this.workExperience = (WorkExperience)workExperience.Clone();
        }

        public Resume(string name)
        {
            this.name = name;
            workExperience = new WorkExperience();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this.age = age;
            this.sex = sex;
        }
        public void SetWorkExperience(string timeArea, string company)
        {
            workExperience.TimeArea = timeArea;
            workExperience.Company = company;
        }

        public void Display()
        {

        }

        public object Clone()
        {
            Resume resume = new Resume(workExperience);
            resume.age = age;
            resume.sex = sex;
            resume.name = name;
            return resume;
        }
    }
}
