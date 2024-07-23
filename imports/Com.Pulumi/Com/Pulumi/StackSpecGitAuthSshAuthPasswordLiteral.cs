using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>LiteralRef refers to a literal value.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordLiteral
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpecGitAuthSshAuthPasswordLiteral")]
    public class StackSpecGitAuthSshAuthPasswordLiteral : Com.Pulumi.IStackSpecGitAuthSshAuthPasswordLiteral
    {
        /// <summary>Value to load.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordLiteral#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
