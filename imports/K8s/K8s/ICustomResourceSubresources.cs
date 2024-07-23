using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CustomResourceSubresources defines the status and scale subresources for CustomResources.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceSubresources
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICustomResourceSubresources), fullyQualifiedName: "k8s.CustomResourceSubresources")]
    public interface ICustomResourceSubresources
    {
        /// <summary>scale indicates the custom resource should serve a `/scale` subresource that returns an `autoscaling/v1` Scale object.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceSubresources#scale
        /// </remarks>
        [JsiiProperty(name: "scale", typeJson: "{\"fqn\":\"k8s.CustomResourceSubresourceScale\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ICustomResourceSubresourceScale? Scale
        {
            get
            {
                return null;
            }
        }

        /// <summary>status indicates the custom resource should serve a `/status` subresource.</summary>
        /// <remarks>
        /// When enabled: 1. requests to the custom resource primary endpoint ignore changes to the <c>status</c> stanza of the object. 2. requests to the custom resource <c>/status</c> subresource ignore changes to anything other than the <c>status</c> stanza of the object.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceSubresources#status
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>CustomResourceSubresources defines the status and scale subresources for CustomResources.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceSubresources
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICustomResourceSubresources), fullyQualifiedName: "k8s.CustomResourceSubresources")]
        internal sealed class _Proxy : DeputyBase, K8s.ICustomResourceSubresources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>scale indicates the custom resource should serve a `/scale` subresource that returns an `autoscaling/v1` Scale object.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceSubresources#scale
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scale", typeJson: "{\"fqn\":\"k8s.CustomResourceSubresourceScale\"}", isOptional: true)]
            public K8s.ICustomResourceSubresourceScale? Scale
            {
                get => GetInstanceProperty<K8s.ICustomResourceSubresourceScale?>();
            }

            /// <summary>status indicates the custom resource should serve a `/status` subresource.</summary>
            /// <remarks>
            /// When enabled: 1. requests to the custom resource primary endpoint ignore changes to the <c>status</c> stanza of the object. 2. requests to the custom resource <c>/status</c> subresource ignore changes to anything other than the <c>status</c> stanza of the object.
            ///
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceSubresources#status
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
            public object? Status
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
