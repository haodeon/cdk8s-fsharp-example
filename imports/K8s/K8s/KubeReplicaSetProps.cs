using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ReplicaSet ensures that a specified number of pod replicas are running at any given time.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSet
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeReplicaSetProps")]
    public class KubeReplicaSetProps : K8s.IKubeReplicaSetProps
    {
        /// <summary>If the Labels of a ReplicaSet are empty, they are defaulted to be the same as the Pod(s) that the ReplicaSet manages.</summary>
        /// <remarks>
        /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSet#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Spec defines the specification of the desired behavior of the ReplicaSet.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSet#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ReplicaSetSpec\"}", isOptional: true)]
        public K8s.IReplicaSetSpec? Spec
        {
            get;
            set;
        }
    }
}
