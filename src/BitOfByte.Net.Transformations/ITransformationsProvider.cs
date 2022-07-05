using BitOfByte.Net.Data;
using CSharpFunctionalExtensions;
using System.Threading.Tasks;

namespace BitOfByte.Net.Transformations
{
    /// <summary>
    /// Interface for transformations provider
    /// </summary>
    public interface ITransformationsProvider:IRepository<TransformDefinition>
    {
        /// <summary>
        /// Gets the TransformDefinition with then specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>TransformDefinition with the specified name if found!</returns>
        Result<TransformDefinition> Get(string name);


        /// <summary>
        /// Gets the TransformDefinition with then specified name asynchornously.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>TransformDefinition with the specified name if found!</returns>
        Task<Result<TransformDefinition>> GetAsync(string name);
    }
}
