using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CustomResourceColumnDefinition specifies a column for server side printing.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICustomResourceColumnDefinition), fullyQualifiedName: "k8s.CustomResourceColumnDefinition")]
    public interface ICustomResourceColumnDefinition
    {
        /// <summary>jsonPath is a simple JSON path (i.e. with array notation) which is evaluated against each custom resource to produce the value for this column.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition#jsonPath
        /// </remarks>
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
        string JsonPath
        {
            get;
        }

        /// <summary>name is a human readable name for the column.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>type is an OpenAPI type definition for this column.</summary>
        /// <remarks>
        /// See https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types for details.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>description is a human readable description of this column.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition#description
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>format is an optional OpenAPI type definition for this column.</summary>
        /// <remarks>
        /// The 'name' format is applied to the primary identifier column to assist in clients identifying column is the resource name. See https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types for details.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition#format
        /// </remarks>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Format
        {
            get
            {
                return null;
            }
        }

        /// <summary>priority is an integer defining the relative importance of this column compared to others.</summary>
        /// <remarks>
        /// Lower numbers are considered higher priority. Columns that may be omitted in limited space scenarios should be given a priority greater than 0.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition#priority
        /// </remarks>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>CustomResourceColumnDefinition specifies a column for server side printing.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICustomResourceColumnDefinition), fullyQualifiedName: "k8s.CustomResourceColumnDefinition")]
        internal sealed class _Proxy : DeputyBase, K8s.ICustomResourceColumnDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>jsonPath is a simple JSON path (i.e. with array notation) which is evaluated against each custom resource to produce the value for this column.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition#jsonPath
            /// </remarks>
            [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
            public string JsonPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>name is a human readable name for the column.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>type is an OpenAPI type definition for this column.</summary>
            /// <remarks>
            /// See https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types for details.
            ///
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>description is a human readable description of this column.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition#description
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>format is an optional OpenAPI type definition for this column.</summary>
            /// <remarks>
            /// The 'name' format is applied to the primary identifier column to assist in clients identifying column is the resource name. See https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types for details.
            ///
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition#format
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Format
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>priority is an integer defining the relative importance of this column compared to others.</summary>
            /// <remarks>
            /// Lower numbers are considered higher priority. Columns that may be omitted in limited space scenarios should be given a priority greater than 0.
            ///
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceColumnDefinition#priority
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
