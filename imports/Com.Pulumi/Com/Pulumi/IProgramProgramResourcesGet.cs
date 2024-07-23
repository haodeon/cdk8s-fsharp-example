using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>A getter function for the resource.</summary>
    /// <remarks>
    /// Supplying get is mutually exclusive to properties.
    ///
    /// <strong>Schema</strong>: ProgramProgramResourcesGet
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IProgramProgramResourcesGet), fullyQualifiedName: "compulumi.ProgramProgramResourcesGet")]
    public interface IProgramProgramResourcesGet
    {
        /// <summary>The ID of the resource to import.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesGet#id
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>state contains the known properties (input &amp; output) of the resource.</summary>
        /// <remarks>
        /// This assists
        /// the provider in figuring out the correct resource.
        ///
        /// <strong>Schema</strong>: ProgramProgramResourcesGet#state
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>A getter function for the resource.</summary>
        /// <remarks>
        /// Supplying get is mutually exclusive to properties.
        ///
        /// <strong>Schema</strong>: ProgramProgramResourcesGet
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IProgramProgramResourcesGet), fullyQualifiedName: "compulumi.ProgramProgramResourcesGet")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IProgramProgramResourcesGet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the resource to import.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesGet#id
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }
        }
    }
}
