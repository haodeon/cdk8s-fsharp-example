using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>IngressClassSpec provides information about the class of an Ingress.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IIngressClassSpec), fullyQualifiedName: "k8s.IngressClassSpec")]
    public interface IIngressClassSpec
    {
        /// <summary>controller refers to the name of the controller that should handle this class.</summary>
        /// <remarks>
        /// This allows for different "flavors" that are controlled by the same controller. For example, you may have different parameters for the same implementing controller. This should be specified as a domain-prefixed path no more than 250 characters in length, e.g. "acme.io/ingress-controller". This field is immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassSpec#controller
        /// </remarks>
        [JsiiProperty(name: "controller", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Controller
        {
            get
            {
                return null;
            }
        }

        /// <summary>parameters is a link to a custom resource containing additional configuration for the controller.</summary>
        /// <remarks>
        /// This is optional if the controller does not require extra parameters.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassSpec#parameters
        /// </remarks>
        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"k8s.IngressClassParametersReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IIngressClassParametersReference? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>IngressClassSpec provides information about the class of an Ingress.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IIngressClassSpec), fullyQualifiedName: "k8s.IngressClassSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IIngressClassSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>controller refers to the name of the controller that should handle this class.</summary>
            /// <remarks>
            /// This allows for different "flavors" that are controlled by the same controller. For example, you may have different parameters for the same implementing controller. This should be specified as a domain-prefixed path no more than 250 characters in length, e.g. "acme.io/ingress-controller". This field is immutable.
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassSpec#controller
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "controller", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Controller
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>parameters is a link to a custom resource containing additional configuration for the controller.</summary>
            /// <remarks>
            /// This is optional if the controller does not require extra parameters.
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassSpec#parameters
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"k8s.IngressClassParametersReference\"}", isOptional: true)]
            public K8s.IIngressClassParametersReference? Parameters
            {
                get => GetInstanceProperty<K8s.IIngressClassParametersReference?>();
            }
        }
    }
}
