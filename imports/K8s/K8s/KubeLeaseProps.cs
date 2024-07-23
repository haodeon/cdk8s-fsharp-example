using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Lease defines a lease concept.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.coordination.v1.Lease
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeLeaseProps")]
    public class KubeLeaseProps : K8s.IKubeLeaseProps
    {
        /// <summary>More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.Lease#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>spec contains the specification of the Lease.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.Lease#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.LeaseSpec\"}", isOptional: true)]
        public K8s.ILeaseSpec? Spec
        {
            get;
            set;
        }
    }
}
