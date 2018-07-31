using AI.Helpers;
using AI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Models
{
    public class Human : ILivingEntity
    {
        #region Constructor

        public Human(DateTime? dob, DateTime? dod, string firstName, string lastName, Gender Gender, decimal height, decimal weight, string oib, string jmbg, string phoneNumber, string mail, Color hairColor = Color.Brown, Color eyesColor = Color.Brown, string nickName = "")
        {
            this.Start = dob;
            this.End = dod;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = Gender;
            this.Height = height;
            this.Weight = weight;
            this.EyesColor = eyesColor;
            this.HairColor = hairColor;
            this.Nickname = nickName;
            this.Oib = oib;
            this.JMBG = jmbg;
            this.PhoneNumber = phoneNumber;
            this.Mail = mail;
            this.IsAlive = dod == null;
            SetAge();
            this.Relationships = new List<HumanRelationship>();
        }

        #endregion

        #region Properties

        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public Gender Gender { get; set; }
        public string Name { get { return this.FirstName + " " + this.LastName; } set { } }
        public DateTime? Start { get; set; }
        public DateTime? Modifed { get; set; }
        public DateTime? End { get; set; }
        public bool IsAlive { get; set; }

        public Color HairColor { get; set; }

        public Color EyesColor { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Nickname { get; set; }

        public int Age { get; set; }

        public string Oib { get; set; }

        public string JMBG { get; set; }

        public string PhoneNumber { get; set; }

        public string Mail { get; set; }

        public List<HumanRelationship> Relationships { get; set; }

        #endregion


        #region Methods
        public void Breathe()
        {
            throw new NotImplementedException();
        }

        public void Do()
        {
            throw new NotImplementedException();
        }

        public void Eat(IObjectEntity food)
        {
            throw new NotImplementedException();
        }

        public void Dump(IObjectEntity objectEntity)
        {
            throw new NotImplementedException();
        }

        public void SetAge()
        {

            TimeSpan difference = new TimeSpan();

            if (this.IsAlive)
            {
                difference = DateTime.Now - this.Start.GetValueOrDefault();
                this.Age = (int)difference.TotalDays / 365;
            }
            else
            {
                difference = this.End.GetValueOrDefault() - this.Start.GetValueOrDefault();
                this.Age = (int)difference.TotalDays / 365;
            }
        }

        public void AddRelationship(Human person, bool isParent = false, bool isWife = false, bool isChild = false, bool isRelative = false, bool isFriend = false, bool isContact = false)
        {
            HumanRelationship humanRelationship = new HumanRelationship() { IsChild = isChild, IsContact = isContact, IsRelative = isRelative, IsFriend = isFriend, IsParent = isParent, IsWife = isWife, Person = person };
            this.Relationships.Add(humanRelationship);
        }


        public void Talk(object someObject)
        {
            Console.WriteLine("I would like to say following: " + someObject);
        }

        public void Reproduce()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
