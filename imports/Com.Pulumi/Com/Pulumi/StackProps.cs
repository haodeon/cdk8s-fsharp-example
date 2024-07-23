using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>Stack is the Schema for the stacks API.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: Stack
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackProps")]
    public class StackProps : Com.Pulumi.IStackProps
    {
        /// <remarks>
        /// <strong>Schema</strong>: Stack#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdk8s.ApiObjectMetadata\"}", isOptional: true)]
        public Org.Cdk8s.IApiObjectMetadata? Metadata
        {
            get;
            set;
        }

        /// <summary>StackSpec defines the desired state of Pulumi Stack being managed by this operator.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: Stack#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"compulumi.StackSpec\"}", isOptional: true)]
        public Com.Pulumi.IStackSpec? Spec
        {
            get;
            set;
        }
    }
}
