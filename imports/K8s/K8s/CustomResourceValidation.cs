using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CustomResourceValidation is a list of validation methods for CustomResources.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceValidation
    /// </remarks>
    [JsiiByValue(fqn: "k8s.CustomResourceValidation")]
    public class CustomResourceValidation : K8s.ICustomResourceValidation
    {
        /// <summary>openAPIV3Schema is the OpenAPI v3 schema to use for validation and pruning.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceValidation#openAPIV3Schema
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openApiv3Schema", typeJson: "{\"fqn\":\"k8s.JsonSchemaProps\"}", isOptional: true)]
        public K8s.IJsonSchemaProps? OpenApiv3Schema
        {
            get;
            set;
        }
    }
}
