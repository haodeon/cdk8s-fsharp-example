using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NonResourceAttributes includes the authorization attributes available for non-resource requests to the Authorizer interface.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.NonResourceAttributes
    /// </remarks>
    [JsiiInterface(nativeType: typeof(INonResourceAttributes), fullyQualifiedName: "k8s.NonResourceAttributes")]
    public interface INonResourceAttributes
    {
        /// <summary>Path is the URL path of the request.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.NonResourceAttributes#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>Verb is the standard HTTP verb.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.NonResourceAttributes#verb
        /// </remarks>
        [JsiiProperty(name: "verb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Verb
        {
            get
            {
                return null;
            }
        }

        /// <summary>NonResourceAttributes includes the authorization attributes available for non-resource requests to the Authorizer interface.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.NonResourceAttributes
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INonResourceAttributes), fullyQualifiedName: "k8s.NonResourceAttributes")]
        internal sealed class _Proxy : DeputyBase, K8s.INonResourceAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Path is the URL path of the request.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.NonResourceAttributes#path
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Verb is the standard HTTP verb.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.NonResourceAttributes#verb
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Verb
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
