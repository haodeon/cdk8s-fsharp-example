using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>PrerequisiteRef refers to another stack, and gives requirements for the prerequisite to be considered satisfied.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecPrerequisites
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackV1Alpha1SpecPrerequisites), fullyQualifiedName: "compulumi.StackV1Alpha1SpecPrerequisites")]
    public interface IStackV1Alpha1SpecPrerequisites
    {
        /// <summary>Name is the name of the Stack resource that is a prerequisite.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecPrerequisites#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Requirement gives specific requirements for the prerequisite;</summary>
        /// <remarks>
        /// the base requirement is that
        /// the referenced stack is in a successful state.
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecPrerequisites#requirement
        /// </remarks>
        [JsiiProperty(name: "requirement", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecPrerequisitesRequirement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackV1Alpha1SpecPrerequisitesRequirement? Requirement
        {
            get
            {
                return null;
            }
        }

        /// <summary>PrerequisiteRef refers to another stack, and gives requirements for the prerequisite to be considered satisfied.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecPrerequisites
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackV1Alpha1SpecPrerequisites), fullyQualifiedName: "compulumi.StackV1Alpha1SpecPrerequisites")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackV1Alpha1SpecPrerequisites
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name is the name of the Stack resource that is a prerequisite.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecPrerequisites#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Requirement gives specific requirements for the prerequisite;</summary>
            /// <remarks>
            /// the base requirement is that
            /// the referenced stack is in a successful state.
            ///
            /// <strong>Schema</strong>: StackV1Alpha1SpecPrerequisites#requirement
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requirement", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecPrerequisitesRequirement\"}", isOptional: true)]
            public Com.Pulumi.IStackV1Alpha1SpecPrerequisitesRequirement? Requirement
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecPrerequisitesRequirement?>();
            }
        }
    }
}
