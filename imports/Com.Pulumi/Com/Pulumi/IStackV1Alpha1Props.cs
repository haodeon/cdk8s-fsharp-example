using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>Stack is the Schema for the stacks API.</summary>
    /// <remarks>
    /// Deprecated: Note Stacks from pulumi.com/v1alpha1 is deprecated in favor of pulumi.com/v1.
    /// It is completely backward compatible. Users are strongly encouraged to switch to pulumi.com/v1.
    ///
    /// <strong>Schema</strong>: StackV1Alpha1
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackV1Alpha1Props), fullyQualifiedName: "compulumi.StackV1Alpha1Props")]
    public interface IStackV1Alpha1Props
    {
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdk8s.ApiObjectMetadata\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Org.Cdk8s.IApiObjectMetadata? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>StackSpec defines the desired state of Pulumi Stack being managed by this operator.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1Spec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackV1Alpha1Spec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Stack is the Schema for the stacks API.</summary>
        /// <remarks>
        /// Deprecated: Note Stacks from pulumi.com/v1alpha1 is deprecated in favor of pulumi.com/v1.
        /// It is completely backward compatible. Users are strongly encouraged to switch to pulumi.com/v1.
        ///
        /// <strong>Schema</strong>: StackV1Alpha1
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackV1Alpha1Props), fullyQualifiedName: "compulumi.StackV1Alpha1Props")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackV1Alpha1Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdk8s.ApiObjectMetadata\"}", isOptional: true)]
            public Org.Cdk8s.IApiObjectMetadata? Metadata
            {
                get => GetInstanceProperty<Org.Cdk8s.IApiObjectMetadata?>();
            }

            /// <summary>StackSpec defines the desired state of Pulumi Stack being managed by this operator.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1Spec\"}", isOptional: true)]
            public Com.Pulumi.IStackV1Alpha1Spec? Spec
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1Spec?>();
            }
        }
    }
}
