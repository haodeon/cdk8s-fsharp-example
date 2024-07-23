using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceClaimParameters defines resource requests for a ResourceClaim in an in-tree format understood by Kubernetes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeResourceClaimParametersV1Alpha2Props")]
    public class KubeResourceClaimParametersV1Alpha2Props : K8s.IKubeResourceClaimParametersV1Alpha2Props
    {
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
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Shareable indicates whether the allocated claim is meant to be shareable by multiple consumers at the same time.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParameters#shareable
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shareable", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Shareable
        {
            get;
            set;
        }
    }
}
