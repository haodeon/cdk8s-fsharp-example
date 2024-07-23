using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>Env selects an environment variable set on the operator process.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthUserNameEnv
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackV1Alpha1SpecGitAuthBasicAuthUserNameEnv), fullyQualifiedName: "compulumi.StackV1Alpha1SpecGitAuthBasicAuthUserNameEnv")]
    public interface IStackV1Alpha1SpecGitAuthBasicAuthUserNameEnv
    {
        /// <summary>Name of the environment variable.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthUserNameEnv#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthUserNameEnv
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackV1Alpha1SpecGitAuthBasicAuthUserNameEnv), fullyQualifiedName: "compulumi.StackV1Alpha1SpecGitAuthBasicAuthUserNameEnv")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthUserNameEnv
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the environment variable.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthUserNameEnv#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
