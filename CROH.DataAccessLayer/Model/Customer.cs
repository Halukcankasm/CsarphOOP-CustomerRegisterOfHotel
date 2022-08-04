using System;
using System.Collections.Generic;
using System.Text;

namespace CROH.DataAccessLayer.Model
{
    public class Customer
    {
        private string name;
        private string surName;
        private string telNumber;
        private CustomerType cusType;

        public int Id { get; set; }
        public string Name 
        {
            get
            {
                string firstCharacter = (name.Substring(0, 1)).ToUpper();
                string contuinesCharacters = (name.Substring(0, name.Length)).ToLower();

                return firstCharacter+contuinesCharacters;
            }
            set
            {
                name = value;
            }
            
        }

        public string SurName
        {
            get
            {
                return surName.ToUpper();

            }
            set
            {
                surName = value;
            }

        }

        public string TelNumber 
        {
            get
            {
                return telNumber;
            }
            set
            {
                telNumber = value;
            }
        }

        public CustomerType CusType 
        {
            get
            {
                return cusType;
            }
            set
            {
                cusType = value;
            }
        }

    }
}
