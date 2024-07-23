using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>FluxSource specifies how to fetch source code from a Flux source object.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackV1Alpha1SpecFluxSource), fullyQualifiedName: "compulumi.StackV1Alpha1SpecFluxSource")]
    public interface IStackV1Alpha1SpecFluxSource
    {
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSource#sourceRef
        /// </remarks>
        [JsiiProperty(name: "sourceRef", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecFluxSourceSourceRef\"}")]
        Com.Pulumi.IStackV1Alpha1SpecFluxSourceSourceRef SourceRef
        {
            get;
        }

        /// <summary>Dir gives the subdirectory containing the Pulumi project (i.e., containing Pulumi.yaml) of interest, within the fetched source.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSource#dir
        /// </remarks>
        [JsiiProperty(name: "dir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Dir
        {
            get
            {
                return null;
            }
        }

        /// <summary>FluxSource specifies how to fetch source code from a Flux source object.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackV1Alpha1SpecFluxSource), fullyQualifiedName: "compulumi.StackV1Alpha1SpecFluxSource")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackV1Alpha1SpecFluxSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSource#sourceRef
            /// </remarks>
            [JsiiProperty(name: "sourceRef", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecFluxSourceSourceRef\"}")]
            public Com.Pulumi.IStackV1Alpha1SpecFluxSourceSourceRef SourceRef
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecFluxSourceSourceRef>()!;
            }

            /// <summary>Dir gives the subdirectory containing the Pulumi project (i.e., containing Pulumi.yaml) of interest, within the fetched source.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSource#dir
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Dir
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
