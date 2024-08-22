// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace UnbrandedTypeSpec.Models
{
    /// <summary> this is a model with a projected name. </summary>
    public partial class ProjectedModel
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal ProjectedModel(string name)
        {
            Name = name;
        }

        internal ProjectedModel(string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> name of the ModelWithProjectedName. </summary>
        public string Name { get; set; }
    }
}
