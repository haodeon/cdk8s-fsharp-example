using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>PrerequisiteRef refers to another stack, and gives requirements for the prerequisite to be considered satisfied.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecPrerequisites
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecPrerequisites), fullyQualifiedName: "compulumi.StackSpecPrerequisites")]
    public interface IStackSpecPrerequisites
    {
        /// <summary>Name is the name of the Stack resource that is a prerequisite.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecPrerequisites#name
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
        /// <strong>Schema</strong>: StackSpecPrerequisites#requirement
        /// </remarks>
        [JsiiProperty(name: "requirement", typeJson: "{\"fqn\":\"compulumi.StackSpecPrerequisitesRequirement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecPrerequisitesRequirement? Requirement
        {
            get
            {
                return null;
            }
        }

        /// <summary>PrerequisiteRef refers to another stack, and gives requirements for the prerequisite to be considered satisfied.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecPrerequisites
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecPrerequisites), fullyQualifiedName: "compulumi.StackSpecPrerequisites")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecPrerequisites
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name is the name of the Stack resource that is a prerequisite.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecPrerequisites#name
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
            /// <strong>Schema</strong>: StackSpecPrerequisites#requirement
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requirement", typeJson: "{\"fqn\":\"compulumi.StackSpecPrerequisitesRequirement\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecPrerequisitesRequirement? Requirement
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecPrerequisitesRequirement?>();
            }
        }
    }
}
