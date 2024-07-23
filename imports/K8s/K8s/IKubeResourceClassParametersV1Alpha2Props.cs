using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceClassParameters defines resource requests for a ResourceClass in an in-tree format understood by Kubernetes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParameters
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeResourceClassParametersV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClassParametersV1Alpha2Props")]
    public interface IKubeResourceClassParametersV1Alpha2Props
    {
        /// <summary>Filters describes additional contraints that must be met when using the class.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParameters#filters
        /// </remarks>
        [JsiiProperty(name: "filters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ResourceFilterV1Alpha2\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IResourceFilterV1Alpha2[]? Filters
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this object was created from some other resource, then this links back to that resource.</summary>
        /// <remarks>
        /// This field is used to find the in-tree representation of the class parameters when the parameter reference of the class refers to some unknown type.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParameters#generatedFrom
        /// </remarks>
        [JsiiProperty(name: "generatedFrom", typeJson: "{\"fqn\":\"k8s.ResourceClassParametersReferenceV1Alpha2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IResourceClassParametersReferenceV1Alpha2? GeneratedFrom
        {
            get
            {
                return null;
            }
        }

        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParameters#metadata
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

        /// <summary>VendorParameters are arbitrary setup parameters for all claims using this class.</summary>
        /// <remarks>
        /// They are ignored while allocating the claim. There must not be more than one entry per driver.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParameters#vendorParameters
        /// </remarks>
        [JsiiProperty(name: "vendorParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.VendorParametersV1Alpha2\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IVendorParametersV1Alpha2[]? VendorParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceClassParameters defines resource requests for a ResourceClass in an in-tree format understood by Kubernetes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParameters
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeResourceClassParametersV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClassParametersV1Alpha2Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeResourceClassParametersV1Alpha2Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filters describes additional contraints that must be met when using the class.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParameters#filters
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ResourceFilterV1Alpha2\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IResourceFilterV1Alpha2[]? Filters
            {
                get => GetInstanceProperty<K8s.IResourceFilterV1Alpha2[]?>();
            }

            /// <summary>If this object was created from some other resource, then this links back to that resource.</summary>
            /// <remarks>
            /// This field is used to find the in-tree representation of the class parameters when the parameter reference of the class refers to some unknown type.
            ///
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParameters#generatedFrom
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "generatedFrom", typeJson: "{\"fqn\":\"k8s.ResourceClassParametersReferenceV1Alpha2\"}", isOptional: true)]
            public K8s.IResourceClassParametersReferenceV1Alpha2? GeneratedFrom
            {
                get => GetInstanceProperty<K8s.IResourceClassParametersReferenceV1Alpha2?>();
            }

            /// <summary>Standard object metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParameters#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>VendorParameters are arbitrary setup parameters for all claims using this class.</summary>
            /// <remarks>
            /// They are ignored while allocating the claim. There must not be more than one entry per driver.
            ///
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParameters#vendorParameters
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vendorParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.VendorParametersV1Alpha2\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IVendorParametersV1Alpha2[]? VendorParameters
            {
                get => GetInstanceProperty<K8s.IVendorParametersV1Alpha2[]?>();
            }
        }
    }
}
