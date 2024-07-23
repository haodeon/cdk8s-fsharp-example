using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>RuleWithOperations is a tuple of Operations and Resources.</summary>
    /// <remarks>
    /// It is recommended to make sure that all the tuple expansions are valid.
    ///
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.RuleWithOperations
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IRuleWithOperations), fullyQualifiedName: "k8s.RuleWithOperations")]
    public interface IRuleWithOperations
    {
        /// <summary>APIGroups is the API groups the resources belong to.</summary>
        /// <remarks>
        /// '<em>' is all groups. If '</em>' is present, the length of the slice must be one. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.RuleWithOperations#apiGroups
        /// </remarks>
        [JsiiProperty(name: "apiGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ApiGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>APIVersions is the API versions the resources belong to.</summary>
        /// <remarks>
        /// '<em>' is all versions. If '</em>' is present, the length of the slice must be one. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.RuleWithOperations#apiVersions
        /// </remarks>
        [JsiiProperty(name: "apiVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ApiVersions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Operations is the operations the admission hook cares about - CREATE, UPDATE, DELETE, CONNECT or * for all of those operations and any future admission operations that are added.</summary>
        /// <remarks>
        /// If '*' is present, the length of the slice must be one. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.RuleWithOperations#operations
        /// </remarks>
        [JsiiProperty(name: "operations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Operations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Resources is a list of resources this rule applies to.</summary>
        /// <remarks>
        /// For example: 'pods' means pods. 'pods/log' means the log subresource of pods. '<em>' means all resources, but not subresources. 'pods/</em>' means all subresources of pods. '<em>/scale' means all scale subresources. '</em>/*' means all resources and their subresources.
        ///
        /// If wildcard is present, the validation rule will ensure resources do not overlap with each other.
        ///
        /// Depending on the enclosing object, subresources might not be allowed. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.RuleWithOperations#resources
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Resources
        {
            get
            {
                return null;
            }
        }

        /// <summary>scope specifies the scope of this rule.</summary>
        /// <remarks>
        /// Valid values are "Cluster", "Namespaced", and "<em>" "Cluster" means that only cluster-scoped resources will match this rule. Namespace API objects are cluster-scoped. "Namespaced" means that only namespaced resources will match this rule. "</em>" means that there are no scope restrictions. Subresources match the scope of their parent resource. Default is "*".
        ///
        /// <strong>Default</strong>: .
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.RuleWithOperations#scope
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scope
        {
            get
            {
                return null;
            }
        }

        /// <summary>RuleWithOperations is a tuple of Operations and Resources.</summary>
        /// <remarks>
        /// It is recommended to make sure that all the tuple expansions are valid.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.RuleWithOperations
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IRuleWithOperations), fullyQualifiedName: "k8s.RuleWithOperations")]
        internal sealed class _Proxy : DeputyBase, K8s.IRuleWithOperations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>APIGroups is the API groups the resources belong to.</summary>
            /// <remarks>
            /// '<em>' is all groups. If '</em>' is present, the length of the slice must be one. Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.RuleWithOperations#apiGroups
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ApiGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>APIVersions is the API versions the resources belong to.</summary>
            /// <remarks>
            /// '<em>' is all versions. If '</em>' is present, the length of the slice must be one. Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.RuleWithOperations#apiVersions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ApiVersions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Operations is the operations the admission hook cares about - CREATE, UPDATE, DELETE, CONNECT or * for all of those operations and any future admission operations that are added.</summary>
            /// <remarks>
            /// If '*' is present, the length of the slice must be one. Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.RuleWithOperations#operations
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "operations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Operations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Resources is a list of resources this rule applies to.</summary>
            /// <remarks>
            /// For example: 'pods' means pods. 'pods/log' means the log subresource of pods. '<em>' means all resources, but not subresources. 'pods/</em>' means all subresources of pods. '<em>/scale' means all scale subresources. '</em>/*' means all resources and their subresources.
            ///
            /// If wildcard is present, the validation rule will ensure resources do not overlap with each other.
            ///
            /// Depending on the enclosing object, subresources might not be allowed. Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.RuleWithOperations#resources
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Resources
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>scope specifies the scope of this rule.</summary>
            /// <remarks>
            /// Valid values are "Cluster", "Namespaced", and "<em>" "Cluster" means that only cluster-scoped resources will match this rule. Namespace API objects are cluster-scoped. "Namespaced" means that only namespaced resources will match this rule. "</em>" means that there are no scope restrictions. Subresources match the scope of their parent resource. Default is "*".
            ///
            /// <strong>Default</strong>: .
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.RuleWithOperations#scope
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scope
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
