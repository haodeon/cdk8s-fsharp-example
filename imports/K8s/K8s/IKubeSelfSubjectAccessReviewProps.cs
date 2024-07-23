using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SelfSubjectAccessReview checks whether or the current user can perform an action.</summary>
    /// <remarks>
    /// Not filling in a spec.namespace means "in all namespaces".  Self is a special case, because users should always be able to check whether they can perform an action
    ///
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectAccessReview
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeSelfSubjectAccessReviewProps), fullyQualifiedName: "k8s.KubeSelfSubjectAccessReviewProps")]
    public interface IKubeSelfSubjectAccessReviewProps
    {
        /// <summary>Spec holds information about the request being evaluated.</summary>
        /// <remarks>
        /// user and groups must be empty
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectAccessReview#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.SelfSubjectAccessReviewSpec\"}")]
        K8s.ISelfSubjectAccessReviewSpec Spec
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectAccessReview#metadata
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

        /// <summary>SelfSubjectAccessReview checks whether or the current user can perform an action.</summary>
        /// <remarks>
        /// Not filling in a spec.namespace means "in all namespaces".  Self is a special case, because users should always be able to check whether they can perform an action
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectAccessReview
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeSelfSubjectAccessReviewProps), fullyQualifiedName: "k8s.KubeSelfSubjectAccessReviewProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeSelfSubjectAccessReviewProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Spec holds information about the request being evaluated.</summary>
            /// <remarks>
            /// user and groups must be empty
            ///
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectAccessReview#spec
            /// </remarks>
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.SelfSubjectAccessReviewSpec\"}")]
            public K8s.ISelfSubjectAccessReviewSpec Spec
            {
                get => GetInstanceProperty<K8s.ISelfSubjectAccessReviewSpec>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectAccessReview#metadata
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
