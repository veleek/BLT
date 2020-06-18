using System;
using System.Collections.Generic;
using System.Text;

namespace BLT
{
    [Serializable]
    public class PersonOld : IComparable<PersonOld>, IEquatable<PersonOld>
    {
        bool nameDirty = true;

        private String firstName;
        public String FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                nameDirty = true;
                hashDirty = true;
            }
        }

        private String lastName;
        public String LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                nameDirty = true;
                hashDirty = true;
            }
        }

        private String displayName;
        public String DisplayName
        {
            get 
            {
                if (nameDirty)
                {
                    StringBuilder sb = new StringBuilder(32);
                    if (firstName.Length > 0)
                    {
                        sb.Append(firstName);
                    }

                    if (lastName.Length > 0)
                    {
                        if(sb.Length > 0)
                        {
                            sb.Append(' ');
                        }

                        sb.Append(lastName);
                    }

                    displayName = sb.ToString();
                    nameDirty = false;
                }
                return displayName;
            }
        }

        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set 
            { 
                birthDate = value;
                hashDirty = true;
            }
        }

        /// <summary>
        /// The identifing numeber for this PersonOld.  Any PersonOld with the same name and 
        /// the same birthdate will have the same ID.  The ID is simply the HashCode. 
        /// </summary>
        public Int32 ID
        {
            get { return this.GetHashCode(); }
        }

        internal PersonOld(String firstName, String lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        #region IEquatable<PersonOld> Members
        /// <summary>
        /// Returns a boolean value indicating if two PersonOld objects are equal
        /// </summary>
        /// <param name="other">The other PersonOld to be compared</param>
        /// <returns>True if the IDs of the two objects are equal</returns>
        public bool Equals(PersonOld other)
        {
            return this.ID == other.ID;
        }
        
        #endregion

        #region IComparable<PersonOld> Members
        /// <summary>
        /// Compares two PersonOld objects together, mostly for display ordering.  Two Persons are
        /// sorted using the regular alphabetical sorting method on the DisplayName property.
        /// If the two names are identical, the names are ordered using their associated IDs.
        /// </summary>
        /// <param name="other">The other PersonOld to compare this too</param>
        /// <returns>
        /// Less than 1 if the this PersonOld comes before the other, Greater than 1 if the this
        /// PersonOld comes after the other, and 0 if they are the same PersonOld
        /// </returns>
        public int CompareTo(PersonOld other)
        {
            Int32 res = String.Compare(this.DisplayName, other.DisplayName, true);

            if (res == 0)
            {
                return this.ID.CompareTo(other.ID);
            }
            else
            {
                return res;
            }
        }

        #endregion

        private bool hashDirty = true;
        private Int32 hashCode;

        public override int GetHashCode()
        {
            if (hashDirty)
            {
                String hashString = firstName + lastName + birthDate.ToShortDateString();
                hashCode = hashString.GetHashCode();

                hashDirty = false;
            }

            return hashCode;
        }
    }
}
