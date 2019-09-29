﻿using System;
namespace Misfit.Model
{
    public class UserResult : BaseEntity
    {
        public UserResult()
        {
        }
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public string Sum { get; set; }
        public DateTime DateOfCalculation { get; set; }
        public virtual User User { get; set; }
    }
}