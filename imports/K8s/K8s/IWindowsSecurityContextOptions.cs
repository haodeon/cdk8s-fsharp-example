using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>WindowsSecurityContextOptions contain Windows-specific options and credentials.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.WindowsSecurityContextOptions
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IWindowsSecurityContextOptions), fullyQualifiedName: "k8s.WindowsSecurityContextOptions")]
    public interface IWindowsSecurityContextOptions
    {
        /// <summary>GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.WindowsSecurityContextOptions#gmsaCredentialSpec
        /// </remarks>
        [JsiiProperty(name: "gmsaCredentialSpec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GmsaCredentialSpec
        {
            get
            {
                return null;
            }
        }

        /// <summary>GMSACredentialSpecName is the name of the GMSA credential spec to use.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.WindowsSecurityContextOptions#gmsaCredentialSpecName
        /// </remarks>
        [JsiiProperty(name: "gmsaCredentialSpecName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GmsaCredentialSpecName
        {
            get
            {
                return null;
            }
        }

        /// <summary>HostProcess determines if a container should be run as a 'Host Process' container.</summary>
        /// <remarks>
        /// All of a Pod's containers must have the same effective HostProcess value (it is not allowed to have a mix of HostProcess containers and non-HostProcess containers). In addition, if HostProcess is true then HostNetwork must also be set to true.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.WindowsSecurityContextOptions#hostProcess
        /// </remarks>
        [JsiiProperty(name: "hostProcess", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? HostProcess
        {
            get
            {
                return null;
            }
        }

        /// <summary>The UserName in Windows to run the entrypoint of the container process.</summary>
        /// <remarks>
        /// Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        ///
        /// <strong>Default</strong>: the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.WindowsSecurityContextOptions#runAsUserName
        /// </remarks>
        [JsiiProperty(name: "runAsUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RunAsUserName
        {
            get
            {
                return null;
            }
        }

        /// <summary>WindowsSecurityContextOptions contain Windows-specific options and credentials.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.WindowsSecurityContextOptions
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IWindowsSecurityContextOptions), fullyQualifiedName: "k8s.WindowsSecurityContextOptions")]
        internal sealed class _Proxy : DeputyBase, K8s.IWindowsSecurityContextOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.WindowsSecurityContextOptions#gmsaCredentialSpec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gmsaCredentialSpec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GmsaCredentialSpec
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>GMSACredentialSpecName is the name of the GMSA credential spec to use.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.WindowsSecurityContextOptions#gmsaCredentialSpecName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gmsaCredentialSpecName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GmsaCredentialSpecName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>HostProcess determines if a container should be run as a 'Host Process' container.</summary>
            /// <remarks>
            /// All of a Pod's containers must have the same effective HostProcess value (it is not allowed to have a mix of HostProcess containers and non-HostProcess containers). In addition, if HostProcess is true then HostNetwork must also be set to true.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.WindowsSecurityContextOptions#hostProcess
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostProcess", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? HostProcess
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>The UserName in Windows to run the entrypoint of the container process.</summary>
            /// <remarks>
            /// Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
            ///
            /// <strong>Default</strong>: the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.WindowsSecurityContextOptions#runAsUserName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runAsUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RunAsUserName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
