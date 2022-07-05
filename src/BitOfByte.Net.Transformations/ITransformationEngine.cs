using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOfByte.Net.Transformations
{
    /// <summary>
    /// Interface for transformation engine
    /// </summary>
    public interface ITransformationEngine
    {
        /// <summary>
        /// Get the type of transformations engine supports.
        /// </summary>
        /// <value>
        /// Transformation type supported by engine.
        /// </value>
        string ForType { get; }


        /// <summary>
        /// Applies the transformation on source.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="definition">The definition.</param>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        Task<Result<string>> Transform<TSource>(TransformDefinition definition, TSource source);
    }
}
