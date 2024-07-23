using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>LiteralRef refers to a literal value.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordLiteral
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuthSshAuthPasswordLiteral), fullyQualifiedName: "compulumi.StackSpecGitAuthSshAuthPasswordLiteral")]
    public interface IStackSpecGitAuthSshAuthPasswordLiteral
    {
        /// <summary>Value to load.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordLiteral#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordLiteral
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuthSshAuthPasswordLiteral), fullyQualifiedName: "compulumi.StackSpecGitAuthSshAuthPasswordLiteral")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuthSshAuthPasswordLiteral
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Value to load.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordLiteral#value
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
