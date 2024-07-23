using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NamedResourcesRequest is used in ResourceRequestModel.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesRequest
    /// </remarks>
    [JsiiInterface(nativeType: typeof(INamedResourcesRequestV1Alpha2), fullyQualifiedName: "k8s.NamedResourcesRequestV1Alpha2")]
    public interface INamedResourcesRequestV1Alpha2
    {
        /// <summary>Selector is a CEL expression which must evaluate to true if a resource instance is suitable.</summary>
        /// <remarks>
        /// The language is as defined in https://kubernetes.io/docs/reference/using-api/cel/
        ///
        /// In addition, for each type NamedResourcesin AttributeValue there is a map that resolves to the corresponding value of the instance under evaluation. For example:
        ///
        /// attributes.quantity["a"].isGreaterThan(quantity("0")) &amp;&amp;
        /// attributes.stringslice["b"].isSorted()
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesRequest#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}")]
        string Selector
        {
            get;
        }

        /// <summary>NamedResourcesRequest is used in ResourceRequestModel.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesRequest
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INamedResourcesRequestV1Alpha2), fullyQualifiedName: "k8s.NamedResourcesRequestV1Alpha2")]
        internal sealed class _Proxy : DeputyBase, K8s.INamedResourcesRequestV1Alpha2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Selector is a CEL expression which must evaluate to true if a resource instance is suitable.</summary>
            /// <remarks>
            /// The language is as defined in https://kubernetes.io/docs/reference/using-api/cel/
            ///
            /// In addition, for each type NamedResourcesin AttributeValue there is a map that resolves to the corresponding value of the instance under evaluation. For example:
            ///
            /// attributes.quantity["a"].isGreaterThan(quantity("0")) &amp;&amp;
            /// attributes.stringslice["b"].isSorted()
            ///
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesRequest#selector
            /// </remarks>
            [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}")]
            public string Selector
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
