﻿namespace Moveis.Data.Entity
{
    public class User
    {
        public int Id { get;set; }  
        public string FirstName { get;set; }
        public string LastName { get;set; }     
        public DateTime DOB { get; set; }       
        public string Login { get; set; }       
        public string Password { get; set; }    

    }
}
