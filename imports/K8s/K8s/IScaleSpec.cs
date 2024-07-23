using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ScaleSpec describes the attributes of a scale subresource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.ScaleSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IScaleSpec), fullyQualifiedName: "k8s.ScaleSpec")]
    public interface IScaleSpec
    {
        /// <summary>replicas is the desired number of instances for the scaled object.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.ScaleSpec#replicas
        /// </remarks>
        [JsiiProperty(name: "replicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Replicas
        {
            get
            {
                return null;
            }
        }

        /// <summary>ScaleSpec describes the attributes of a scale subresource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.ScaleSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IScaleSpec), fullyQualifiedName: "k8s.ScaleSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IScaleSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>replicas is the desired number of instances for the scaled object.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.ScaleSpec#replicas
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Replicas
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
