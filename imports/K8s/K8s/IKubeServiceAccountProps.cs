using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ServiceAccount binds together: * a name, understood by users, and perhaps by peripheral systems, for an identity * a principal that can be authenticated and authorized * a set of secrets.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccount
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeServiceAccountProps), fullyQualifiedName: "k8s.KubeServiceAccountProps")]
    public interface IKubeServiceAccountProps
    {
        /// <summary>AutomountServiceAccountToken indicates whether pods running as this service account should have an API token automatically mounted.</summary>
        /// <remarks>
        /// Can be overridden at the pod level.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccount#automountServiceAccountToken
        /// </remarks>
        [JsiiProperty(name: "automountServiceAccountToken", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AutomountServiceAccountToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>ImagePullSecrets is a list of references to secrets in the same namespace to use for pulling any images in pods that reference this ServiceAccount.</summary>
        /// <remarks>
        /// ImagePullSecrets are distinct from Secrets because Secrets can be mounted in the pod, but ImagePullSecrets are only accessed by the kubelet. More info: https://kubernetes.io/docs/concepts/containers/images/#specifying-imagepullsecrets-on-a-pod
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccount#imagePullSecrets
        /// </remarks>
        [JsiiProperty(name: "imagePullSecrets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.LocalObjectReference\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILocalObjectReference[]? ImagePullSecrets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccount#metadata
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

        /// <summary>Secrets is a list of the secrets in the same namespace that pods running using this ServiceAccount are allowed to use.</summary>
        /// <remarks>
        /// Pods are only limited to this list if this service account has a "kubernetes.io/enforce-mountable-secrets" annotation set to "true". This field should not be used to find auto-generated service account token secrets for use outside of pods. Instead, tokens can be requested directly using the TokenRequest API, or service account token secrets can be manually created. More info: https://kubernetes.io/docs/concepts/configuration/secret
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccount#secrets
        /// </remarks>
        [JsiiProperty(name: "secrets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ObjectReference\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectReference[]? Secrets
        {
            get
            {
                return null;
            }
        }

        /// <summary>ServiceAccount binds together: * a name, understood by users, and perhaps by peripheral systems, for an identity * a principal that can be authenticated and authorized * a set of secrets.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccount
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeServiceAccountProps), fullyQualifiedName: "k8s.KubeServiceAccountProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeServiceAccountProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<bool?>();
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
                get => GetInstanceProperty<K8s.ILocalObjectReference[]?>();
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
                get => GetInstanceProperty<K8s.IObjectMeta?>();
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
                get => GetInstanceProperty<K8s.IObjectReference[]?>();
            }
        }
    }
}
