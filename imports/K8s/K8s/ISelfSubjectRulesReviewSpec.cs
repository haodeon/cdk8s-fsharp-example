using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SelfSubjectRulesReviewSpec defines the specification for SelfSubjectRulesReview.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectRulesReviewSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISelfSubjectRulesReviewSpec), fullyQualifiedName: "k8s.SelfSubjectRulesReviewSpec")]
    public interface ISelfSubjectRulesReviewSpec
    {
        /// <summary>Namespace to evaluate rules for.</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectRulesReviewSpec#namespace
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

        /// <summary>SelfSubjectRulesReviewSpec defines the specification for SelfSubjectRulesReview.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectRulesReviewSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISelfSubjectRulesReviewSpec), fullyQualifiedName: "k8s.SelfSubjectRulesReviewSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.ISelfSubjectRulesReviewSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
