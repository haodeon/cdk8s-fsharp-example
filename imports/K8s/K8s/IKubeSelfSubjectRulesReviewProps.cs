using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SelfSubjectRulesReview enumerates the set of actions the current user can perform within a namespace.</summary>
    /// <remarks>
    /// The returned list of actions may be incomplete depending on the server's authorization mode, and any errors experienced during the evaluation. SelfSubjectRulesReview should be used by UIs to show/hide actions, or to quickly let an end user reason about their permissions. It should NOT Be used by external systems to drive authorization decisions as this raises confused deputy, cache lifetime/revocation, and correctness concerns. SubjectAccessReview, and LocalAccessReview are the correct way to defer authorization decisions to the API server.
    ///
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectRulesReview
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeSelfSubjectRulesReviewProps), fullyQualifiedName: "k8s.KubeSelfSubjectRulesReviewProps")]
    public interface IKubeSelfSubjectRulesReviewProps
    {
        /// <summary>Spec holds information about the request being evaluated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectRulesReview#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.SelfSubjectRulesReviewSpec\"}")]
        K8s.ISelfSubjectRulesReviewSpec Spec
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectRulesReview#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>SelfSubjectRulesReview enumerates the set of actions the current user can perform within a namespace.</summary>
        /// <remarks>
        /// The returned list of actions may be incomplete depending on the server's authorization mode, and any errors experienced during the evaluation. SelfSubjectRulesReview should be used by UIs to show/hide actions, or to quickly let an end user reason about their permissions. It should NOT Be used by external systems to drive authorization decisions as this raises confused deputy, cache lifetime/revocation, and correctness concerns. SubjectAccessReview, and LocalAccessReview are the correct way to defer authorization decisions to the API server.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectRulesReview
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeSelfSubjectRulesReviewProps), fullyQualifiedName: "k8s.KubeSelfSubjectRulesReviewProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeSelfSubjectRulesReviewProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Spec holds information about the request being evaluated.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectRulesReview#spec
            /// </remarks>
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.SelfSubjectRulesReviewSpec\"}")]
            public K8s.ISelfSubjectRulesReviewSpec Spec
            {
                get => GetInstanceProperty<K8s.ISelfSubjectRulesReviewSpec>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectRulesReview#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }
        }
    }
}
