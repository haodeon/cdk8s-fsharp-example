using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>Env selects an environment variable set on the operator process.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthPasswordEnv
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpecGitAuthBasicAuthPasswordEnv")]
    public class StackSpecGitAuthBasicAuthPasswordEnv : Com.Pulumi.IStackSpecGitAuthBasicAuthPasswordEnv
    {
        /// <summary>Name of the environment variable.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthPasswordEnv#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
