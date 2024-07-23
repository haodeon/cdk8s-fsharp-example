using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>Env selects an environment variable set on the operator process.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecSecretsRefEnv
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpecSecretsRefEnv")]
    public class StackSpecSecretsRefEnv : Com.Pulumi.IStackSpecSecretsRefEnv
    {
        /// <summary>Name of the environment variable.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecSecretsRefEnv#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}