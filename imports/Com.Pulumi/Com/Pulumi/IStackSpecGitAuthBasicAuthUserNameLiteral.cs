using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>LiteralRef refers to a literal value.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserNameLiteral
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuthBasicAuthUserNameLiteral), fullyQualifiedName: "compulumi.StackSpecGitAuthBasicAuthUserNameLiteral")]
    public interface IStackSpecGitAuthBasicAuthUserNameLiteral
    {
        /// <summary>Value to load.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserNameLiteral#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserNameLiteral
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuthBasicAuthUserNameLiteral), fullyQualifiedName: "compulumi.StackSpecGitAuthBasicAuthUserNameLiteral")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameLiteral
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Value to load.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserNameLiteral#value
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
