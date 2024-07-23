using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>options contains all resource options supported by Pulumi.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: ProgramProgramResourcesOptions
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IProgramProgramResourcesOptions), fullyQualifiedName: "compulumi.ProgramProgramResourcesOptions")]
    public interface IProgramProgramResourcesOptions
    {
        /// <summary>additionalSecretOutputs specifies properties that must be encrypted as secrets.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions#additionalSecretOutputs
        /// </remarks>
        [JsiiProperty(name: "additionalSecretOutputs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdditionalSecretOutputs
        {
            get
            {
                return null;
            }
        }

        /// <summary>aliases specifies names that this resource used to have, so that renaming or refactoring doesn’t replace it.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions#aliases
        /// </remarks>
        [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Aliases
        {
            get
            {
                return null;
            }
        }

        /// <summary>customTimeouts overrides the default retry/timeout behavior for resource provisioning.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions#customTimeouts
        /// </remarks>
        [JsiiProperty(name: "customTimeouts", typeJson: "{\"fqn\":\"compulumi.ProgramProgramResourcesOptionsCustomTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IProgramProgramResourcesOptionsCustomTimeouts? CustomTimeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>deleteBeforeReplace overrides the default create-before-delete behavior when replacing.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions#deleteBeforeReplace
        /// </remarks>
        [JsiiProperty(name: "deleteBeforeReplace", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DeleteBeforeReplace
        {
            get
            {
                return null;
            }
        }

        /// <summary>dependsOn adds explicit dependencies in addition to the ones in the dependency graph.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions#dependsOn
        /// </remarks>
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object[]? DependsOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>ignoreChanges declares that changes to certain properties should be ignored when diffing.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions#ignoreChanges
        /// </remarks>
        [JsiiProperty(name: "ignoreChanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IgnoreChanges
        {
            get
            {
                return null;
            }
        }

        /// <summary>import adopts an existing resource from your cloud account under the control of Pulumi.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions#import
        /// </remarks>
        [JsiiProperty(name: "import", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Import
        {
            get
            {
                return null;
            }
        }

        /// <summary>parent resource option specifies a parent for a resource.</summary>
        /// <remarks>
        /// It is used to associate
        /// children with the parents that encapsulate or are responsible for them.
        ///
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions#parent
        /// </remarks>
        [JsiiProperty(name: "parent", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Parent
        {
            get
            {
                return null;
            }
        }

        /// <summary>protect prevents accidental deletion of a resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions#protect
        /// </remarks>
        [JsiiProperty(name: "protect", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Protect
        {
            get
            {
                return null;
            }
        }

        /// <summary>provider resource option sets a provider for the resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions#provider
        /// </remarks>
        [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Provider
        {
            get
            {
                return null;
            }
        }

        /// <summary>providers resource option sets a map of providers for the resource and its children.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions#providers
        /// </remarks>
        [JsiiProperty(name: "providers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, object>? Providers
        {
            get
            {
                return null;
            }
        }

        /// <summary>version specifies a provider plugin version that should be used when operating on a resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions#version
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

        /// <summary>options contains all resource options supported by Pulumi.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: ProgramProgramResourcesOptions
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IProgramProgramResourcesOptions), fullyQualifiedName: "compulumi.ProgramProgramResourcesOptions")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IProgramProgramResourcesOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>additionalSecretOutputs specifies properties that must be encrypted as secrets.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptions#additionalSecretOutputs
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalSecretOutputs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdditionalSecretOutputs
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>aliases specifies names that this resource used to have, so that renaming or refactoring doesn’t replace it.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptions#aliases
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Aliases
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>customTimeouts overrides the default retry/timeout behavior for resource provisioning.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptions#customTimeouts
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customTimeouts", typeJson: "{\"fqn\":\"compulumi.ProgramProgramResourcesOptionsCustomTimeouts\"}", isOptional: true)]
            public Com.Pulumi.IProgramProgramResourcesOptionsCustomTimeouts? CustomTimeouts
            {
                get => GetInstanceProperty<Com.Pulumi.IProgramProgramResourcesOptionsCustomTimeouts?>();
            }

            /// <summary>deleteBeforeReplace overrides the default create-before-delete behavior when replacing.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptions#deleteBeforeReplace
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteBeforeReplace", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DeleteBeforeReplace
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>dependsOn adds explicit dependencies in addition to the ones in the dependency graph.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptions#dependsOn
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? DependsOn
            {
                get => GetInstanceProperty<object[]?>();
            }

            /// <summary>ignoreChanges declares that changes to certain properties should be ignored when diffing.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptions#ignoreChanges
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreChanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IgnoreChanges
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>import adopts an existing resource from your cloud account under the control of Pulumi.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptions#import
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "import", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Import
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>parent resource option specifies a parent for a resource.</summary>
            /// <remarks>
            /// It is used to associate
            /// children with the parents that encapsulate or are responsible for them.
            ///
            /// <strong>Schema</strong>: ProgramProgramResourcesOptions#parent
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parent", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
            public object? Parent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>protect prevents accidental deletion of a resource.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptions#protect
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protect", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Protect
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>provider resource option sets a provider for the resource.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptions#provider
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
            public object? Provider
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>providers resource option sets a map of providers for the resource and its children.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptions#providers
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "providers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, object>? Providers
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
            }

            /// <summary>version specifies a provider plugin version that should be used when operating on a resource.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: ProgramProgramResourcesOptions#version
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
