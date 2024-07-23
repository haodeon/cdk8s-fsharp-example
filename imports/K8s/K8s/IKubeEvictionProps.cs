using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Eviction evicts a pod from its node subject to certain policies and safety constraints.</summary>
    /// <remarks>
    /// This is a subresource of Pod.  A request to cause such an eviction is created by POSTing to .../pods/<pod name="name" xmlns="http://www.w3.org/1999/xhtml"></pod>/evictions.
    ///
    /// <strong>Schema</strong>: io.k8s.api.policy.v1.Eviction
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeEvictionProps), fullyQualifiedName: "k8s.KubeEvictionProps")]
    public interface IKubeEvictionProps
    {
        /// <summary>DeleteOptions may be provided.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.Eviction#deleteOptions
        /// </remarks>
        [JsiiProperty(name: "deleteOptions", typeJson: "{\"fqn\":\"k8s.DeleteOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IDeleteOptions? DeleteOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>ObjectMeta describes the pod that is being evicted.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.Eviction#metadata
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

        /// <summary>Eviction evicts a pod from its node subject to certain policies and safety constraints.</summary>
        /// <remarks>
        /// This is a subresource of Pod.  A request to cause such an eviction is created by POSTing to .../pods/<pod name="name" xmlns="http://www.w3.org/1999/xhtml"></pod>/evictions.
        ///
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.Eviction
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeEvictionProps), fullyQualifiedName: "k8s.KubeEvictionProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeEvictionProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>DeleteOptions may be provided.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.policy.v1.Eviction#deleteOptions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteOptions", typeJson: "{\"fqn\":\"k8s.DeleteOptions\"}", isOptional: true)]
            public K8s.IDeleteOptions? DeleteOptions
            {
                get => GetInstanceProperty<K8s.IDeleteOptions?>();
            }

            /// <summary>ObjectMeta describes the pod that is being evicted.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.policy.v1.Eviction#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }
        }
    }
}
