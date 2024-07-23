using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>HTTPHeader describes a custom header to be used in HTTP probes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPHeader
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IHttpHeader), fullyQualifiedName: "k8s.HttpHeader")]
    public interface IHttpHeader
    {
        /// <summary>The header field name.</summary>
        /// <remarks>
        /// This will be canonicalized upon output, so case-variant names will be understood as the same header.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPHeader#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The header field value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPHeader#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>HTTPHeader describes a custom header to be used in HTTP probes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPHeader
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IHttpHeader), fullyQualifiedName: "k8s.HttpHeader")]
        internal sealed class _Proxy : DeputyBase, K8s.IHttpHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The header field name.</summary>
            /// <remarks>
            /// This will be canonicalized upon output, so case-variant names will be understood as the same header.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPHeader#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The header field value.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPHeader#value
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
