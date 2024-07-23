using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive traffic.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IProbe), fullyQualifiedName: "k8s.Probe")]
    public interface IProbe
    {
        /// <summary>Exec specifies the action to take.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#exec
        /// </remarks>
        [JsiiProperty(name: "exec", typeJson: "{\"fqn\":\"k8s.ExecAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IExecAction? Exec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded.</summary>
        /// <remarks>
        /// Defaults to 3. Minimum value is 1.
        ///
        /// <strong>Default</strong>: 3. Minimum value is 1.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#failureThreshold
        /// </remarks>
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailureThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>GRPC specifies an action involving a GRPC port.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#grpc
        /// </remarks>
        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"k8s.GrpcAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IGrpcAction? Grpc
        {
            get
            {
                return null;
            }
        }

        /// <summary>HTTPGet specifies the http request to perform.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#httpGet
        /// </remarks>
        [JsiiProperty(name: "httpGet", typeJson: "{\"fqn\":\"k8s.HttpGetAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IHttpGetAction? HttpGet
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of seconds after the container has started before liveness probes are initiated.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#initialDelaySeconds
        /// </remarks>
        [JsiiProperty(name: "initialDelaySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InitialDelaySeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>How often (in seconds) to perform the probe.</summary>
        /// <remarks>
        /// Default to 10 seconds. Minimum value is 1.
        ///
        /// <strong>Default</strong>: 10 seconds. Minimum value is 1.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#periodSeconds
        /// </remarks>
        [JsiiProperty(name: "periodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PeriodSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed.</summary>
        /// <remarks>
        /// Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.
        ///
        /// <strong>Default</strong>: 1. Must be 1 for liveness and startup. Minimum value is 1.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#successThreshold
        /// </remarks>
        [JsiiProperty(name: "successThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SuccessThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#tcpSocket
        /// </remarks>
        [JsiiProperty(name: "tcpSocket", typeJson: "{\"fqn\":\"k8s.TcpSocketAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ITcpSocketAction? TcpSocket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Optional duration in seconds the pod needs to terminate gracefully upon probe failure.</summary>
        /// <remarks>
        /// The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#terminationGracePeriodSeconds
        /// </remarks>
        [JsiiProperty(name: "terminationGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TerminationGracePeriodSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of seconds after which the probe times out.</summary>
        /// <remarks>
        /// Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        ///
        /// <strong>Default</strong>: 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#timeoutSeconds
        /// </remarks>
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive traffic.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IProbe), fullyQualifiedName: "k8s.Probe")]
        internal sealed class _Proxy : DeputyBase, K8s.IProbe
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Exec specifies the action to take.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#exec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exec", typeJson: "{\"fqn\":\"k8s.ExecAction\"}", isOptional: true)]
            public K8s.IExecAction? Exec
            {
                get => GetInstanceProperty<K8s.IExecAction?>();
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
                get => GetInstanceProperty<double?>();
            }

            /// <summary>GRPC specifies an action involving a GRPC port.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#grpc
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"k8s.GrpcAction\"}", isOptional: true)]
            public K8s.IGrpcAction? Grpc
            {
                get => GetInstanceProperty<K8s.IGrpcAction?>();
            }

            /// <summary>HTTPGet specifies the http request to perform.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#httpGet
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpGet", typeJson: "{\"fqn\":\"k8s.HttpGetAction\"}", isOptional: true)]
            public K8s.IHttpGetAction? HttpGet
            {
                get => GetInstanceProperty<K8s.IHttpGetAction?>();
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
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<double?>();
            }

            /// <summary>TCPSocket specifies an action involving a TCP port.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Probe#tcpSocket
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpSocket", typeJson: "{\"fqn\":\"k8s.TcpSocketAction\"}", isOptional: true)]
            public K8s.ITcpSocketAction? TcpSocket
            {
                get => GetInstanceProperty<K8s.ITcpSocketAction?>();
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
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
