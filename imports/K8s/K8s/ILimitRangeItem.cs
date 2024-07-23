using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>LimitRangeItem defines a min/max usage limit for any resource that matches on kind.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ILimitRangeItem), fullyQualifiedName: "k8s.LimitRangeItem")]
    public interface ILimitRangeItem
    {
        /// <summary>Type of resource that this limit applies to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Default resource requirement limit value by resource name if resource limit is omitted.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem#default
        /// </remarks>
        [JsiiProperty(name: "default", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, K8s.Quantity>? Default
        {
            get
            {
                return null;
            }
        }

        /// <summary>DefaultRequest is the default resource requirement request value by resource name if resource request is omitted.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem#defaultRequest
        /// </remarks>
        [JsiiProperty(name: "defaultRequest", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, K8s.Quantity>? DefaultRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Max usage constraints on this kind by resource name.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem#max
        /// </remarks>
        [JsiiProperty(name: "max", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, K8s.Quantity>? Max
        {
            get
            {
                return null;
            }
        }

        /// <summary>MaxLimitRequestRatio if specified, the named resource must have a request and limit that are both non-zero where limit divided by request is less than or equal to the enumerated value;</summary>
        /// <remarks>
        /// this represents the max burst for the named resource.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem#maxLimitRequestRatio
        /// </remarks>
        [JsiiProperty(name: "maxLimitRequestRatio", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, K8s.Quantity>? MaxLimitRequestRatio
        {
            get
            {
                return null;
            }
        }

        /// <summary>Min usage constraints on this kind by resource name.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem#min
        /// </remarks>
        [JsiiProperty(name: "min", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, K8s.Quantity>? Min
        {
            get
            {
                return null;
            }
        }

        /// <summary>LimitRangeItem defines a min/max usage limit for any resource that matches on kind.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ILimitRangeItem), fullyQualifiedName: "k8s.LimitRangeItem")]
        internal sealed class _Proxy : DeputyBase, K8s.ILimitRangeItem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of resource that this limit applies to.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Default resource requirement limit value by resource name if resource limit is omitted.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem#default
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, K8s.Quantity>? Default
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, K8s.Quantity>?>();
            }

            /// <summary>DefaultRequest is the default resource requirement request value by resource name if resource request is omitted.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem#defaultRequest
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultRequest", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, K8s.Quantity>? DefaultRequest
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, K8s.Quantity>?>();
            }

            /// <summary>Max usage constraints on this kind by resource name.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem#max
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "max", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, K8s.Quantity>? Max
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, K8s.Quantity>?>();
            }

            /// <summary>MaxLimitRequestRatio if specified, the named resource must have a request and limit that are both non-zero where limit divided by request is less than or equal to the enumerated value;</summary>
            /// <remarks>
            /// this represents the max burst for the named resource.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem#maxLimitRequestRatio
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxLimitRequestRatio", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, K8s.Quantity>? MaxLimitRequestRatio
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, K8s.Quantity>?>();
            }

            /// <summary>Min usage constraints on this kind by resource name.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeItem#min
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "min", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, K8s.Quantity>? Min
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, K8s.Quantity>?>();
            }
        }
    }
}
