using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queeless
{
    public class LoginPage
    {
        private string name;
        private string email;
        private string phoneNumber;
        private string password;

        public LoginPage(string name,string email,string phoneNumber,string password)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.password = password;
        }

        public string GetName()
        {
            return name;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }
         public string GetPassword()
        {
            return password;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }

        public bool IsValidName()
        {
            if (name == "")
            {
                return false;
            }
            return true;
        }

        public bool IsValidPhoneNumber()
        {
            if (phoneNumber.Length != 10)
            {
                return false;
            }

            foreach(char number in phoneNumber)
            {
                if (!char.IsDigit(number))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsValidStudentEmail()
        {
            if (!email.EndsWith("@student.uj.ac.za"))
            {
                return false;
            }

            string studentNumber = email.Replace("@student.uj.ac.za", "");

            if (studentNumber.Length != 9)
            {
                return false;
            }

            foreach (char number in studentNumber)
            {
                if (!char.IsDigit(number))
                {
                    return false;
                }
            }

            return true;
        }
        public bool IsValidLecturerEmail()
        {
            if (!email.EndsWith("@lecturer.uj.ac.za"))
            {
                return false;
            }
            return true;
        }

        public bool IsValidPassword()
        {
            if (password.Length != 13)
            {
                return false;
            }

            bool hasNumber = false;
            bool hasSpecial = false;

            foreach (char character in password)
            {
                if (char.IsDigit(character))
                {
                    hasNumber = true;
                }

                if (!char.IsLetterOrDigit(character))
                {
                    hasSpecial = true;
                }
            }

            if (!hasNumber || !hasSpecial)
            {
                return false;
            }

            return true;
        }

        public bool StudentLogin()
        {
            if (!IsValidStudentEmail())
            {
                return false;
            }

            if (password == "")
            {
                return false;
            }

            return true;
        }

        public bool LecturerLogin()
        {
            if (!IsValidLecturerEmail())
            {
                return false;
            }

            if (password == "")
            {
                return false;
            }

            return true;
        }

        public bool SignUp()
        {
            if (!IsValidName())
            {
                return false;
            }

            if (!IsValidPhoneNumber())
            {
                return false;
            }

            if (!IsValidStudentEmail())
            {
                return false;
            }

            if (!IsValidPassword())
            {
                return false;
            }

            return true;
        }
    }
}

