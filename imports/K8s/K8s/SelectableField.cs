using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>SelectableField specifies the JSON path of a field that may be used with field selectors.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.SelectableField
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SelectableField")]
    public class SelectableField : K8s.ISelectableField
    {
        /// <summary>jsonPath is a simple JSON path which is evaluated against each custom resource to produce a field selector value.</summary>
        /// <remarks>
        /// Only JSON paths without the array notation are allowed. Must point to a field of type string, boolean or integer. Types with enum values and strings with formats are allowed. If jsonPath refers to absent field in a resource, the jsonPath evaluates to an empty string. Must not point to metdata fields. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.SelectableField#jsonPath
        /// </remarks>
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
        public string JsonPath
        {
            get;
            set;
        }
    }
}
