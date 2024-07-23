using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PodSpec is a description of a pod.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PodSpec")]
    public class PodSpec : K8s.IPodSpec
    {
        /// <summary>List of containers belonging to the pod.</summary>
        /// <remarks>
        /// Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#containers
        /// </remarks>
        [JsiiProperty(name: "containers", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Container\"},\"kind\":\"array\"}}")]
        public K8s.IContainer[] Containers
        {
            get;
            set;
        }

        /// <summary>Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers.</summary>
        /// <remarks>
        /// Value must be a positive integer.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#activeDeadlineSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeDeadlineSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ActiveDeadlineSeconds
        {
            get;
            set;
        }

        /// <summary>If specified, the pod's scheduling constraints.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#affinity
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "affinity", typeJson: "{\"fqn\":\"k8s.Affinity\"}", isOptional: true)]
        public K8s.IAffinity? Affinity
        {
            get;
            set;
        }

        /// <summary>AutomountServiceAccountToken indicates whether a service account token should be automatically mounted.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#automountServiceAccountToken
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automountServiceAccountToken", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? AutomountServiceAccountToken
        {
            get;
            set;
        }

        /// <summary>Specifies the DNS parameters of a pod.</summary>
        /// <remarks>
        /// Parameters specified here will be merged to the generated DNS configuration based on DNSPolicy.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#dnsConfig
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dnsConfig", typeJson: "{\"fqn\":\"k8s.PodDnsConfig\"}", isOptional: true)]
        public K8s.IPodDnsConfig? DnsConfig
        {
            get;
            set;
        }

        /// <summary>Set DNS policy for the pod.</summary>
        /// <remarks>
        /// Defaults to "ClusterFirst". Valid values are 'ClusterFirstWithHostNet', 'ClusterFirst', 'Default' or 'None'. DNS parameters given in DNSConfig will be merged with the policy selected with DNSPolicy. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to 'ClusterFirstWithHostNet'.
        ///
        /// <strong>Default</strong>: ClusterFirst". Valid values are 'ClusterFirstWithHostNet', 'ClusterFirst', 'Default' or 'None'. DNS parameters given in DNSConfig will be merged with the policy selected with DNSPolicy. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to 'ClusterFirstWithHostNet'.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#dnsPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dnsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsPolicy
        {
            get;
            set;
        }

        /// <summary>EnableServiceLinks indicates whether information about services should be injected into pod's environment variables, matching the syntax of Docker links.</summary>
        /// <remarks>
        /// Optional: Defaults to true.
        ///
        /// <strong>Default</strong>: true.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#enableServiceLinks
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableServiceLinks", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? EnableServiceLinks
        {
            get;
            set;
        }

        /// <summary>List of ephemeral containers run in this pod.</summary>
        /// <remarks>
        /// Ephemeral containers may be run in an existing pod to perform user-initiated actions such as debugging. This list cannot be specified when creating a pod, and it cannot be modified by updating the pod spec. In order to add an ephemeral container to an existing pod, use the pod's ephemeralcontainers subresource.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#ephemeralContainers
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ephemeralContainers", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EphemeralContainer\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IEphemeralContainer[]? EphemeralContainers
        {
            get;
            set;
        }

        /// <summary>HostAliases is an optional list of hosts and IPs that will be injected into the pod's hosts file if specified.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#hostAliases
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostAliases", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.HostAlias\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IHostAlias[]? HostAliases
        {
            get;
            set;
        }

        /// <summary>Use the host's ipc namespace.</summary>
        /// <remarks>
        /// Optional: Default to false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#hostIPC
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostIpc", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? HostIpc
        {
            get;
            set;
        }

        /// <summary>Specifies the hostname of the Pod If not specified, the pod's hostname will be set to a system-defined value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#hostname
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hostname
        {
            get;
            set;
        }

        /// <summary>Host networking requested for this pod.</summary>
        /// <remarks>
        /// Use the host's network namespace. If this option is set, the ports that will be used must be specified. Default to false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#hostNetwork
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostNetwork", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? HostNetwork
        {
            get;
            set;
        }

        /// <summary>Use the host's pid namespace.</summary>
        /// <remarks>
        /// Optional: Default to false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#hostPID
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostPid", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? HostPid
        {
            get;
            set;
        }

        /// <summary>Use the host's user namespace.</summary>
        /// <remarks>
        /// Optional: Default to true. If set to true or not present, the pod will be run in the host user namespace, useful for when the pod needs a feature only available to the host user namespace, such as loading a kernel module with CAP_SYS_MODULE. When set to false, a new userns is created for the pod. Setting false is useful for mitigating container breakout vulnerabilities even allowing users to run their containers as root without actually having root privileges on the host. This field is alpha-level and is only honored by servers that enable the UserNamespacesSupport feature.
        ///
        /// <strong>Default</strong>: true. If set to true or not present, the pod will be run in the host user namespace, useful for when the pod needs a feature only available to the host user namespace, such as loading a kernel module with CAP_SYS_MODULE. When set to false, a new userns is created for the pod. Setting false is useful for mitigating container breakout vulnerabilities even allowing users to run their containers as root without actually having root privileges on the host. This field is alpha-level and is only honored by servers that enable the UserNamespacesSupport feature.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#hostUsers
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostUsers", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? HostUsers
        {
            get;
            set;
        }

        /// <summary>ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec.</summary>
        /// <remarks>
        /// If specified, these secrets will be passed to individual puller implementations for them to use. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#imagePullSecrets
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imagePullSecrets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.LocalObjectReference\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.ILocalObjectReference[]? ImagePullSecrets
        {
            get;
            set;
        }

        /// <summary>List of initialization containers belonging to the pod.</summary>
        /// <remarks>
        /// Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, Liveness probes, or Startup probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#initContainers
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initContainers", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Container\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IContainer[]? InitContainers
        {
            get;
            set;
        }

        /// <summary>NodeName is a request to schedule this pod onto a specific node.</summary>
        /// <remarks>
        /// If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#nodeName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeName
        {
            get;
            set;
        }

        /// <summary>NodeSelector is a selector which must be true for the pod to fit on a node.</summary>
        /// <remarks>
        /// Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#nodeSelector
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeSelector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? NodeSelector
        {
            get;
            set;
        }

        /// <summary>Specifies the OS of the containers in the pod.</summary>
        /// <remarks>
        /// Some pod and container fields are restricted if this is set.
        ///
        /// If the OS field is set to linux, the following fields must be unset: -securityContext.windowsOptions
        ///
        /// If the OS field is set to windows, following fields must be unset: - spec.hostPID - spec.hostIPC - spec.hostUsers - spec.securityContext.appArmorProfile - spec.securityContext.seLinuxOptions - spec.securityContext.seccompProfile - spec.securityContext.fsGroup - spec.securityContext.fsGroupChangePolicy - spec.securityContext.sysctls - spec.shareProcessNamespace - spec.securityContext.runAsUser - spec.securityContext.runAsGroup - spec.securityContext.supplementalGroups - spec.containers[<em>].securityContext.appArmorProfile - spec.containers[</em>].securityContext.seLinuxOptions - spec.containers[<em>].securityContext.seccompProfile - spec.containers[</em>].securityContext.capabilities - spec.containers[<em>].securityContext.readOnlyRootFilesystem - spec.containers[</em>].securityContext.privileged - spec.containers[<em>].securityContext.allowPrivilegeEscalation - spec.containers[</em>].securityContext.procMount - spec.containers[<em>].securityContext.runAsUser - spec.containers[</em>].securityContext.runAsGroup
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#os
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "os", typeJson: "{\"fqn\":\"k8s.PodOs\"}", isOptional: true)]
        public K8s.IPodOs? Os
        {
            get;
            set;
        }

        /// <summary>Overhead represents the resource overhead associated with running a pod for a given RuntimeClass.</summary>
        /// <remarks>
        /// This field will be autopopulated at admission time by the RuntimeClass admission controller. If the RuntimeClass admission controller is enabled, overhead must not be set in Pod create requests. The RuntimeClass admission controller will reject Pod create requests which have the overhead already set. If RuntimeClass is configured and selected in the PodSpec, Overhead will be set to the value defined in the corresponding RuntimeClass, otherwise it will remain unset and treated as zero. More info: https://git.k8s.io/enhancements/keps/sig-node/688-pod-overhead/README.md
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#overhead
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overhead", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, K8s.Quantity>? Overhead
        {
            get;
            set;
        }

        /// <summary>PreemptionPolicy is the Policy for preempting pods with lower priority.</summary>
        /// <remarks>
        /// One of Never, PreemptLowerPriority. Defaults to PreemptLowerPriority if unset.
        ///
        /// <strong>Default</strong>: PreemptLowerPriority if unset.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#preemptionPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preemptionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreemptionPolicy
        {
            get;
            set;
        }

        /// <summary>The priority value.</summary>
        /// <remarks>
        /// Various system components use this field to find the priority of the pod. When Priority Admission Controller is enabled, it prevents users from setting this field. The admission controller populates this field from PriorityClassName. The higher the value, the higher the priority.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#priority
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>If specified, indicates the pod's priority.</summary>
        /// <remarks>
        /// "system-node-critical" and "system-cluster-critical" are two special keywords which indicate the highest priorities with the former being the highest priority. Any other name must be defined by creating a PriorityClass object with that name. If not specified, the pod priority will be default or zero if there is no default.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#priorityClassName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priorityClassName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PriorityClassName
        {
            get;
            set;
        }

        /// <summary>If specified, all readiness gates will be evaluated for pod readiness.</summary>
        /// <remarks>
        /// A pod is ready when all its containers are ready AND all conditions specified in the readiness gates have status equal to "True" More info: https://git.k8s.io/enhancements/keps/sig-network/580-pod-readiness-gates
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#readinessGates
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readinessGates", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PodReadinessGate\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IPodReadinessGate[]? ReadinessGates
        {
            get;
            set;
        }

        /// <summary>ResourceClaims defines which ResourceClaims must be allocated and reserved before the Pod is allowed to start.</summary>
        /// <remarks>
        /// The resources will be made available to those containers which consume them by name.
        ///
        /// This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.
        ///
        /// This field is immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#resourceClaims
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceClaims", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PodResourceClaim\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IPodResourceClaim[]? ResourceClaims
        {
            get;
            set;
        }

        /// <summary>Restart policy for all containers within the pod.</summary>
        /// <remarks>
        /// One of Always, OnFailure, Never. In some contexts, only a subset of those values may be permitted. Default to Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy
        ///
        /// <strong>Default</strong>: Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#restartPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "restartPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RestartPolicy
        {
            get;
            set;
        }

        /// <summary>RuntimeClassName refers to a RuntimeClass object in the node.k8s.io group, which should be used to run this pod.  If no RuntimeClass resource matches the named class, the pod will not be run. If unset or empty, the "legacy" RuntimeClass will be used, which is an implicit class with an empty definition that uses the default runtime handler. More info: https://git.k8s.io/enhancements/keps/sig-node/585-runtime-class.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#runtimeClassName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeClassName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RuntimeClassName
        {
            get;
            set;
        }

        /// <summary>If specified, the pod will be dispatched by specified scheduler.</summary>
        /// <remarks>
        /// If not specified, the pod will be dispatched by default scheduler.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#schedulerName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schedulerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SchedulerName
        {
            get;
            set;
        }

        /// <summary>SchedulingGates is an opaque list of values that if specified will block scheduling the pod.</summary>
        /// <remarks>
        /// If schedulingGates is not empty, the pod will stay in the SchedulingGated state and the scheduler will not attempt to schedule the pod.
        ///
        /// SchedulingGates can only be set at pod creation time, and be removed only afterwards.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#schedulingGates
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schedulingGates", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PodSchedulingGate\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IPodSchedulingGate[]? SchedulingGates
        {
            get;
            set;
        }

        /// <summary>SecurityContext holds pod-level security attributes and common container settings.</summary>
        /// <remarks>
        /// Optional: Defaults to empty.  See type description for default values of each field.
        ///
        /// <strong>Default</strong>: empty.  See type description for default values of each field.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#securityContext
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "securityContext", typeJson: "{\"fqn\":\"k8s.PodSecurityContext\"}", isOptional: true)]
        public K8s.IPodSecurityContext? SecurityContext
        {
            get;
            set;
        }

        /// <summary>DeprecatedServiceAccount is a deprecated alias for ServiceAccountName.</summary>
        /// <remarks>
        /// Deprecated: Use serviceAccountName instead.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#serviceAccount
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccount
        {
            get;
            set;
        }

        /// <summary>ServiceAccountName is the name of the ServiceAccount to use to run this pod.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#serviceAccountName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccountName
        {
            get;
            set;
        }

        /// <summary>If true the pod's hostname will be configured as the pod's FQDN, rather than the leaf name (the default).</summary>
        /// <remarks>
        /// In Linux containers, this means setting the FQDN in the hostname field of the kernel (the nodename field of struct utsname). In Windows containers, this means setting the registry value of hostname for the registry key HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters to FQDN. If a pod does not have FQDN, this has no effect. Default to false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#setHostnameAsFQDN
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setHostnameAsFqdn", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? SetHostnameAsFqdn
        {
            get;
            set;
        }

        /// <summary>Share a single process namespace between all of the containers in a pod.</summary>
        /// <remarks>
        /// When this is set containers will be able to view and signal processes from other containers in the same pod, and the first process in each container will not be assigned PID 1. HostPID and ShareProcessNamespace cannot both be set. Optional: Default to false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#shareProcessNamespace
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shareProcessNamespace", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ShareProcessNamespace
        {
            get;
            set;
        }

        /// <summary>If specified, the fully qualified Pod hostname will be "&lt;hostname&gt;.&lt;subdomain&gt;.&lt;pod namespace&gt;.svc.&lt;cluster domain&gt;". If not specified, the pod will not have a domainname at all.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#subdomain
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subdomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Subdomain
        {
            get;
            set;
        }

        /// <summary>Optional duration in seconds the pod needs to terminate gracefully.</summary>
        /// <remarks>
        /// May be decreased in delete request. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.
        ///
        /// <strong>Default</strong>: 30 seconds.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#terminationGracePeriodSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "terminationGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TerminationGracePeriodSeconds
        {
            get;
            set;
        }

        /// <summary>If specified, the pod's tolerations.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#tolerations
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tolerations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Toleration\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IToleration[]? Tolerations
        {
            get;
            set;
        }

        /// <summary>TopologySpreadConstraints describes how a group of pods ought to spread across topology domains.</summary>
        /// <remarks>
        /// Scheduler will schedule pods in a way which abides by the constraints. All topologySpreadConstraints are ANDed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#topologySpreadConstraints
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "topologySpreadConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.TopologySpreadConstraint\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.ITopologySpreadConstraint[]? TopologySpreadConstraints
        {
            get;
            set;
        }

        /// <summary>List of volumes that can be mounted by containers belonging to the pod.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSpec#volumes
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Volume\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IVolume[]? Volumes
        {
            get;
            set;
        }
    }
}
