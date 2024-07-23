using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingAdmissionPolicyBindingSpec is the specification of the ValidatingAdmissionPolicyBinding.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IValidatingAdmissionPolicyBindingSpecV1Beta1), fullyQualifiedName: "k8s.ValidatingAdmissionPolicyBindingSpecV1Beta1")]
    public interface IValidatingAdmissionPolicyBindingSpecV1Beta1
    {
        /// <summary>MatchResources declares what resources match this binding and will be validated by it.</summary>
        /// <remarks>
        /// Note that this is intersected with the policy's matchConstraints, so only requests that are matched by the policy can be selected by this. If this is unset, all resources matched by the policy are validated by this binding When resourceRules is unset, it does not constrain resource matching. If a resource is matched by the other fields of this object, it will be validated. Note that this is differs from ValidatingAdmissionPolicy matchConstraints, where resourceRules are required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingSpec#matchResources
        /// </remarks>
        [JsiiProperty(name: "matchResources", typeJson: "{\"fqn\":\"k8s.MatchResourcesV1Beta1\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IMatchResourcesV1Beta1? MatchResources
        {
            get
            {
                return null;
            }
        }

        /// <summary>paramRef specifies the parameter resource used to configure the admission control policy.</summary>
        /// <remarks>
        /// It should point to a resource of the type specified in ParamKind of the bound ValidatingAdmissionPolicy. If the policy specifies a ParamKind and the resource referred to by ParamRef does not exist, this binding is considered mis-configured and the FailurePolicy of the ValidatingAdmissionPolicy applied. If the policy does not specify a ParamKind then this field is ignored, and the rules are evaluated without a param.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingSpec#paramRef
        /// </remarks>
        [JsiiProperty(name: "paramRef", typeJson: "{\"fqn\":\"k8s.ParamRefV1Beta1\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IParamRefV1Beta1? ParamRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>PolicyName references a ValidatingAdmissionPolicy name which the ValidatingAdmissionPolicyBinding binds to.</summary>
        /// <remarks>
        /// If the referenced resource does not exist, this binding is considered invalid and will be ignored Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingSpec#policyName
        /// </remarks>
        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>validationActions declares how Validations of the referenced ValidatingAdmissionPolicy are enforced.</summary>
        /// <remarks>
        /// If a validation evaluates to false it is always enforced according to these actions.
        ///
        /// Failures defined by the ValidatingAdmissionPolicy's FailurePolicy are enforced according to these actions only if the FailurePolicy is set to Fail, otherwise the failures are ignored. This includes compilation errors, runtime errors and misconfigurations of the policy.
        ///
        /// validationActions is declared as a set of action values. Order does not matter. validationActions may not contain duplicates of the same action.
        ///
        /// The supported actions values are:
        ///
        /// "Deny" specifies that a validation failure results in a denied request.
        ///
        /// "Warn" specifies that a validation failure is reported to the request client in HTTP Warning headers, with a warning code of 299. Warnings can be sent both for allowed or denied admission responses.
        ///
        /// "Audit" specifies that a validation failure is included in the published audit event for the request. The audit event will contain a <c>validation.policy.admission.k8s.io/validation_failure</c> audit annotation with a value containing the details of the validation failures, formatted as a JSON list of objects, each with the following fields: - message: The validation failure message string - policy: The resource name of the ValidatingAdmissionPolicy - binding: The resource name of the ValidatingAdmissionPolicyBinding - expressionIndex: The index of the failed validations in the ValidatingAdmissionPolicy - validationActions: The enforcement actions enacted for the validation failure Example audit annotation: <c>"validation.policy.admission.k8s.io/validation_failure": "[{"message": "Invalid value", {"policy": "policy.example.com", {"binding": "policybinding.example.com", {"expressionIndex": "1", {"validationActions": ["Audit"]}]"</c>
        ///
        /// Clients should expect to handle additional values by ignoring any values not recognized.
        ///
        /// "Deny" and "Warn" may not be used together since this combination needlessly duplicates the validation failure both in the API response body and the HTTP warning headers.
        ///
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingSpec#validationActions
        /// </remarks>
        [JsiiProperty(name: "validationActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ValidationActions
        {
            get
            {
                return null;
            }
        }

        /// <summary>ValidatingAdmissionPolicyBindingSpec is the specification of the ValidatingAdmissionPolicyBinding.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IValidatingAdmissionPolicyBindingSpecV1Beta1), fullyQualifiedName: "k8s.ValidatingAdmissionPolicyBindingSpecV1Beta1")]
        internal sealed class _Proxy : DeputyBase, K8s.IValidatingAdmissionPolicyBindingSpecV1Beta1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>MatchResources declares what resources match this binding and will be validated by it.</summary>
            /// <remarks>
            /// Note that this is intersected with the policy's matchConstraints, so only requests that are matched by the policy can be selected by this. If this is unset, all resources matched by the policy are validated by this binding When resourceRules is unset, it does not constrain resource matching. If a resource is matched by the other fields of this object, it will be validated. Note that this is differs from ValidatingAdmissionPolicy matchConstraints, where resourceRules are required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingSpec#matchResources
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchResources", typeJson: "{\"fqn\":\"k8s.MatchResourcesV1Beta1\"}", isOptional: true)]
            public K8s.IMatchResourcesV1Beta1? MatchResources
            {
                get => GetInstanceProperty<K8s.IMatchResourcesV1Beta1?>();
            }

            /// <summary>paramRef specifies the parameter resource used to configure the admission control policy.</summary>
            /// <remarks>
            /// It should point to a resource of the type specified in ParamKind of the bound ValidatingAdmissionPolicy. If the policy specifies a ParamKind and the resource referred to by ParamRef does not exist, this binding is considered mis-configured and the FailurePolicy of the ValidatingAdmissionPolicy applied. If the policy does not specify a ParamKind then this field is ignored, and the rules are evaluated without a param.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingSpec#paramRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paramRef", typeJson: "{\"fqn\":\"k8s.ParamRefV1Beta1\"}", isOptional: true)]
            public K8s.IParamRefV1Beta1? ParamRef
            {
                get => GetInstanceProperty<K8s.IParamRefV1Beta1?>();
            }

            /// <summary>PolicyName references a ValidatingAdmissionPolicy name which the ValidatingAdmissionPolicyBinding binds to.</summary>
            /// <remarks>
            /// If the referenced resource does not exist, this binding is considered invalid and will be ignored Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingSpec#policyName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>validationActions declares how Validations of the referenced ValidatingAdmissionPolicy are enforced.</summary>
            /// <remarks>
            /// If a validation evaluates to false it is always enforced according to these actions.
            ///
            /// Failures defined by the ValidatingAdmissionPolicy's FailurePolicy are enforced according to these actions only if the FailurePolicy is set to Fail, otherwise the failures are ignored. This includes compilation errors, runtime errors and misconfigurations of the policy.
            ///
            /// validationActions is declared as a set of action values. Order does not matter. validationActions may not contain duplicates of the same action.
            ///
            /// The supported actions values are:
            ///
            /// "Deny" specifies that a validation failure results in a denied request.
            ///
            /// "Warn" specifies that a validation failure is reported to the request client in HTTP Warning headers, with a warning code of 299. Warnings can be sent both for allowed or denied admission responses.
            ///
            /// "Audit" specifies that a validation failure is included in the published audit event for the request. The audit event will contain a <c>validation.policy.admission.k8s.io/validation_failure</c> audit annotation with a value containing the details of the validation failures, formatted as a JSON list of objects, each with the following fields: - message: The validation failure message string - policy: The resource name of the ValidatingAdmissionPolicy - binding: The resource name of the ValidatingAdmissionPolicyBinding - expressionIndex: The index of the failed validations in the ValidatingAdmissionPolicy - validationActions: The enforcement actions enacted for the validation failure Example audit annotation: <c>"validation.policy.admission.k8s.io/validation_failure": "[{"message": "Invalid value", {"policy": "policy.example.com", {"binding": "policybinding.example.com", {"expressionIndex": "1", {"validationActions": ["Audit"]}]"</c>
            ///
            /// Clients should expect to handle additional values by ignoring any values not recognized.
            ///
            /// "Deny" and "Warn" may not be used together since this combination needlessly duplicates the validation failure both in the API response body and the HTTP warning headers.
            ///
            /// Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingSpec#validationActions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validationActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ValidationActions
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
