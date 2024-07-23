using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ComponentStatus (and ComponentStatusList) holds the cluster validation info.</summary>
    /// <remarks>
    /// Deprecated: This API is deprecated in v1.19+
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatus
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeComponentStatusProps), fullyQualifiedName: "k8s.KubeComponentStatusProps")]
    public interface IKubeComponentStatusProps
    {
        /// <summary>List of component conditions observed.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatus#conditions
        /// </remarks>
        [JsiiProperty(name: "conditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ComponentCondition\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IComponentCondition[]? Conditions
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatus#metadata
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

        /// <summary>ComponentStatus (and ComponentStatusList) holds the cluster validation info.</summary>
        /// <remarks>
        /// Deprecated: This API is deprecated in v1.19+
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatus
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeComponentStatusProps), fullyQualifiedName: "k8s.KubeComponentStatusProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeComponentStatusProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of component conditions observed.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatus#conditions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "conditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ComponentCondition\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IComponentCondition[]? Conditions
            {
                get => GetInstanceProperty<K8s.IComponentCondition[]?>();
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatus#metadata
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
