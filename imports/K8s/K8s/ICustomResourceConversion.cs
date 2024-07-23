using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CustomResourceConversion describes how to convert different versions of a CR.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceConversion
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICustomResourceConversion), fullyQualifiedName: "k8s.CustomResourceConversion")]
    public interface ICustomResourceConversion
    {
        /// <summary>strategy specifies how custom resources are converted between versions.</summary>
        /// <remarks>
        /// Allowed values are: - <c>"None"</c>: The converter only change the apiVersion and would not touch any other field in the custom resource. - <c>"Webhook"</c>: API Server will call to an external webhook to do the conversion. Additional information
        /// is needed for this option. This requires spec.preserveUnknownFields to be false, and spec.conversion.webhook to be set.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceConversion#strategy
        /// </remarks>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        string Strategy
        {
            get;
        }

        /// <summary>webhook describes how to call the conversion webhook.</summary>
        /// <remarks>
        /// Required when <c>strategy</c> is set to <c>"Webhook"</c>.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceConversion#webhook
        /// </remarks>
        [JsiiProperty(name: "webhook", typeJson: "{\"fqn\":\"k8s.WebhookConversion\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IWebhookConversion? Webhook
        {
            get
            {
                return null;
            }
        }

        /// <summary>CustomResourceConversion describes how to convert different versions of a CR.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceConversion
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICustomResourceConversion), fullyQualifiedName: "k8s.CustomResourceConversion")]
        internal sealed class _Proxy : DeputyBase, K8s.ICustomResourceConversion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>strategy specifies how custom resources are converted between versions.</summary>
            /// <remarks>
            /// Allowed values are: - <c>"None"</c>: The converter only change the apiVersion and would not touch any other field in the custom resource. - <c>"Webhook"</c>: API Server will call to an external webhook to do the conversion. Additional information
            /// is needed for this option. This requires spec.preserveUnknownFields to be false, and spec.conversion.webhook to be set.
            ///
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceConversion#strategy
            /// </remarks>
            [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
            public string Strategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>webhook describes how to call the conversion webhook.</summary>
            /// <remarks>
            /// Required when <c>strategy</c> is set to <c>"Webhook"</c>.
            ///
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceConversion#webhook
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webhook", typeJson: "{\"fqn\":\"k8s.WebhookConversion\"}", isOptional: true)]
            public K8s.IWebhookConversion? Webhook
            {
                get => GetInstanceProperty<K8s.IWebhookConversion?>();
            }
        }
    }
}
