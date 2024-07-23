using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ParamRef describes how to locate the params to be used as input to expressions of rules applied by a policy binding.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamRef
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IParamRefV1Alpha1), fullyQualifiedName: "k8s.ParamRefV1Alpha1")]
    public interface IParamRefV1Alpha1
    {
        /// <summary>`name` is the name of the resource being referenced.</summary>
        /// <remarks>
        /// <c>name</c> and <c>selector</c> are mutually exclusive properties. If one is set, the other must be unset.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamRef#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>namespace is the namespace of the referenced resource.</summary>
        /// <remarks>
        /// Allows limiting the search for params to a specific namespace. Applies to both <c>name</c> and <c>selector</c> fields.
        ///
        /// A per-namespace parameter may be used by specifying a namespace-scoped <c>paramKind</c> in the policy and leaving this field empty.
        ///
        /// <list type="bullet">
        /// <description>If <c>paramKind</c> is cluster-scoped, this field MUST be unset. Setting this field results in a configuration error.</description>
        /// <description>If <c>paramKind</c> is namespace-scoped, the namespace of the object being evaluated for admission will be used when this field is left unset. Take care that if this is left empty the binding must not match any cluster-scoped resources, which will result in an error.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamRef#namespace
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>`parameterNotFoundAction` controls the behavior of the binding when the resource exists, and name or selector is valid, but there are no parameters matched by the binding.</summary>
        /// <remarks>
        /// If the value is set to <c>Allow</c>, then no matched parameters will be treated as successful validation by the binding. If set to <c>Deny</c>, then no matched parameters will be subject to the <c>failurePolicy</c> of the policy.
        ///
        /// Allowed values are <c>Allow</c> or <c>Deny</c> Default to <c>Deny</c>
        ///
        /// <strong>Default</strong>: Deny`
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamRef#parameterNotFoundAction
        /// </remarks>
        [JsiiProperty(name: "parameterNotFoundAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParameterNotFoundAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>selector can be used to match multiple param objects based on their labels.</summary>
        /// <remarks>
        /// Supply selector: {} to match all resources of the ParamKind.
        ///
        /// If multiple params are found, they are all evaluated with the policy expressions and the results are ANDed together.
        ///
        /// One of <c>name</c> or <c>selector</c> must be set, but <c>name</c> and <c>selector</c> are mutually exclusive properties. If one is set, the other must be unset.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamRef#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector? Selector
        {
            get
            {
                return null;
            }
        }

        /// <summary>ParamRef describes how to locate the params to be used as input to expressions of rules applied by a policy binding.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamRef
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IParamRefV1Alpha1), fullyQualifiedName: "k8s.ParamRefV1Alpha1")]
        internal sealed class _Proxy : DeputyBase, K8s.IParamRefV1Alpha1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`name` is the name of the resource being referenced.</summary>
            /// <remarks>
            /// <c>name</c> and <c>selector</c> are mutually exclusive properties. If one is set, the other must be unset.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamRef#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>namespace is the namespace of the referenced resource.</summary>
            /// <remarks>
            /// Allows limiting the search for params to a specific namespace. Applies to both <c>name</c> and <c>selector</c> fields.
            ///
            /// A per-namespace parameter may be used by specifying a namespace-scoped <c>paramKind</c> in the policy and leaving this field empty.
            ///
            /// <list type="bullet">
            /// <description>If <c>paramKind</c> is cluster-scoped, this field MUST be unset. Setting this field results in a configuration error.</description>
            /// <description>If <c>paramKind</c> is namespace-scoped, the namespace of the object being evaluated for admission will be used when this field is left unset. Take care that if this is left empty the binding must not match any cluster-scoped resources, which will result in an error.</description>
            /// </list>
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamRef#namespace
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>`parameterNotFoundAction` controls the behavior of the binding when the resource exists, and name or selector is valid, but there are no parameters matched by the binding.</summary>
            /// <remarks>
            /// If the value is set to <c>Allow</c>, then no matched parameters will be treated as successful validation by the binding. If set to <c>Deny</c>, then no matched parameters will be subject to the <c>failurePolicy</c> of the policy.
            ///
            /// Allowed values are <c>Allow</c> or <c>Deny</c> Default to <c>Deny</c>
            ///
            /// <strong>Default</strong>: Deny`
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamRef#parameterNotFoundAction
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameterNotFoundAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParameterNotFoundAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>selector can be used to match multiple param objects based on their labels.</summary>
            /// <remarks>
            /// Supply selector: {} to match all resources of the ParamKind.
            ///
            /// If multiple params are found, they are all evaluated with the policy expressions and the results are ANDed together.
            ///
            /// One of <c>name</c> or <c>selector</c> must be set, but <c>name</c> and <c>selector</c> are mutually exclusive properties. If one is set, the other must be unset.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamRef#selector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? Selector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }
        }
    }
}
