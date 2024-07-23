using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CustomResourceSubresources defines the status and scale subresources for CustomResources.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceSubresources
    /// </remarks>
    [JsiiByValue(fqn: "k8s.CustomResourceSubresources")]
    public class CustomResourceSubresources : K8s.ICustomResourceSubresources
    {
        /// <summary>scale indicates the custom resource should serve a `/scale` subresource that returns an `autoscaling/v1` Scale object.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceSubresources#scale
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scale", typeJson: "{\"fqn\":\"k8s.CustomResourceSubresourceScale\"}", isOptional: true)]
        public K8s.ICustomResourceSubresourceScale? Scale
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
