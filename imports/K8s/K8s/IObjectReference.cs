using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IObjectReference), fullyQualifiedName: "k8s.ObjectReference")]
    public interface IObjectReference
    {
        /// <summary>API version of the referent.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#apiVersion
        /// </remarks>
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#fieldPath
        /// </remarks>
        [JsiiProperty(name: "fieldPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FieldPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Kind of the referent.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kind
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Namespace of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#namespace
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specific resourceVersion to which this reference is made, if any.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#resourceVersion
        /// </remarks>
        [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>UID of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#uid
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uid
        {
            get
            {
                return null;
            }
        }

        /// <summary>ObjectReference contains enough information to let you inspect or modify the referred object.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IObjectReference), fullyQualifiedName: "k8s.ObjectReference")]
        internal sealed class _Proxy : DeputyBase, K8s.IObjectReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>API version of the referent.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#apiVersion
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#fieldPath
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FieldPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Kind of the referent.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#kind
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kind
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Name of the referent.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Namespace of the referent.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#namespace
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specific resourceVersion to which this reference is made, if any.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#resourceVersion
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>UID of the referent.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ObjectReference#uid
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
