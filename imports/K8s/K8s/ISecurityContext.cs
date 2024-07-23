using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SecurityContext holds security configuration that will be applied to a container.</summary>
    /// <remarks>
    /// Some fields are present in both SecurityContext and PodSecurityContext.  When both are set, the values in SecurityContext take precedence.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISecurityContext), fullyQualifiedName: "k8s.SecurityContext")]
    public interface ISecurityContext
    {
        /// <summary>AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process.</summary>
        /// <remarks>
        /// This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#allowPrivilegeEscalation
        /// </remarks>
        [JsiiProperty(name: "allowPrivilegeEscalation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllowPrivilegeEscalation
        {
            get
            {
                return null;
            }
        }

        /// <summary>appArmorProfile is the AppArmor options to use by this container.</summary>
        /// <remarks>
        /// If set, this profile overrides the pod's appArmorProfile. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#appArmorProfile
        /// </remarks>
        [JsiiProperty(name: "appArmorProfile", typeJson: "{\"fqn\":\"k8s.AppArmorProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IAppArmorProfile? AppArmorProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>The capabilities to add/drop when running containers.</summary>
        /// <remarks>
        /// Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Default</strong>: the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#capabilities
        /// </remarks>
        [JsiiProperty(name: "capabilities", typeJson: "{\"fqn\":\"k8s.Capabilities\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ICapabilities? Capabilities
        {
            get
            {
                return null;
            }
        }

        /// <summary>Run container in privileged mode.</summary>
        /// <remarks>
        /// Processes in privileged containers are essentially equivalent to root on the host. Defaults to false. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Default</strong>: false. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#privileged
        /// </remarks>
        [JsiiProperty(name: "privileged", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Privileged
        {
            get
            {
                return null;
            }
        }

        /// <summary>procMount denotes the type of proc mount to use for the containers.</summary>
        /// <remarks>
        /// The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#procMount
        /// </remarks>
        [JsiiProperty(name: "procMount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProcMount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this container has a read-only root filesystem.</summary>
        /// <remarks>
        /// Default is false. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Default</strong>: false. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#readOnlyRootFilesystem
        /// </remarks>
        [JsiiProperty(name: "readOnlyRootFilesystem", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ReadOnlyRootFilesystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>The GID to run the entrypoint of the container process.</summary>
        /// <remarks>
        /// Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#runAsGroup
        /// </remarks>
        [JsiiProperty(name: "runAsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RunAsGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates that the container must run as a non-root user.</summary>
        /// <remarks>
        /// If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#runAsNonRoot
        /// </remarks>
        [JsiiProperty(name: "runAsNonRoot", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RunAsNonRoot
        {
            get
            {
                return null;
            }
        }

        /// <summary>The UID to run the entrypoint of the container process.</summary>
        /// <remarks>
        /// Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Default</strong>: user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#runAsUser
        /// </remarks>
        [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RunAsUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>The seccomp options to use by this container.</summary>
        /// <remarks>
        /// If seccomp options are provided at both the pod &amp; container level, the container options override the pod options. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#seccompProfile
        /// </remarks>
        [JsiiProperty(name: "seccompProfile", typeJson: "{\"fqn\":\"k8s.SeccompProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISeccompProfile? SeccompProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>The SELinux context to be applied to the container.</summary>
        /// <remarks>
        /// If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#seLinuxOptions
        /// </remarks>
        [JsiiProperty(name: "seLinuxOptions", typeJson: "{\"fqn\":\"k8s.SeLinuxOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISeLinuxOptions? SeLinuxOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Windows specific settings applied to all containers.</summary>
        /// <remarks>
        /// If unspecified, the options from the PodSecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#windowsOptions
        /// </remarks>
        [JsiiProperty(name: "windowsOptions", typeJson: "{\"fqn\":\"k8s.WindowsSecurityContextOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IWindowsSecurityContextOptions? WindowsOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>SecurityContext holds security configuration that will be applied to a container.</summary>
        /// <remarks>
        /// Some fields are present in both SecurityContext and PodSecurityContext.  When both are set, the values in SecurityContext take precedence.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISecurityContext), fullyQualifiedName: "k8s.SecurityContext")]
        internal sealed class _Proxy : DeputyBase, K8s.ISecurityContext
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process.</summary>
            /// <remarks>
            /// This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#allowPrivilegeEscalation
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowPrivilegeEscalation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllowPrivilegeEscalation
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>appArmorProfile is the AppArmor options to use by this container.</summary>
            /// <remarks>
            /// If set, this profile overrides the pod's appArmorProfile. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#appArmorProfile
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appArmorProfile", typeJson: "{\"fqn\":\"k8s.AppArmorProfile\"}", isOptional: true)]
            public K8s.IAppArmorProfile? AppArmorProfile
            {
                get => GetInstanceProperty<K8s.IAppArmorProfile?>();
            }

            /// <summary>The capabilities to add/drop when running containers.</summary>
            /// <remarks>
            /// Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Default</strong>: the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#capabilities
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capabilities", typeJson: "{\"fqn\":\"k8s.Capabilities\"}", isOptional: true)]
            public K8s.ICapabilities? Capabilities
            {
                get => GetInstanceProperty<K8s.ICapabilities?>();
            }

            /// <summary>Run container in privileged mode.</summary>
            /// <remarks>
            /// Processes in privileged containers are essentially equivalent to root on the host. Defaults to false. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Default</strong>: false. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#privileged
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privileged", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Privileged
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>procMount denotes the type of proc mount to use for the containers.</summary>
            /// <remarks>
            /// The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#procMount
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "procMount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProcMount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether this container has a read-only root filesystem.</summary>
            /// <remarks>
            /// Default is false. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Default</strong>: false. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#readOnlyRootFilesystem
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnlyRootFilesystem", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnlyRootFilesystem
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>The GID to run the entrypoint of the container process.</summary>
            /// <remarks>
            /// Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#runAsGroup
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runAsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RunAsGroup
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Indicates that the container must run as a non-root user.</summary>
            /// <remarks>
            /// If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#runAsNonRoot
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runAsNonRoot", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RunAsNonRoot
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>The UID to run the entrypoint of the container process.</summary>
            /// <remarks>
            /// Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Default</strong>: user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#runAsUser
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RunAsUser
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The seccomp options to use by this container.</summary>
            /// <remarks>
            /// If seccomp options are provided at both the pod &amp; container level, the container options override the pod options. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#seccompProfile
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "seccompProfile", typeJson: "{\"fqn\":\"k8s.SeccompProfile\"}", isOptional: true)]
            public K8s.ISeccompProfile? SeccompProfile
            {
                get => GetInstanceProperty<K8s.ISeccompProfile?>();
            }

            /// <summary>The SELinux context to be applied to the container.</summary>
            /// <remarks>
            /// If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#seLinuxOptions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "seLinuxOptions", typeJson: "{\"fqn\":\"k8s.SeLinuxOptions\"}", isOptional: true)]
            public K8s.ISeLinuxOptions? SeLinuxOptions
            {
                get => GetInstanceProperty<K8s.ISeLinuxOptions?>();
            }

            /// <summary>The Windows specific settings applied to all containers.</summary>
            /// <remarks>
            /// If unspecified, the options from the PodSecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecurityContext#windowsOptions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "windowsOptions", typeJson: "{\"fqn\":\"k8s.WindowsSecurityContextOptions\"}", isOptional: true)]
            public K8s.IWindowsSecurityContextOptions? WindowsOptions
            {
                get => GetInstanceProperty<K8s.IWindowsSecurityContextOptions?>();
            }
        }
    }
}
