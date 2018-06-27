﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace Blazor.FlexGrid.Components.Configuration.MetaData
{
    public class NullEntityType : IEntityType
    {
        public static NullEntityType Instance = new NullEntityType();

        public object this[string name] => null;

        public Type ClrType => null;

        public IModel Model => null;

        public string Name => string.Empty;

        public IProperty AddProperty(MemberInfo memberInfo)
        {
            return null;
        }

        public IAnnotation FindAnnotation(string name)
        {
            return null;
        }

        public IProperty FindProperty(string name)
        {
            return null;
        }

        public IEnumerable<IAnnotation> GetAllAnnotations()
        {
            return new List<Annotation>();
        }

        public IEnumerable<IProperty> GetProperties()
        {
            return new List<Property>();
        }
    }
}
