﻿using System.Collections.Generic;

namespace CSP
{
    public class Variable
    {
        static int uniqueId = 0;

        public Variable(int avalibleColorsCount)
        {
            for (int i = 0; i < avalibleColorsCount; i++)
            {
                this.avalibleColors.Add(new Color(i));
            }
        }

        public Variable(IEnumerable<Color> avalibleColors)
        {
            this.avalibleColors.AddRange(avalibleColors);
        }

        public int Id { get; set; } = uniqueId++;

        internal List<Color> avalibleColors = new();
        public IReadOnlyList<Color> AvalibleColors { get => avalibleColors; }
        public override string ToString()
        {
            return Id.ToString() + "(" + AvalibleColors.Count.ToString() + ") ";
        }
    }
}
