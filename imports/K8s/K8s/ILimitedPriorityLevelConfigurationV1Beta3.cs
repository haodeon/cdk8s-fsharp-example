using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>LimitedPriorityLevelConfiguration specifies how to handle requests that are subject to limits.</summary>
    /// <remarks>
    /// It addresses two issues:
    ///
    /// <list type="bullet">
    /// <description>How are requests for this priority level limited?</description>
    /// <description>What should be done with requests that exceed the limit?</description>
    /// </list>
    ///
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitedPriorityLevelConfiguration
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ILimitedPriorityLevelConfigurationV1Beta3), fullyQualifiedName: "k8s.LimitedPriorityLevelConfigurationV1Beta3")]
    public interface ILimitedPriorityLevelConfigurationV1Beta3
    {
        /// <summary>`borrowingLimitPercent`, if present, configures a limit on how many seats this priority level can borrow from other priority levels.</summary>
        /// <remarks>
        /// The limit is known as this level's BorrowingConcurrencyLimit (BorrowingCL) and is a limit on the total number of seats that this level may borrow at any one time. This field holds the ratio of that limit to the level's nominal concurrency limit. When this field is non-nil, it must hold a non-negative integer and the limit is calculated as follows.
        ///
        /// BorrowingCL(i) = round( NominalCL(i) * borrowingLimitPercent(i)/100.0 )
        ///
        /// The value of this field can be more than 100, implying that this priority level can borrow a number of seats that is greater than its own nominal concurrency limit (NominalCL). When this field is left <c>nil</c>, the limit is effectively infinite.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitedPriorityLevelConfiguration#borrowingLimitPercent
        /// </remarks>
        [JsiiProperty(name: "borrowingLimitPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BorrowingLimitPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>`lendablePercent` prescribes the fraction of the level's NominalCL that can be borrowed by other priority levels.</summary>
        /// <remarks>
        /// The value of this field must be between 0 and 100, inclusive, and it defaults to 0. The number of seats that other levels can borrow from this level, known as this level's LendableConcurrencyLimit (LendableCL), is defined as follows.
        ///
        /// LendableCL(i) = round( NominalCL(i) * lendablePercent(i)/100.0 )
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitedPriorityLevelConfiguration#lendablePercent
        /// </remarks>
        [JsiiProperty(name: "lendablePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LendablePercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>`limitResponse` indicates what to do with requests that can not be executed right now.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitedPriorityLevelConfiguration#limitResponse
        /// </remarks>
        [JsiiProperty(name: "limitResponse", typeJson: "{\"fqn\":\"k8s.LimitResponseV1Beta3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILimitResponseV1Beta3? LimitResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>`nominalConcurrencyShares` (NCS) contributes to the computation of the NominalConcurrencyLimit (NominalCL) of this level.</summary>
        /// <remarks>
        /// This is the number of execution seats available at this priority level. This is used both for requests dispatched from this priority level as well as requests dispatched from other priority levels borrowing seats from this level. The server's concurrency limit (ServerCL) is divided among the Limited priority levels in proportion to their NCS values:
        ///
        /// NominalCL(i)  = ceil( ServerCL * NCS(i) / sum_ncs ) sum_ncs = sum[priority level k] NCS(k)
        ///
        /// Bigger numbers mean a larger nominal concurrency limit, at the expense of every other priority level. This field has a default value of 30.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitedPriorityLevelConfiguration#nominalConcurrencyShares
        /// </remarks>
        [JsiiProperty(name: "nominalConcurrencyShares", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NominalConcurrencyShares
        {
            get
            {
                return null;
            }
        }

        /// <summary>LimitedPriorityLevelConfiguration specifies how to handle requests that are subject to limits.</summary>
        /// <remarks>
        /// It addresses two issues:
        ///
        /// <list type="bullet">
        /// <description>How are requests for this priority level limited?</description>
        /// <description>What should be done with requests that exceed the limit?</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitedPriorityLevelConfiguration
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ILimitedPriorityLevelConfigurationV1Beta3), fullyQualifiedName: "k8s.LimitedPriorityLevelConfigurationV1Beta3")]
        internal sealed class _Proxy : DeputyBase, K8s.ILimitedPriorityLevelConfigurationV1Beta3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`borrowingLimitPercent`, if present, configures a limit on how many seats this priority level can borrow from other priority levels.</summary>
            /// <remarks>
            /// The limit is known as this level's BorrowingConcurrencyLimit (BorrowingCL) and is a limit on the total number of seats that this level may borrow at any one time. This field holds the ratio of that limit to the level's nominal concurrency limit. When this field is non-nil, it must hold a non-negative integer and the limit is calculated as follows.
            ///
            /// BorrowingCL(i) = round( NominalCL(i) * borrowingLimitPercent(i)/100.0 )
            ///
            /// The value of this field can be more than 100, implying that this priority level can borrow a number of seats that is greater than its own nominal concurrency limit (NominalCL). When this field is left <c>nil</c>, the limit is effectively infinite.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitedPriorityLevelConfiguration#borrowingLimitPercent
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "borrowingLimitPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BorrowingLimitPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>`lendablePercent` prescribes the fraction of the level's NominalCL that can be borrowed by other priority levels.</summary>
            /// <remarks>
            /// The value of this field must be between 0 and 100, inclusive, and it defaults to 0. The number of seats that other levels can borrow from this level, known as this level's LendableConcurrencyLimit (LendableCL), is defined as follows.
            ///
            /// LendableCL(i) = round( NominalCL(i) * lendablePercent(i)/100.0 )
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitedPriorityLevelConfiguration#lendablePercent
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lendablePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LendablePercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>`limitResponse` indicates what to do with requests that can not be executed right now.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitedPriorityLevelConfiguration#limitResponse
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limitResponse", typeJson: "{\"fqn\":\"k8s.LimitResponseV1Beta3\"}", isOptional: true)]
            public K8s.ILimitResponseV1Beta3? LimitResponse
            {
                get => GetInstanceProperty<K8s.ILimitResponseV1Beta3?>();
            }

            /// <summary>`nominalConcurrencyShares` (NCS) contributes to the computation of the NominalConcurrencyLimit (NominalCL) of this level.</summary>
            /// <remarks>
            /// This is the number of execution seats available at this priority level. This is used both for requests dispatched from this priority level as well as requests dispatched from other priority levels borrowing seats from this level. The server's concurrency limit (ServerCL) is divided among the Limited priority levels in proportion to their NCS values:
            ///
            /// NominalCL(i)  = ceil( ServerCL * NCS(i) / sum_ncs ) sum_ncs = sum[priority level k] NCS(k)
            ///
            /// Bigger numbers mean a larger nominal concurrency limit, at the expense of every other priority level. This field has a default value of 30.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitedPriorityLevelConfiguration#nominalConcurrencyShares
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nominalConcurrencyShares", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NominalConcurrencyShares
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
