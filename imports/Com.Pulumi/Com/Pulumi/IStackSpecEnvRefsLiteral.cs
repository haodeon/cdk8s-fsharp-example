using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>LiteralRef refers to a literal value.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecEnvRefsLiteral
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecEnvRefsLiteral), fullyQualifiedName: "compulumi.StackSpecEnvRefsLiteral")]
    public interface IStackSpecEnvRefsLiteral
    {
        /// <summary>Value to load.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecEnvRefsLiteral#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecEnvRefsLiteral
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecEnvRefsLiteral), fullyQualifiedName: "compulumi.StackSpecEnvRefsLiteral")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecEnvRefsLiteral
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Value to load.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecEnvRefsLiteral#value
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
