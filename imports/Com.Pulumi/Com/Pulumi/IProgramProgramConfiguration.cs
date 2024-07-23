using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <remarks>
    /// <strong>Schema</strong>: ProgramProgramConfiguration
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IProgramProgramConfiguration), fullyQualifiedName: "compulumi.ProgramProgramConfiguration")]
    public interface IProgramProgramConfiguration
    {
        /// <summary>default is a value of the appropriate type for the template to use if no value is specified.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramConfiguration#default
        /// </remarks>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Default
        {
            get
            {
                return null;
            }
        }

        /// <summary>type is the (required) data type for the parameter.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramConfiguration#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"fqn\":\"compulumi.ProgramProgramConfigurationType\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.ProgramProgramConfigurationType? Type
        {
            get
            {
                return null;
            }
        }

        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramConfiguration
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IProgramProgramConfiguration), fullyQualifiedName: "compulumi.ProgramProgramConfiguration")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IProgramProgramConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default is a value of the appropriate type for the template to use if no value is specified.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramConfiguration#default
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
            public object? Default
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>type is the (required) data type for the parameter.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramConfiguration#type
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"fqn\":\"compulumi.ProgramProgramConfigurationType\"}", isOptional: true)]
            public Com.Pulumi.ProgramProgramConfigurationType? Type
            {
                get => GetInstanceProperty<Com.Pulumi.ProgramProgramConfigurationType?>();
            }
        }
    }
}
