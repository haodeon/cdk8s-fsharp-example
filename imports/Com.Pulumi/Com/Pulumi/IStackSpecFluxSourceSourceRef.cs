using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecFluxSourceSourceRef
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecFluxSourceSourceRef), fullyQualifiedName: "compulumi.StackSpecFluxSourceSourceRef")]
    public interface IStackSpecFluxSourceSourceRef
    {
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecFluxSourceSourceRef#apiVersion
        /// </remarks>
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}")]
        string ApiVersion
        {
            get;
        }

        /// <remarks>
        /// <strong>Schema</strong>: StackSpecFluxSourceSourceRef#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <remarks>
        /// <strong>Schema</strong>: StackSpecFluxSourceSourceRef#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <remarks>
        /// <strong>Schema</strong>: StackSpecFluxSourceSourceRef
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecFluxSourceSourceRef), fullyQualifiedName: "compulumi.StackSpecFluxSourceSourceRef")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecFluxSourceSourceRef
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <remarks>
            /// <strong>Schema</strong>: StackSpecFluxSourceSourceRef#apiVersion
            /// </remarks>
            [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Schema</strong>: StackSpecFluxSourceSourceRef#kind
            /// </remarks>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Schema</strong>: StackSpecFluxSourceSourceRef#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
