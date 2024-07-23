using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SubjectAccessReview checks whether or not a user or group can perform an action.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReview
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeSubjectAccessReviewProps), fullyQualifiedName: "k8s.KubeSubjectAccessReviewProps")]
    public interface IKubeSubjectAccessReviewProps
    {
        /// <summary>Spec holds information about the request being evaluated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReview#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.SubjectAccessReviewSpec\"}")]
        K8s.ISubjectAccessReviewSpec Spec
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReview#metadata
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

        /// <summary>SubjectAccessReview checks whether or not a user or group can perform an action.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReview
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeSubjectAccessReviewProps), fullyQualifiedName: "k8s.KubeSubjectAccessReviewProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeSubjectAccessReviewProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Spec holds information about the request being evaluated.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReview#spec
            /// </remarks>
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.SubjectAccessReviewSpec\"}")]
            public K8s.ISubjectAccessReviewSpec Spec
            {
                get => GetInstanceProperty<K8s.ISubjectAccessReviewSpec>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReview#metadata
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
