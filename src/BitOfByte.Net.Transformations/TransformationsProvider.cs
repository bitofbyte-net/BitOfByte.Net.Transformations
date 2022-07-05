using BitOfByte.Net.Data;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BitOfByte.Net.Transformations
{
    /// <summary>
    /// TransformationsProvider implementation using EF Repository
    /// </summary>
    public class TransformationsProvider : Repository<TransformDefinition>, ITransformationsProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransformationsProvider"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public TransformationsProvider(DbContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets the TransformDefinition with then specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>
        /// TransformDefinition with the specified name if found!
        /// </returns>
        public Result<TransformDefinition> Get(string name)
        {
            return FindBy(d => d.Name == name).FirstOrDefault();
        }

        /// <summary>
        /// Gets the TransformDefinition with then specified name asynchornously.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>
        /// TransformDefinition with the specified name if found!
        /// </returns>
        public Task<Result<TransformDefinition>> GetAsync(string name)
        {
            return Task.Run(() => Get(name));
        }
    }
}
