using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>LiteralRef refers to a literal value.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuthAccessTokenLiteral
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuthAccessTokenLiteral), fullyQualifiedName: "compulumi.StackSpecGitAuthAccessTokenLiteral")]
    public interface IStackSpecGitAuthAccessTokenLiteral
    {
        /// <summary>Value to load.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthAccessTokenLiteral#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthAccessTokenLiteral
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuthAccessTokenLiteral), fullyQualifiedName: "compulumi.StackSpecGitAuthAccessTokenLiteral")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuthAccessTokenLiteral
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Value to load.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthAccessTokenLiteral#value
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
