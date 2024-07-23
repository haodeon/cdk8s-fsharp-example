using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Preconditions must be fulfilled before an operation (update, delete, etc.) is carried out.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Preconditions
    /// </remarks>
    [JsiiByValue(fqn: "k8s.Preconditions")]
    public class Preconditions : K8s.IPreconditions
    {
        /// <summary>Specifies the target ResourceVersion.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Preconditions#resourceVersion
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceVersion
        {
            get;
            set;
        }

        /// <summary>Specifies the target UID.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Preconditions#uid
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uid
        {
            get;
            set;
        }
    }
}
