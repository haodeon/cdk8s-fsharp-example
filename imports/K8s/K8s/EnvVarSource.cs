using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EnvVarSource represents a source for the value of an EnvVar.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.EnvVarSource")]
    public class EnvVarSource : K8s.IEnvVarSource
    {
        /// <summary>Selects a key of a ConfigMap.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource#configMapKeyRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configMapKeyRef", typeJson: "{\"fqn\":\"k8s.ConfigMapKeySelector\"}", isOptional: true)]
        public K8s.IConfigMapKeySelector? ConfigMapKeyRef
        {
            get;
            set;
        }

        /// <summary>Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['&lt;KEY&gt;']`, `metadata.annotations['&lt;KEY&gt;']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource#fieldRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldRef", typeJson: "{\"fqn\":\"k8s.ObjectFieldSelector\"}", isOptional: true)]
        public K8s.IObjectFieldSelector? FieldRef
        {
            get;
            set;
        }

        /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource#resourceFieldRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceFieldRef", typeJson: "{\"fqn\":\"k8s.ResourceFieldSelector\"}", isOptional: true)]
        public K8s.IResourceFieldSelector? ResourceFieldRef
        {
            get;
            set;
        }

        /// <summary>Selects a key of a secret in the pod's namespace.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource#secretKeyRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretKeyRef", typeJson: "{\"fqn\":\"k8s.SecretKeySelector\"}", isOptional: true)]
        public K8s.ISecretKeySelector? SecretKeyRef
        {
            get;
            set;
        }
    }
}
