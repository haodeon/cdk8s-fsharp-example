using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CrossVersionObjectReference contains enough information to let you identify the referred resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.CrossVersionObjectReference
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICrossVersionObjectReferenceV2), fullyQualifiedName: "k8s.CrossVersionObjectReferenceV2")]
    public interface ICrossVersionObjectReferenceV2
    {
        /// <summary>kind is the kind of the referent;</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.CrossVersionObjectReference#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>name is the name of the referent;</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.CrossVersionObjectReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>apiVersion is the API version of the referent.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.CrossVersionObjectReference#apiVersion
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

        /// <summary>CrossVersionObjectReference contains enough information to let you identify the referred resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.CrossVersionObjectReference
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICrossVersionObjectReferenceV2), fullyQualifiedName: "k8s.CrossVersionObjectReferenceV2")]
        internal sealed class _Proxy : DeputyBase, K8s.ICrossVersionObjectReferenceV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kind is the kind of the referent;</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.CrossVersionObjectReference#kind
            /// </remarks>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>name is the name of the referent;</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.CrossVersionObjectReference#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>apiVersion is the API version of the referent.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.CrossVersionObjectReference#apiVersion
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
