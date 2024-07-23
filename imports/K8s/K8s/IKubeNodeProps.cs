using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Node is a worker node in Kubernetes.</summary>
    /// <remarks>
    /// Each node will have a unique identifier in the cache (i.e. in etcd).
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Node
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeNodeProps), fullyQualifiedName: "k8s.KubeNodeProps")]
    public interface IKubeNodeProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Node#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Spec defines the behavior of a node.</summary>
        /// <remarks>
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Node#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.NodeSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INodeSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Node is a worker node in Kubernetes.</summary>
        /// <remarks>
        /// Each node will have a unique identifier in the cache (i.e. in etcd).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Node
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeNodeProps), fullyQualifiedName: "k8s.KubeNodeProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeNodeProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Node#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Spec defines the behavior of a node.</summary>
            /// <remarks>
            /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Node#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.NodeSpec\"}", isOptional: true)]
            public K8s.INodeSpec? Spec
            {
                get => GetInstanceProperty<K8s.INodeSpec?>();
            }
        }
    }
}
