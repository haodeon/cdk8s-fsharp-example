using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>ProgramRef refers to a Program object, to be used as the source for the stack.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecProgramRef
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecProgramRef), fullyQualifiedName: "compulumi.StackSpecProgramRef")]
    public interface IStackSpecProgramRef
    {
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecProgramRef#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>ProgramRef refers to a Program object, to be used as the source for the stack.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecProgramRef
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecProgramRef), fullyQualifiedName: "compulumi.StackSpecProgramRef")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecProgramRef
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <remarks>
            /// <strong>Schema</strong>: StackSpecProgramRef#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
