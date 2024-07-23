using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>Env selects an environment variable set on the operator process.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserNameEnv
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuthBasicAuthUserNameEnv), fullyQualifiedName: "compulumi.StackSpecGitAuthBasicAuthUserNameEnv")]
    public interface IStackSpecGitAuthBasicAuthUserNameEnv
    {
        /// <summary>Name of the environment variable.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserNameEnv#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserNameEnv
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuthBasicAuthUserNameEnv), fullyQualifiedName: "compulumi.StackSpecGitAuthBasicAuthUserNameEnv")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameEnv
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the environment variable.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserNameEnv#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
