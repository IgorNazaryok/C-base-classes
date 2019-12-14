using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Home_Work_3
{
    class Vehicle
    {
       protected int x, y;
        protected double price, speed;
        protected string yearIssue;
        public Vehicle()
        {

        }
        public Vehicle(double price, double speed, string yearIssue)
        {
            this.price = price;
            this.speed = speed;
            this.yearIssue = yearIssue;
        }
        public Vehicle(int x, int y, double price, double speed, string yearIssue)
        {

        }
        public void Info()
        {
           
        }
    }
 } 
