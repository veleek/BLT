using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Collections;
using System.Collections.ObjectModel;

namespace BLT.Data
{
    public class PersonManager
    {
        private static PersonManager instance;
        public static PersonManager Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new PersonManager();
                }
                return instance; 
            }
        }
        
        private Dictionary<Int32, PersonOld> personMap;

        private PersonManager()
        {
            personMap = new Dictionary<int, PersonOld>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public PersonOld CreatePerson(String firstName, String lastName)
        {
            return CreatePerson(firstName, lastName, DateTime.Today);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <returns></returns>
        public PersonOld CreatePerson(String firstName, String lastName, DateTime birthDate)
        {
            PersonOld p = new PersonOld(firstName, lastName, birthDate);

            personMap.Add(p.ID, p);

            return p;
        }

        public void RemovePerson(PersonOld p)
        {
            personMap.Remove(p.ID);
        }

        public void RemovePerson(Int32 id)
        {
            personMap.Remove(id);
        }

        public PersonOld this[Int32 index]
        {
            get { return personMap[index]; }
        }

        public ReadOnlyCollection<PersonOld> AllPeople
        {
            get
            {
                List<PersonOld> people = new List<PersonOld>(this.personMap.Count);
                people.AddRange(this.personMap.Values);

                return people.AsReadOnly();
            }
        }
    }
}
