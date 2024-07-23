using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Affinity is a group of affinity scheduling rules.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Affinity
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IAffinity), fullyQualifiedName: "k8s.Affinity")]
    public interface IAffinity
    {
        /// <summary>Describes node affinity scheduling rules for the pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Affinity#nodeAffinity
        /// </remarks>
        [JsiiProperty(name: "nodeAffinity", typeJson: "{\"fqn\":\"k8s.NodeAffinity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INodeAffinity? NodeAffinity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Affinity#podAffinity
        /// </remarks>
        [JsiiProperty(name: "podAffinity", typeJson: "{\"fqn\":\"k8s.PodAffinity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPodAffinity? PodAffinity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Affinity#podAntiAffinity
        /// </remarks>
        [JsiiProperty(name: "podAntiAffinity", typeJson: "{\"fqn\":\"k8s.PodAntiAffinity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPodAntiAffinity? PodAntiAffinity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Affinity is a group of affinity scheduling rules.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Affinity
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IAffinity), fullyQualifiedName: "k8s.Affinity")]
        internal sealed class _Proxy : DeputyBase, K8s.IAffinity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Describes node affinity scheduling rules for the pod.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Affinity#nodeAffinity
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeAffinity", typeJson: "{\"fqn\":\"k8s.NodeAffinity\"}", isOptional: true)]
            public K8s.INodeAffinity? NodeAffinity
            {
                get => GetInstanceProperty<K8s.INodeAffinity?>();
            }

            /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Affinity#podAffinity
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "podAffinity", typeJson: "{\"fqn\":\"k8s.PodAffinity\"}", isOptional: true)]
            public K8s.IPodAffinity? PodAffinity
            {
                get => GetInstanceProperty<K8s.IPodAffinity?>();
            }

            /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Affinity#podAntiAffinity
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "podAntiAffinity", typeJson: "{\"fqn\":\"k8s.PodAntiAffinity\"}", isOptional: true)]
            public K8s.IPodAntiAffinity? PodAntiAffinity
            {
                get => GetInstanceProperty<K8s.IPodAntiAffinity?>();
            }
        }
    }
}
