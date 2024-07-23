using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>ProgramRef refers to a Program object, to be used as the source for the stack.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecProgramRef
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpecProgramRef")]
    public class StackSpecProgramRef : Com.Pulumi.IStackSpecProgramRef
    {
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecProgramRef#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
