using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>BasicAuth configures git authentication through basic auth — i.e. username and password. Both UserName and Password are required.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuthBasicAuth
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuthBasicAuth), fullyQualifiedName: "compulumi.StackSpecGitAuthBasicAuth")]
    public interface IStackSpecGitAuthBasicAuth
    {
        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuth#password
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthPassword\"}")]
        Com.Pulumi.IStackSpecGitAuthBasicAuthPassword Password
        {
            get;
        }

        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuth#userName
        /// </remarks>
        [JsiiProperty(name: "userName", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserName\"}")]
        Com.Pulumi.IStackSpecGitAuthBasicAuthUserName UserName
        {
            get;
        }

        /// <summary>BasicAuth configures git authentication through basic auth — i.e. username and password. Both UserName and Password are required.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuth
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuthBasicAuth), fullyQualifiedName: "compulumi.StackSpecGitAuthBasicAuth")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuthBasicAuth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
            /// <remarks>
            /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
            /// strings are currently supported.
            ///
            /// <strong>Schema</strong>: StackSpecGitAuthBasicAuth#password
            /// </remarks>
            [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthPassword\"}")]
            public Com.Pulumi.IStackSpecGitAuthBasicAuthPassword Password
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthBasicAuthPassword>()!;
            }

            /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
            /// <remarks>
            /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
            /// strings are currently supported.
            ///
            /// <strong>Schema</strong>: StackSpecGitAuthBasicAuth#userName
            /// </remarks>
            [JsiiProperty(name: "userName", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserName\"}")]
            public Com.Pulumi.IStackSpecGitAuthBasicAuthUserName UserName
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthBasicAuthUserName>()!;
            }
        }
    }
}
