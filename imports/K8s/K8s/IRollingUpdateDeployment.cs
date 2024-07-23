using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Spec to control the desired behavior of rolling update.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.RollingUpdateDeployment
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IRollingUpdateDeployment), fullyQualifiedName: "k8s.RollingUpdateDeployment")]
    public interface IRollingUpdateDeployment
    {
        /// <summary>The maximum number of pods that can be scheduled above the desired number of pods.</summary>
        /// <remarks>
        /// Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). This can not be 0 if MaxUnavailable is 0. Absolute number is calculated from percentage by rounding up. Defaults to 25%. Example: when this is set to 30%, the new ReplicaSet can be scaled up immediately when the rolling update starts, such that the total number of old and new pods do not exceed 130% of desired pods. Once old pods have been killed, new ReplicaSet can be scaled up further, ensuring that total number of pods running at any time during the update is at most 130% of desired pods.
        ///
        /// <strong>Default</strong>: 25%. Example: when this is set to 30%, the new ReplicaSet can be scaled up immediately when the rolling update starts, such that the total number of old and new pods do not exceed 130% of desired pods. Once old pods have been killed, new ReplicaSet can be scaled up further, ensuring that total number of pods running at any time during the update is at most 130% of desired pods.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.RollingUpdateDeployment#maxSurge
        /// </remarks>
        [JsiiProperty(name: "maxSurge", typeJson: "{\"fqn\":\"k8s.IntOrString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IntOrString? MaxSurge
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum number of pods that can be unavailable during the update.</summary>
        /// <remarks>
        /// Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). Absolute number is calculated from percentage by rounding down. This can not be 0 if MaxSurge is 0. Defaults to 25%. Example: when this is set to 30%, the old ReplicaSet can be scaled down to 70% of desired pods immediately when the rolling update starts. Once new pods are ready, old ReplicaSet can be scaled down further, followed by scaling up the new ReplicaSet, ensuring that the total number of pods available at all times during the update is at least 70% of desired pods.
        ///
        /// <strong>Default</strong>: 25%. Example: when this is set to 30%, the old ReplicaSet can be scaled down to 70% of desired pods immediately when the rolling update starts. Once new pods are ready, old ReplicaSet can be scaled down further, followed by scaling up the new ReplicaSet, ensuring that the total number of pods available at all times during the update is at least 70% of desired pods.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.RollingUpdateDeployment#maxUnavailable
        /// </remarks>
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"fqn\":\"k8s.IntOrString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IntOrString? MaxUnavailable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Spec to control the desired behavior of rolling update.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.RollingUpdateDeployment
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IRollingUpdateDeployment), fullyQualifiedName: "k8s.RollingUpdateDeployment")]
        internal sealed class _Proxy : DeputyBase, K8s.IRollingUpdateDeployment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The maximum number of pods that can be scheduled above the desired number of pods.</summary>
            /// <remarks>
            /// Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). This can not be 0 if MaxUnavailable is 0. Absolute number is calculated from percentage by rounding up. Defaults to 25%. Example: when this is set to 30%, the new ReplicaSet can be scaled up immediately when the rolling update starts, such that the total number of old and new pods do not exceed 130% of desired pods. Once old pods have been killed, new ReplicaSet can be scaled up further, ensuring that total number of pods running at any time during the update is at most 130% of desired pods.
            ///
            /// <strong>Default</strong>: 25%. Example: when this is set to 30%, the new ReplicaSet can be scaled up immediately when the rolling update starts, such that the total number of old and new pods do not exceed 130% of desired pods. Once old pods have been killed, new ReplicaSet can be scaled up further, ensuring that total number of pods running at any time during the update is at most 130% of desired pods.
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.RollingUpdateDeployment#maxSurge
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxSurge", typeJson: "{\"fqn\":\"k8s.IntOrString\"}", isOptional: true)]
            public K8s.IntOrString? MaxSurge
            {
                get => GetInstanceProperty<K8s.IntOrString?>();
            }

            /// <summary>The maximum number of pods that can be unavailable during the update.</summary>
            /// <remarks>
            /// Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). Absolute number is calculated from percentage by rounding down. This can not be 0 if MaxSurge is 0. Defaults to 25%. Example: when this is set to 30%, the old ReplicaSet can be scaled down to 70% of desired pods immediately when the rolling update starts. Once new pods are ready, old ReplicaSet can be scaled down further, followed by scaling up the new ReplicaSet, ensuring that the total number of pods available at all times during the update is at least 70% of desired pods.
            ///
            /// <strong>Default</strong>: 25%. Example: when this is set to 30%, the old ReplicaSet can be scaled down to 70% of desired pods immediately when the rolling update starts. Once new pods are ready, old ReplicaSet can be scaled down further, followed by scaling up the new ReplicaSet, ensuring that the total number of pods available at all times during the update is at least 70% of desired pods.
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.RollingUpdateDeployment#maxUnavailable
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnavailable", typeJson: "{\"fqn\":\"k8s.IntOrString\"}", isOptional: true)]
            public K8s.IntOrString? MaxUnavailable
            {
                get => GetInstanceProperty<K8s.IntOrString?>();
            }
        }
    }
}