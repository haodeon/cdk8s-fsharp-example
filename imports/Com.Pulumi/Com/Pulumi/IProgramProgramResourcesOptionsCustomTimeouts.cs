using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>customTimeouts overrides the default retry/timeout behavior for resource provisioning.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: ProgramProgramResourcesOptionsCustomTimeouts
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IProgramProgramResourcesOptionsCustomTimeouts), fullyQualifiedName: "compulumi.ProgramProgramResourcesOptionsCustomTimeouts")]
    public interface IProgramProgramResourcesOptionsCustomTimeouts
    {
        /// <summary>create is the custom timeout for create operations.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptionsCustomTimeouts#create
        /// </remarks>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>delete is the custom timeout for delete operations.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptionsCustomTimeouts#delete
        /// </remarks>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>update is the custom timeout for update operations.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptionsCustomTimeouts#update
        /// </remarks>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        /// <summary>customTimeouts overrides the default retry/timeout behavior for resource provisioning.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptionsCustomTimeouts
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IProgramProgramResourcesOptionsCustomTimeouts), fullyQualifiedName: "compulumi.ProgramProgramResourcesOptionsCustomTimeouts")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IProgramProgramResourcesOptionsCustomTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>create is the custom timeout for create operations.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptionsCustomTimeouts#create
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>delete is the custom timeout for delete operations.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptionsCustomTimeouts#delete
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>update is the custom timeout for update operations.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptionsCustomTimeouts#update
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
