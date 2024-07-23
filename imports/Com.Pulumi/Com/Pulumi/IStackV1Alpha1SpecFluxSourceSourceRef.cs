using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSourceSourceRef
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackV1Alpha1SpecFluxSourceSourceRef), fullyQualifiedName: "compulumi.StackV1Alpha1SpecFluxSourceSourceRef")]
    public interface IStackV1Alpha1SpecFluxSourceSourceRef
    {
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSourceSourceRef#apiVersion
        /// </remarks>
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}")]
        string ApiVersion
        {
            get;
        }

        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSourceSourceRef#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSourceSourceRef#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSourceSourceRef
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackV1Alpha1SpecFluxSourceSourceRef), fullyQualifiedName: "compulumi.StackV1Alpha1SpecFluxSourceSourceRef")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackV1Alpha1SpecFluxSourceSourceRef
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSourceSourceRef#apiVersion
            /// </remarks>
            [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSourceSourceRef#kind
            /// </remarks>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSourceSourceRef#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
