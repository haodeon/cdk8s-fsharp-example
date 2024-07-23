using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>A getter function for the resource.</summary>
    /// <remarks>
    /// Supplying get is mutually exclusive to properties.
    ///
    /// <strong>Schema</strong>: ProgramProgramResourcesGet
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.ProgramProgramResourcesGet")]
    public class ProgramProgramResourcesGet : Com.Pulumi.IProgramProgramResourcesGet
    {
        /// <summary>The ID of the resource to import.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesGet#id
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>state contains the known properties (input &amp; output) of the resource.</summary>
        /// <remarks>
        /// This assists
        /// the provider in figuring out the correct resource.
        ///
        /// <strong>Schema</strong>: ProgramProgramResourcesGet#state
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, object>? State
        {
            get;
            set;
        }
    }
}
