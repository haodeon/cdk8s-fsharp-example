using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Namespace provides a scope for Names.</summary>
    /// <remarks>
    /// Use of multiple namespaces is optional.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Namespace
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeNamespaceProps), fullyQualifiedName: "k8s.KubeNamespaceProps")]
    public interface IKubeNamespaceProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Namespace#metadata
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

        /// <summary>Spec defines the behavior of the Namespace.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Namespace#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.NamespaceSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INamespaceSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Namespace provides a scope for Names.</summary>
        /// <remarks>
        /// Use of multiple namespaces is optional.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Namespace
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeNamespaceProps), fullyQualifiedName: "k8s.KubeNamespaceProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeNamespaceProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Namespace#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Spec defines the behavior of the Namespace.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Namespace#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.NamespaceSpec\"}", isOptional: true)]
            public K8s.INamespaceSpec? Spec
            {
                get => GetInstanceProperty<K8s.INamespaceSpec?>();
            }
        }
    }
}
