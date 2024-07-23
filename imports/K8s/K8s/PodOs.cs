using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PodOS defines the OS parameters of a pod.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodOS
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PodOs")]
    public class PodOs : K8s.IPodOs
    {
        /// <summary>Name is the name of the operating system.</summary>
        /// <remarks>
        /// The currently supported values are linux and windows. Additional value may be defined in future and can be one of: https://github.com/opencontainers/runtime-spec/blob/master/config.md#platform-specific-configuration Clients should expect to handle additional values and treat unrecognized values in this field as os: null
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodOS#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
