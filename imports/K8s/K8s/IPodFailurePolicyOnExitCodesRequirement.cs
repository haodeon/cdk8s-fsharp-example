using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodFailurePolicyOnExitCodesRequirement describes the requirement for handling a failed pod based on its container exit codes.</summary>
    /// <remarks>
    /// In particular, it lookups the .state.terminated.exitCode for each app container and init container status, represented by the .status.containerStatuses and .status.initContainerStatuses fields in the Pod status, respectively. Containers completed with success (exit code 0) are excluded from the requirement check.
    ///
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnExitCodesRequirement
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPodFailurePolicyOnExitCodesRequirement), fullyQualifiedName: "k8s.PodFailurePolicyOnExitCodesRequirement")]
    public interface IPodFailurePolicyOnExitCodesRequirement
    {
        /// <summary>Represents the relationship between the container exit code(s) and the specified values.</summary>
        /// <remarks>
        /// Containers completed with success (exit code 0) are excluded from the requirement check. Possible values are:
        ///
        /// <list type="bullet">
        /// <description>In: the requirement is satisfied if at least one container exit code
        /// (might be multiple if there are multiple containers not restricted
        /// by the 'containerName' field) is in the set of specified values.</description>
        /// <description>NotIn: the requirement is satisfied if at least one container exit code
        /// (might be multiple if there are multiple containers not restricted
        /// by the 'containerName' field) is not in the set of specified values.
        /// Additional values are considered to be added in the future. Clients should react to an unknown operator by assuming the requirement is not satisfied.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnExitCodesRequirement#operator
        /// </remarks>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        string Operator
        {
            get;
        }

        /// <summary>Specifies the set of values.</summary>
        /// <remarks>
        /// Each returned container exit code (might be multiple in case of multiple containers) is checked against this set of values with respect to the operator. The list of values must be ordered and must not contain duplicates. Value '0' cannot be used for the In operator. At least one element is required. At most 255 elements are allowed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnExitCodesRequirement#values
        /// </remarks>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] Values
        {
            get;
        }

        /// <summary>Restricts the check for exit codes to the container with the specified name.</summary>
        /// <remarks>
        /// When null, the rule applies to all containers. When specified, it should match one the container or initContainer names in the pod template.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnExitCodesRequirement#containerName
        /// </remarks>
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>PodFailurePolicyOnExitCodesRequirement describes the requirement for handling a failed pod based on its container exit codes.</summary>
        /// <remarks>
        /// In particular, it lookups the .state.terminated.exitCode for each app container and init container status, represented by the .status.containerStatuses and .status.initContainerStatuses fields in the Pod status, respectively. Containers completed with success (exit code 0) are excluded from the requirement check.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnExitCodesRequirement
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPodFailurePolicyOnExitCodesRequirement), fullyQualifiedName: "k8s.PodFailurePolicyOnExitCodesRequirement")]
        internal sealed class _Proxy : DeputyBase, K8s.IPodFailurePolicyOnExitCodesRequirement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Represents the relationship between the container exit code(s) and the specified values.</summary>
            /// <remarks>
            /// Containers completed with success (exit code 0) are excluded from the requirement check. Possible values are:
            ///
            /// <list type="bullet">
            /// <description>In: the requirement is satisfied if at least one container exit code
            /// (might be multiple if there are multiple containers not restricted
            /// by the 'containerName' field) is in the set of specified values.</description>
            /// <description>NotIn: the requirement is satisfied if at least one container exit code
            /// (might be multiple if there are multiple containers not restricted
            /// by the 'containerName' field) is not in the set of specified values.
            /// Additional values are considered to be added in the future. Clients should react to an unknown operator by assuming the requirement is not satisfied.</description>
            /// </list>
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnExitCodesRequirement#operator
            /// </remarks>
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
            public string Operator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the set of values.</summary>
            /// <remarks>
            /// Each returned container exit code (might be multiple in case of multiple containers) is checked against this set of values with respect to the operator. The list of values must be ordered and must not contain duplicates. Value '0' cannot be used for the In operator. At least one element is required. At most 255 elements are allowed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnExitCodesRequirement#values
            /// </remarks>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] Values
            {
                get => GetInstanceProperty<double[]>()!;
            }

            /// <summary>Restricts the check for exit codes to the container with the specified name.</summary>
            /// <remarks>
            /// When null, the rule applies to all containers. When specified, it should match one the container or initContainer names in the pod template.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnExitCodesRequirement#containerName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
