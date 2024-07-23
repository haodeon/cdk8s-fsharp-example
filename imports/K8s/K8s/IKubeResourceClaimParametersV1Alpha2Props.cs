using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceClaimParameters defines resource requests for a ResourceClaim in an in-tree format understood by Kubernetes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeResourceClaimParametersV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClaimParametersV1Alpha2Props")]
    public interface IKubeResourceClaimParametersV1Alpha2Props
    {
        /// <summary>DriverRequests describes all resources that are needed for the allocated claim.</summary>
        /// <remarks>
        /// A single claim may use resources coming from different drivers. For each driver, this array has at most one entry which then may have one or more per-driver requests.
        ///
        /// May be empty, in which case the claim can always be allocated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters#driverRequests
        /// </remarks>
        [JsiiProperty(name: "driverRequests", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.DriverRequestsV1Alpha2\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IDriverRequestsV1Alpha2[]? DriverRequests
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this object was created from some other resource, then this links back to that resource.</summary>
        /// <remarks>
        /// This field is used to find the in-tree representation of the claim parameters when the parameter reference of the claim refers to some unknown type.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters#generatedFrom
        /// </remarks>
        [JsiiProperty(name: "generatedFrom", typeJson: "{\"fqn\":\"k8s.ResourceClaimParametersReferenceV1Alpha2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IResourceClaimParametersReferenceV1Alpha2? GeneratedFrom
        {
            get
            {
                return null;
            }
        }

        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters#metadata
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

        /// <summary>Shareable indicates whether the allocated claim is meant to be shareable by multiple consumers at the same time.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters#shareable
        /// </remarks>
        [JsiiProperty(name: "shareable", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Shareable
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceClaimParameters defines resource requests for a ResourceClaim in an in-tree format understood by Kubernetes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeResourceClaimParametersV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClaimParametersV1Alpha2Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeResourceClaimParametersV1Alpha2Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>DriverRequests describes all resources that are needed for the allocated claim.</summary>
            /// <remarks>
            /// A single claim may use resources coming from different drivers. For each driver, this array has at most one entry which then may have one or more per-driver requests.
            ///
            /// May be empty, in which case the claim can always be allocated.
            ///
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters#driverRequests
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driverRequests", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.DriverRequestsV1Alpha2\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IDriverRequestsV1Alpha2[]? DriverRequests
            {
                get => GetInstanceProperty<K8s.IDriverRequestsV1Alpha2[]?>();
            }

            /// <summary>If this object was created from some other resource, then this links back to that resource.</summary>
            /// <remarks>
            /// This field is used to find the in-tree representation of the claim parameters when the parameter reference of the claim refers to some unknown type.
            ///
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters#generatedFrom
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "generatedFrom", typeJson: "{\"fqn\":\"k8s.ResourceClaimParametersReferenceV1Alpha2\"}", isOptional: true)]
            public K8s.IResourceClaimParametersReferenceV1Alpha2? GeneratedFrom
            {
                get => GetInstanceProperty<K8s.IResourceClaimParametersReferenceV1Alpha2?>();
            }

            /// <summary>Standard object metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Shareable indicates whether the allocated claim is meant to be shareable by multiple consumers at the same time.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters#shareable
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shareable", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Shareable
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
