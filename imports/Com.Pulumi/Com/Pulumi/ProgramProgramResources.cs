using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <remarks>
    /// <strong>Schema</strong>: ProgramProgramResources
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.ProgramProgramResources")]
    public class ProgramProgramResources : Com.Pulumi.IProgramProgramResources
    {
        /// <summary>type is the Pulumi type token for this resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResources#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>A getter function for the resource.</summary>
        /// <remarks>
        /// Supplying get is mutually exclusive to properties.
        ///
        /// <strong>Schema</strong>: ProgramProgramResources#get
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "get", typeJson: "{\"fqn\":\"compulumi.ProgramProgramResourcesGet\"}", isOptional: true)]
        public Com.Pulumi.IProgramProgramResourcesGet? Get
        {
            get;
            set;
        }

        /// <summary>options contains all resource options supported by Pulumi.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResources#options
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"compulumi.ProgramProgramResourcesOptions\"}", isOptional: true)]
        public Com.Pulumi.IProgramProgramResourcesOptions? Options
        {
            get;
            set;
        }

        /// <summary>properties contains the primary resource-specific keys and values to initialize the resource state.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResources#properties
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, object>? Properties
        {
            get;
            set;
        }
    }
}
