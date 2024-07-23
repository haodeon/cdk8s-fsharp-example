using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>FluxSource specifies how to fetch source code from a Flux source object.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecFluxSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecFluxSource), fullyQualifiedName: "compulumi.StackSpecFluxSource")]
    public interface IStackSpecFluxSource
    {
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecFluxSource#sourceRef
        /// </remarks>
        [JsiiProperty(name: "sourceRef", typeJson: "{\"fqn\":\"compulumi.StackSpecFluxSourceSourceRef\"}")]
        Com.Pulumi.IStackSpecFluxSourceSourceRef SourceRef
        {
            get;
        }

        /// <summary>Dir gives the subdirectory containing the Pulumi project (i.e., containing Pulumi.yaml) of interest, within the fetched source.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecFluxSource#dir
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
        /// <strong>Schema</strong>: StackSpecFluxSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecFluxSource), fullyQualifiedName: "compulumi.StackSpecFluxSource")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecFluxSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <remarks>
            /// <strong>Schema</strong>: StackSpecFluxSource#sourceRef
            /// </remarks>
            [JsiiProperty(name: "sourceRef", typeJson: "{\"fqn\":\"compulumi.StackSpecFluxSourceSourceRef\"}")]
            public Com.Pulumi.IStackSpecFluxSourceSourceRef SourceRef
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecFluxSourceSourceRef>()!;
            }

            /// <summary>Dir gives the subdirectory containing the Pulumi project (i.e., containing Pulumi.yaml) of interest, within the fetched source.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecFluxSource#dir
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
