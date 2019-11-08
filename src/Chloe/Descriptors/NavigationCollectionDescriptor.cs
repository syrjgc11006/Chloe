﻿using Chloe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chloe.Descriptors
{
    public class NavigationCollectionDescriptor : PropertyDescriptor
    {
        public NavigationCollectionDescriptor(NavigationCollectionDefinition definition, TypeDescriptor declaringTypeDescriptor) : base(definition, declaringTypeDescriptor)
        {
            this.Definition = definition;
        }

        public new NavigationCollectionDefinition Definition { get; private set; }
        public Type ElementType { get { return this.Definition.ElementType; } }
    }
}
