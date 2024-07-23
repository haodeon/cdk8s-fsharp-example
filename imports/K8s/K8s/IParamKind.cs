using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ParamKind is a tuple of Group Kind and Version.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ParamKind
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IParamKind), fullyQualifiedName: "k8s.ParamKind")]
    public interface IParamKind
    {
        /// <summary>APIVersion is the API group version the resources belong to.</summary>
        /// <remarks>
        /// In format of "group/version". Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ParamKind#apiVersion
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

        /// <summary>Kind is the API kind the resources belong to.</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ParamKind#kind
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

        /// <summary>ParamKind is a tuple of Group Kind and Version.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ParamKind
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IParamKind), fullyQualifiedName: "k8s.ParamKind")]
        internal sealed class _Proxy : DeputyBase, K8s.IParamKind
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>APIVersion is the API group version the resources belong to.</summary>
            /// <remarks>
            /// In format of "group/version". Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ParamKind#apiVersion
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Kind is the API kind the resources belong to.</summary>
            /// <remarks>
            /// Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ParamKind#kind
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kind
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
