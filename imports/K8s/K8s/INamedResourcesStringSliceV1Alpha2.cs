using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NamedResourcesStringSlice contains a slice of strings.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesStringSlice
    /// </remarks>
    [JsiiInterface(nativeType: typeof(INamedResourcesStringSliceV1Alpha2), fullyQualifiedName: "k8s.NamedResourcesStringSliceV1Alpha2")]
    public interface INamedResourcesStringSliceV1Alpha2
    {
        /// <summary>Strings is the slice of strings.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesStringSlice#strings
        /// </remarks>
        [JsiiProperty(name: "strings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Strings
        {
            get;
        }

        /// <summary>NamedResourcesStringSlice contains a slice of strings.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesStringSlice
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INamedResourcesStringSliceV1Alpha2), fullyQualifiedName: "k8s.NamedResourcesStringSliceV1Alpha2")]
        internal sealed class _Proxy : DeputyBase, K8s.INamedResourcesStringSliceV1Alpha2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Strings is the slice of strings.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesStringSlice#strings
            /// </remarks>
            [JsiiProperty(name: "strings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Strings
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
