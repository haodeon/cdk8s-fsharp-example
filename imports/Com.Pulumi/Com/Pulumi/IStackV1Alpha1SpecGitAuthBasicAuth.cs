using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>BasicAuth configures git authentication through basic auth — i.e. username and password. Both UserName and Password are required.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuth
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackV1Alpha1SpecGitAuthBasicAuth), fullyQualifiedName: "compulumi.StackV1Alpha1SpecGitAuthBasicAuth")]
    public interface IStackV1Alpha1SpecGitAuthBasicAuth
    {
        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuth#password
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuthPassword\"}")]
        Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthPassword Password
        {
            get;
        }

        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuth#userName
        /// </remarks>
        [JsiiProperty(name: "userName", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuthUserName\"}")]
        Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthUserName UserName
        {
            get;
        }

        /// <summary>BasicAuth configures git authentication through basic auth — i.e. username and password. Both UserName and Password are required.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuth
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackV1Alpha1SpecGitAuthBasicAuth), fullyQualifiedName: "compulumi.StackV1Alpha1SpecGitAuthBasicAuth")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
            /// <remarks>
            /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
            /// strings are currently supported.
            ///
            /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuth#password
            /// </remarks>
            [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuthPassword\"}")]
            public Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthPassword Password
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthPassword>()!;
            }

            /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
            /// <remarks>
            /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
            /// strings are currently supported.
            ///
            /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuth#userName
            /// </remarks>
            [JsiiProperty(name: "userName", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuthUserName\"}")]
            public Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthUserName UserName
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthUserName>()!;
            }
        }
    }
}
