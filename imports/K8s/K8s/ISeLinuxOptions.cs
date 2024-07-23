using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SELinuxOptions are the labels to be applied to the container.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISeLinuxOptions), fullyQualifiedName: "k8s.SeLinuxOptions")]
    public interface ISeLinuxOptions
    {
        /// <summary>Level is SELinux level label that applies to the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions#level
        /// </remarks>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Level
        {
            get
            {
                return null;
            }
        }

        /// <summary>Role is a SELinux role label that applies to the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions#role
        /// </remarks>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Role
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type is a SELinux type label that applies to the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions#type
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

        /// <summary>User is a SELinux user label that applies to the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions#user
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

        /// <summary>SELinuxOptions are the labels to be applied to the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISeLinuxOptions), fullyQualifiedName: "k8s.SeLinuxOptions")]
        internal sealed class _Proxy : DeputyBase, K8s.ISeLinuxOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Level is SELinux level label that applies to the container.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions#level
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Level
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Role is a SELinux role label that applies to the container.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions#role
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Role
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Type is a SELinux type label that applies to the container.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions#type
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>User is a SELinux user label that applies to the container.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions#user
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
