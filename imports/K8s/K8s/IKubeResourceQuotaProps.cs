using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceQuota sets aggregate quota restrictions enforced per namespace.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuota
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeResourceQuotaProps), fullyQualifiedName: "k8s.KubeResourceQuotaProps")]
    public interface IKubeResourceQuotaProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuota#metadata
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

        /// <summary>Spec defines the desired quota.</summary>
        /// <remarks>
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuota#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ResourceQuotaSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IResourceQuotaSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceQuota sets aggregate quota restrictions enforced per namespace.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuota
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeResourceQuotaProps), fullyQualifiedName: "k8s.KubeResourceQuotaProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeResourceQuotaProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuota#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Spec defines the desired quota.</summary>
            /// <remarks>
            /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuota#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ResourceQuotaSpec\"}", isOptional: true)]
            public K8s.IResourceQuotaSpec? Spec
            {
                get => GetInstanceProperty<K8s.IResourceQuotaSpec?>();
            }
        }
    }
}
