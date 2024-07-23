using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Scale represents a scaling request for a resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.Scale
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeScaleProps), fullyQualifiedName: "k8s.KubeScaleProps")]
    public interface IKubeScaleProps
    {
        /// <summary>Standard object metadata;</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.Scale#metadata
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

        /// <summary>spec defines the behavior of the scale.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.Scale#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ScaleSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IScaleSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Scale represents a scaling request for a resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.Scale
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeScaleProps), fullyQualifiedName: "k8s.KubeScaleProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeScaleProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object metadata;</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.Scale#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>spec defines the behavior of the scale.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status.
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.Scale#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ScaleSpec\"}", isOptional: true)]
            public K8s.IScaleSpec? Spec
            {
                get => GetInstanceProperty<K8s.IScaleSpec?>();
            }
        }
    }
}
