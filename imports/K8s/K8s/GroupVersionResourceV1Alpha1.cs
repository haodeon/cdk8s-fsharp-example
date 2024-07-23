using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>The names of the group, the version, and the resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.GroupVersionResource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.GroupVersionResourceV1Alpha1")]
    public class GroupVersionResourceV1Alpha1 : K8s.IGroupVersionResourceV1Alpha1
    {
        /// <summary>The name of the group.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.GroupVersionResource#group
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Group
        {
            get;
            set;
        }

        /// <summary>The name of the resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.GroupVersionResource#resource
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Resource
        {
            get;
            set;
        }

        /// <summary>The name of the version.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.GroupVersionResource#version
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
