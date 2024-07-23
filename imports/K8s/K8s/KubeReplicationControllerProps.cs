using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ReplicationController represents the configuration of a replication controller.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationController
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeReplicationControllerProps")]
    public class KubeReplicationControllerProps : K8s.IKubeReplicationControllerProps
    {
        /// <summary>If the Labels of a ReplicationController are empty, they are defaulted to be the same as the Pod(s) that the replication controller manages.</summary>
        /// <remarks>
        /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationController#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Spec defines the specification of the desired behavior of the replication controller.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationController#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ReplicationControllerSpec\"}", isOptional: true)]
        public K8s.IReplicationControllerSpec? Spec
        {
            get;
            set;
        }
    }
}
