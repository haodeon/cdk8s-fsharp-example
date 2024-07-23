using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ObjectFieldSelector selects an APIVersioned field of an object.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectFieldSelector
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ObjectFieldSelector")]
    public class ObjectFieldSelector : K8s.IObjectFieldSelector
    {
        /// <summary>Path of the field to select in the specified API version.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectFieldSelector#fieldPath
        /// </remarks>
        [JsiiProperty(name: "fieldPath", typeJson: "{\"primitive\":\"string\"}")]
        public string FieldPath
        {
            get;
            set;
        }

        /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectFieldSelector#apiVersion
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiVersion
        {
            get;
            set;
        }
    }
}
