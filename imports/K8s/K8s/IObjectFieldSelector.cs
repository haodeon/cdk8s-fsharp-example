using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ObjectFieldSelector selects an APIVersioned field of an object.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectFieldSelector
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IObjectFieldSelector), fullyQualifiedName: "k8s.ObjectFieldSelector")]
    public interface IObjectFieldSelector
    {
        /// <summary>Path of the field to select in the specified API version.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectFieldSelector#fieldPath
        /// </remarks>
        [JsiiProperty(name: "fieldPath", typeJson: "{\"primitive\":\"string\"}")]
        string FieldPath
        {
            get;
        }

        /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectFieldSelector#apiVersion
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

        /// <summary>ObjectFieldSelector selects an APIVersioned field of an object.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectFieldSelector
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IObjectFieldSelector), fullyQualifiedName: "k8s.ObjectFieldSelector")]
        internal sealed class _Proxy : DeputyBase, K8s.IObjectFieldSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Path of the field to select in the specified API version.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectFieldSelector#fieldPath
            /// </remarks>
            [JsiiProperty(name: "fieldPath", typeJson: "{\"primitive\":\"string\"}")]
            public string FieldPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectFieldSelector#apiVersion
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
