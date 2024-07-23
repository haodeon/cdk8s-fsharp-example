using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingAdmissionPolicySpec is the specification of the desired behavior of the AdmissionPolicy.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IValidatingAdmissionPolicySpecV1Alpha1), fullyQualifiedName: "k8s.ValidatingAdmissionPolicySpecV1Alpha1")]
    public interface IValidatingAdmissionPolicySpecV1Alpha1
    {
        /// <summary>auditAnnotations contains CEL expressions which are used to produce audit annotations for the audit event of the API request.</summary>
        /// <remarks>
        /// validations and auditAnnotations may not both be empty; a least one of validations or auditAnnotations is required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#auditAnnotations
        /// </remarks>
        [JsiiProperty(name: "auditAnnotations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.AuditAnnotationV1Alpha1\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IAuditAnnotationV1Alpha1[]? AuditAnnotations
        {
            get
            {
                return null;
            }
        }

        /// <summary>failurePolicy defines how to handle failures for the admission policy.</summary>
        /// <remarks>
        /// Failures can occur from CEL expression parse errors, type check errors, runtime errors and invalid or mis-configured policy definitions or bindings.
        ///
        /// A policy is invalid if spec.paramKind refers to a non-existent Kind. A binding is invalid if spec.paramRef.name refers to a non-existent resource.
        ///
        /// failurePolicy does not define how validations that evaluate to false are handled.
        ///
        /// When failurePolicy is set to Fail, ValidatingAdmissionPolicyBinding validationActions define how failures are enforced.
        ///
        /// Allowed values are Ignore or Fail. Defaults to Fail.
        ///
        /// <strong>Default</strong>: Fail.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#failurePolicy
        /// </remarks>
        [JsiiProperty(name: "failurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FailurePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>MatchConditions is a list of conditions that must be met for a request to be validated.</summary>
        /// <remarks>
        /// Match conditions filter requests that have already been matched by the rules, namespaceSelector, and objectSelector. An empty list of matchConditions matches all requests. There are a maximum of 64 match conditions allowed.
        ///
        /// If a parameter object is provided, it can be accessed via the <c>params</c> handle in the same manner as validation expressions.
        ///
        /// The exact matching logic is (in order):
        ///
        /// <list type="number">
        /// <description>If ANY matchCondition evaluates to FALSE, the policy is skipped.</description>
        /// <description>If ALL matchConditions evaluate to TRUE, the policy is evaluated.</description>
        /// <description>If any matchCondition evaluates to an error (but none are FALSE):</description>
        /// </list>
        ///
        /// <list type="bullet">
        /// <description>If failurePolicy=Fail, reject the request</description>
        /// <description>If failurePolicy=Ignore, the policy is skipped</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#matchConditions
        /// </remarks>
        [JsiiProperty(name: "matchConditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.MatchConditionV1Alpha1\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IMatchConditionV1Alpha1[]? MatchConditions
        {
            get
            {
                return null;
            }
        }

        /// <summary>MatchConstraints specifies what resources this policy is designed to validate.</summary>
        /// <remarks>
        /// The AdmissionPolicy cares about a request if it matches <em>all</em> Constraints. However, in order to prevent clusters from being put into an unstable state that cannot be recovered from via the API ValidatingAdmissionPolicy cannot match ValidatingAdmissionPolicy and ValidatingAdmissionPolicyBinding. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#matchConstraints
        /// </remarks>
        [JsiiProperty(name: "matchConstraints", typeJson: "{\"fqn\":\"k8s.MatchResourcesV1Alpha1\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IMatchResourcesV1Alpha1? MatchConstraints
        {
            get
            {
                return null;
            }
        }

        /// <summary>ParamKind specifies the kind of resources used to parameterize this policy.</summary>
        /// <remarks>
        /// If absent, there are no parameters for this policy and the param CEL variable will not be provided to validation expressions. If ParamKind refers to a non-existent kind, this policy definition is mis-configured and the FailurePolicy is applied. If paramKind is specified but paramRef is unset in ValidatingAdmissionPolicyBinding, the params variable will be null.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#paramKind
        /// </remarks>
        [JsiiProperty(name: "paramKind", typeJson: "{\"fqn\":\"k8s.ParamKindV1Alpha1\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IParamKindV1Alpha1? ParamKind
        {
            get
            {
                return null;
            }
        }

        /// <summary>Validations contain CEL expressions which is used to apply the validation.</summary>
        /// <remarks>
        /// Validations and AuditAnnotations may not both be empty; a minimum of one Validations or AuditAnnotations is required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#validations
        /// </remarks>
        [JsiiProperty(name: "validations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ValidationV1Alpha1\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IValidationV1Alpha1[]? Validations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Variables contain definitions of variables that can be used in composition of other expressions.</summary>
        /// <remarks>
        /// Each variable is defined as a named CEL expression. The variables defined here will be available under <c>variables</c> in other expressions of the policy except MatchConditions because MatchConditions are evaluated before the rest of the policy.
        ///
        /// The expression of a variable can refer to other variables defined earlier in the list but not those after. Thus, Variables must be sorted by the order of first appearance and acyclic.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#variables
        /// </remarks>
        [JsiiProperty(name: "variables", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.VariableV1Alpha1\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IVariableV1Alpha1[]? Variables
        {
            get
            {
                return null;
            }
        }

        /// <summary>ValidatingAdmissionPolicySpec is the specification of the desired behavior of the AdmissionPolicy.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IValidatingAdmissionPolicySpecV1Alpha1), fullyQualifiedName: "k8s.ValidatingAdmissionPolicySpecV1Alpha1")]
        internal sealed class _Proxy : DeputyBase, K8s.IValidatingAdmissionPolicySpecV1Alpha1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>auditAnnotations contains CEL expressions which are used to produce audit annotations for the audit event of the API request.</summary>
            /// <remarks>
            /// validations and auditAnnotations may not both be empty; a least one of validations or auditAnnotations is required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#auditAnnotations
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auditAnnotations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.AuditAnnotationV1Alpha1\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IAuditAnnotationV1Alpha1[]? AuditAnnotations
            {
                get => GetInstanceProperty<K8s.IAuditAnnotationV1Alpha1[]?>();
            }

            /// <summary>failurePolicy defines how to handle failures for the admission policy.</summary>
            /// <remarks>
            /// Failures can occur from CEL expression parse errors, type check errors, runtime errors and invalid or mis-configured policy definitions or bindings.
            ///
            /// A policy is invalid if spec.paramKind refers to a non-existent Kind. A binding is invalid if spec.paramRef.name refers to a non-existent resource.
            ///
            /// failurePolicy does not define how validations that evaluate to false are handled.
            ///
            /// When failurePolicy is set to Fail, ValidatingAdmissionPolicyBinding validationActions define how failures are enforced.
            ///
            /// Allowed values are Ignore or Fail. Defaults to Fail.
            ///
            /// <strong>Default</strong>: Fail.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#failurePolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FailurePolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>MatchConditions is a list of conditions that must be met for a request to be validated.</summary>
            /// <remarks>
            /// Match conditions filter requests that have already been matched by the rules, namespaceSelector, and objectSelector. An empty list of matchConditions matches all requests. There are a maximum of 64 match conditions allowed.
            ///
            /// If a parameter object is provided, it can be accessed via the <c>params</c> handle in the same manner as validation expressions.
            ///
            /// The exact matching logic is (in order):
            ///
            /// <list type="number">
            /// <description>If ANY matchCondition evaluates to FALSE, the policy is skipped.</description>
            /// <description>If ALL matchConditions evaluate to TRUE, the policy is evaluated.</description>
            /// <description>If any matchCondition evaluates to an error (but none are FALSE):</description>
            /// </list>
            ///
            /// <list type="bullet">
            /// <description>If failurePolicy=Fail, reject the request</description>
            /// <description>If failurePolicy=Ignore, the policy is skipped</description>
            /// </list>
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#matchConditions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchConditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.MatchConditionV1Alpha1\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IMatchConditionV1Alpha1[]? MatchConditions
            {
                get => GetInstanceProperty<K8s.IMatchConditionV1Alpha1[]?>();
            }

            /// <summary>MatchConstraints specifies what resources this policy is designed to validate.</summary>
            /// <remarks>
            /// The AdmissionPolicy cares about a request if it matches <em>all</em> Constraints. However, in order to prevent clusters from being put into an unstable state that cannot be recovered from via the API ValidatingAdmissionPolicy cannot match ValidatingAdmissionPolicy and ValidatingAdmissionPolicyBinding. Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#matchConstraints
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchConstraints", typeJson: "{\"fqn\":\"k8s.MatchResourcesV1Alpha1\"}", isOptional: true)]
            public K8s.IMatchResourcesV1Alpha1? MatchConstraints
            {
                get => GetInstanceProperty<K8s.IMatchResourcesV1Alpha1?>();
            }

            /// <summary>ParamKind specifies the kind of resources used to parameterize this policy.</summary>
            /// <remarks>
            /// If absent, there are no parameters for this policy and the param CEL variable will not be provided to validation expressions. If ParamKind refers to a non-existent kind, this policy definition is mis-configured and the FailurePolicy is applied. If paramKind is specified but paramRef is unset in ValidatingAdmissionPolicyBinding, the params variable will be null.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#paramKind
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paramKind", typeJson: "{\"fqn\":\"k8s.ParamKindV1Alpha1\"}", isOptional: true)]
            public K8s.IParamKindV1Alpha1? ParamKind
            {
                get => GetInstanceProperty<K8s.IParamKindV1Alpha1?>();
            }

            /// <summary>Validations contain CEL expressions which is used to apply the validation.</summary>
            /// <remarks>
            /// Validations and AuditAnnotations may not both be empty; a minimum of one Validations or AuditAnnotations is required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#validations
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ValidationV1Alpha1\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IValidationV1Alpha1[]? Validations
            {
                get => GetInstanceProperty<K8s.IValidationV1Alpha1[]?>();
            }

            /// <summary>Variables contain definitions of variables that can be used in composition of other expressions.</summary>
            /// <remarks>
            /// Each variable is defined as a named CEL expression. The variables defined here will be available under <c>variables</c> in other expressions of the policy except MatchConditions because MatchConditions are evaluated before the rest of the policy.
            ///
            /// The expression of a variable can refer to other variables defined earlier in the list but not those after. Thus, Variables must be sorted by the order of first appearance and acyclic.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicySpec#variables
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "variables", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.VariableV1Alpha1\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IVariableV1Alpha1[]? Variables
            {
                get => GetInstanceProperty<K8s.IVariableV1Alpha1[]?>();
            }
        }
    }
}
