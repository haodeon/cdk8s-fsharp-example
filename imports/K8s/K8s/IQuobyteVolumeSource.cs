using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a Quobyte mount that lasts the lifetime of a pod.</summary>
    /// <remarks>
    /// Quobyte volumes do not support ownership management or SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IQuobyteVolumeSource), fullyQualifiedName: "k8s.QuobyteVolumeSource")]
    public interface IQuobyteVolumeSource
    {
        /// <summary>registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource#registry
        /// </remarks>
        [JsiiProperty(name: "registry", typeJson: "{\"primitive\":\"string\"}")]
        string Registry
        {
            get;
        }

        /// <summary>volume is a string that references an already created Quobyte volume by name.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource#volume
        /// </remarks>
        [JsiiProperty(name: "volume", typeJson: "{\"primitive\":\"string\"}")]
        string Volume
        {
            get;
        }

        /// <summary>group to map volume access to Default is no group.</summary>
        /// <remarks>
        /// <strong>Default</strong>: no group
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource#group
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

        /// <summary>readOnly here will force the Quobyte volume to be mounted with read-only permissions.</summary>
        /// <remarks>
        /// Defaults to false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource#readOnly
        /// </remarks>
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ReadOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>tenant owning the given Quobyte volume in the Backend Used with dynamically provisioned Quobyte volumes, value is set by the plugin.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource#tenant
        /// </remarks>
        [JsiiProperty(name: "tenant", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Tenant
        {
            get
            {
                return null;
            }
        }

        /// <summary>user to map volume access to Defaults to serivceaccount user.</summary>
        /// <remarks>
        /// <strong>Default</strong>: serivceaccount user
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource#user
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? User
        {
            get
            {
                return null;
            }
        }

        /// <summary>Represents a Quobyte mount that lasts the lifetime of a pod.</summary>
        /// <remarks>
        /// Quobyte volumes do not support ownership management or SELinux relabeling.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IQuobyteVolumeSource), fullyQualifiedName: "k8s.QuobyteVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IQuobyteVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource#registry
            /// </remarks>
            [JsiiProperty(name: "registry", typeJson: "{\"primitive\":\"string\"}")]
            public string Registry
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>volume is a string that references an already created Quobyte volume by name.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource#volume
            /// </remarks>
            [JsiiProperty(name: "volume", typeJson: "{\"primitive\":\"string\"}")]
            public string Volume
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>group to map volume access to Default is no group.</summary>
            /// <remarks>
            /// <strong>Default</strong>: no group
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource#group
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Group
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>readOnly here will force the Quobyte volume to be mounted with read-only permissions.</summary>
            /// <remarks>
            /// Defaults to false.
            ///
            /// <strong>Default</strong>: false.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource#readOnly
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnly
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>tenant owning the given Quobyte volume in the Backend Used with dynamically provisioned Quobyte volumes, value is set by the plugin.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource#tenant
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tenant", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Tenant
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>user to map volume access to Defaults to serivceaccount user.</summary>
            /// <remarks>
            /// <strong>Default</strong>: serivceaccount user
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.QuobyteVolumeSource#user
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? User
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
