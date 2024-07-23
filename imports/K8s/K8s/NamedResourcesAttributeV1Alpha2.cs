using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>NamedResourcesAttribute is a combination of an attribute name and its value.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesAttribute
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NamedResourcesAttributeV1Alpha2")]
    public class NamedResourcesAttributeV1Alpha2 : K8s.INamedResourcesAttributeV1Alpha2
    {
        /// <summary>Name is unique identifier among all resource instances managed by the driver on the node.</summary>
        /// <remarks>
        /// It must be a DNS subdomain.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesAttribute#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>BoolValue is a true/false value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesAttribute#bool
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bool", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Bool
        {
            get;
            set;
        }

        /// <summary>IntValue is a 64-bit integer.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesAttribute#int
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "int", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Int
        {
            get;
            set;
        }

        /// <summary>IntSliceValue is an array of 64-bit integers.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesAttribute#intSlice
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intSlice", typeJson: "{\"fqn\":\"k8s.NamedResourcesIntSliceV1Alpha2\"}", isOptional: true)]
        public K8s.INamedResourcesIntSliceV1Alpha2? IntSlice
        {
            get;
            set;
        }

        /// <summary>QuantityValue is a quantity.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesAttribute#quantity
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "quantity", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
        public K8s.Quantity? Quantity
        {
            get;
            set;
        }

        /// <summary>StringValue is a string.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesAttribute#string
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "string", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? String
        {
            get;
            set;
        }

        /// <summary>StringSliceValue is an array of strings.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesAttribute#stringSlice
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringSlice", typeJson: "{\"fqn\":\"k8s.NamedResourcesStringSliceV1Alpha2\"}", isOptional: true)]
        public K8s.INamedResourcesStringSliceV1Alpha2? StringSlice
        {
            get;
            set;
        }

        /// <summary>VersionValue is a semantic version according to semver.org spec 2.0.0.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesAttribute#version
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
