using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Lifecycle describes actions that the management system should take in response to container lifecycle events.</summary>
    /// <remarks>
    /// For the PostStart and PreStop lifecycle handlers, management of the container blocks until the action is complete, unless the container process fails, in which case the handler is aborted.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Lifecycle
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ILifecycle), fullyQualifiedName: "k8s.Lifecycle")]
    public interface ILifecycle
    {
        /// <summary>PostStart is called immediately after a container is created.</summary>
        /// <remarks>
        /// If the handler fails, the container is terminated and restarted according to its restart policy. Other management of the container blocks until the hook completes. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Lifecycle#postStart
        /// </remarks>
        [JsiiProperty(name: "postStart", typeJson: "{\"fqn\":\"k8s.LifecycleHandler\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILifecycleHandler? PostStart
        {
            get
            {
                return null;
            }
        }

        /// <summary>PreStop is called immediately before a container is terminated due to an API request or management event such as liveness/startup probe failure, preemption, resource contention, etc.</summary>
        /// <remarks>
        /// The handler is not called if the container crashes or exits. The Pod's termination grace period countdown begins before the PreStop hook is executed. Regardless of the outcome of the handler, the container will eventually terminate within the Pod's termination grace period (unless delayed by finalizers). Other management of the container blocks until the hook completes or until the termination grace period is reached. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Lifecycle#preStop
        /// </remarks>
        [JsiiProperty(name: "preStop", typeJson: "{\"fqn\":\"k8s.LifecycleHandler\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILifecycleHandler? PreStop
        {
            get
            {
                return null;
            }
        }

        /// <summary>Lifecycle describes actions that the management system should take in response to container lifecycle events.</summary>
        /// <remarks>
        /// For the PostStart and PreStop lifecycle handlers, management of the container blocks until the action is complete, unless the container process fails, in which case the handler is aborted.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Lifecycle
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ILifecycle), fullyQualifiedName: "k8s.Lifecycle")]
        internal sealed class _Proxy : DeputyBase, K8s.ILifecycle
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>PostStart is called immediately after a container is created.</summary>
            /// <remarks>
            /// If the handler fails, the container is terminated and restarted according to its restart policy. Other management of the container blocks until the hook completes. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Lifecycle#postStart
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postStart", typeJson: "{\"fqn\":\"k8s.LifecycleHandler\"}", isOptional: true)]
            public K8s.ILifecycleHandler? PostStart
            {
                get => GetInstanceProperty<K8s.ILifecycleHandler?>();
            }

            /// <summary>PreStop is called immediately before a container is terminated due to an API request or management event such as liveness/startup probe failure, preemption, resource contention, etc.</summary>
            /// <remarks>
            /// The handler is not called if the container crashes or exits. The Pod's termination grace period countdown begins before the PreStop hook is executed. Regardless of the outcome of the handler, the container will eventually terminate within the Pod's termination grace period (unless delayed by finalizers). Other management of the container blocks until the hook completes or until the termination grace period is reached. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Lifecycle#preStop
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preStop", typeJson: "{\"fqn\":\"k8s.LifecycleHandler\"}", isOptional: true)]
            public K8s.ILifecycleHandler? PreStop
            {
                get => GetInstanceProperty<K8s.ILifecycleHandler?>();
            }
        }
    }
}
