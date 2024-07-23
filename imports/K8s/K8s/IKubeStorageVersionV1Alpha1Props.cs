using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Storage version of a specific resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersion
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeStorageVersionV1Alpha1Props), fullyQualifiedName: "k8s.KubeStorageVersionV1Alpha1Props")]
    public interface IKubeStorageVersionV1Alpha1Props
    {
        /// <summary>Spec is an empty spec.</summary>
        /// <remarks>
        /// It is here to comply with Kubernetes API style.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersion#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"primitive\":\"any\"}")]
        object Spec
        {
            get;
        }

        /// <summary>The name is &lt;group&gt;.&lt;resource&gt;.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersion#metadata
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

        /// <summary>Storage version of a specific resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersion
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeStorageVersionV1Alpha1Props), fullyQualifiedName: "k8s.KubeStorageVersionV1Alpha1Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeStorageVersionV1Alpha1Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Spec is an empty spec.</summary>
            /// <remarks>
            /// It is here to comply with Kubernetes API style.
            ///
            /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersion#spec
            /// </remarks>
            [JsiiProperty(name: "spec", typeJson: "{\"primitive\":\"any\"}")]
            public object Spec
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The name is &lt;group&gt;.&lt;resource&gt;.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersion#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }
        }
    }
}
