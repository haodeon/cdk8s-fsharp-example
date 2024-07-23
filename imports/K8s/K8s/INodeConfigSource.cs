using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NodeConfigSource specifies a source of node configuration.</summary>
    /// <remarks>
    /// Exactly one subfield (excluding metadata) must be non-nil. This API is deprecated since 1.22
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeConfigSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(INodeConfigSource), fullyQualifiedName: "k8s.NodeConfigSource")]
    public interface INodeConfigSource
    {
        /// <summary>ConfigMap is a reference to a Node's ConfigMap.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeConfigSource#configMap
        /// </remarks>
        [JsiiProperty(name: "configMap", typeJson: "{\"fqn\":\"k8s.ConfigMapNodeConfigSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IConfigMapNodeConfigSource? ConfigMap
        {
            get
            {
                return null;
            }
        }

        /// <summary>NodeConfigSource specifies a source of node configuration.</summary>
        /// <remarks>
        /// Exactly one subfield (excluding metadata) must be non-nil. This API is deprecated since 1.22
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeConfigSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INodeConfigSource), fullyQualifiedName: "k8s.NodeConfigSource")]
        internal sealed class _Proxy : DeputyBase, K8s.INodeConfigSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ConfigMap is a reference to a Node's ConfigMap.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeConfigSource#configMap
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configMap", typeJson: "{\"fqn\":\"k8s.ConfigMapNodeConfigSource\"}", isOptional: true)]
            public K8s.IConfigMapNodeConfigSource? ConfigMap
            {
                get => GetInstanceProperty<K8s.IConfigMapNodeConfigSource?>();
            }
        }
    }
}
