﻿using System.Collections.Generic;

namespace Shooter
{
    public sealed class GoodBonusesEqualityComparer : IEqualityComparer<GoodBonus>
    {
        public bool Equals(GoodBonus x, GoodBonus y) => x.Point == y.Point;

        public int GetHashCode(GoodBonus obj) => obj.Point.GetHashCode();
    }
}
