using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>ProgramRef refers to a Program object, to be used as the source for the stack.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecProgramRef
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackV1Alpha1SpecProgramRef), fullyQualifiedName: "compulumi.StackV1Alpha1SpecProgramRef")]
    public interface IStackV1Alpha1SpecProgramRef
    {
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecProgramRef#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>ProgramRef refers to a Program object, to be used as the source for the stack.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecProgramRef
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackV1Alpha1SpecProgramRef), fullyQualifiedName: "compulumi.StackV1Alpha1SpecProgramRef")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackV1Alpha1SpecProgramRef
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecProgramRef#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
