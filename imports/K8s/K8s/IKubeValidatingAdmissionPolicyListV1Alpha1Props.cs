using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingAdmissionPolicyList is a list of ValidatingAdmissionPolicy.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicyList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeValidatingAdmissionPolicyListV1Alpha1Props), fullyQualifiedName: "k8s.KubeValidatingAdmissionPolicyListV1Alpha1Props")]
    public interface IKubeValidatingAdmissionPolicyListV1Alpha1Props
    {
        /// <summary>List of ValidatingAdmissionPolicy.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicyList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeValidatingAdmissionPolicyV1Alpha1Props\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IKubeValidatingAdmissionPolicyV1Alpha1Props[]? Items
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
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicyList#metadata
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

        /// <summary>ValidatingAdmissionPolicyList is a list of ValidatingAdmissionPolicy.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicyList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeValidatingAdmissionPolicyListV1Alpha1Props), fullyQualifiedName: "k8s.KubeValidatingAdmissionPolicyListV1Alpha1Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeValidatingAdmissionPolicyListV1Alpha1Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of ValidatingAdmissionPolicy.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicyList#items
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeValidatingAdmissionPolicyV1Alpha1Props\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IKubeValidatingAdmissionPolicyV1Alpha1Props[]? Items
            {
                get => GetInstanceProperty<K8s.IKubeValidatingAdmissionPolicyV1Alpha1Props[]?>();
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ValidatingAdmissionPolicyList#metadata
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
