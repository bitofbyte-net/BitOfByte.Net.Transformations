using CSharpFunctionalExtensions;
using Fluid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOfByte.Net.Transformations
{
    /// <summary>
    /// Implementation of TransformationEngine using Fluid
    /// </summary>
    /// <seealso cref="BitOfByte.Net.Transformations.ITransformationEngine" />
    public class FluidTransformationEngine : ITransformationEngine
    {
        /// <summary>
        /// Get the type of transformations engine supports.
        /// </summary>
        /// <value>
        /// Transformation type supported by engine.
        /// </value>
        public string ForType => "Liquid";

        /// <summary>
        /// Transforms the specified .
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="definition">The definition.</param>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public async Task<Result<string>> Transform<TSource>(TransformDefinition definition, TSource source)
        {
            if(definition is not LiquidTransformation)
                return Result.Failure<string>("Engine only support 'Liquid' transformations");

            var fluidDefinition = definition as LiquidTransformation;
            var parser = new FluidParser();

            if (parser.TryParse(fluidDefinition.Template, out var template, out string error))
            {
                var context = new TemplateContext(source);
                var result = await template.RenderAsync(context);

                return Result.Success(result);
            }else
            {
                return Result.Failure<string>($"Template parsing error: ${error}");
            }
        }
    }
}
