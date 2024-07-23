using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SelfSubjectRulesReviewSpec defines the specification for SelfSubjectRulesReview.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectRulesReviewSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SelfSubjectRulesReviewSpec")]
    public class SelfSubjectRulesReviewSpec : K8s.ISelfSubjectRulesReviewSpec
    {
        /// <summary>Namespace to evaluate rules for.</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectRulesReviewSpec#namespace
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }
    }
}
