using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Dmitriev_01
{
    internal class LoginChecker
    {
        private string login;
        private StringBuilder errorDescr;
                
        public string  ErrorDescr
        {
            get
            {
                return errorDescr.ToString();
            }
        }

        public bool UseRegEx { get; set; }

        public LoginChecker(string login)
        {
            this.login = login;
            errorDescr = new StringBuilder();
            UseRegEx = false;
        }
                
        internal bool IsCorrect()
        {
            errorDescr = new StringBuilder();
            if (UseRegEx)            
                return IsHasCorrectLength() & !IsStartByNumberRegEx() & IsNotHaveForbiddenCharRegEx();
            else
                return IsHasCorrectLength() & !IsStartByNumber() & IsNotHaveForbiddenChar();
        }

        private bool IsNotHaveForbiddenCharRegEx()
        {
            Regex re = new Regex(@"[^\da-z]");
            if (re.IsMatch(login))
            {
                StringBuilder chrs = new StringBuilder();
                
                foreach (var item in re.Matches(login))
                {
                    if (chrs.ToString().IndexOf(item.ToString()) == -1)
                        chrs.Append(item.ToString());     
                }

                errorDescr.AppendFormat("содержит запрещенные символы '{0}'; ", chrs.ToString());
                return false;
            }
            
            return true;
        }

        private bool IsStartByNumberRegEx()
        {
            Regex re = new Regex(@"^\d");
            if (re.IsMatch(login))
            {
                errorDescr.Append("начинается с цифры; ");
                return true;
            }
            return false;
        }

        private bool IsHasCorrectLength()
        {
            if (login.Length < 2)
            {
                errorDescr.Append("имеет меньше двух символов; ");
                return false;
            }
            else if (login.Length > 10)
            {
                errorDescr.Append("имеет больше десяти символов; ");
                return false;
            }

            return true;
        }

        private bool IsNotHaveForbiddenChar()
        {
            StringBuilder chrs = new StringBuilder();
                        
            foreach (char c in login)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    if(chrs.ToString().IndexOf(c) == -1)
                        chrs.Append(c);
                }
            }

            if (chrs.Length > 0)
            {
                errorDescr.AppendFormat("содержит запрещенные символы '{0}'; ", chrs.ToString());                
                return false;
            }

            return true;
        }

        private bool IsStartByNumber()
        {
            if (login.Length > 0 && char.IsDigit(login[0]))
            {
                errorDescr.Append("начинается с цифры; ");
                return true;
            }

            return false;
        }
    }
}