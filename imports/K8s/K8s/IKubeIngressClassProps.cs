using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>IngressClass represents the class of the Ingress, referenced by the Ingress Spec.</summary>
    /// <remarks>
    /// The <c>ingressclass.kubernetes.io/is-default-class</c> annotation can be used to indicate that an IngressClass should be considered default. When a single IngressClass resource has this annotation set to true, new Ingress resources without a class specified will be assigned this default class.
    ///
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClass
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeIngressClassProps), fullyQualifiedName: "k8s.KubeIngressClassProps")]
    public interface IKubeIngressClassProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClass#metadata
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

        /// <summary>spec is the desired state of the IngressClass.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClass#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.IngressClassSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IIngressClassSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>IngressClass represents the class of the Ingress, referenced by the Ingress Spec.</summary>
        /// <remarks>
        /// The <c>ingressclass.kubernetes.io/is-default-class</c> annotation can be used to indicate that an IngressClass should be considered default. When a single IngressClass resource has this annotation set to true, new Ingress resources without a class specified will be assigned this default class.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClass
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeIngressClassProps), fullyQualifiedName: "k8s.KubeIngressClassProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeIngressClassProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClass#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>spec is the desired state of the IngressClass.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClass#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.IngressClassSpec\"}", isOptional: true)]
            public K8s.IIngressClassSpec? Spec
            {
                get => GetInstanceProperty<K8s.IIngressClassSpec?>();
            }
        }
    }
}
