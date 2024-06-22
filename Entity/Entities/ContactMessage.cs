using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class ContactMessage : EntityBase
    {
        public ContactMessage()
        {

        }

        public ContactMessage(string fullName, string email, string phoneNumber, string message)
        {
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Message = message;
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
    }
}
