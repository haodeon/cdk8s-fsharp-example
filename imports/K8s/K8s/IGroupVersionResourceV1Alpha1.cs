using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>The names of the group, the version, and the resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.GroupVersionResource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IGroupVersionResourceV1Alpha1), fullyQualifiedName: "k8s.GroupVersionResourceV1Alpha1")]
    public interface IGroupVersionResourceV1Alpha1
    {
        /// <summary>The name of the group.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.GroupVersionResource#group
        /// </remarks>
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.GroupVersionResource#resource
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Resource
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the version.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.GroupVersionResource#version
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>The names of the group, the version, and the resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.GroupVersionResource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IGroupVersionResourceV1Alpha1), fullyQualifiedName: "k8s.GroupVersionResourceV1Alpha1")]
        internal sealed class _Proxy : DeputyBase, K8s.IGroupVersionResourceV1Alpha1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the group.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.GroupVersionResource#group
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Group
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the resource.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.GroupVersionResource#resource
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Resource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the version.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.GroupVersionResource#version
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
