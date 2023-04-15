using BestMessenger.Infrastructure.Commands;
using BestMessenger.Infrastructure.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace BestMessenger.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        #region Properties
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { UpdateValue<string>(ref firstName, value); }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { UpdateValue<string>(ref lastName, value); }
        }

        private string nickName;

        public string NickName
        {
            get { return nickName; }
            set { UpdateValue<string>(ref nickName, value);}
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { UpdateValue<string>(ref email, value); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { UpdateValue<string>(ref password, value); }
        }
        #endregion

        #region Commands
        public ActionCommand RegistrationCommand => new ActionCommand(x => ValidateProperties());
        #endregion

        public RegistrationViewModel()
        {
            
        }
        private void ValidateProperties()
        {
            ValidationUtils.NameValidate(FirstName);
            ValidationUtils.NameValidate(LastName);
            ValidationUtils.NameValidate(NickName);
            ValidationUtils.EmailValidate(Email);
            ValidationUtils.PasswordValidate(Password);
        }
    }
}
