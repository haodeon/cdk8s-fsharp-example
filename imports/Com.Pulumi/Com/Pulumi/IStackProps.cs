using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>Stack is the Schema for the stacks API.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: Stack
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackProps), fullyQualifiedName: "compulumi.StackProps")]
    public interface IStackProps
    {
        /// <remarks>
        /// <strong>Schema</strong>: Stack#metadata
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
        /// <strong>Schema</strong>: Stack#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"compulumi.StackSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Stack is the Schema for the stacks API.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: Stack
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackProps), fullyQualifiedName: "compulumi.StackProps")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <remarks>
            /// <strong>Schema</strong>: Stack#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdk8s.ApiObjectMetadata\"}", isOptional: true)]
            public Org.Cdk8s.IApiObjectMetadata? Metadata
            {
                get => GetInstanceProperty<Org.Cdk8s.IApiObjectMetadata?>();
            }

            /// <summary>StackSpec defines the desired state of Pulumi Stack being managed by this operator.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: Stack#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"compulumi.StackSpec\"}", isOptional: true)]
            public Com.Pulumi.IStackSpec? Spec
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpec?>();
            }
        }
    }
}
