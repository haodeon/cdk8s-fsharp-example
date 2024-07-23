using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceClaim
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ResourceClaim")]
    public class ResourceClaim : K8s.IResourceClaim
    {
        /// <summary>Name must match the name of one entry in pod.spec.resourceClaims of the Pod where this field is used. It makes that resource available inside a container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceClaim#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
