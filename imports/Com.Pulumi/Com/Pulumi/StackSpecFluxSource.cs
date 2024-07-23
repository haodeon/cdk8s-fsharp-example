using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>FluxSource specifies how to fetch source code from a Flux source object.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecFluxSource
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpecFluxSource")]
    public class StackSpecFluxSource : Com.Pulumi.IStackSpecFluxSource
    {
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecFluxSource#sourceRef
        /// </remarks>
        [JsiiProperty(name: "sourceRef", typeJson: "{\"fqn\":\"compulumi.StackSpecFluxSourceSourceRef\"}")]
        public Com.Pulumi.IStackSpecFluxSourceSourceRef SourceRef
        {
            get;
            set;
        }

        /// <summary>Dir gives the subdirectory containing the Pulumi project (i.e., containing Pulumi.yaml) of interest, within the fetched source.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecFluxSource#dir
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Dir
        {
            get;
            set;
        }
    }
}
