using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>A single application container that you want to run within a pod.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Container
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IContainer), fullyQualifiedName: "k8s.Container")]
    public interface IContainer
    {
        /// <summary>Name of the container specified as a DNS_LABEL.</summary>
        /// <remarks>
        /// Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Arguments to the entrypoint.</summary>
        /// <remarks>
        /// The container image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#args
        /// </remarks>
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Args
        {
            get
            {
                return null;
            }
        }

        /// <summary>Entrypoint array.</summary>
        /// <remarks>
        /// Not executed within a shell. The container image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#command
        /// </remarks>
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Command
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of environment variables to set in the container.</summary>
        /// <remarks>
        /// Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#env
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EnvVar\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IEnvVar[]? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of sources to populate environment variables in the container.</summary>
        /// <remarks>
        /// The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#envFrom
        /// </remarks>
        [JsiiProperty(name: "envFrom", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EnvFromSource\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IEnvFromSource[]? EnvFrom
        {
            get
            {
                return null;
            }
        }

        /// <summary>Container image name.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#image
        /// </remarks>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Image
        {
            get
            {
                return null;
            }
        }

        /// <summary>Image pull policy.</summary>
        /// <remarks>
        /// One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images
        ///
        /// <strong>Default</strong>: Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#imagePullPolicy
        /// </remarks>
        [JsiiProperty(name: "imagePullPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImagePullPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Actions that the management system should take in response to container lifecycle events.</summary>
        /// <remarks>
        /// Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#lifecycle
        /// </remarks>
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"k8s.Lifecycle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILifecycle? Lifecycle
        {
            get
            {
                return null;
            }
        }

        /// <summary>Periodic probe of container liveness.</summary>
        /// <remarks>
        /// Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#livenessProbe
        /// </remarks>
        [JsiiProperty(name: "livenessProbe", typeJson: "{\"fqn\":\"k8s.Probe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IProbe? LivenessProbe
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of ports to expose from the container.</summary>
        /// <remarks>
        /// Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default "0.0.0.0" address inside a container will be accessible from the network. Modifying this array with strategic merge patch may corrupt the data. For more information See https://github.com/kubernetes/kubernetes/issues/108255. Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#ports
        /// </remarks>
        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ContainerPort\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IContainerPort[]? Ports
        {
            get
            {
                return null;
            }
        }

        /// <summary>Periodic probe of container service readiness.</summary>
        /// <remarks>
        /// Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#readinessProbe
        /// </remarks>
        [JsiiProperty(name: "readinessProbe", typeJson: "{\"fqn\":\"k8s.Probe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IProbe? ReadinessProbe
        {
            get
            {
                return null;
            }
        }

        /// <summary>Resources resize policy for the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#resizePolicy
        /// </remarks>
        [JsiiProperty(name: "resizePolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ContainerResizePolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IContainerResizePolicy[]? ResizePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Compute Resources required by this container.</summary>
        /// <remarks>
        /// Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#resources
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"k8s.ResourceRequirements\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IResourceRequirements? Resources
        {
            get
            {
                return null;
            }
        }

        /// <summary>RestartPolicy defines the restart behavior of individual containers in a pod.</summary>
        /// <remarks>
        /// This field may only be set for init containers, and the only allowed value is "Always". For non-init containers or when this field is not specified, the restart behavior is defined by the Pod's restart policy and the container type. Setting the RestartPolicy as "Always" for the init container will have the following effect: this init container will be continually restarted on exit until all regular containers have terminated. Once all regular containers have completed, all init containers with restartPolicy "Always" will be shut down. This lifecycle differs from normal init containers and is often referred to as a "sidecar" container. Although this init container still starts in the init container sequence, it does not wait for the container to complete before proceeding to the next init container. Instead, the next init container starts immediately after this init container is started, or after any startupProbe has successfully completed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#restartPolicy
        /// </remarks>
        [JsiiProperty(name: "restartPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RestartPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>SecurityContext defines the security options the container should be run with.</summary>
        /// <remarks>
        /// If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext. More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#securityContext
        /// </remarks>
        [JsiiProperty(name: "securityContext", typeJson: "{\"fqn\":\"k8s.SecurityContext\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISecurityContext? SecurityContext
        {
            get
            {
                return null;
            }
        }

        /// <summary>StartupProbe indicates that the Pod has successfully initialized.</summary>
        /// <remarks>
        /// If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a Pod's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#startupProbe
        /// </remarks>
        [JsiiProperty(name: "startupProbe", typeJson: "{\"fqn\":\"k8s.Probe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IProbe? StartupProbe
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this container should allocate a buffer for stdin in the container runtime.</summary>
        /// <remarks>
        /// If this is not set, reads from stdin in the container will always result in EOF. Default is false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#stdin
        /// </remarks>
        [JsiiProperty(name: "stdin", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Stdin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the container runtime should close the stdin channel after it has been opened by a single attach.</summary>
        /// <remarks>
        /// When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false
        ///
        /// <strong>Default</strong>: false
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#stdinOnce
        /// </remarks>
        [JsiiProperty(name: "stdinOnce", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? StdinOnce
        {
            get
            {
                return null;
            }
        }

        /// <summary>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem.</summary>
        /// <remarks>
        /// Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.
        ///
        /// <strong>Default</strong>: dev/termination-log. Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#terminationMessagePath
        /// </remarks>
        [JsiiProperty(name: "terminationMessagePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TerminationMessagePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicate how the termination message should be populated.</summary>
        /// <remarks>
        /// File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.
        ///
        /// <strong>Default</strong>: File. Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#terminationMessagePolicy
        /// </remarks>
        [JsiiProperty(name: "terminationMessagePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TerminationMessagePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this container should allocate a TTY for itself, also requires 'stdin' to be true.</summary>
        /// <remarks>
        /// Default is false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#tty
        /// </remarks>
        [JsiiProperty(name: "tty", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Tty
        {
            get
            {
                return null;
            }
        }

        /// <summary>volumeDevices is the list of block devices to be used by the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#volumeDevices
        /// </remarks>
        [JsiiProperty(name: "volumeDevices", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.VolumeDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IVolumeDevice[]? VolumeDevices
        {
            get
            {
                return null;
            }
        }

        /// <summary>Pod volumes to mount into the container's filesystem.</summary>
        /// <remarks>
        /// Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#volumeMounts
        /// </remarks>
        [JsiiProperty(name: "volumeMounts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.VolumeMount\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IVolumeMount[]? VolumeMounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Container's working directory.</summary>
        /// <remarks>
        /// If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#workingDir
        /// </remarks>
        [JsiiProperty(name: "workingDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkingDir
        {
            get
            {
                return null;
            }
        }

        /// <summary>A single application container that you want to run within a pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Container
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IContainer), fullyQualifiedName: "k8s.Container")]
        internal sealed class _Proxy : DeputyBase, K8s.IContainer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the container specified as a DNS_LABEL.</summary>
            /// <remarks>
            /// Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Arguments to the entrypoint.</summary>
            /// <remarks>
            /// The container image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#args
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Args
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Entrypoint array.</summary>
            /// <remarks>
            /// Not executed within a shell. The container image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#command
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Command
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>List of environment variables to set in the container.</summary>
            /// <remarks>
            /// Cannot be updated.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#env
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EnvVar\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IEnvVar[]? Env
            {
                get => GetInstanceProperty<K8s.IEnvVar[]?>();
            }

            /// <summary>List of sources to populate environment variables in the container.</summary>
            /// <remarks>
            /// The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#envFrom
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "envFrom", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EnvFromSource\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IEnvFromSource[]? EnvFrom
            {
                get => GetInstanceProperty<K8s.IEnvFromSource[]?>();
            }

            /// <summary>Container image name.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#image
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Image
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Image pull policy.</summary>
            /// <remarks>
            /// One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images
            ///
            /// <strong>Default</strong>: Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#imagePullPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imagePullPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImagePullPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Actions that the management system should take in response to container lifecycle events.</summary>
            /// <remarks>
            /// Cannot be updated.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#lifecycle
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"k8s.Lifecycle\"}", isOptional: true)]
            public K8s.ILifecycle? Lifecycle
            {
                get => GetInstanceProperty<K8s.ILifecycle?>();
            }

            /// <summary>Periodic probe of container liveness.</summary>
            /// <remarks>
            /// Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#livenessProbe
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "livenessProbe", typeJson: "{\"fqn\":\"k8s.Probe\"}", isOptional: true)]
            public K8s.IProbe? LivenessProbe
            {
                get => GetInstanceProperty<K8s.IProbe?>();
            }

            /// <summary>List of ports to expose from the container.</summary>
            /// <remarks>
            /// Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default "0.0.0.0" address inside a container will be accessible from the network. Modifying this array with strategic merge patch may corrupt the data. For more information See https://github.com/kubernetes/kubernetes/issues/108255. Cannot be updated.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#ports
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ContainerPort\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IContainerPort[]? Ports
            {
                get => GetInstanceProperty<K8s.IContainerPort[]?>();
            }

            /// <summary>Periodic probe of container service readiness.</summary>
            /// <remarks>
            /// Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#readinessProbe
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readinessProbe", typeJson: "{\"fqn\":\"k8s.Probe\"}", isOptional: true)]
            public K8s.IProbe? ReadinessProbe
            {
                get => GetInstanceProperty<K8s.IProbe?>();
            }

            /// <summary>Resources resize policy for the container.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#resizePolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resizePolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ContainerResizePolicy\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IContainerResizePolicy[]? ResizePolicy
            {
                get => GetInstanceProperty<K8s.IContainerResizePolicy[]?>();
            }

            /// <summary>Compute Resources required by this container.</summary>
            /// <remarks>
            /// Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#resources
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"k8s.ResourceRequirements\"}", isOptional: true)]
            public K8s.IResourceRequirements? Resources
            {
                get => GetInstanceProperty<K8s.IResourceRequirements?>();
            }

            /// <summary>RestartPolicy defines the restart behavior of individual containers in a pod.</summary>
            /// <remarks>
            /// This field may only be set for init containers, and the only allowed value is "Always". For non-init containers or when this field is not specified, the restart behavior is defined by the Pod's restart policy and the container type. Setting the RestartPolicy as "Always" for the init container will have the following effect: this init container will be continually restarted on exit until all regular containers have terminated. Once all regular containers have completed, all init containers with restartPolicy "Always" will be shut down. This lifecycle differs from normal init containers and is often referred to as a "sidecar" container. Although this init container still starts in the init container sequence, it does not wait for the container to complete before proceeding to the next init container. Instead, the next init container starts immediately after this init container is started, or after any startupProbe has successfully completed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#restartPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "restartPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RestartPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>SecurityContext defines the security options the container should be run with.</summary>
            /// <remarks>
            /// If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext. More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#securityContext
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityContext", typeJson: "{\"fqn\":\"k8s.SecurityContext\"}", isOptional: true)]
            public K8s.ISecurityContext? SecurityContext
            {
                get => GetInstanceProperty<K8s.ISecurityContext?>();
            }

            /// <summary>StartupProbe indicates that the Pod has successfully initialized.</summary>
            /// <remarks>
            /// If specified, no other probes are executed until this completes successfully. If this probe fails, the Pod will be restarted, just as if the livenessProbe failed. This can be used to provide different probe parameters at the beginning of a Pod's lifecycle, when it might take a long time to load data or warm a cache, than during steady-state operation. This cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#startupProbe
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startupProbe", typeJson: "{\"fqn\":\"k8s.Probe\"}", isOptional: true)]
            public K8s.IProbe? StartupProbe
            {
                get => GetInstanceProperty<K8s.IProbe?>();
            }

            /// <summary>Whether this container should allocate a buffer for stdin in the container runtime.</summary>
            /// <remarks>
            /// If this is not set, reads from stdin in the container will always result in EOF. Default is false.
            ///
            /// <strong>Default</strong>: false.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#stdin
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stdin", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Stdin
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>Whether the container runtime should close the stdin channel after it has been opened by a single attach.</summary>
            /// <remarks>
            /// When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false
            ///
            /// <strong>Default</strong>: false
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#stdinOnce
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stdinOnce", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? StdinOnce
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem.</summary>
            /// <remarks>
            /// Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.
            ///
            /// <strong>Default</strong>: dev/termination-log. Cannot be updated.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#terminationMessagePath
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "terminationMessagePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TerminationMessagePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicate how the termination message should be populated.</summary>
            /// <remarks>
            /// File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.
            ///
            /// <strong>Default</strong>: File. Cannot be updated.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#terminationMessagePolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "terminationMessagePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TerminationMessagePolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether this container should allocate a TTY for itself, also requires 'stdin' to be true.</summary>
            /// <remarks>
            /// Default is false.
            ///
            /// <strong>Default</strong>: false.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#tty
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tty", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Tty
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>volumeDevices is the list of block devices to be used by the container.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#volumeDevices
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeDevices", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.VolumeDevice\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IVolumeDevice[]? VolumeDevices
            {
                get => GetInstanceProperty<K8s.IVolumeDevice[]?>();
            }

            /// <summary>Pod volumes to mount into the container's filesystem.</summary>
            /// <remarks>
            /// Cannot be updated.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#volumeMounts
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeMounts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.VolumeMount\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IVolumeMount[]? VolumeMounts
            {
                get => GetInstanceProperty<K8s.IVolumeMount[]?>();
            }

            /// <summary>Container's working directory.</summary>
            /// <remarks>
            /// If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Container#workingDir
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workingDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkingDir
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
