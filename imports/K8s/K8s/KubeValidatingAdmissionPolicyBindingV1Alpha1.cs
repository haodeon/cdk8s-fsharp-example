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
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicyBinding
    /// </remarks>
    [JsiiClass(nativeType: typeof(K8s.KubeValidatingAdmissionPolicyBindingV1Alpha1), fullyQualifiedName: "k8s.KubeValidatingAdmissionPolicyBindingV1Alpha1", parametersJson: "[{\"docs\":{\"summary\":\"the scope in which to define this object.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"a scope-local name for the object.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"initialization props.\"},\"name\":\"props\",\"optional\":true,\"type\":{\"fqn\":\"k8s.KubeValidatingAdmissionPolicyBindingV1Alpha1Props\"}}]")]
    public class KubeValidatingAdmissionPolicyBindingV1Alpha1 : Org.Cdk8s.ApiObject
    {
        /// <summary>Defines a "io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicyBinding" API object.</summary>
        /// <param name="scope">the scope in which to define this object.</param>
        /// <param name="id">a scope-local name for the object.</param>
        /// <param name="props">initialization props.</param>
        public KubeValidatingAdmissionPolicyBindingV1Alpha1(Constructs.Construct scope, string id, K8s.IKubeValidatingAdmissionPolicyBindingV1Alpha1Props? props = null): base(_MakeDeputyProps(scope, id, props))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, K8s.IKubeValidatingAdmissionPolicyBindingV1Alpha1Props? props = null)
        {
            return new DeputyProps(new object?[]{scope, id, props});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubeValidatingAdmissionPolicyBindingV1Alpha1(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubeValidatingAdmissionPolicyBindingV1Alpha1(DeputyProps props): base(props)
        {
        }

        /// <summary>Renders a Kubernetes manifest for "io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicyBinding".</summary>
        /// <param name="props">initialization props.</param>
        /// <remarks>
        /// This can be used to inline resource manifests inside other objects (e.g. as templates).
        /// </remarks>
        [JsiiMethod(name: "manifest", returnsJson: "{\"type\":{\"primitive\":\"any\"}}", parametersJson: "[{\"docs\":{\"summary\":\"initialization props.\"},\"name\":\"props\",\"optional\":true,\"type\":{\"fqn\":\"k8s.KubeValidatingAdmissionPolicyBindingV1Alpha1Props\"}}]")]
        public static object Manifest(K8s.IKubeValidatingAdmissionPolicyBindingV1Alpha1Props? props = null)
        {
            return InvokeStaticMethod<object>(typeof(K8s.KubeValidatingAdmissionPolicyBindingV1Alpha1), new System.Type[]{typeof(K8s.IKubeValidatingAdmissionPolicyBindingV1Alpha1Props)}, new object?[]{props})!;
        }

        /// <summary>Renders the object to Kubernetes JSON.</summary>
        [JsiiMethod(name: "toJson", returnsJson: "{\"type\":{\"primitive\":\"any\"}}")]
        public override object ToJson()
        {
            return InvokeInstanceMethod<object>(new System.Type[]{}, new object[]{})!;
        }

        /// <summary>Returns the apiVersion and kind for "io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicyBinding".</summary>
        [JsiiProperty(name: "GVK", typeJson: "{\"fqn\":\"cdk8s.GroupVersionKind\"}")]
        public static Org.Cdk8s.IGroupVersionKind GVK
        {
            get;
        }
        = GetStaticProperty<Org.Cdk8s.IGroupVersionKind>(typeof(K8s.KubeValidatingAdmissionPolicyBindingV1Alpha1))!;
    }
}
