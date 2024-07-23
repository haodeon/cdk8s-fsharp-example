using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingAdmissionPolicy describes the definition of an admission validation policy that accepts or rejects an object without changing it.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicy
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeValidatingAdmissionPolicyProps")]
    public class KubeValidatingAdmissionPolicyProps : K8s.IKubeValidatingAdmissionPolicyProps
    {
        /// <summary>Standard object metadata;</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicy#metadata
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
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicy#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ValidatingAdmissionPolicySpec\"}", isOptional: true)]
        public K8s.IValidatingAdmissionPolicySpec? Spec
        {
            get;
            set;
        }
    }
}
