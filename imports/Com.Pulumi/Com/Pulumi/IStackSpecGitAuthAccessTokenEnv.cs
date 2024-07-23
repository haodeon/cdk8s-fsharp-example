using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>Env selects an environment variable set on the operator process.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuthAccessTokenEnv
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuthAccessTokenEnv), fullyQualifiedName: "compulumi.StackSpecGitAuthAccessTokenEnv")]
    public interface IStackSpecGitAuthAccessTokenEnv
    {
        /// <summary>Name of the environment variable.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthAccessTokenEnv#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthAccessTokenEnv
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuthAccessTokenEnv), fullyQualifiedName: "compulumi.StackSpecGitAuthAccessTokenEnv")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuthAccessTokenEnv
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the environment variable.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthAccessTokenEnv#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
