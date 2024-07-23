using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Overhead structure represents the resource overhead associated with running a pod.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.node.v1.Overhead
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IOverhead), fullyQualifiedName: "k8s.Overhead")]
    public interface IOverhead
    {
        /// <summary>podFixed represents the fixed resource overhead associated with running a pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.node.v1.Overhead#podFixed
        /// </remarks>
        [JsiiProperty(name: "podFixed", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, K8s.Quantity>? PodFixed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Overhead structure represents the resource overhead associated with running a pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.node.v1.Overhead
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IOverhead), fullyQualifiedName: "k8s.Overhead")]
        internal sealed class _Proxy : DeputyBase, K8s.IOverhead
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>podFixed represents the fixed resource overhead associated with running a pod.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.node.v1.Overhead#podFixed
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "podFixed", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, K8s.Quantity>? PodFixed
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, K8s.Quantity>?>();
            }
        }
    }
}
