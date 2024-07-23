using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ServiceSpec describes the attributes that a user creates on a service.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IServiceSpec), fullyQualifiedName: "k8s.ServiceSpec")]
    public interface IServiceSpec
    {
        /// <summary>allocateLoadBalancerNodePorts defines if NodePorts will be automatically allocated for services with type LoadBalancer.</summary>
        /// <remarks>
        /// Default is "true". It may be set to "false" if the cluster load-balancer does not rely on NodePorts.  If the caller requests specific NodePorts (by specifying a value), those requests will be respected, regardless of this field. This field may only be set for services with type LoadBalancer and will be cleared if the type is changed to any other type.
        ///
        /// <strong>Default</strong>: true". It may be set to "false" if the cluster load-balancer does not rely on NodePorts.  If the caller requests specific NodePorts (by specifying a value), those requests will be respected, regardless of this field. This field may only be set for services with type LoadBalancer and will be cleared if the type is changed to any other type.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#allocateLoadBalancerNodePorts
        /// </remarks>
        [JsiiProperty(name: "allocateLoadBalancerNodePorts", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllocateLoadBalancerNodePorts
        {
            get
            {
                return null;
            }
        }

        /// <summary>clusterIP is the IP address of the service and is usually assigned randomly.</summary>
        /// <remarks>
        /// If an address is specified manually, is in-range (as per system configuration), and is not in use, it will be allocated to the service; otherwise creation of the service will fail. This field may not be changed through updates unless the type field is also being changed to ExternalName (which requires this field to be blank) or the type field is being changed from ExternalName (in which case this field may optionally be specified, as describe above).  Valid values are "None", empty string (""), or a valid IP address. Setting this to "None" makes a "headless service" (no virtual IP), which is useful when direct endpoint connections are preferred and proxying is not required.  Only applies to types ClusterIP, NodePort, and LoadBalancer. If this field is specified when creating a Service of type ExternalName, creation will fail. This field will be wiped when updating a Service to type ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#clusterIP
        /// </remarks>
        [JsiiProperty(name: "clusterIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>ClusterIPs is a list of IP addresses assigned to this service, and are usually assigned randomly.</summary>
        /// <remarks>
        /// If an address is specified manually, is in-range (as per system configuration), and is not in use, it will be allocated to the service; otherwise creation of the service will fail. This field may not be changed through updates unless the type field is also being changed to ExternalName (which requires this field to be empty) or the type field is being changed from ExternalName (in which case this field may optionally be specified, as describe above).  Valid values are "None", empty string (""), or a valid IP address.  Setting this to "None" makes a "headless service" (no virtual IP), which is useful when direct endpoint connections are preferred and proxying is not required.  Only applies to types ClusterIP, NodePort, and LoadBalancer. If this field is specified when creating a Service of type ExternalName, creation will fail. This field will be wiped when updating a Service to type ExternalName.  If this field is not specified, it will be initialized from the clusterIP field.  If this field is specified, clients must ensure that clusterIPs[0] and clusterIP have the same value.
        ///
        /// This field may hold a maximum of two entries (dual-stack IPs, in either order). These IPs must correspond to the values of the ipFamilies field. Both clusterIPs and ipFamilies are governed by the ipFamilyPolicy field. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#clusterIPs
        /// </remarks>
        [JsiiProperty(name: "clusterIPs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ClusterIPs
        {
            get
            {
                return null;
            }
        }

        /// <summary>externalIPs is a list of IP addresses for which nodes in the cluster will also accept traffic for this service.</summary>
        /// <remarks>
        /// These IPs are not managed by Kubernetes.  The user is responsible for ensuring that traffic arrives at a node with this IP.  A common example is external load-balancers that are not part of the Kubernetes system.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#externalIPs
        /// </remarks>
        [JsiiProperty(name: "externalIPs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExternalIPs
        {
            get
            {
                return null;
            }
        }

        /// <summary>externalName is the external reference that discovery mechanisms will return as an alias for this service (e.g. a DNS CNAME record). No proxying will be involved.  Must be a lowercase RFC-1123 hostname (https://tools.ietf.org/html/rfc1123) and requires `type` to be "ExternalName".</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#externalName
        /// </remarks>
        [JsiiProperty(name: "externalName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalName
        {
            get
            {
                return null;
            }
        }

        /// <summary>externalTrafficPolicy describes how nodes distribute service traffic they receive on one of the Service's "externally-facing" addresses (NodePorts, ExternalIPs, and LoadBalancer IPs).</summary>
        /// <remarks>
        /// If set to "Local", the proxy will configure the service in a way that assumes that external load balancers will take care of balancing the service traffic between nodes, and so each node will deliver traffic only to the node-local endpoints of the service, without masquerading the client source IP. (Traffic mistakenly sent to a node with no endpoints will be dropped.) The default value, "Cluster", uses the standard behavior of routing to all endpoints evenly (possibly modified by topology and other features). Note that traffic sent to an External IP or LoadBalancer IP from within the cluster will always get "Cluster" semantics, but clients sending to a NodePort from within the cluster may need to take traffic policy into account when picking a node.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#externalTrafficPolicy
        /// </remarks>
        [JsiiProperty(name: "externalTrafficPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalTrafficPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>healthCheckNodePort specifies the healthcheck nodePort for the service.</summary>
        /// <remarks>
        /// This only applies when type is set to LoadBalancer and externalTrafficPolicy is set to Local. If a value is specified, is in-range, and is not in use, it will be used.  If not specified, a value will be automatically allocated.  External systems (e.g. load-balancers) can use this port to determine if a given node holds endpoints for this service or not.  If this field is specified when creating a Service which does not need it, creation will fail. This field will be wiped when updating a Service to no longer need it (e.g. changing type). This field cannot be updated once set.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#healthCheckNodePort
        /// </remarks>
        [JsiiProperty(name: "healthCheckNodePort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthCheckNodePort
        {
            get
            {
                return null;
            }
        }

        /// <summary>InternalTrafficPolicy describes how nodes distribute service traffic they receive on the ClusterIP.</summary>
        /// <remarks>
        /// If set to "Local", the proxy will assume that pods only want to talk to endpoints of the service on the same node as the pod, dropping the traffic if there are no local endpoints. The default value, "Cluster", uses the standard behavior of routing to all endpoints evenly (possibly modified by topology and other features).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#internalTrafficPolicy
        /// </remarks>
        [JsiiProperty(name: "internalTrafficPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InternalTrafficPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>IPFamilies is a list of IP families (e.g. IPv4, IPv6) assigned to this service. This field is usually assigned automatically based on cluster configuration and the ipFamilyPolicy field. If this field is specified manually, the requested family is available in the cluster, and ipFamilyPolicy allows it, it will be used; otherwise creation of the service will fail. This field is conditionally mutable: it allows for adding or removing a secondary IP family, but it does not allow changing the primary IP family of the Service. Valid values are "IPv4" and "IPv6".  This field only applies to Services of types ClusterIP, NodePort, and LoadBalancer, and does apply to "headless" services. This field will be wiped when updating a Service to type ExternalName.</summary>
        /// <remarks>
        /// This field may hold a maximum of two entries (dual-stack families, in either order).  These families must correspond to the values of the clusterIPs field, if specified. Both clusterIPs and ipFamilies are governed by the ipFamilyPolicy field.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#ipFamilies
        /// </remarks>
        [JsiiProperty(name: "ipFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IpFamilies
        {
            get
            {
                return null;
            }
        }

        /// <summary>IPFamilyPolicy represents the dual-stack-ness requested or required by this Service.</summary>
        /// <remarks>
        /// If there is no value provided, then this field will be set to SingleStack. Services can be "SingleStack" (a single IP family), "PreferDualStack" (two IP families on dual-stack configured clusters or a single IP family on single-stack clusters), or "RequireDualStack" (two IP families on dual-stack configured clusters, otherwise fail). The ipFamilies and clusterIPs fields depend on the value of this field. This field will be wiped when updating a service to type ExternalName.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#ipFamilyPolicy
        /// </remarks>
        [JsiiProperty(name: "ipFamilyPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpFamilyPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>loadBalancerClass is the class of the load balancer implementation this Service belongs to.</summary>
        /// <remarks>
        /// If specified, the value of this field must be a label-style identifier, with an optional prefix, e.g. "internal-vip" or "example.com/internal-vip". Unprefixed names are reserved for end-users. This field can only be set when the Service type is 'LoadBalancer'. If not set, the default load balancer implementation is used, today this is typically done through the cloud provider integration, but should apply for any default implementation. If set, it is assumed that a load balancer implementation is watching for Services with a matching class. Any default load balancer implementation (e.g. cloud providers) should ignore Services that set this field. This field can only be set when creating or updating a Service to type 'LoadBalancer'. Once set, it can not be changed. This field will be wiped when a service is updated to a non 'LoadBalancer' type.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#loadBalancerClass
        /// </remarks>
        [JsiiProperty(name: "loadBalancerClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoadBalancerClass
        {
            get
            {
                return null;
            }
        }

        /// <summary>Only applies to Service Type: LoadBalancer.</summary>
        /// <remarks>
        /// This feature depends on whether the underlying cloud-provider supports specifying the loadBalancerIP when a load balancer is created. This field will be ignored if the cloud-provider does not support the feature. Deprecated: This field was under-specified and its meaning varies across implementations. Using it is non-portable and it may not support dual-stack. Users are encouraged to use implementation-specific annotations when available.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#loadBalancerIP
        /// </remarks>
        [JsiiProperty(name: "loadBalancerIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoadBalancerIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>If specified and supported by the platform, this will restrict traffic through the cloud-provider load-balancer will be restricted to the specified client IPs.</summary>
        /// <remarks>
        /// This field will be ignored if the cloud-provider does not support the feature." More info: https://kubernetes.io/docs/tasks/access-application-cluster/create-external-load-balancer/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#loadBalancerSourceRanges
        /// </remarks>
        [JsiiProperty(name: "loadBalancerSourceRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LoadBalancerSourceRanges
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of ports that are exposed by this service.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#ports
        /// </remarks>
        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ServicePort\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IServicePort[]? Ports
        {
            get
            {
                return null;
            }
        }

        /// <summary>publishNotReadyAddresses indicates that any agent which deals with endpoints for this Service should disregard any indications of ready/not-ready.</summary>
        /// <remarks>
        /// The primary use case for setting this field is for a StatefulSet's Headless Service to propagate SRV DNS records for its Pods for the purpose of peer discovery. The Kubernetes controllers that generate Endpoints and EndpointSlice resources for Services interpret this to mean that all endpoints are considered "ready" even if the Pods themselves are not. Agents which consume only Kubernetes generated endpoints through the Endpoints or EndpointSlice resources can safely assume this behavior.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#publishNotReadyAddresses
        /// </remarks>
        [JsiiProperty(name: "publishNotReadyAddresses", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? PublishNotReadyAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Route service traffic to pods with label keys and values matching this selector.</summary>
        /// <remarks>
        /// If empty or not present, the service is assumed to have an external process managing its endpoints, which Kubernetes will not modify. Only applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if type is ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Selector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Supports "ClientIP" and "None".</summary>
        /// <remarks>
        /// Used to maintain session affinity. Enable client IP based session affinity. Must be ClientIP or None. Defaults to None. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
        ///
        /// <strong>Default</strong>: None. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#sessionAffinity
        /// </remarks>
        [JsiiProperty(name: "sessionAffinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionAffinity
        {
            get
            {
                return null;
            }
        }

        /// <summary>sessionAffinityConfig contains the configurations of session affinity.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#sessionAffinityConfig
        /// </remarks>
        [JsiiProperty(name: "sessionAffinityConfig", typeJson: "{\"fqn\":\"k8s.SessionAffinityConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISessionAffinityConfig? SessionAffinityConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>TrafficDistribution offers a way to express preferences for how traffic is distributed to Service endpoints.</summary>
        /// <remarks>
        /// Implementations can use this field as a hint, but are not required to guarantee strict adherence. If the field is not set, the implementation will apply its default routing strategy. If set to "PreferClose", implementations should prioritize endpoints that are topologically close (e.g., same zone).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#trafficDistribution
        /// </remarks>
        [JsiiProperty(name: "trafficDistribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrafficDistribution
        {
            get
            {
                return null;
            }
        }

        /// <summary>type determines how the Service is exposed.</summary>
        /// <remarks>
        /// Defaults to ClusterIP. Valid options are ExternalName, ClusterIP, NodePort, and LoadBalancer. "ClusterIP" allocates a cluster-internal IP address for load-balancing to endpoints. Endpoints are determined by the selector or if that is not specified, by manual construction of an Endpoints object or EndpointSlice objects. If clusterIP is "None", no virtual IP is allocated and the endpoints are published as a set of endpoints rather than a virtual IP. "NodePort" builds on ClusterIP and allocates a port on every node which routes to the same endpoints as the clusterIP. "LoadBalancer" builds on NodePort and creates an external load-balancer (if supported in the current cloud) which routes to the same endpoints as the clusterIP. "ExternalName" aliases this service to the specified externalName. Several other fields do not apply to ExternalName services. More info: https://kubernetes.io/docs/concepts/services-networking/service/#publishing-services-service-types
        ///
        /// <strong>Default</strong>: ClusterIP. Valid options are ExternalName, ClusterIP, NodePort, and LoadBalancer. "ClusterIP" allocates a cluster-internal IP address for load-balancing to endpoints. Endpoints are determined by the selector or if that is not specified, by manual construction of an Endpoints object or EndpointSlice objects. If clusterIP is "None", no virtual IP is allocated and the endpoints are published as a set of endpoints rather than a virtual IP. "NodePort" builds on ClusterIP and allocates a port on every node which routes to the same endpoints as the clusterIP. "LoadBalancer" builds on NodePort and creates an external load-balancer (if supported in the current cloud) which routes to the same endpoints as the clusterIP. "ExternalName" aliases this service to the specified externalName. Several other fields do not apply to ExternalName services. More info: https://kubernetes.io/docs/concepts/services-networking/service/#publishing-services-service-types
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>ServiceSpec describes the attributes that a user creates on a service.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IServiceSpec), fullyQualifiedName: "k8s.ServiceSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IServiceSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allocateLoadBalancerNodePorts defines if NodePorts will be automatically allocated for services with type LoadBalancer.</summary>
            /// <remarks>
            /// Default is "true". It may be set to "false" if the cluster load-balancer does not rely on NodePorts.  If the caller requests specific NodePorts (by specifying a value), those requests will be respected, regardless of this field. This field may only be set for services with type LoadBalancer and will be cleared if the type is changed to any other type.
            ///
            /// <strong>Default</strong>: true". It may be set to "false" if the cluster load-balancer does not rely on NodePorts.  If the caller requests specific NodePorts (by specifying a value), those requests will be respected, regardless of this field. This field may only be set for services with type LoadBalancer and will be cleared if the type is changed to any other type.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#allocateLoadBalancerNodePorts
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allocateLoadBalancerNodePorts", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllocateLoadBalancerNodePorts
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>clusterIP is the IP address of the service and is usually assigned randomly.</summary>
            /// <remarks>
            /// If an address is specified manually, is in-range (as per system configuration), and is not in use, it will be allocated to the service; otherwise creation of the service will fail. This field may not be changed through updates unless the type field is also being changed to ExternalName (which requires this field to be blank) or the type field is being changed from ExternalName (in which case this field may optionally be specified, as describe above).  Valid values are "None", empty string (""), or a valid IP address. Setting this to "None" makes a "headless service" (no virtual IP), which is useful when direct endpoint connections are preferred and proxying is not required.  Only applies to types ClusterIP, NodePort, and LoadBalancer. If this field is specified when creating a Service of type ExternalName, creation will fail. This field will be wiped when updating a Service to type ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#clusterIP
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ClusterIPs is a list of IP addresses assigned to this service, and are usually assigned randomly.</summary>
            /// <remarks>
            /// If an address is specified manually, is in-range (as per system configuration), and is not in use, it will be allocated to the service; otherwise creation of the service will fail. This field may not be changed through updates unless the type field is also being changed to ExternalName (which requires this field to be empty) or the type field is being changed from ExternalName (in which case this field may optionally be specified, as describe above).  Valid values are "None", empty string (""), or a valid IP address.  Setting this to "None" makes a "headless service" (no virtual IP), which is useful when direct endpoint connections are preferred and proxying is not required.  Only applies to types ClusterIP, NodePort, and LoadBalancer. If this field is specified when creating a Service of type ExternalName, creation will fail. This field will be wiped when updating a Service to type ExternalName.  If this field is not specified, it will be initialized from the clusterIP field.  If this field is specified, clients must ensure that clusterIPs[0] and clusterIP have the same value.
            ///
            /// This field may hold a maximum of two entries (dual-stack IPs, in either order). These IPs must correspond to the values of the ipFamilies field. Both clusterIPs and ipFamilies are governed by the ipFamilyPolicy field. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#clusterIPs
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterIPs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ClusterIPs
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>externalIPs is a list of IP addresses for which nodes in the cluster will also accept traffic for this service.</summary>
            /// <remarks>
            /// These IPs are not managed by Kubernetes.  The user is responsible for ensuring that traffic arrives at a node with this IP.  A common example is external load-balancers that are not part of the Kubernetes system.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#externalIPs
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalIPs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExternalIPs
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>externalName is the external reference that discovery mechanisms will return as an alias for this service (e.g. a DNS CNAME record). No proxying will be involved.  Must be a lowercase RFC-1123 hostname (https://tools.ietf.org/html/rfc1123) and requires `type` to be "ExternalName".</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#externalName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>externalTrafficPolicy describes how nodes distribute service traffic they receive on one of the Service's "externally-facing" addresses (NodePorts, ExternalIPs, and LoadBalancer IPs).</summary>
            /// <remarks>
            /// If set to "Local", the proxy will configure the service in a way that assumes that external load balancers will take care of balancing the service traffic between nodes, and so each node will deliver traffic only to the node-local endpoints of the service, without masquerading the client source IP. (Traffic mistakenly sent to a node with no endpoints will be dropped.) The default value, "Cluster", uses the standard behavior of routing to all endpoints evenly (possibly modified by topology and other features). Note that traffic sent to an External IP or LoadBalancer IP from within the cluster will always get "Cluster" semantics, but clients sending to a NodePort from within the cluster may need to take traffic policy into account when picking a node.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#externalTrafficPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalTrafficPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalTrafficPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>healthCheckNodePort specifies the healthcheck nodePort for the service.</summary>
            /// <remarks>
            /// This only applies when type is set to LoadBalancer and externalTrafficPolicy is set to Local. If a value is specified, is in-range, and is not in use, it will be used.  If not specified, a value will be automatically allocated.  External systems (e.g. load-balancers) can use this port to determine if a given node holds endpoints for this service or not.  If this field is specified when creating a Service which does not need it, creation will fail. This field will be wiped when updating a Service to no longer need it (e.g. changing type). This field cannot be updated once set.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#healthCheckNodePort
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckNodePort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthCheckNodePort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>InternalTrafficPolicy describes how nodes distribute service traffic they receive on the ClusterIP.</summary>
            /// <remarks>
            /// If set to "Local", the proxy will assume that pods only want to talk to endpoints of the service on the same node as the pod, dropping the traffic if there are no local endpoints. The default value, "Cluster", uses the standard behavior of routing to all endpoints evenly (possibly modified by topology and other features).
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#internalTrafficPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "internalTrafficPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InternalTrafficPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>IPFamilies is a list of IP families (e.g. IPv4, IPv6) assigned to this service. This field is usually assigned automatically based on cluster configuration and the ipFamilyPolicy field. If this field is specified manually, the requested family is available in the cluster, and ipFamilyPolicy allows it, it will be used; otherwise creation of the service will fail. This field is conditionally mutable: it allows for adding or removing a secondary IP family, but it does not allow changing the primary IP family of the Service. Valid values are "IPv4" and "IPv6".  This field only applies to Services of types ClusterIP, NodePort, and LoadBalancer, and does apply to "headless" services. This field will be wiped when updating a Service to type ExternalName.</summary>
            /// <remarks>
            /// This field may hold a maximum of two entries (dual-stack families, in either order).  These families must correspond to the values of the clusterIPs field, if specified. Both clusterIPs and ipFamilies are governed by the ipFamilyPolicy field.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#ipFamilies
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IpFamilies
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>IPFamilyPolicy represents the dual-stack-ness requested or required by this Service.</summary>
            /// <remarks>
            /// If there is no value provided, then this field will be set to SingleStack. Services can be "SingleStack" (a single IP family), "PreferDualStack" (two IP families on dual-stack configured clusters or a single IP family on single-stack clusters), or "RequireDualStack" (two IP families on dual-stack configured clusters, otherwise fail). The ipFamilies and clusterIPs fields depend on the value of this field. This field will be wiped when updating a service to type ExternalName.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#ipFamilyPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipFamilyPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpFamilyPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>loadBalancerClass is the class of the load balancer implementation this Service belongs to.</summary>
            /// <remarks>
            /// If specified, the value of this field must be a label-style identifier, with an optional prefix, e.g. "internal-vip" or "example.com/internal-vip". Unprefixed names are reserved for end-users. This field can only be set when the Service type is 'LoadBalancer'. If not set, the default load balancer implementation is used, today this is typically done through the cloud provider integration, but should apply for any default implementation. If set, it is assumed that a load balancer implementation is watching for Services with a matching class. Any default load balancer implementation (e.g. cloud providers) should ignore Services that set this field. This field can only be set when creating or updating a Service to type 'LoadBalancer'. Once set, it can not be changed. This field will be wiped when a service is updated to a non 'LoadBalancer' type.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#loadBalancerClass
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoadBalancerClass
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Only applies to Service Type: LoadBalancer.</summary>
            /// <remarks>
            /// This feature depends on whether the underlying cloud-provider supports specifying the loadBalancerIP when a load balancer is created. This field will be ignored if the cloud-provider does not support the feature. Deprecated: This field was under-specified and its meaning varies across implementations. Using it is non-portable and it may not support dual-stack. Users are encouraged to use implementation-specific annotations when available.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#loadBalancerIP
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoadBalancerIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If specified and supported by the platform, this will restrict traffic through the cloud-provider load-balancer will be restricted to the specified client IPs.</summary>
            /// <remarks>
            /// This field will be ignored if the cloud-provider does not support the feature." More info: https://kubernetes.io/docs/tasks/access-application-cluster/create-external-load-balancer/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#loadBalancerSourceRanges
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerSourceRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LoadBalancerSourceRanges
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The list of ports that are exposed by this service.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#ports
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ServicePort\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IServicePort[]? Ports
            {
                get => GetInstanceProperty<K8s.IServicePort[]?>();
            }

            /// <summary>publishNotReadyAddresses indicates that any agent which deals with endpoints for this Service should disregard any indications of ready/not-ready.</summary>
            /// <remarks>
            /// The primary use case for setting this field is for a StatefulSet's Headless Service to propagate SRV DNS records for its Pods for the purpose of peer discovery. The Kubernetes controllers that generate Endpoints and EndpointSlice resources for Services interpret this to mean that all endpoints are considered "ready" even if the Pods themselves are not. Agents which consume only Kubernetes generated endpoints through the Endpoints or EndpointSlice resources can safely assume this behavior.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#publishNotReadyAddresses
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publishNotReadyAddresses", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? PublishNotReadyAddresses
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>Route service traffic to pods with label keys and values matching this selector.</summary>
            /// <remarks>
            /// If empty or not present, the service is assumed to have an external process managing its endpoints, which Kubernetes will not modify. Only applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if type is ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#selector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Selector
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Supports "ClientIP" and "None".</summary>
            /// <remarks>
            /// Used to maintain session affinity. Enable client IP based session affinity. Must be ClientIP or None. Defaults to None. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
            ///
            /// <strong>Default</strong>: None. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#sessionAffinity
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionAffinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionAffinity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>sessionAffinityConfig contains the configurations of session affinity.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#sessionAffinityConfig
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sessionAffinityConfig", typeJson: "{\"fqn\":\"k8s.SessionAffinityConfig\"}", isOptional: true)]
            public K8s.ISessionAffinityConfig? SessionAffinityConfig
            {
                get => GetInstanceProperty<K8s.ISessionAffinityConfig?>();
            }

            /// <summary>TrafficDistribution offers a way to express preferences for how traffic is distributed to Service endpoints.</summary>
            /// <remarks>
            /// Implementations can use this field as a hint, but are not required to guarantee strict adherence. If the field is not set, the implementation will apply its default routing strategy. If set to "PreferClose", implementations should prioritize endpoints that are topologically close (e.g., same zone).
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#trafficDistribution
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trafficDistribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrafficDistribution
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>type determines how the Service is exposed.</summary>
            /// <remarks>
            /// Defaults to ClusterIP. Valid options are ExternalName, ClusterIP, NodePort, and LoadBalancer. "ClusterIP" allocates a cluster-internal IP address for load-balancing to endpoints. Endpoints are determined by the selector or if that is not specified, by manual construction of an Endpoints object or EndpointSlice objects. If clusterIP is "None", no virtual IP is allocated and the endpoints are published as a set of endpoints rather than a virtual IP. "NodePort" builds on ClusterIP and allocates a port on every node which routes to the same endpoints as the clusterIP. "LoadBalancer" builds on NodePort and creates an external load-balancer (if supported in the current cloud) which routes to the same endpoints as the clusterIP. "ExternalName" aliases this service to the specified externalName. Several other fields do not apply to ExternalName services. More info: https://kubernetes.io/docs/concepts/services-networking/service/#publishing-services-service-types
            ///
            /// <strong>Default</strong>: ClusterIP. Valid options are ExternalName, ClusterIP, NodePort, and LoadBalancer. "ClusterIP" allocates a cluster-internal IP address for load-balancing to endpoints. Endpoints are determined by the selector or if that is not specified, by manual construction of an Endpoints object or EndpointSlice objects. If clusterIP is "None", no virtual IP is allocated and the endpoints are published as a set of endpoints rather than a virtual IP. "NodePort" builds on ClusterIP and allocates a port on every node which routes to the same endpoints as the clusterIP. "LoadBalancer" builds on NodePort and creates an external load-balancer (if supported in the current cloud) which routes to the same endpoints as the clusterIP. "ExternalName" aliases this service to the specified externalName. Several other fields do not apply to ExternalName services. More info: https://kubernetes.io/docs/concepts/services-networking/service/#publishing-services-service-types
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceSpec#type
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
