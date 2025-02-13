﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Position : IEquatable<Position?>
    {
        public int Row { get; }
        public int Col { get; }

        public Position(int row, int col)
        {
            Row = row; 
            Col = col;
        }

        public Position Translate(Direction dir)
        {
            return new Position(Row + dir.RowOffSet, Col + dir.ColOffSet);
        }

        public bool Equals(Position? other)
        {
            return other is not null &&
                   Row == other.Row &&
                   Col == other.Col;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Col);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }
    }
}
