using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ExemptPriorityLevelConfiguration describes the configurable aspects of the handling of exempt requests.</summary>
    /// <remarks>
    /// In the mandatory exempt configuration object the values in the fields here can be modified by authorized users, unlike the rest of the <c>spec</c>.
    ///
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.ExemptPriorityLevelConfiguration
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IExemptPriorityLevelConfiguration), fullyQualifiedName: "k8s.ExemptPriorityLevelConfiguration")]
    public interface IExemptPriorityLevelConfiguration
    {
        /// <summary>`lendablePercent` prescribes the fraction of the level's NominalCL that can be borrowed by other priority levels.</summary>
        /// <remarks>
        /// This value of this field must be between 0 and 100, inclusive, and it defaults to 0. The number of seats that other levels can borrow from this level, known as this level's LendableConcurrencyLimit (LendableCL), is defined as follows.
        ///
        /// LendableCL(i) = round( NominalCL(i) * lendablePercent(i)/100.0 )
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.ExemptPriorityLevelConfiguration#lendablePercent
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

        /// <summary>`nominalConcurrencyShares` (NCS) contributes to the computation of the NominalConcurrencyLimit (NominalCL) of this level.</summary>
        /// <remarks>
        /// This is the number of execution seats nominally reserved for this priority level. This DOES NOT limit the dispatching from this priority level but affects the other priority levels through the borrowing mechanism. The server's concurrency limit (ServerCL) is divided among all the priority levels in proportion to their NCS values:
        ///
        /// NominalCL(i)  = ceil( ServerCL * NCS(i) / sum_ncs ) sum_ncs = sum[priority level k] NCS(k)
        ///
        /// Bigger numbers mean a larger nominal concurrency limit, at the expense of every other priority level. This field has a default value of zero.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.ExemptPriorityLevelConfiguration#nominalConcurrencyShares
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

        /// <summary>ExemptPriorityLevelConfiguration describes the configurable aspects of the handling of exempt requests.</summary>
        /// <remarks>
        /// In the mandatory exempt configuration object the values in the fields here can be modified by authorized users, unlike the rest of the <c>spec</c>.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.ExemptPriorityLevelConfiguration
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IExemptPriorityLevelConfiguration), fullyQualifiedName: "k8s.ExemptPriorityLevelConfiguration")]
        internal sealed class _Proxy : DeputyBase, K8s.IExemptPriorityLevelConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`lendablePercent` prescribes the fraction of the level's NominalCL that can be borrowed by other priority levels.</summary>
            /// <remarks>
            /// This value of this field must be between 0 and 100, inclusive, and it defaults to 0. The number of seats that other levels can borrow from this level, known as this level's LendableConcurrencyLimit (LendableCL), is defined as follows.
            ///
            /// LendableCL(i) = round( NominalCL(i) * lendablePercent(i)/100.0 )
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.ExemptPriorityLevelConfiguration#lendablePercent
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lendablePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LendablePercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>`nominalConcurrencyShares` (NCS) contributes to the computation of the NominalConcurrencyLimit (NominalCL) of this level.</summary>
            /// <remarks>
            /// This is the number of execution seats nominally reserved for this priority level. This DOES NOT limit the dispatching from this priority level but affects the other priority levels through the borrowing mechanism. The server's concurrency limit (ServerCL) is divided among all the priority levels in proportion to their NCS values:
            ///
            /// NominalCL(i)  = ceil( ServerCL * NCS(i) / sum_ncs ) sum_ncs = sum[priority level k] NCS(k)
            ///
            /// Bigger numbers mean a larger nominal concurrency limit, at the expense of every other priority level. This field has a default value of zero.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.ExemptPriorityLevelConfiguration#nominalConcurrencyShares
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
