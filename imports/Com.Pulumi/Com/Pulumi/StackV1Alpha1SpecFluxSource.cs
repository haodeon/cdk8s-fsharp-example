using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>FluxSource specifies how to fetch source code from a Flux source object.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSource
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackV1Alpha1SpecFluxSource")]
    public class StackV1Alpha1SpecFluxSource : Com.Pulumi.IStackV1Alpha1SpecFluxSource
    {
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSource#sourceRef
        /// </remarks>
        [JsiiProperty(name: "sourceRef", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecFluxSourceSourceRef\"}")]
        public Com.Pulumi.IStackV1Alpha1SpecFluxSourceSourceRef SourceRef
        {
            get;
            set;
        }

        /// <summary>Dir gives the subdirectory containing the Pulumi project (i.e., containing Pulumi.yaml) of interest, within the fetched source.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSource#dir
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
