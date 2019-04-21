﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extensions
{
    public static class StringExtensions
    {
        public static string Align(string[] data, int[] sizeOfColum)
        {
            int lenght = sizeOfColum.Sum();
            StringBuilder res = new StringBuilder(lenght);
            
            for(int i = 0; i < data.Length; i++)
            {
                res.Append(data[i].PadLeft(sizeOfColum[i]));
            }

            return res.ToString();
        }
    }
}
