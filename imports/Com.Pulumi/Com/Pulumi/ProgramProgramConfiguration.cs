using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <remarks>
    /// <strong>Schema</strong>: ProgramProgramConfiguration
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.ProgramProgramConfiguration")]
    public class ProgramProgramConfiguration : Com.Pulumi.IProgramProgramConfiguration
    {
        /// <summary>default is a value of the appropriate type for the template to use if no value is specified.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramConfiguration#default
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        public object? Default
        {
            get;
            set;
        }

        /// <summary>type is the (required) data type for the parameter.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramConfiguration#type
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"fqn\":\"compulumi.ProgramProgramConfigurationType\"}", isOptional: true)]
        public Com.Pulumi.ProgramProgramConfigurationType? Type
        {
            get;
            set;
        }
    }
}
