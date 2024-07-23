using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NamedResourcesResources is used in ResourceModel.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesResources
    /// </remarks>
    [JsiiInterface(nativeType: typeof(INamedResourcesResourcesV1Alpha2), fullyQualifiedName: "k8s.NamedResourcesResourcesV1Alpha2")]
    public interface INamedResourcesResourcesV1Alpha2
    {
        /// <summary>The list of all individual resources instances currently available.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesResources#instances
        /// </remarks>
        [JsiiProperty(name: "instances", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NamedResourcesInstanceV1Alpha2\"},\"kind\":\"array\"}}")]
        K8s.INamedResourcesInstanceV1Alpha2[] Instances
        {
            get;
        }

        /// <summary>NamedResourcesResources is used in ResourceModel.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesResources
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INamedResourcesResourcesV1Alpha2), fullyQualifiedName: "k8s.NamedResourcesResourcesV1Alpha2")]
        internal sealed class _Proxy : DeputyBase, K8s.INamedResourcesResourcesV1Alpha2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The list of all individual resources instances currently available.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesResources#instances
            /// </remarks>
            [JsiiProperty(name: "instances", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NamedResourcesInstanceV1Alpha2\"},\"kind\":\"array\"}}")]
            public K8s.INamedResourcesInstanceV1Alpha2[] Instances
            {
                get => GetInstanceProperty<K8s.INamedResourcesInstanceV1Alpha2[]>()!;
            }
        }
    }
}
