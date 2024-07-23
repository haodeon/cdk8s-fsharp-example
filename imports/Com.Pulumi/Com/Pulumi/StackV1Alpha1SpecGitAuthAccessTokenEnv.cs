using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>Env selects an environment variable set on the operator process.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthAccessTokenEnv
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackV1Alpha1SpecGitAuthAccessTokenEnv")]
    public class StackV1Alpha1SpecGitAuthAccessTokenEnv : Com.Pulumi.IStackV1Alpha1SpecGitAuthAccessTokenEnv
    {
        /// <summary>Name of the environment variable.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthAccessTokenEnv#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
