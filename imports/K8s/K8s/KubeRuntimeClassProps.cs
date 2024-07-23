using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>RuntimeClass defines a class of container runtime supported in the cluster.</summary>
    /// <remarks>
    /// The RuntimeClass is used to determine which container runtime is used to run all containers in a pod. RuntimeClasses are manually defined by a user or cluster provisioner, and referenced in the PodSpec. The Kubelet is responsible for resolving the RuntimeClassName reference before running the pod.  For more details, see https://kubernetes.io/docs/concepts/containers/runtime-class/
    ///
    /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClass
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeRuntimeClassProps")]
    public class KubeRuntimeClassProps : K8s.IKubeRuntimeClassProps
    {
        /// <summary>handler specifies the underlying runtime and configuration that the CRI implementation will use to handle pods of this class.</summary>
        /// <remarks>
        /// The possible values are specific to the node &amp; CRI configuration.  It is assumed that all handlers are available on every node, and handlers of the same name are equivalent on every node. For example, a handler called "runc" might specify that the runc OCI runtime (using native Linux containers) will be used to run the containers in a pod. The Handler must be lowercase, conform to the DNS Label (RFC 1123) requirements, and is immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClass#handler
        /// </remarks>
        [JsiiProperty(name: "handler", typeJson: "{\"primitive\":\"string\"}")]
        public string Handler
        {
            get;
            set;
        }

        /// <summary>More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClass#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>overhead represents the resource overhead associated with running a pod for a given RuntimeClass.</summary>
        /// <remarks>
        /// For more details, see
        /// https://kubernetes.io/docs/concepts/scheduling-eviction/pod-overhead/
        ///
        /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClass#overhead
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overhead", typeJson: "{\"fqn\":\"k8s.Overhead\"}", isOptional: true)]
        public K8s.IOverhead? Overhead
        {
            get;
            set;
        }

        /// <summary>scheduling holds the scheduling constraints to ensure that pods running with this RuntimeClass are scheduled to nodes that support it.</summary>
        /// <remarks>
        /// If scheduling is nil, this RuntimeClass is assumed to be supported by all nodes.
        ///
        /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClass#scheduling
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scheduling", typeJson: "{\"fqn\":\"k8s.Scheduling\"}", isOptional: true)]
        public K8s.IScheduling? Scheduling
        {
            get;
            set;
        }
    }
}
