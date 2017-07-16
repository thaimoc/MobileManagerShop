using System;
using System.Collections.Generic;
using System.Collections;
using BLToolkit.Mapping;
using BLToolkit.DataAccess;
using System.ComponentModel;

namespace DAL.SqlServer
{
    public static class ReflectionExtensions
    {
        // Fields
        private static readonly Hashtable _keyList = new Hashtable();

        // Methods
        public static string GetFirstKey<T>(this Type value) where T : class
        {
            MemberMapper[] mmList = value.GetKeyFieldList<T>();
            return ((mmList.Length == 0) ? null : mmList[0].Name);
        }

        public static MemberMapper[] GetKeyFieldList<T>(this Type value) where T : class
        {
            string key = value.FullName;
            MemberMapper[] mmList = (MemberMapper[])_keyList[key];
            if (mmList == null)
            {
                List<MemberMapper> list = new List<MemberMapper>();
                foreach (MemberMapper mm in ObjectMapper<T>.Instance)
                {
                    if (!mm.MapMemberInfo.SqlIgnore)
                    {
                        PrimaryKeyAttribute attr = mm.MapMemberInfo.MemberAccessor.GetAttribute<PrimaryKeyAttribute>();
                        if (attr != null)
                        {
                            //list.Insert(attr.Order - 1, mm);
                            list.Insert(attr.Order + 1, mm);
                        }
                    }
                }
                mmList = list.ToArray();
                _keyList[key] = mmList;
            }
            return mmList;
        }

        public static object ChangeTypeTo(this object value, Type conversionType)
        {
            if (conversionType == null)
            {
                throw new ArgumentNullException("conversionType");
            }
            if (conversionType.IsGenericType && conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return null;
                }
                NullableConverter nullableConverter = new NullableConverter(conversionType);
                conversionType = nullableConverter.UnderlyingType;
            }
            else
            {
                if (conversionType == typeof(Guid))
                {
                    return new Guid(value.ToString());
                }
                if ((conversionType == typeof(long)) && (value.GetType() == typeof(int)))
                {
                    throw new InvalidOperationException("Can't convert an Int64 (long) to Int32(int). If you're using SQLite - this is probably due to your PK being an INTEGER, which is 64bit. You'll need to set your key to long.");
                }
            }
            return Convert.ChangeType(value, conversionType);
        }
    }
}
