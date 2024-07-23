using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <remarks>
    /// <strong>Schema</strong>: ProgramProgramResources
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IProgramProgramResources), fullyQualifiedName: "compulumi.ProgramProgramResources")]
    public interface IProgramProgramResources
    {
        /// <summary>type is the Pulumi type token for this resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResources#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>A getter function for the resource.</summary>
        /// <remarks>
        /// Supplying get is mutually exclusive to properties.
        ///
        /// <strong>Schema</strong>: ProgramProgramResources#get
        /// </remarks>
        [JsiiProperty(name: "get", typeJson: "{\"fqn\":\"compulumi.ProgramProgramResourcesGet\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IProgramProgramResourcesGet? Get
        {
            get
            {
                return null;
            }
        }

        /// <summary>options contains all resource options supported by Pulumi.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResources#options
        /// </remarks>
        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"compulumi.ProgramProgramResourcesOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IProgramProgramResourcesOptions? Options
        {
            get
            {
                return null;
            }
        }

        /// <summary>properties contains the primary resource-specific keys and values to initialize the resource state.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResources#properties
        /// </remarks>
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? Properties
        {
            get
            {
                return null;
            }
        }

        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResources
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IProgramProgramResources), fullyQualifiedName: "compulumi.ProgramProgramResources")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IProgramProgramResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>type is the Pulumi type token for this resource.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResources#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<Com.Pulumi.IProgramProgramResourcesGet?>();
            }

            /// <summary>options contains all resource options supported by Pulumi.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResources#options
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"compulumi.ProgramProgramResourcesOptions\"}", isOptional: true)]
            public Com.Pulumi.IProgramProgramResourcesOptions? Options
            {
                get => GetInstanceProperty<Com.Pulumi.IProgramProgramResourcesOptions?>();
            }

            /// <summary>properties contains the primary resource-specific keys and values to initialize the resource state.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResources#properties
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, object>? Properties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }
        }
    }
}
