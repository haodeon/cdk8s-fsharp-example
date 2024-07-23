using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive traffic.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe
    /// </remarks>
    [JsiiByValue(fqn: "k8s.Probe")]
    public class Probe : K8s.IProbe
    {
        /// <summary>Exec specifies the action to take.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#exec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exec", typeJson: "{\"fqn\":\"k8s.ExecAction\"}", isOptional: true)]
        public K8s.IExecAction? Exec
        {
            get;
            set;
        }

        /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded.</summary>
        /// <remarks>
        /// Defaults to 3. Minimum value is 1.
        ///
        /// <strong>Default</strong>: 3. Minimum value is 1.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#failureThreshold
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }

        /// <summary>GRPC specifies an action involving a GRPC port.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#grpc
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"k8s.GrpcAction\"}", isOptional: true)]
        public K8s.IGrpcAction? Grpc
        {
            get;
            set;
        }

        /// <summary>HTTPGet specifies the http request to perform.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#httpGet
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpGet", typeJson: "{\"fqn\":\"k8s.HttpGetAction\"}", isOptional: true)]
        public K8s.IHttpGetAction? HttpGet
        {
            get;
            set;
        }

        /// <summary>Number of seconds after the container has started before liveness probes are initiated.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#initialDelaySeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initialDelaySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InitialDelaySeconds
        {
            get;
            set;
        }

        /// <summary>How often (in seconds) to perform the probe.</summary>
        /// <remarks>
        /// Default to 10 seconds. Minimum value is 1.
        ///
        /// <strong>Default</strong>: 10 seconds. Minimum value is 1.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#periodSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "periodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PeriodSeconds
        {
            get;
            set;
        }

        /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed.</summary>
        /// <remarks>
        /// Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.
        ///
        /// <strong>Default</strong>: 1. Must be 1 for liveness and startup. Minimum value is 1.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#successThreshold
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "successThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SuccessThreshold
        {
            get;
            set;
        }

        /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#tcpSocket
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpSocket", typeJson: "{\"fqn\":\"k8s.TcpSocketAction\"}", isOptional: true)]
        public K8s.ITcpSocketAction? TcpSocket
        {
            get;
            set;
        }

        /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure.</summary>
        /// <remarks>
        /// The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#terminationGracePeriodSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "terminationGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TerminationGracePeriodSeconds
        {
            get;
            set;
        }

        /// <summary>Number of seconds after which the probe times out.</summary>
        /// <remarks>
        /// Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        ///
        /// <strong>Default</strong>: 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#timeoutSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutSeconds
        {
            get;
            set;
        }
    }
}
