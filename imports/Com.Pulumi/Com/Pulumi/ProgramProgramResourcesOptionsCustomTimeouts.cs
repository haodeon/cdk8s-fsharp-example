using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>customTimeouts overrides the default retry/timeout behavior for resource provisioning.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: ProgramProgramResourcesOptionsCustomTimeouts
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.ProgramProgramResourcesOptionsCustomTimeouts")]
    public class ProgramProgramResourcesOptionsCustomTimeouts : Com.Pulumi.IProgramProgramResourcesOptionsCustomTimeouts
    {
        /// <summary>create is the custom timeout for create operations.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptionsCustomTimeouts#create
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>delete is the custom timeout for delete operations.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptionsCustomTimeouts#delete
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>update is the custom timeout for update operations.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptionsCustomTimeouts#update
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
