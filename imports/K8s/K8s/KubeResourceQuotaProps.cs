using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceQuota sets aggregate quota restrictions enforced per namespace.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuota
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeResourceQuotaProps")]
    public class KubeResourceQuotaProps : K8s.IKubeResourceQuotaProps
    {
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
            get;
            set;
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
            get;
            set;
        }
    }
}
