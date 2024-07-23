using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodTemplate describes a template for creating copies of a predefined pod.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodTemplate
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubePodTemplateProps), fullyQualifiedName: "k8s.KubePodTemplateProps")]
    public interface IKubePodTemplateProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodTemplate#metadata
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

        /// <summary>Template defines the pods that will be created from this pod template.</summary>
        /// <remarks>
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodTemplate#template
        /// </remarks>
        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"k8s.PodTemplateSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPodTemplateSpec? Template
        {
            get
            {
                return null;
            }
        }

        /// <summary>PodTemplate describes a template for creating copies of a predefined pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodTemplate
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubePodTemplateProps), fullyQualifiedName: "k8s.KubePodTemplateProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubePodTemplateProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodTemplate#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Template defines the pods that will be created from this pod template.</summary>
            /// <remarks>
            /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodTemplate#template
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"k8s.PodTemplateSpec\"}", isOptional: true)]
            public K8s.IPodTemplateSpec? Template
            {
                get => GetInstanceProperty<K8s.IPodTemplateSpec?>();
            }
        }
    }
}
