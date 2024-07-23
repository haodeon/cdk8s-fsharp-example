using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>An EphemeralContainer is a temporary container that you may add to an existing Pod for user-initiated activities such as debugging.</summary>
    /// <remarks>
    /// Ephemeral containers have no resource or scheduling guarantees, and they will not be restarted when they exit or when a Pod is removed or restarted. The kubelet may evict a Pod if an ephemeral container causes the Pod to exceed its resource allocation.
    ///
    /// To add an ephemeral container, use the ephemeralcontainers subresource of an existing Pod. Ephemeral containers may not be removed or restarted.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer
    /// </remarks>
    [JsiiByValue(fqn: "k8s.EphemeralContainer")]
    public class EphemeralContainer : K8s.IEphemeralContainer
    {
        /// <summary>Name of the ephemeral container specified as a DNS_LABEL.</summary>
        /// <remarks>
        /// This name must be unique among all containers, init containers and ephemeral containers.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Arguments to the entrypoint.</summary>
        /// <remarks>
        /// The image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#args
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Args
        {
            get;
            set;
        }

        /// <summary>Entrypoint array.</summary>
        /// <remarks>
        /// Not executed within a shell. The image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#command
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Command
        {
            get;
            set;
        }

        /// <summary>List of environment variables to set in the container.</summary>
        /// <remarks>
        /// Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#env
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "env", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EnvVar\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IEnvVar[]? Env
        {
            get;
            set;
        }

        /// <summary>List of sources to populate environment variables in the container.</summary>
        /// <remarks>
        /// The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#envFrom
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "envFrom", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EnvFromSource\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IEnvFromSource[]? EnvFrom
        {
            get;
            set;
        }

        /// <summary>Container image name.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/containers/images
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#image
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Image
        {
            get;
            set;
        }

        /// <summary>Image pull policy.</summary>
        /// <remarks>
        /// One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images
        ///
        /// <strong>Default</strong>: Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#imagePullPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imagePullPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImagePullPolicy
        {
            get;
            set;
        }

        /// <summary>Lifecycle is not allowed for ephemeral containers.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#lifecycle
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"k8s.Lifecycle\"}", isOptional: true)]
        public K8s.ILifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <summary>Probes are not allowed for ephemeral containers.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#livenessProbe
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "livenessProbe", typeJson: "{\"fqn\":\"k8s.Probe\"}", isOptional: true)]
        public K8s.IProbe? LivenessProbe
        {
            get;
            set;
        }

        /// <summary>Ports are not allowed for ephemeral containers.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#ports
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ContainerPort\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IContainerPort[]? Ports
        {
            get;
            set;
        }

        /// <summary>Probes are not allowed for ephemeral containers.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#readinessProbe
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readinessProbe", typeJson: "{\"fqn\":\"k8s.Probe\"}", isOptional: true)]
        public K8s.IProbe? ReadinessProbe
        {
            get;
            set;
        }

        /// <summary>Resources resize policy for the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#resizePolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resizePolicy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ContainerResizePolicy\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IContainerResizePolicy[]? ResizePolicy
        {
            get;
            set;
        }

        /// <summary>Resources are not allowed for ephemeral containers.</summary>
        /// <remarks>
        /// Ephemeral containers use spare resources already allocated to the pod.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#resources
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"k8s.ResourceRequirements\"}", isOptional: true)]
        public K8s.IResourceRequirements? Resources
        {
            get;
            set;
        }

        /// <summary>Restart policy for the container to manage the restart behavior of each container within a pod.</summary>
        /// <remarks>
        /// This may only be set for init containers. You cannot set this field on ephemeral containers.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#restartPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "restartPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RestartPolicy
        {
            get;
            set;
        }

        /// <summary>Optional: SecurityContext defines the security options the ephemeral container should be run with.</summary>
        /// <remarks>
        /// If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#securityContext
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "securityContext", typeJson: "{\"fqn\":\"k8s.SecurityContext\"}", isOptional: true)]
        public K8s.ISecurityContext? SecurityContext
        {
            get;
            set;
        }

        /// <summary>Probes are not allowed for ephemeral containers.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#startupProbe
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startupProbe", typeJson: "{\"fqn\":\"k8s.Probe\"}", isOptional: true)]
        public K8s.IProbe? StartupProbe
        {
            get;
            set;
        }

        /// <summary>Whether this container should allocate a buffer for stdin in the container runtime.</summary>
        /// <remarks>
        /// If this is not set, reads from stdin in the container will always result in EOF. Default is false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#stdin
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stdin", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Stdin
        {
            get;
            set;
        }

        /// <summary>Whether the container runtime should close the stdin channel after it has been opened by a single attach.</summary>
        /// <remarks>
        /// When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false
        ///
        /// <strong>Default</strong>: false
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#stdinOnce
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stdinOnce", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? StdinOnce
        {
            get;
            set;
        }

        /// <summary>If set, the name of the container from PodSpec that this ephemeral container targets.</summary>
        /// <remarks>
        /// The ephemeral container will be run in the namespaces (IPC, PID, etc) of this container. If not set then the ephemeral container uses the namespaces configured in the Pod spec.
        ///
        /// The container runtime must implement support for this feature. If the runtime does not support namespace targeting then the result of setting this field is undefined.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#targetContainerName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetContainerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetContainerName
        {
            get;
            set;
        }

        /// <summary>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem.</summary>
        /// <remarks>
        /// Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.
        ///
        /// <strong>Default</strong>: dev/termination-log. Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#terminationMessagePath
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "terminationMessagePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TerminationMessagePath
        {
            get;
            set;
        }

        /// <summary>Indicate how the termination message should be populated.</summary>
        /// <remarks>
        /// File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.
        ///
        /// <strong>Default</strong>: File. Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#terminationMessagePolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "terminationMessagePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TerminationMessagePolicy
        {
            get;
            set;
        }

        /// <summary>Whether this container should allocate a TTY for itself, also requires 'stdin' to be true.</summary>
        /// <remarks>
        /// Default is false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#tty
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tty", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Tty
        {
            get;
            set;
        }

        /// <summary>volumeDevices is the list of block devices to be used by the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#volumeDevices
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeDevices", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.VolumeDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IVolumeDevice[]? VolumeDevices
        {
            get;
            set;
        }

        /// <summary>Pod volumes to mount into the container's filesystem.</summary>
        /// <remarks>
        /// Subpath mounts are not allowed for ephemeral containers. Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#volumeMounts
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeMounts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.VolumeMount\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IVolumeMount[]? VolumeMounts
        {
            get;
            set;
        }

        /// <summary>Container's working directory.</summary>
        /// <remarks>
        /// If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralContainer#workingDir
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workingDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkingDir
        {
            get;
            set;
        }
    }
}
