﻿using System;
using System.Linq;

namespace CSP
{
    public struct Pair : IEquatable<Pair>
    {
        public Pair(Variable variable, Color color)
        {
#if DEBUG
            if (!variable.AvalibleColors.Contains(color))
            {
                throw new ArgumentException("Pair cannot be made, becouse the color does not belong to the variable");
            }
#endif
            Variable = variable;
            Color = color;
        }
        public Variable Variable;
        public Color Color;

        public void Deconstruct(out Variable variable, out Color color)
        {
            variable = Variable;
            color = Color;
        }

        public bool IsNeighborOf(Pair pair)
        {
            return Color.IsNeighborOf(pair.Color);
        }

        public bool Equals(Pair pair)
        {
            return Variable == pair.Variable && Color == pair.Color;
        }

        public override bool Equals(object obj)
        {
            return obj is Pair pair && Equals(pair);
        }

        public static bool operator ==(Pair first, Pair second) => first.Equals(second);
        public static bool operator !=(Pair first, Pair second) => !(first == second);

        public override int GetHashCode() => base.GetHashCode();
        public override string ToString()
        {
            return $"[{Variable} : {Color}] ";
        }
    }
}
