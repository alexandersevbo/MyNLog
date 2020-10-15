﻿using System;

namespace MyNLog
{
    public static class TypeExtensions
    {
        public static bool IsCanBeNull(this Type type)
        {
            return !type.IsValueType || (Nullable.GetUnderlyingType(type) != null);
        }
    }
}
