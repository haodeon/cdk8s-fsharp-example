using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>Program is the schema for the inline YAML program API.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: Program
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IProgramProps), fullyQualifiedName: "compulumi.ProgramProps")]
    public interface IProgramProps
    {
        /// <remarks>
        /// <strong>Schema</strong>: Program#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdk8s.ApiObjectMetadata\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Org.Cdk8s.IApiObjectMetadata? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <remarks>
        /// <strong>Schema</strong>: Program#program
        /// </remarks>
        [JsiiProperty(name: "program", typeJson: "{\"fqn\":\"compulumi.ProgramProgram\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IProgramProgram? Program
        {
            get
            {
                return null;
            }
        }

        /// <summary>Program is the schema for the inline YAML program API.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: Program
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IProgramProps), fullyQualifiedName: "compulumi.ProgramProps")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IProgramProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <remarks>
            /// <strong>Schema</strong>: Program#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdk8s.ApiObjectMetadata\"}", isOptional: true)]
            public Org.Cdk8s.IApiObjectMetadata? Metadata
            {
                get => GetInstanceProperty<Org.Cdk8s.IApiObjectMetadata?>();
            }

            /// <remarks>
            /// <strong>Schema</strong>: Program#program
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "program", typeJson: "{\"fqn\":\"compulumi.ProgramProgram\"}", isOptional: true)]
            public Com.Pulumi.IProgramProgram? Program
            {
                get => GetInstanceProperty<Com.Pulumi.IProgramProgram?>();
            }
        }
    }
}
