using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Pod is a collection of containers that can run on a host.</summary>
    /// <remarks>
    /// This resource is created by clients and scheduled onto hosts.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Pod
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubePodProps")]
    public class KubePodProps : K8s.IKubePodProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Pod#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Specification of the desired behavior of the pod.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Pod#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PodSpec\"}", isOptional: true)]
        public K8s.IPodSpec? Spec
        {
            get;
            set;
        }
    }
}
