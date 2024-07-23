using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ReplicationController represents the configuration of a replication controller.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationController
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeReplicationControllerProps), fullyQualifiedName: "k8s.KubeReplicationControllerProps")]
    public interface IKubeReplicationControllerProps
    {
        /// <summary>If the Labels of a ReplicationController are empty, they are defaulted to be the same as the Pod(s) that the replication controller manages.</summary>
        /// <remarks>
        /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationController#metadata
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

        /// <summary>Spec defines the specification of the desired behavior of the replication controller.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationController#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ReplicationControllerSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IReplicationControllerSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>ReplicationController represents the configuration of a replication controller.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationController
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeReplicationControllerProps), fullyQualifiedName: "k8s.KubeReplicationControllerProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeReplicationControllerProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<K8s.IObjectMeta?>();
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
                get => GetInstanceProperty<K8s.IReplicationControllerSpec?>();
            }
        }
    }
}
