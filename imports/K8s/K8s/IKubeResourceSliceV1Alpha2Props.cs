using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceSlice provides information about available resources on individual nodes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceSlice
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeResourceSliceV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceSliceV1Alpha2Props")]
    public interface IKubeResourceSliceV1Alpha2Props
    {
        /// <summary>DriverName identifies the DRA driver providing the capacity information.</summary>
        /// <remarks>
        /// A field selector can be used to list only ResourceSlice objects with a certain driver name.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceSlice#driverName
        /// </remarks>
        [JsiiProperty(name: "driverName", typeJson: "{\"primitive\":\"string\"}")]
        string DriverName
        {
            get;
        }

        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceSlice#metadata
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

        /// <summary>NamedResources describes available resources using the named resources model.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceSlice#namedResources
        /// </remarks>
        [JsiiProperty(name: "namedResources", typeJson: "{\"fqn\":\"k8s.NamedResourcesResourcesV1Alpha2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INamedResourcesResourcesV1Alpha2? NamedResources
        {
            get
            {
                return null;
            }
        }

        /// <summary>NodeName identifies the node which provides the resources if they are local to a node.</summary>
        /// <remarks>
        /// A field selector can be used to list only ResourceSlice objects with a certain node name.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceSlice#nodeName
        /// </remarks>
        [JsiiProperty(name: "nodeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceSlice provides information about available resources on individual nodes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceSlice
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeResourceSliceV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceSliceV1Alpha2Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeResourceSliceV1Alpha2Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>DriverName identifies the DRA driver providing the capacity information.</summary>
            /// <remarks>
            /// A field selector can be used to list only ResourceSlice objects with a certain driver name.
            ///
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceSlice#driverName
            /// </remarks>
            [JsiiProperty(name: "driverName", typeJson: "{\"primitive\":\"string\"}")]
            public string DriverName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Standard object metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceSlice#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>NamedResources describes available resources using the named resources model.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceSlice#namedResources
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namedResources", typeJson: "{\"fqn\":\"k8s.NamedResourcesResourcesV1Alpha2\"}", isOptional: true)]
            public K8s.INamedResourcesResourcesV1Alpha2? NamedResources
            {
                get => GetInstanceProperty<K8s.INamedResourcesResourcesV1Alpha2?>();
            }

            /// <summary>NodeName identifies the node which provides the resources if they are local to a node.</summary>
            /// <remarks>
            /// A field selector can be used to list only ResourceSlice objects with a certain node name.
            ///
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceSlice#nodeName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
