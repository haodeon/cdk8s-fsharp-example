using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>BasicAuth configures git authentication through basic auth — i.e. username and password. Both UserName and Password are required.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuthBasicAuth
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpecGitAuthBasicAuth")]
    public class StackSpecGitAuthBasicAuth : Com.Pulumi.IStackSpecGitAuthBasicAuth
    {
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
            get;
            set;
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
            get;
            set;
        }
    }
}
