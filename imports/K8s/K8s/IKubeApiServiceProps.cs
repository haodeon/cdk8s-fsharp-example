using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>APIService represents a server for a particular GroupVersion.</summary>
    /// <remarks>
    /// Name must be "version.group".
    ///
    /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIService
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeApiServiceProps), fullyQualifiedName: "k8s.KubeApiServiceProps")]
    public interface IKubeApiServiceProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIService#metadata
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

        /// <summary>Spec contains information for locating and communicating with a server.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIService#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ApiServiceSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IApiServiceSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>APIService represents a server for a particular GroupVersion.</summary>
        /// <remarks>
        /// Name must be "version.group".
        ///
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIService
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeApiServiceProps), fullyQualifiedName: "k8s.KubeApiServiceProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeApiServiceProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIService#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Spec contains information for locating and communicating with a server.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIService#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ApiServiceSpec\"}", isOptional: true)]
            public K8s.IApiServiceSpec? Spec
            {
                get => GetInstanceProperty<K8s.IApiServiceSpec?>();
            }
        }
    }
}
