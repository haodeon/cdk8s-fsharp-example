using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ReplicaSet ensures that a specified number of pod replicas are running at any given time.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSet
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeReplicaSetProps), fullyQualifiedName: "k8s.KubeReplicaSetProps")]
    public interface IKubeReplicaSetProps
    {
        /// <summary>If the Labels of a ReplicaSet are empty, they are defaulted to be the same as the Pod(s) that the ReplicaSet manages.</summary>
        /// <remarks>
        /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSet#metadata
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

        /// <summary>Spec defines the specification of the desired behavior of the ReplicaSet.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSet#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ReplicaSetSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IReplicaSetSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>ReplicaSet ensures that a specified number of pod replicas are running at any given time.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSet
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeReplicaSetProps), fullyQualifiedName: "k8s.KubeReplicaSetProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeReplicaSetProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<K8s.IObjectMeta?>();
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
                get => GetInstanceProperty<K8s.IReplicaSetSpec?>();
            }
        }
    }
}
