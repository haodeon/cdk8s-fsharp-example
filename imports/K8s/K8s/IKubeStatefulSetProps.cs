using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StatefulSet represents a set of pods with consistent identities.</summary>
    /// <remarks>
    /// Identities are defined as:
    ///
    /// <list type="bullet">
    /// <description>Network: A single stable DNS and hostname.</description>
    /// <description>Storage: As many VolumeClaims as requested.</description>
    /// </list>
    ///
    /// The StatefulSet guarantees that a given network identity will always map to the same storage identity.
    ///
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSet
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeStatefulSetProps), fullyQualifiedName: "k8s.KubeStatefulSetProps")]
    public interface IKubeStatefulSetProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSet#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Spec defines the desired identities of pods in this set.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSet#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.StatefulSetSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IStatefulSetSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>StatefulSet represents a set of pods with consistent identities.</summary>
        /// <remarks>
        /// Identities are defined as:
        ///
        /// <list type="bullet">
        /// <description>Network: A single stable DNS and hostname.</description>
        /// <description>Storage: As many VolumeClaims as requested.</description>
        /// </list>
        ///
        /// The StatefulSet guarantees that a given network identity will always map to the same storage identity.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSet
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeStatefulSetProps), fullyQualifiedName: "k8s.KubeStatefulSetProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeStatefulSetProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSet#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Spec defines the desired identities of pods in this set.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSet#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.StatefulSetSpec\"}", isOptional: true)]
            public K8s.IStatefulSetSpec? Spec
            {
                get => GetInstanceProperty<K8s.IStatefulSetSpec?>();
            }
        }
    }
}
