using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.LocalObjectReference
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ILocalObjectReference), fullyQualifiedName: "k8s.LocalObjectReference")]
    public interface ILocalObjectReference
    {
        /// <summary>Name of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LocalObjectReference#name
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

        /// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LocalObjectReference
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ILocalObjectReference), fullyQualifiedName: "k8s.LocalObjectReference")]
        internal sealed class _Proxy : DeputyBase, K8s.ILocalObjectReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the referent.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LocalObjectReference#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
