using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Storage version of a specific resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersion
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeStorageVersionV1Alpha1Props")]
    public class KubeStorageVersionV1Alpha1Props : K8s.IKubeStorageVersionV1Alpha1Props
    {
        /// <summary>Spec is an empty spec.</summary>
        /// <remarks>
        /// It is here to comply with Kubernetes API style.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersion#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"primitive\":\"any\"}")]
        public object Spec
        {
            get;
            set;
        }

        /// <summary>The name is &lt;group&gt;.&lt;resource&gt;.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersion#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }
    }
}
