using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Adds and removes POSIX capabilities from running containers.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Capabilities
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICapabilities), fullyQualifiedName: "k8s.Capabilities")]
    public interface ICapabilities
    {
        /// <summary>Added capabilities.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Capabilities#add
        /// </remarks>
        [JsiiProperty(name: "add", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Add
        {
            get
            {
                return null;
            }
        }

        /// <summary>Removed capabilities.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Capabilities#drop
        /// </remarks>
        [JsiiProperty(name: "drop", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Drop
        {
            get
            {
                return null;
            }
        }

        /// <summary>Adds and removes POSIX capabilities from running containers.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Capabilities
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICapabilities), fullyQualifiedName: "k8s.Capabilities")]
        internal sealed class _Proxy : DeputyBase, K8s.ICapabilities
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Added capabilities.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Capabilities#add
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "add", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Add
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Removed capabilities.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Capabilities#drop
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "drop", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Drop
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
