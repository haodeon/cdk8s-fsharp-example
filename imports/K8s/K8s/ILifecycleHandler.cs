using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>LifecycleHandler defines a specific action that should be taken in a lifecycle hook.</summary>
    /// <remarks>
    /// One and only one of the fields, except TCPSocket must be specified.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.LifecycleHandler
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ILifecycleHandler), fullyQualifiedName: "k8s.LifecycleHandler")]
    public interface ILifecycleHandler
    {
        /// <summary>Exec specifies the action to take.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LifecycleHandler#exec
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

        /// <summary>HTTPGet specifies the http request to perform.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LifecycleHandler#httpGet
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

        /// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LifecycleHandler#sleep
        /// </remarks>
        [JsiiProperty(name: "sleep", typeJson: "{\"fqn\":\"k8s.SleepAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISleepAction? Sleep
        {
            get
            {
                return null;
            }
        }

        /// <summary>Deprecated.</summary>
        /// <remarks>
        /// TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LifecycleHandler#tcpSocket
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

        /// <summary>LifecycleHandler defines a specific action that should be taken in a lifecycle hook.</summary>
        /// <remarks>
        /// One and only one of the fields, except TCPSocket must be specified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LifecycleHandler
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ILifecycleHandler), fullyQualifiedName: "k8s.LifecycleHandler")]
        internal sealed class _Proxy : DeputyBase, K8s.ILifecycleHandler
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Exec specifies the action to take.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LifecycleHandler#exec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exec", typeJson: "{\"fqn\":\"k8s.ExecAction\"}", isOptional: true)]
            public K8s.IExecAction? Exec
            {
                get => GetInstanceProperty<K8s.IExecAction?>();
            }

            /// <summary>HTTPGet specifies the http request to perform.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LifecycleHandler#httpGet
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpGet", typeJson: "{\"fqn\":\"k8s.HttpGetAction\"}", isOptional: true)]
            public K8s.IHttpGetAction? HttpGet
            {
                get => GetInstanceProperty<K8s.IHttpGetAction?>();
            }

            /// <summary>Sleep represents the duration that the container should sleep before being terminated.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LifecycleHandler#sleep
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sleep", typeJson: "{\"fqn\":\"k8s.SleepAction\"}", isOptional: true)]
            public K8s.ISleepAction? Sleep
            {
                get => GetInstanceProperty<K8s.ISleepAction?>();
            }

            /// <summary>Deprecated.</summary>
            /// <remarks>
            /// TCPSocket is NOT supported as a LifecycleHandler and kept for the backward compatibility. There are no validation of this field and lifecycle hooks will fail in runtime when tcp handler is specified.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LifecycleHandler#tcpSocket
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tcpSocket", typeJson: "{\"fqn\":\"k8s.TcpSocketAction\"}", isOptional: true)]
            public K8s.ITcpSocketAction? TcpSocket
            {
                get => GetInstanceProperty<K8s.ITcpSocketAction?>();
            }
        }
    }
}
