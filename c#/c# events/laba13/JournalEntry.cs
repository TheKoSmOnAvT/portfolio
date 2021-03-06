﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba13
{
    class JournalEntry
    {
        public string NameCollection { get; set; }
        public string Information { get; set; }
        public object Link { get; set; }

        public JournalEntry(string name, string inform, object ln)
        {
            NameCollection = name;
            Information = inform;
            Link = ln;
        }
        public override string ToString()
        {
            return $"Название: {NameCollection}\n Информация: {Information}\n ОбЪект: {Link}";
        }
    }
}
