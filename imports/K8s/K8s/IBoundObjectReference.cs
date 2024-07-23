using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>BoundObjectReference is a reference to an object that a token is bound to.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IBoundObjectReference), fullyQualifiedName: "k8s.BoundObjectReference")]
    public interface IBoundObjectReference
    {
        /// <summary>API version of the referent.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference#apiVersion
        /// </remarks>
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Kind of the referent.</summary>
        /// <remarks>
        /// Valid kinds are 'Pod' and 'Secret'.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kind
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the referent.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>UID of the referent.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference#uid
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uid
        {
            get
            {
                return null;
            }
        }

        /// <summary>BoundObjectReference is a reference to an object that a token is bound to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IBoundObjectReference), fullyQualifiedName: "k8s.BoundObjectReference")]
        internal sealed class _Proxy : DeputyBase, K8s.IBoundObjectReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>API version of the referent.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference#apiVersion
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Kind of the referent.</summary>
            /// <remarks>
            /// Valid kinds are 'Pod' and 'Secret'.
            ///
            /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference#kind
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kind
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the referent.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>UID of the referent.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference#uid
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
