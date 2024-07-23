using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PriorityLevelConfiguration represents the configuration of a priority level.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfiguration
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubePriorityLevelConfigurationProps), fullyQualifiedName: "k8s.KubePriorityLevelConfigurationProps")]
    public interface IKubePriorityLevelConfigurationProps
    {
        /// <summary>`metadata` is the standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfiguration#metadata
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

        /// <summary>`spec` is the specification of the desired behavior of a "request-priority".</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfiguration#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PriorityLevelConfigurationSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPriorityLevelConfigurationSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>PriorityLevelConfiguration represents the configuration of a priority level.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfiguration
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubePriorityLevelConfigurationProps), fullyQualifiedName: "k8s.KubePriorityLevelConfigurationProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubePriorityLevelConfigurationProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`metadata` is the standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfiguration#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>`spec` is the specification of the desired behavior of a "request-priority".</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfiguration#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PriorityLevelConfigurationSpec\"}", isOptional: true)]
            public K8s.IPriorityLevelConfigurationSpec? Spec
            {
                get => GetInstanceProperty<K8s.IPriorityLevelConfigurationSpec?>();
            }
        }
    }
}
