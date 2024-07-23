using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ServiceAccount binds together: * a name, understood by users, and perhaps by peripheral systems, for an identity * a principal that can be authenticated and authorized * a set of secrets.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccount
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeServiceAccountProps")]
    public class KubeServiceAccountProps : K8s.IKubeServiceAccountProps
    {
        /// <summary>AutomountServiceAccountToken indicates whether pods running as this service account should have an API token automatically mounted.</summary>
        /// <remarks>
        /// Can be overridden at the pod level.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccount#automountServiceAccountToken
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automountServiceAccountToken", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? AutomountServiceAccountToken
        {
            get;
            set;
        }

        /// <summary>ImagePullSecrets is a list of references to secrets in the same namespace to use for pulling any images in pods that reference this ServiceAccount.</summary>
        /// <remarks>
        /// ImagePullSecrets are distinct from Secrets because Secrets can be mounted in the pod, but ImagePullSecrets are only accessed by the kubelet. More info: https://kubernetes.io/docs/concepts/containers/images/#specifying-imagepullsecrets-on-a-pod
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccount#imagePullSecrets
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imagePullSecrets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.LocalObjectReference\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.ILocalObjectReference[]? ImagePullSecrets
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccount#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Secrets is a list of the secrets in the same namespace that pods running using this ServiceAccount are allowed to use.</summary>
        /// <remarks>
        /// Pods are only limited to this list if this service account has a "kubernetes.io/enforce-mountable-secrets" annotation set to "true". This field should not be used to find auto-generated service account token secrets for use outside of pods. Instead, tokens can be requested directly using the TokenRequest API, or service account token secrets can be manually created. More info: https://kubernetes.io/docs/concepts/configuration/secret
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccount#secrets
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secrets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ObjectReference\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IObjectReference[]? Secrets
        {
            get;
            set;
        }
    }
}
