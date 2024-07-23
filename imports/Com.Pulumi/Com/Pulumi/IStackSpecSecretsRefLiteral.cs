using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>LiteralRef refers to a literal value.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecSecretsRefLiteral
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecSecretsRefLiteral), fullyQualifiedName: "compulumi.StackSpecSecretsRefLiteral")]
    public interface IStackSpecSecretsRefLiteral
    {
        /// <summary>Value to load.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecSecretsRefLiteral#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecSecretsRefLiteral
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecSecretsRefLiteral), fullyQualifiedName: "compulumi.StackSpecSecretsRefLiteral")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecSecretsRefLiteral
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Value to load.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecSecretsRefLiteral#value
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
