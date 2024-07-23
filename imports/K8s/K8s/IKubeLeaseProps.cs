using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Lease defines a lease concept.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.coordination.v1.Lease
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeLeaseProps), fullyQualifiedName: "k8s.KubeLeaseProps")]
    public interface IKubeLeaseProps
    {
        /// <summary>More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.Lease#metadata
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

        /// <summary>spec contains the specification of the Lease.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.Lease#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.LeaseSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILeaseSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Lease defines a lease concept.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.Lease
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeLeaseProps), fullyQualifiedName: "k8s.KubeLeaseProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeLeaseProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.coordination.v1.Lease#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>spec contains the specification of the Lease.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
            ///
            /// <strong>Schema</strong>: io.k8s.api.coordination.v1.Lease#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.LeaseSpec\"}", isOptional: true)]
            public K8s.ILeaseSpec? Spec
            {
                get => GetInstanceProperty<K8s.ILeaseSpec?>();
            }
        }
    }
}
