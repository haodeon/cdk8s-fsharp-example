using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodSecurityContext holds pod-level security attributes and common container settings.</summary>
    /// <remarks>
    /// Some fields are also present in container.securityContext.  Field values of container.securityContext take precedence over field values of PodSecurityContext.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPodSecurityContext), fullyQualifiedName: "k8s.PodSecurityContext")]
    public interface IPodSecurityContext
    {
        /// <summary>appArmorProfile is the AppArmor options to use by the containers in this pod.</summary>
        /// <remarks>
        /// Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#appArmorProfile
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

        /// <summary>A special supplemental group that applies to all containers in a pod.</summary>
        /// <remarks>
        /// Some volume types allow the Kubelet to change the ownership of that volume to be owned by the pod:
        ///
        /// <list type="number">
        /// <description>The owning GID will be the FSGroup 2. The setgid bit is set (new files created in the volume will be owned by FSGroup) 3. The permission bits are OR'd with rw-rw----</description>
        /// </list>
        ///
        /// If unset, the Kubelet will not modify the ownership and permissions of any volume. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#fsGroup
        /// </remarks>
        [JsiiProperty(name: "fsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FsGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>fsGroupChangePolicy defines behavior of changing ownership and permission of the volume before being exposed inside Pod.</summary>
        /// <remarks>
        /// This field will only apply to volume types which support fsGroup based ownership(and permissions). It will have no effect on ephemeral volume types such as: secret, configmaps and emptydir. Valid values are "OnRootMismatch" and "Always". If not specified, "Always" is used. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#fsGroupChangePolicy
        /// </remarks>
        [JsiiProperty(name: "fsGroupChangePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FsGroupChangePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>The GID to run the entrypoint of the container process.</summary>
        /// <remarks>
        /// Uses runtime default if unset. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#runAsGroup
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
        /// If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#runAsNonRoot
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
        /// Defaults to user specified in image metadata if unspecified. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Default</strong>: user specified in image metadata if unspecified. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#runAsUser
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

        /// <summary>The seccomp options to use by the containers in this pod.</summary>
        /// <remarks>
        /// Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#seccompProfile
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

        /// <summary>The SELinux context to be applied to all containers.</summary>
        /// <remarks>
        /// If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#seLinuxOptions
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

        /// <summary>A list of groups applied to the first process run in each container, in addition to the container's primary GID, the fsGroup (if specified), and group memberships defined in the container image for the uid of the container process.</summary>
        /// <remarks>
        /// If unspecified, no additional groups are added to any container. Note that group memberships defined in the container image for the uid of the container process are still effective, even if they are not included in this list. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#supplementalGroups
        /// </remarks>
        [JsiiProperty(name: "supplementalGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? SupplementalGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sysctls hold a list of namespaced sysctls used for the pod.</summary>
        /// <remarks>
        /// Pods with unsupported sysctls (by the container runtime) might fail to launch. Note that this field cannot be set when spec.os.name is windows.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#sysctls
        /// </remarks>
        [JsiiProperty(name: "sysctls", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Sysctl\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISysctl[]? Sysctls
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Windows specific settings applied to all containers.</summary>
        /// <remarks>
        /// If unspecified, the options within a container's SecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#windowsOptions
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

        /// <summary>PodSecurityContext holds pod-level security attributes and common container settings.</summary>
        /// <remarks>
        /// Some fields are also present in container.securityContext.  Field values of container.securityContext take precedence over field values of PodSecurityContext.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPodSecurityContext), fullyQualifiedName: "k8s.PodSecurityContext")]
        internal sealed class _Proxy : DeputyBase, K8s.IPodSecurityContext
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>appArmorProfile is the AppArmor options to use by the containers in this pod.</summary>
            /// <remarks>
            /// Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#appArmorProfile
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appArmorProfile", typeJson: "{\"fqn\":\"k8s.AppArmorProfile\"}", isOptional: true)]
            public K8s.IAppArmorProfile? AppArmorProfile
            {
                get => GetInstanceProperty<K8s.IAppArmorProfile?>();
            }

            /// <summary>A special supplemental group that applies to all containers in a pod.</summary>
            /// <remarks>
            /// Some volume types allow the Kubelet to change the ownership of that volume to be owned by the pod:
            ///
            /// <list type="number">
            /// <description>The owning GID will be the FSGroup 2. The setgid bit is set (new files created in the volume will be owned by FSGroup) 3. The permission bits are OR'd with rw-rw----</description>
            /// </list>
            ///
            /// If unset, the Kubelet will not modify the ownership and permissions of any volume. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#fsGroup
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FsGroup
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>fsGroupChangePolicy defines behavior of changing ownership and permission of the volume before being exposed inside Pod.</summary>
            /// <remarks>
            /// This field will only apply to volume types which support fsGroup based ownership(and permissions). It will have no effect on ephemeral volume types such as: secret, configmaps and emptydir. Valid values are "OnRootMismatch" and "Always". If not specified, "Always" is used. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#fsGroupChangePolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fsGroupChangePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FsGroupChangePolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The GID to run the entrypoint of the container process.</summary>
            /// <remarks>
            /// Uses runtime default if unset. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#runAsGroup
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runAsGroup", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RunAsGroup
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Indicates that the container must run as a non-root user.</summary>
            /// <remarks>
            /// If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#runAsNonRoot
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runAsNonRoot", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RunAsNonRoot
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>The UID to run the entrypoint of the container process.</summary>
            /// <remarks>
            /// Defaults to user specified in image metadata if unspecified. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Default</strong>: user specified in image metadata if unspecified. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#runAsUser
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runAsUser", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RunAsUser
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The seccomp options to use by the containers in this pod.</summary>
            /// <remarks>
            /// Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#seccompProfile
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "seccompProfile", typeJson: "{\"fqn\":\"k8s.SeccompProfile\"}", isOptional: true)]
            public K8s.ISeccompProfile? SeccompProfile
            {
                get => GetInstanceProperty<K8s.ISeccompProfile?>();
            }

            /// <summary>The SELinux context to be applied to all containers.</summary>
            /// <remarks>
            /// If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#seLinuxOptions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "seLinuxOptions", typeJson: "{\"fqn\":\"k8s.SeLinuxOptions\"}", isOptional: true)]
            public K8s.ISeLinuxOptions? SeLinuxOptions
            {
                get => GetInstanceProperty<K8s.ISeLinuxOptions?>();
            }

            /// <summary>A list of groups applied to the first process run in each container, in addition to the container's primary GID, the fsGroup (if specified), and group memberships defined in the container image for the uid of the container process.</summary>
            /// <remarks>
            /// If unspecified, no additional groups are added to any container. Note that group memberships defined in the container image for the uid of the container process are still effective, even if they are not included in this list. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#supplementalGroups
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "supplementalGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? SupplementalGroups
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Sysctls hold a list of namespaced sysctls used for the pod.</summary>
            /// <remarks>
            /// Pods with unsupported sysctls (by the container runtime) might fail to launch. Note that this field cannot be set when spec.os.name is windows.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#sysctls
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysctls", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Sysctl\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.ISysctl[]? Sysctls
            {
                get => GetInstanceProperty<K8s.ISysctl[]?>();
            }

            /// <summary>The Windows specific settings applied to all containers.</summary>
            /// <remarks>
            /// If unspecified, the options within a container's SecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSecurityContext#windowsOptions
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
