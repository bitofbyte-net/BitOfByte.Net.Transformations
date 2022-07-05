using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOfByte.Net.Transformations
{
    /// <summary>
    /// POCO to hold liquid transformation definition
    /// </summary>
    /// <seealso cref="BitOfByte.Net.Transformations.TransformDefinition" />
    public class LiquidTransformation : TransformDefinition
    {
        /// <summary>
        /// Gets or sets the transformation template.
        /// </summary>
        /// <value>
        /// The template.
        /// </value>
        public string Template { get; set; }
    }
}
