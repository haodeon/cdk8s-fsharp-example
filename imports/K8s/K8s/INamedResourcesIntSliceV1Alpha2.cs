using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NamedResourcesIntSlice contains a slice of 64-bit integers.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesIntSlice
    /// </remarks>
    [JsiiInterface(nativeType: typeof(INamedResourcesIntSliceV1Alpha2), fullyQualifiedName: "k8s.NamedResourcesIntSliceV1Alpha2")]
    public interface INamedResourcesIntSliceV1Alpha2
    {
        /// <summary>Ints is the slice of 64-bit integers.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesIntSlice#ints
        /// </remarks>
        [JsiiProperty(name: "ints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] Ints
        {
            get;
        }

        /// <summary>NamedResourcesIntSlice contains a slice of 64-bit integers.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesIntSlice
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INamedResourcesIntSliceV1Alpha2), fullyQualifiedName: "k8s.NamedResourcesIntSliceV1Alpha2")]
        internal sealed class _Proxy : DeputyBase, K8s.INamedResourcesIntSliceV1Alpha2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Ints is the slice of 64-bit integers.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesIntSlice#ints
            /// </remarks>
            [JsiiProperty(name: "ints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] Ints
            {
                get => GetInstanceProperty<double[]>()!;
            }
        }
    }
}
