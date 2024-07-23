using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a Flocker volume mounted by the Flocker agent.</summary>
    /// <remarks>
    /// One and only one of datasetName and datasetUUID should be set. Flocker volumes do not support ownership management or SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.FlockerVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IFlockerVolumeSource), fullyQualifiedName: "k8s.FlockerVolumeSource")]
    public interface IFlockerVolumeSource
    {
        /// <summary>datasetName is Name of the dataset stored as metadata -&gt; name on the dataset for Flocker should be considered as deprecated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlockerVolumeSource#datasetName
        /// </remarks>
        [JsiiProperty(name: "datasetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatasetName
        {
            get
            {
                return null;
            }
        }

        /// <summary>datasetUUID is the UUID of the dataset.</summary>
        /// <remarks>
        /// This is unique identifier of a Flocker dataset
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlockerVolumeSource#datasetUUID
        /// </remarks>
        [JsiiProperty(name: "datasetUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatasetUuid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Represents a Flocker volume mounted by the Flocker agent.</summary>
        /// <remarks>
        /// One and only one of datasetName and datasetUUID should be set. Flocker volumes do not support ownership management or SELinux relabeling.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlockerVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IFlockerVolumeSource), fullyQualifiedName: "k8s.FlockerVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IFlockerVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>datasetName is Name of the dataset stored as metadata -&gt; name on the dataset for Flocker should be considered as deprecated.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.FlockerVolumeSource#datasetName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "datasetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatasetName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>datasetUUID is the UUID of the dataset.</summary>
            /// <remarks>
            /// This is unique identifier of a Flocker dataset
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.FlockerVolumeSource#datasetUUID
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "datasetUuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatasetUuid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
