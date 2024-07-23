using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ResourcePolicyRule is a predicate that matches some resource requests, testing the request's verb and the target resource.</summary>
    /// <remarks>
    /// A ResourcePolicyRule matches a resource request if and only if: (a) at least one member of verbs matches the request, (b) at least one member of apiGroups matches the request, (c) at least one member of resources matches the request, and (d) either (d1) the request does not specify a namespace (i.e., <c>Namespace==""</c>) and clusterScope is true or (d2) the request specifies a namespace and least one member of namespaces matches the request's namespace.
    ///
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.ResourcePolicyRule
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ResourcePolicyRuleV1Beta3")]
    public class ResourcePolicyRuleV1Beta3 : K8s.IResourcePolicyRuleV1Beta3
    {
        /// <summary>`apiGroups` is a list of matching API groups and may not be empty.</summary>
        /// <remarks>
        /// "*" matches all API groups and, if present, must be the only entry. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.ResourcePolicyRule#apiGroups
        /// </remarks>
        [JsiiProperty(name: "apiGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ApiGroups
        {
            get;
            set;
        }

        /// <summary>`resources` is a list of matching resources (i.e., lowercase and plural) with, if desired, subresource.  For example, [ "services", "nodes/status" ].  This list may not be empty. "*" matches all resources and, if present, must be the only entry. Required.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.ResourcePolicyRule#resources
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Resources
        {
            get;
            set;
        }

        /// <summary>`verbs` is a list of matching verbs and may not be empty.</summary>
        /// <remarks>
        /// "*" matches all verbs and, if present, must be the only entry. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.ResourcePolicyRule#verbs
        /// </remarks>
        [JsiiProperty(name: "verbs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Verbs
        {
            get;
            set;
        }

        /// <summary>`clusterScope` indicates whether to match requests that do not specify a namespace (which happens either because the resource is not namespaced or the request targets all namespaces).</summary>
        /// <remarks>
        /// If this field is omitted or false then the <c>namespaces</c> field must contain a non-empty list.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.ResourcePolicyRule#clusterScope
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterScope", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ClusterScope
        {
            get;
            set;
        }

        /// <summary>`namespaces` is a list of target namespaces that restricts matches.</summary>
        /// <remarks>
        /// A request that specifies a target namespace matches only if either (a) this list contains that target namespace or (b) this list contains "<em>".  Note that "</em>" matches any specified namespace but does not match a request that <em>does not specify</em> a namespace (see the <c>clusterScope</c> field for that). This list may be empty, but only if <c>clusterScope</c> is true.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.ResourcePolicyRule#namespaces
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Namespaces
        {
            get;
            set;
        }
    }
}
