using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingAdmissionPolicyBinding binds the ValidatingAdmissionPolicy with paramerized resources.</summary>
    /// <remarks>
    /// ValidatingAdmissionPolicyBinding and parameter CRDs together define how cluster administrators configure policies for clusters.
    ///
    /// For a given admission request, each binding will cause its policy to be evaluated N times, where N is 1 for policies/bindings that don't use params, otherwise N is the number of parameters selected by the binding.
    ///
    /// The CEL expressions of a policy must have a computed CEL cost below the maximum CEL budget. Each evaluation of the policy is given an independent CEL cost budget. Adding/removing policies, bindings, or params can not affect whether a given (policy, binding, param) combination is within its own CEL budget.
    ///
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBinding
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeValidatingAdmissionPolicyBindingV1Beta1Props")]
    public class KubeValidatingAdmissionPolicyBindingV1Beta1Props : K8s.IKubeValidatingAdmissionPolicyBindingV1Beta1Props
    {
        /// <summary>Standard object metadata;</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBinding#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Specification of the desired behavior of the ValidatingAdmissionPolicyBinding.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBinding#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ValidatingAdmissionPolicyBindingSpecV1Beta1\"}", isOptional: true)]
        public K8s.IValidatingAdmissionPolicyBindingSpecV1Beta1? Spec
        {
            get;
            set;
        }
    }
}
