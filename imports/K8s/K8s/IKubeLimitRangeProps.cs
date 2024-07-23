using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>LimitRange sets resource usage limits for each kind of resource in a Namespace.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRange
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeLimitRangeProps), fullyQualifiedName: "k8s.KubeLimitRangeProps")]
    public interface IKubeLimitRangeProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRange#metadata
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

        /// <summary>Spec defines the limits enforced.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRange#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.LimitRangeSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILimitRangeSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>LimitRange sets resource usage limits for each kind of resource in a Namespace.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRange
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeLimitRangeProps), fullyQualifiedName: "k8s.KubeLimitRangeProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeLimitRangeProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRange#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Spec defines the limits enforced.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRange#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.LimitRangeSpec\"}", isOptional: true)]
            public K8s.ILimitRangeSpec? Spec
            {
                get => GetInstanceProperty<K8s.ILimitRangeSpec?>();
            }
        }
    }
}
