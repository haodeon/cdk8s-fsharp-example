using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>LeaseSpec is a specification of a Lease.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.LeaseSpec")]
    public class LeaseSpec : K8s.ILeaseSpec
    {
        /// <summary>acquireTime is a time when the current lease was acquired.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseSpec#acquireTime
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acquireTime", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
        public System.DateTime? AcquireTime
        {
            get;
            set;
        }

        /// <summary>holderIdentity contains the identity of the holder of a current lease.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseSpec#holderIdentity
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "holderIdentity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HolderIdentity
        {
            get;
            set;
        }

        /// <summary>leaseDurationSeconds is a duration that candidates for a lease need to wait to force acquire it.</summary>
        /// <remarks>
        /// This is measure against time of last observed renewTime.
        ///
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseSpec#leaseDurationSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "leaseDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LeaseDurationSeconds
        {
            get;
            set;
        }

        /// <summary>leaseTransitions is the number of transitions of a lease between holders.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseSpec#leaseTransitions
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "leaseTransitions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LeaseTransitions
        {
            get;
            set;
        }

        /// <summary>renewTime is a time when the current holder of a lease has last updated the lease.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseSpec#renewTime
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "renewTime", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
        public System.DateTime? RenewTime
        {
            get;
            set;
        }
    }
}
