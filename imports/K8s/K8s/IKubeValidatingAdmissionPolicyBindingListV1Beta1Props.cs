using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingAdmissionPolicyBindingList is a list of ValidatingAdmissionPolicyBinding.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeValidatingAdmissionPolicyBindingListV1Beta1Props), fullyQualifiedName: "k8s.KubeValidatingAdmissionPolicyBindingListV1Beta1Props")]
    public interface IKubeValidatingAdmissionPolicyBindingListV1Beta1Props
    {
        /// <summary>List of PolicyBinding.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeValidatingAdmissionPolicyBindingV1Beta1Props\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IKubeValidatingAdmissionPolicyBindingV1Beta1Props[]? Items
        {
            get
            {
                return null;
            }
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingList#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IListMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>ValidatingAdmissionPolicyBindingList is a list of ValidatingAdmissionPolicyBinding.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeValidatingAdmissionPolicyBindingListV1Beta1Props), fullyQualifiedName: "k8s.KubeValidatingAdmissionPolicyBindingListV1Beta1Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeValidatingAdmissionPolicyBindingListV1Beta1Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of PolicyBinding.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingList#items
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeValidatingAdmissionPolicyBindingV1Beta1Props\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IKubeValidatingAdmissionPolicyBindingV1Beta1Props[]? Items
            {
                get => GetInstanceProperty<K8s.IKubeValidatingAdmissionPolicyBindingV1Beta1Props[]?>();
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ValidatingAdmissionPolicyBindingList#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
            public K8s.IListMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IListMeta?>();
            }
        }
    }
}
