﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Parusnik : Ship
    {
        private int kp; //количсетво парусов

        public int Kp
        {
            get { return kp; }
            set
            {
                if (value > 1)
                {
                    kp = value;
                }
                else
                {
                    kp = 0;
                }
            }
        }
        public Parusnik()
            : base() { }
        public Parusnik(string name, string date, int cost, int kp)
            : base(name, date, cost)
        {
            Kp = kp;
        }

        public override void Show()
        {
            Console.Write($"{Name} стоимостью {Cost} млн. рублей, изготовлен {Date},  количсетво парусов {Kp}\n");
        }
        public override bool Equals(object obj)
        {
            Parusnik a = (Parusnik)obj;
            return Name == a.Name && Date == a.Date && Cost == a.Cost && Kp == a.kp;
        }
        public override string ToString()
        {
            return Name + " " + Cost + " " + Date + " " + Kp;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() + date.GetHashCode() + cost.GetHashCode() + kp.GetHashCode();
        }
    }

}