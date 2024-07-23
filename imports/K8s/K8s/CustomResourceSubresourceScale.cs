using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CustomResourceSubresourceScale defines how to serve the scale subresource for CustomResources.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceSubresourceScale
    /// </remarks>
    [JsiiByValue(fqn: "k8s.CustomResourceSubresourceScale")]
    public class CustomResourceSubresourceScale : K8s.ICustomResourceSubresourceScale
    {
        /// <summary>specReplicasPath defines the JSON path inside of a custom resource that corresponds to Scale `spec.replicas`. Only JSON paths without the array notation are allowed. Must be a JSON Path under `.spec`. If there is no value under the given path in the custom resource, the `/scale` subresource will return an error on GET.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceSubresourceScale#specReplicasPath
        /// </remarks>
        [JsiiProperty(name: "specReplicasPath", typeJson: "{\"primitive\":\"string\"}")]
        public string SpecReplicasPath
        {
            get;
            set;
        }

        /// <summary>statusReplicasPath defines the JSON path inside of a custom resource that corresponds to Scale `status.replicas`. Only JSON paths without the array notation are allowed. Must be a JSON Path under `.status`. If there is no value under the given path in the custom resource, the `status.replicas` value in the `/scale` subresource will default to 0.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceSubresourceScale#statusReplicasPath
        /// </remarks>
        [JsiiProperty(name: "statusReplicasPath", typeJson: "{\"primitive\":\"string\"}")]
        public string StatusReplicasPath
        {
            get;
            set;
        }

        /// <summary>labelSelectorPath defines the JSON path inside of a custom resource that corresponds to Scale `status.selector`. Only JSON paths without the array notation are allowed. Must be a JSON Path under `.status` or `.spec`. Must be set to work with HorizontalPodAutoscaler. The field pointed by this JSON path must be a string field (not a complex selector struct) which contains a serialized label selector in string form. More info: https://kubernetes.io/docs/tasks/access-kubernetes-api/custom-resources/custom-resource-definitions#scale-subresource If there is no value under the given path in the custom resource, the `status.selector` value in the `/scale` subresource will default to the empty string.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceSubresourceScale#labelSelectorPath
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "labelSelectorPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LabelSelectorPath
        {
            get;
            set;
        }
    }
}
