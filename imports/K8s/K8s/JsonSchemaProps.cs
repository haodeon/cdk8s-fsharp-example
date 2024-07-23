using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>JSONSchemaProps is a JSON-Schema following Specification Draft 4 (http://json-schema.org/).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps
    /// </remarks>
    [JsiiByValue(fqn: "k8s.JsonSchemaProps")]
    public class JsonSchemaProps : K8s.IJsonSchemaProps
    {
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#additionalItems
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalItems", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        public object? AdditionalItems
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#additionalProperties
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalProperties", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        public object? AdditionalProperties
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#allOf
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allOf", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.JsonSchemaProps\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IJsonSchemaProps[]? AllOf
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#anyOf
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "anyOf", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.JsonSchemaProps\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IJsonSchemaProps[]? AnyOf
        {
            get;
            set;
        }

        /// <summary>default is a default value for undefined object fields.</summary>
        /// <remarks>
        /// Defaulting is a beta feature under the CustomResourceDefaulting feature gate. Defaulting requires spec.preserveUnknownFields to be false.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#default
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        public object? Default
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#definitions
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "definitions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.JsonSchemaProps\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, K8s.IJsonSchemaProps>? Definitions
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#dependencies
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependencies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, object>? Dependencies
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#description
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#enum
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enum", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Enum
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#example
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "example", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        public object? Example
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#exclusiveMaximum
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclusiveMaximum", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ExclusiveMaximum
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#exclusiveMinimum
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclusiveMinimum", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ExclusiveMinimum
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#externalDocs
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalDocs", typeJson: "{\"fqn\":\"k8s.ExternalDocumentation\"}", isOptional: true)]
        public K8s.IExternalDocumentation? ExternalDocs
        {
            get;
            set;
        }

        /// <summary>format is an OpenAPI v3 format string. Unknown formats are ignored. The following formats are validated:.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description>bsonobjectid: a bson object ID, i.e. a 24 characters hex string - uri: an URI as parsed by Golang net/url.ParseRequestURI - email: an email address as parsed by Golang net/mail.ParseAddress - hostname: a valid representation for an Internet host name, as defined by RFC 1034, section 3.1 [RFC1034]. - ipv4: an IPv4 IP as parsed by Golang net.ParseIP - ipv6: an IPv6 IP as parsed by Golang net.ParseIP - cidr: a CIDR as parsed by Golang net.ParseCIDR - mac: a MAC address as parsed by Golang net.ParseMAC - uuid: an UUID that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?[0-9a-f]{4}-?[0-9a-f]{4}-?[0-9a-f]{12}$ - uuid3: an UUID3 that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?3[0-9a-f]{3}-?[0-9a-f]{4}-?[0-9a-f]{12}$ - uuid4: an UUID4 that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?4[0-9a-f]{3}-?[89ab][0-9a-f]{3}-?[0-9a-f]{12}$ - uuid5: an UUID5 that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?5[0-9a-f]{3}-?[89ab][0-9a-f]{3}-?[0-9a-f]{12}$ - isbn: an ISBN10 or ISBN13 number string like "0321751043" or "978-0321751041" - isbn10: an ISBN10 number string like "0321751043" - isbn13: an ISBN13 number string like "978-0321751041" - creditcard: a credit card number defined by the regex ^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$ with any non digit characters mixed in - ssn: a U.S. social security number following the regex ^\d{3}[- ]?\d{2}[- ]?\d{4}$ - hexcolor: an hexadecimal color code like "#FFFFFF: following the regex ^#?([0-9a-fA-F]{3}|[0-9a-fA-F]{6})$ - rgbcolor: an RGB color code like rgb like "rgb(255,255,2559" - byte: base64 encoded binary data - password: any kind of string - date: a date string like "2006-01-02" as defined by full-date in RFC3339 - duration: a duration string like "22 ns" as parsed by Golang time.ParseDuration or compatible with Scala duration format - datetime: a date time string like "2014-12-15T19:30:20.000Z" as defined by date-time in RFC3339.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#format
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Format
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#id
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#items
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        public object? Items
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#maximum
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Maximum
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#maxItems
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxItems
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#maxLength
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxLength
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#maxProperties
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxProperties", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxProperties
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#minimum
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Minimum
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#minItems
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinItems
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#minLength
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinLength
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#minProperties
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minProperties", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinProperties
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#multipleOf
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "multipleOf", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MultipleOf
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#not
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"k8s.JsonSchemaProps\"}", isOptional: true)]
        public K8s.IJsonSchemaProps? Not
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#nullable
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nullable", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Nullable
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#oneOf
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oneOf", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.JsonSchemaProps\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IJsonSchemaProps[]? OneOf
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#pattern
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Pattern
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#patternProperties
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "patternProperties", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.JsonSchemaProps\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, K8s.IJsonSchemaProps>? PatternProperties
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#properties
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.JsonSchemaProps\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, K8s.IJsonSchemaProps>? Properties
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#$ref
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ref", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ref
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#required
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "required", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Required
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#$schema
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Schema
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#title
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Title
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#type
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#uniqueItems
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uniqueItems", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? UniqueItems
        {
            get;
            set;
        }

        /// <summary>x-kubernetes-embedded-resource defines that the value is an embedded Kubernetes runtime.Object, with TypeMeta and ObjectMeta. The type must be object. It is allowed to further restrict the embedded object. kind, apiVersion and metadata are validated automatically. x-kubernetes-preserve-unknown-fields is allowed to be true, but does not have to be if the object is fully specified (up to kind, apiVersion, metadata).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#x-kubernetes-embedded-resource
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xKubernetesEmbeddedResource", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? XKubernetesEmbeddedResource
        {
            get;
            set;
        }

        /// <summary>x-kubernetes-int-or-string specifies that this value is either an integer or a string.</summary>
        /// <remarks>
        /// If this is true, an empty type is allowed and type as child of anyOf is permitted if following one of the following patterns:
        ///
        /// <list type="number">
        /// <description>anyOf:</description>
        /// </list>
        ///
        /// <list type="bullet">
        /// <description>type: integer</description>
        /// <description>type: string</description>
        /// </list>
        ///
        /// <list type="number">
        /// <description>allOf:</description>
        /// </list>
        ///
        /// <list type="bullet">
        /// <description>anyOf:</description>
        /// <description>type: integer</description>
        /// <description>type: string</description>
        /// <description>... zero or more</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#x-kubernetes-int-or-string
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xKubernetesIntOrString", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? XKubernetesIntOrString
        {
            get;
            set;
        }

        /// <summary>x-kubernetes-list-map-keys annotates an array with the x-kubernetes-list-type `map` by specifying the keys used as the index of the map.</summary>
        /// <remarks>
        /// This tag MUST only be used on lists that have the "x-kubernetes-list-type" extension set to "map". Also, the values specified for this attribute must be a scalar typed field of the child structure (no nesting is supported).
        ///
        /// The properties specified must either be required or have a default value, to ensure those properties are present for all list items.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#x-kubernetes-list-map-keys
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xKubernetesListMapKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? XKubernetesListMapKeys
        {
            get;
            set;
        }

        /// <summary>x-kubernetes-list-type annotates an array to further describe its topology.</summary>
        /// <remarks>
        /// This extension must only be used on lists and may have 3 possible values:
        ///
        /// <list type="number">
        /// <description><c>atomic</c>: the list is treated as a single entity, like a scalar.
        /// Atomic lists will be entirely replaced when updated. This extension
        /// may be used on any type of list (struct, scalar, ...).</description>
        /// <description><c>set</c>:
        /// Sets are lists that must not have multiple items with the same value. Each
        /// value must be a scalar, an object with x-kubernetes-map-type <c>atomic</c> or an
        /// array with x-kubernetes-list-type <c>atomic</c>.</description>
        /// <description><c>map</c>:
        /// These lists are like maps in that their elements have a non-index key
        /// used to identify them. Order is preserved upon merge. The map tag
        /// must only be used on a list with elements of type object.
        /// Defaults to atomic for arrays.</description>
        /// </list>
        ///
        /// <strong>Default</strong>: atomic for arrays.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#x-kubernetes-list-type
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xKubernetesListType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? XKubernetesListType
        {
            get;
            set;
        }

        /// <summary>x-kubernetes-map-type annotates an object to further describe its topology.</summary>
        /// <remarks>
        /// This extension must only be used when type is object and may have 2 possible values:
        ///
        /// <list type="number">
        /// <description><c>granular</c>:
        /// These maps are actual maps (key-value pairs) and each fields are independent
        /// from each other (they can each be manipulated by separate actors). This is
        /// the default behaviour for all maps.</description>
        /// <description><c>atomic</c>: the list is treated as a single entity, like a scalar.
        /// Atomic maps will be entirely replaced when updated.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#x-kubernetes-map-type
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xKubernetesMapType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? XKubernetesMapType
        {
            get;
            set;
        }

        /// <summary>x-kubernetes-preserve-unknown-fields stops the API server decoding step from pruning fields which are not specified in the validation schema.</summary>
        /// <remarks>
        /// This affects fields recursively, but switches back to normal pruning behaviour if nested properties or additionalProperties are specified in the schema. This can either be true or undefined. False is forbidden.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#x-kubernetes-preserve-unknown-fields
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xKubernetesPreserveUnknownFields", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? XKubernetesPreserveUnknownFields
        {
            get;
            set;
        }

        /// <summary>x-kubernetes-validations describes a list of validation rules written in the CEL expression language.</summary>
        /// <remarks>
        /// This field is an alpha-level. Using this field requires the feature gate <c>CustomResourceValidationExpressions</c> to be enabled.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.JSONSchemaProps#x-kubernetes-validations
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xKubernetesValidations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ValidationRule\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IValidationRule[]? XKubernetesValidations
        {
            get;
            set;
        }
    }
}
