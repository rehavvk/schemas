using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scaffold.Schemas
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SchemaFilterAttribute : Attribute
    {
        public SchemaFilterAttribute(params Type[] schemaTypes)
        {
            SchemaTypes = schemaTypes;
        }

        public Type[] SchemaTypes { get; private set; }
    }
}
