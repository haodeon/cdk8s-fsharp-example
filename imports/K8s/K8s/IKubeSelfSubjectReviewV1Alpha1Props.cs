using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SelfSubjectReview contains the user information that the kube-apiserver has about the user making this request.</summary>
    /// <remarks>
    /// When using impersonation, users will receive the user info of the user being impersonated.  If impersonation or request header authentication is used, any extra keys will have their case ignored and returned as lowercase.
    ///
    /// <strong>Schema</strong>: io.k8s.api.authentication.v1alpha1.SelfSubjectReview
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeSelfSubjectReviewV1Alpha1Props), fullyQualifiedName: "k8s.KubeSelfSubjectReviewV1Alpha1Props")]
    public interface IKubeSelfSubjectReviewV1Alpha1Props
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1alpha1.SelfSubjectReview#metadata
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

        /// <summary>SelfSubjectReview contains the user information that the kube-apiserver has about the user making this request.</summary>
        /// <remarks>
        /// When using impersonation, users will receive the user info of the user being impersonated.  If impersonation or request header authentication is used, any extra keys will have their case ignored and returned as lowercase.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1alpha1.SelfSubjectReview
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeSelfSubjectReviewV1Alpha1Props), fullyQualifiedName: "k8s.KubeSelfSubjectReviewV1Alpha1Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeSelfSubjectReviewV1Alpha1Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.authentication.v1alpha1.SelfSubjectReview#metadata
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
