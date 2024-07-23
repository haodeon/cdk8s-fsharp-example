using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceFieldSelector represents container resources (cpu, memory) and their output format.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceFieldSelector
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IResourceFieldSelector), fullyQualifiedName: "k8s.ResourceFieldSelector")]
    public interface IResourceFieldSelector
    {
        /// <summary>Required: resource to select.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceFieldSelector#resource
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
        string Resource
        {
            get;
        }

        /// <summary>Container name: required for volumes, optional for env vars.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceFieldSelector#containerName
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

        /// <summary>Specifies the output format of the exposed resources, defaults to "1".</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceFieldSelector#divisor
        /// </remarks>
        [JsiiProperty(name: "divisor", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.Quantity? Divisor
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceFieldSelector represents container resources (cpu, memory) and their output format.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceFieldSelector
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IResourceFieldSelector), fullyQualifiedName: "k8s.ResourceFieldSelector")]
        internal sealed class _Proxy : DeputyBase, K8s.IResourceFieldSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Required: resource to select.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceFieldSelector#resource
            /// </remarks>
            [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
            public string Resource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Container name: required for volumes, optional for env vars.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceFieldSelector#containerName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the output format of the exposed resources, defaults to "1".</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceFieldSelector#divisor
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "divisor", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
            public K8s.Quantity? Divisor
            {
                get => GetInstanceProperty<K8s.Quantity?>();
            }
        }
    }
}
