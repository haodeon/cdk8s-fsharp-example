using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <remarks>
    /// <strong>Schema</strong>: ProgramProgram
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.ProgramProgram")]
    public class ProgramProgram : Com.Pulumi.IProgramProgram
    {
        /// <summary>configuration specifies the Pulumi config inputs to the deployment.</summary>
        /// <remarks>
        /// Either type or default is required.
        ///
        /// <strong>Schema</strong>: ProgramProgram#configuration
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"compulumi.ProgramProgramConfiguration\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, Com.Pulumi.IProgramProgramConfiguration>? Configuration
        {
            get;
            set;
        }

        /// <summary>outputs specifies the Pulumi stack outputs of the program and how they are computed from the resources.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgram#outputs
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, object>? Outputs
        {
            get;
            set;
        }

        /// <summary>resources declares the Pulumi resources that will be deployed and managed by the program.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgram#resources
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"compulumi.ProgramProgramResources\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, Com.Pulumi.IProgramProgramResources>? Resources
        {
            get;
            set;
        }

        /// <summary>variables specifies intermediate values of the program;</summary>
        /// <remarks>
        /// the values of variables are
        /// expressions that can be re-used.
        ///
        /// <strong>Schema</strong>: ProgramProgram#variables
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "variables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, object>? Variables
        {
            get;
            set;
        }
    }
}
