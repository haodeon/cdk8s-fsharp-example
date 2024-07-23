using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Affinity is a group of affinity scheduling rules.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Affinity
    /// </remarks>
    [JsiiByValue(fqn: "k8s.Affinity")]
    public class Affinity : K8s.IAffinity
    {
        /// <summary>Describes node affinity scheduling rules for the pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Affinity#nodeAffinity
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeAffinity", typeJson: "{\"fqn\":\"k8s.NodeAffinity\"}", isOptional: true)]
        public K8s.INodeAffinity? NodeAffinity
        {
            get;
            set;
        }

        /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Affinity#podAffinity
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "podAffinity", typeJson: "{\"fqn\":\"k8s.PodAffinity\"}", isOptional: true)]
        public K8s.IPodAffinity? PodAffinity
        {
            get;
            set;
        }

        /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Affinity#podAntiAffinity
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "podAntiAffinity", typeJson: "{\"fqn\":\"k8s.PodAntiAffinity\"}", isOptional: true)]
        public K8s.IPodAntiAffinity? PodAntiAffinity
        {
            get;
            set;
        }
    }
}
