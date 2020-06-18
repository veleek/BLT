using System;
using System.Collections.Generic;
using System.Text;

namespace BLT
{
    public class User
    {
        #region Constructors

        public User(string firstName, string lastName)
            : this(firstName, lastName, Constants.DEFAULT_USER_ID)
        { }

        public User(string firstName, string lastName, int id)
        {
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName");
            }

            if (lastName == null)
            {
                throw new ArgumentNullException("lastName");
            }

            if (firstName.Trim().Length <= 0 || lastName.Trim().Length <= 0)
            {
                throw new ArgumentException("Invalid Name");
            }

            this._firstName = firstName;
            this._lastName = lastName;
            this._id = id;
        }

        #endregion

        #region Public Methods

        public override bool Equals(object obj)
        {
            if (obj is User)
            {
                return Equals(obj as User);
            }

            return false;
        }

        public bool Equals(User otherUser)
        {
            return (_firstName.Equals(otherUser._firstName)) 
                && (_lastName.Equals(otherUser._lastName)) 
                && (_id == otherUser._id);
        }


        public override string ToString()
        {
            return DisplayName;
        }


        public override int GetHashCode()
        {
            int rc = 13 + GetType().GetHashCode();
            rc = +(67 * _id);
            rc = +(31 * ((_firstName == null) ? 51 : _firstName.GetHashCode()));
            rc = +(91 * ((_lastName == null) ? 37 : _firstName.GetHashCode()));

            return rc;
        }

        #endregion

        #region Public Properties

        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public String DisplayName
        {
            get
            {
                return String.Format("{0} {1} ({2})", _firstName, _lastName, _id);
            }
        }

        #endregion

        #region Private Fields

        private string _firstName = null;
        private string _lastName = null;
        private int _id = Int32.MinValue;

        #endregion
    }
}
