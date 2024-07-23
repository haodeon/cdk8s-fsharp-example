using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingAdmissionPolicy describes the definition of an admission validation policy that accepts or rejects an object without changing it.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicy
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeValidatingAdmissionPolicyV1Beta1Props")]
    public class KubeValidatingAdmissionPolicyV1Beta1Props : K8s.IKubeValidatingAdmissionPolicyV1Beta1Props
    {
        /// <summary>Standard object metadata;</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicy#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Specification of the desired behavior of the ValidatingAdmissionPolicy.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicy#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ValidatingAdmissionPolicySpecV1Beta1\"}", isOptional: true)]
        public K8s.IValidatingAdmissionPolicySpecV1Beta1? Spec
        {
            get;
            set;
        }
    }
}
