using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>Program is the schema for the inline YAML program API.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: Program
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.ProgramProps")]
    public class ProgramProps : Com.Pulumi.IProgramProps
    {
        /// <remarks>
        /// <strong>Schema</strong>: Program#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdk8s.ApiObjectMetadata\"}", isOptional: true)]
        public Org.Cdk8s.IApiObjectMetadata? Metadata
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: Program#program
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "program", typeJson: "{\"fqn\":\"compulumi.ProgramProgram\"}", isOptional: true)]
        public Com.Pulumi.IProgramProgram? Program
        {
            get;
            set;
        }
    }
}
