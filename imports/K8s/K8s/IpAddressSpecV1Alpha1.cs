using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>IPAddressSpec describe the attributes in an IP Address.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.IPAddressSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.IpAddressSpecV1Alpha1")]
    public class IpAddressSpecV1Alpha1 : K8s.IIpAddressSpecV1Alpha1
    {
        /// <summary>ParentRef references the resource that an IPAddress is attached to.</summary>
        /// <remarks>
        /// An IPAddress must reference a parent object.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.IPAddressSpec#parentRef
        /// </remarks>
        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"k8s.ParentReferenceV1Alpha1\"}")]
        public K8s.IParentReferenceV1Alpha1 ParentRef
        {
            get;
            set;
        }
    }
}
