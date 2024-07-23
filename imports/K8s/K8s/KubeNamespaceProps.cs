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
    [JsiiByValue(fqn: "k8s.KubeNamespaceProps")]
    public class KubeNamespaceProps : K8s.IKubeNamespaceProps
    {
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
            get;
            set;
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
            get;
            set;
        }
    }
}
