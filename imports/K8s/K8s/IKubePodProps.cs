using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Pod is a collection of containers that can run on a host.</summary>
    /// <remarks>
    /// This resource is created by clients and scheduled onto hosts.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Pod
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubePodProps), fullyQualifiedName: "k8s.KubePodProps")]
    public interface IKubePodProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Pod#metadata
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

        /// <summary>Specification of the desired behavior of the pod.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Pod#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PodSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPodSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Pod is a collection of containers that can run on a host.</summary>
        /// <remarks>
        /// This resource is created by clients and scheduled onto hosts.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Pod
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubePodProps), fullyQualifiedName: "k8s.KubePodProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubePodProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Pod#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Specification of the desired behavior of the pod.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Pod#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PodSpec\"}", isOptional: true)]
            public K8s.IPodSpec? Spec
            {
                get => GetInstanceProperty<K8s.IPodSpec?>();
            }
        }
    }
}
