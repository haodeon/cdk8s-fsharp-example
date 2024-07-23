using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CSINodeSpec holds information about the specification of all CSI drivers installed on a node.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.CsiNodeSpec")]
    public class CsiNodeSpec : K8s.ICsiNodeSpec
    {
        /// <summary>drivers is a list of information of all CSI Drivers existing on a node.</summary>
        /// <remarks>
        /// If all drivers in the list are uninstalled, this can become empty.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeSpec#drivers
        /// </remarks>
        [JsiiProperty(name: "drivers", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.CsiNodeDriver\"},\"kind\":\"array\"}}")]
        public K8s.ICsiNodeDriver[] Drivers
        {
            get;
            set;
        }
    }
}
