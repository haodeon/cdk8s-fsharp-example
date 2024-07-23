using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>TokenRequest requests a token for a given service account.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequest
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeTokenRequestProps")]
    public class KubeTokenRequestProps : K8s.IKubeTokenRequestProps
    {
        /// <summary>Spec holds information about the request being evaluated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequest#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.TokenRequestSpec\"}")]
        public K8s.ITokenRequestSpec Spec
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequest#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }
    }
}
