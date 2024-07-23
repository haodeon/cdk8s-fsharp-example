using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NamespaceSpec describes the attributes on a Namespace.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.NamespaceSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(INamespaceSpec), fullyQualifiedName: "k8s.NamespaceSpec")]
    public interface INamespaceSpec
    {
        /// <summary>Finalizers is an opaque list of values that must be empty to permanently remove object from storage.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/tasks/administer-cluster/namespaces/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NamespaceSpec#finalizers
        /// </remarks>
        [JsiiProperty(name: "finalizers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Finalizers
        {
            get
            {
                return null;
            }
        }

        /// <summary>NamespaceSpec describes the attributes on a Namespace.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NamespaceSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INamespaceSpec), fullyQualifiedName: "k8s.NamespaceSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.INamespaceSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Finalizers is an opaque list of values that must be empty to permanently remove object from storage.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/tasks/administer-cluster/namespaces/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.NamespaceSpec#finalizers
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "finalizers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Finalizers
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
