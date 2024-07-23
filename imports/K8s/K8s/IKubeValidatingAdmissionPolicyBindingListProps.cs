using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingAdmissionPolicyBindingList is a list of ValidatingAdmissionPolicyBinding.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicyBindingList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeValidatingAdmissionPolicyBindingListProps), fullyQualifiedName: "k8s.KubeValidatingAdmissionPolicyBindingListProps")]
    public interface IKubeValidatingAdmissionPolicyBindingListProps
    {
        /// <summary>List of PolicyBinding.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicyBindingList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeValidatingAdmissionPolicyBindingProps\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IKubeValidatingAdmissionPolicyBindingProps[]? Items
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
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicyBindingList#metadata
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
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicyBindingList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeValidatingAdmissionPolicyBindingListProps), fullyQualifiedName: "k8s.KubeValidatingAdmissionPolicyBindingListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeValidatingAdmissionPolicyBindingListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of PolicyBinding.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicyBindingList#items
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeValidatingAdmissionPolicyBindingProps\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IKubeValidatingAdmissionPolicyBindingProps[]? Items
            {
                get => GetInstanceProperty<K8s.IKubeValidatingAdmissionPolicyBindingProps[]?>();
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicyBindingList#metadata
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
