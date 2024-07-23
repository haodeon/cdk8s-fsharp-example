using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SelfSubjectReview contains the user information that the kube-apiserver has about the user making this request.</summary>
    /// <remarks>
    /// When using impersonation, users will receive the user info of the user being impersonated.  If impersonation or request header authentication is used, any extra keys will have their case ignored and returned as lowercase.
    ///
    /// <strong>Schema</strong>: io.k8s.api.authentication.v1beta1.SelfSubjectReview
    /// </remarks>
    [JsiiClass(nativeType: typeof(K8s.KubeSelfSubjectReviewV1Beta1), fullyQualifiedName: "k8s.KubeSelfSubjectReviewV1Beta1", parametersJson: "[{\"docs\":{\"summary\":\"the scope in which to define this object.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"a scope-local name for the object.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"initialization props.\"},\"name\":\"props\",\"optional\":true,\"type\":{\"fqn\":\"k8s.KubeSelfSubjectReviewV1Beta1Props\"}}]")]
    public class KubeSelfSubjectReviewV1Beta1 : Org.Cdk8s.ApiObject
    {
        /// <summary>Defines a "io.k8s.api.authentication.v1beta1.SelfSubjectReview" API object.</summary>
        /// <param name="scope">the scope in which to define this object.</param>
        /// <param name="id">a scope-local name for the object.</param>
        /// <param name="props">initialization props.</param>
        public KubeSelfSubjectReviewV1Beta1(Constructs.Construct scope, string id, K8s.IKubeSelfSubjectReviewV1Beta1Props? props = null): base(_MakeDeputyProps(scope, id, props))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, K8s.IKubeSelfSubjectReviewV1Beta1Props? props = null)
        {
            return new DeputyProps(new object?[]{scope, id, props});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubeSelfSubjectReviewV1Beta1(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubeSelfSubjectReviewV1Beta1(DeputyProps props): base(props)
        {
        }

        /// <summary>Renders a Kubernetes manifest for "io.k8s.api.authentication.v1beta1.SelfSubjectReview".</summary>
        /// <param name="props">initialization props.</param>
        /// <remarks>
        /// This can be used to inline resource manifests inside other objects (e.g. as templates).
        /// </remarks>
        [JsiiMethod(name: "manifest", returnsJson: "{\"type\":{\"primitive\":\"any\"}}", parametersJson: "[{\"docs\":{\"summary\":\"initialization props.\"},\"name\":\"props\",\"optional\":true,\"type\":{\"fqn\":\"k8s.KubeSelfSubjectReviewV1Beta1Props\"}}]")]
        public static object Manifest(K8s.IKubeSelfSubjectReviewV1Beta1Props? props = null)
        {
            return InvokeStaticMethod<object>(typeof(K8s.KubeSelfSubjectReviewV1Beta1), new System.Type[]{typeof(K8s.IKubeSelfSubjectReviewV1Beta1Props)}, new object?[]{props})!;
        }

        /// <summary>Renders the object to Kubernetes JSON.</summary>
        [JsiiMethod(name: "toJson", returnsJson: "{\"type\":{\"primitive\":\"any\"}}")]
        public override object ToJson()
        {
            return InvokeInstanceMethod<object>(new System.Type[]{}, new object[]{})!;
        }

        /// <summary>Returns the apiVersion and kind for "io.k8s.api.authentication.v1beta1.SelfSubjectReview".</summary>
        [JsiiProperty(name: "GVK", typeJson: "{\"fqn\":\"cdk8s.GroupVersionKind\"}")]
        public static Org.Cdk8s.IGroupVersionKind GVK
        {
            get;
        }
        = GetStaticProperty<Org.Cdk8s.IGroupVersionKind>(typeof(K8s.KubeSelfSubjectReviewV1Beta1))!;
    }
}
