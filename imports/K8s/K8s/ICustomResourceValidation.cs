using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CustomResourceValidation is a list of validation methods for CustomResources.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceValidation
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICustomResourceValidation), fullyQualifiedName: "k8s.CustomResourceValidation")]
    public interface ICustomResourceValidation
    {
        /// <summary>openAPIV3Schema is the OpenAPI v3 schema to use for validation and pruning.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceValidation#openAPIV3Schema
        /// </remarks>
        [JsiiProperty(name: "openApiv3Schema", typeJson: "{\"fqn\":\"k8s.JsonSchemaProps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IJsonSchemaProps? OpenApiv3Schema
        {
            get
            {
                return null;
            }
        }

        /// <summary>CustomResourceValidation is a list of validation methods for CustomResources.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceValidation
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICustomResourceValidation), fullyQualifiedName: "k8s.CustomResourceValidation")]
        internal sealed class _Proxy : DeputyBase, K8s.ICustomResourceValidation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>openAPIV3Schema is the OpenAPI v3 schema to use for validation and pruning.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceValidation#openAPIV3Schema
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openApiv3Schema", typeJson: "{\"fqn\":\"k8s.JsonSchemaProps\"}", isOptional: true)]
            public K8s.IJsonSchemaProps? OpenApiv3Schema
            {
                get => GetInstanceProperty<K8s.IJsonSchemaProps?>();
            }
        }
    }
}
