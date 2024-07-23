using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EnvVarSource represents a source for the value of an EnvVar.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IEnvVarSource), fullyQualifiedName: "k8s.EnvVarSource")]
    public interface IEnvVarSource
    {
        /// <summary>Selects a key of a ConfigMap.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource#configMapKeyRef
        /// </remarks>
        [JsiiProperty(name: "configMapKeyRef", typeJson: "{\"fqn\":\"k8s.ConfigMapKeySelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IConfigMapKeySelector? ConfigMapKeyRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['&lt;KEY&gt;']`, `metadata.annotations['&lt;KEY&gt;']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource#fieldRef
        /// </remarks>
        [JsiiProperty(name: "fieldRef", typeJson: "{\"fqn\":\"k8s.ObjectFieldSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectFieldSelector? FieldRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource#resourceFieldRef
        /// </remarks>
        [JsiiProperty(name: "resourceFieldRef", typeJson: "{\"fqn\":\"k8s.ResourceFieldSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IResourceFieldSelector? ResourceFieldRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects a key of a secret in the pod's namespace.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource#secretKeyRef
        /// </remarks>
        [JsiiProperty(name: "secretKeyRef", typeJson: "{\"fqn\":\"k8s.SecretKeySelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISecretKeySelector? SecretKeyRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>EnvVarSource represents a source for the value of an EnvVar.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IEnvVarSource), fullyQualifiedName: "k8s.EnvVarSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IEnvVarSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Selects a key of a ConfigMap.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource#configMapKeyRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configMapKeyRef", typeJson: "{\"fqn\":\"k8s.ConfigMapKeySelector\"}", isOptional: true)]
            public K8s.IConfigMapKeySelector? ConfigMapKeyRef
            {
                get => GetInstanceProperty<K8s.IConfigMapKeySelector?>();
            }

            /// <summary>Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['&lt;KEY&gt;']`, `metadata.annotations['&lt;KEY&gt;']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource#fieldRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldRef", typeJson: "{\"fqn\":\"k8s.ObjectFieldSelector\"}", isOptional: true)]
            public K8s.IObjectFieldSelector? FieldRef
            {
                get => GetInstanceProperty<K8s.IObjectFieldSelector?>();
            }

            /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource#resourceFieldRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceFieldRef", typeJson: "{\"fqn\":\"k8s.ResourceFieldSelector\"}", isOptional: true)]
            public K8s.IResourceFieldSelector? ResourceFieldRef
            {
                get => GetInstanceProperty<K8s.IResourceFieldSelector?>();
            }

            /// <summary>Selects a key of a secret in the pod's namespace.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVarSource#secretKeyRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretKeyRef", typeJson: "{\"fqn\":\"k8s.SecretKeySelector\"}", isOptional: true)]
            public K8s.ISecretKeySelector? SecretKeyRef
            {
                get => GetInstanceProperty<K8s.ISecretKeySelector?>();
            }
        }
    }
}
