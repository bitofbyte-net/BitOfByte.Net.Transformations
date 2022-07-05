using BitOfByte.Net.Data;

namespace BitOfByte.Net.Transformations
{
    /// <summary>
    /// Represents for Transformation
    /// </summary>
    public class TransformDefinition:EntityBase
    {
        /// <summary>
        /// Gets or sets the transformation name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the transformation type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }
    }
}
