using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>StackSpec defines the desired state of Pulumi Stack being managed by this operator.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpec
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpec")]
    public class StackSpec : Com.Pulumi.IStackSpec
    {
        /// <summary>Stack is the fully qualified name of the stack to deploy (&lt;org&gt;/&lt;stack&gt;).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpec#stack
        /// </remarks>
        [JsiiProperty(name: "stack", typeJson: "{\"primitive\":\"string\"}")]
        public string Stack
        {
            get;
            set;
        }

        /// <summary>(optional) AccessTokenSecret is the name of a Secret containing the PULUMI_ACCESS_TOKEN for Pulumi access.</summary>
        /// <remarks>
        /// Deprecated: use EnvRefs with a "secret" entry with the key PULUMI_ACCESS_TOKEN instead.
        ///
        /// <strong>Schema</strong>: StackSpec#accessTokenSecret
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessTokenSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessTokenSecret
        {
            get;
            set;
        }

        /// <summary>(optional) Backend is an optional backend URL to use for all Pulumi operations.&lt;br/&gt; Examples:&lt;br/&gt; - Pulumi Service:              "https://app.pulumi.com" (default)&lt;br/&gt; - Self-managed Pulumi Service: "https://pulumi.acmecorp.com" &lt;br/&gt; - Local:                       "file://./einstein" &lt;br/&gt; - AWS:                         "s3://&lt;my-pulumi-state-bucket&gt;" &lt;br/&gt; - Azure:                       "azblob://&lt;my-pulumi-state-bucket&gt;" &lt;br/&gt; - GCP:                         "gs://&lt;my-pulumi-state-bucket&gt;" &lt;br/&gt; See: https://www.pulumi.com/docs/intro/concepts/state/.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpec#backend
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backend", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Backend
        {
            get;
            set;
        }

        /// <summary>(optional) Branch is the branch name to deploy, either the simple or fully qualified ref name, e.g. refs/heads/master. This is mutually exclusive with the Commit setting. Either value needs to be specified. When specified, the operator will periodically poll to check if the branch has any new commits. The frequency of the polling is configurable through ResyncFrequencySeconds, defaulting to every 60 seconds.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpec#branch
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Branch
        {
            get;
            set;
        }

        /// <summary>(optional) Commit is the hash of the commit to deploy.</summary>
        /// <remarks>
        /// If used, HEAD will be in detached mode. This
        /// is mutually exclusive with the Branch setting. Either value needs to be specified.
        ///
        /// <strong>Schema</strong>: StackSpec#commit
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "commit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Commit
        {
            get;
            set;
        }

        /// <summary>(optional) Config is the configuration for this stack, which can be optionally specified inline.</summary>
        /// <remarks>
        /// If this
        /// is omitted, configuration is assumed to be checked in and taken from the source repository.
        ///
        /// <strong>Schema</strong>: StackSpec#config
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "config", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Config
        {
            get;
            set;
        }

        /// <summary>(optional) ContinueResyncOnCommitMatch - when true - informs the operator to continue trying to update stacks even if the revision of the source matches.</summary>
        /// <remarks>
        /// This might be useful in
        /// environments where Pulumi programs have dynamic elements for example, calls to internal APIs
        /// where GitOps style commit tracking is not sufficient.  Defaults to false, i.e. when a
        /// particular revision is successfully run, the operator will not attempt to rerun the program
        /// at that revision again.
        ///
        /// <strong>Default</strong>: false, i.e. when a
        ///
        /// <strong>Schema</strong>: StackSpec#continueResyncOnCommitMatch
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "continueResyncOnCommitMatch", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ContinueResyncOnCommitMatch
        {
            get;
            set;
        }

        /// <summary>(optional) DestroyOnFinalize can be set to true to destroy the stack completely upon deletion of the Stack custom resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpec#destroyOnFinalize
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destroyOnFinalize", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? DestroyOnFinalize
        {
            get;
            set;
        }

        /// <summary>(optional) EnvRefs is an optional map containing environment variables as keys and stores descriptors to where the variables' values should be loaded from (one of literal, environment variable, file on the filesystem, or Kubernetes Secret) as values.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpec#envRefs
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "envRefs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"compulumi.StackSpecEnvRefs\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, Com.Pulumi.IStackSpecEnvRefs>? EnvRefs
        {
            get;
            set;
        }

        /// <summary>(optional) Envs is an optional array of config maps containing environment variables to set.</summary>
        /// <remarks>
        /// Deprecated: use EnvRefs instead.
        ///
        /// <strong>Schema</strong>: StackSpec#envs
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "envs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Envs
        {
            get;
            set;
        }

        /// <summary>(optional) SecretEnvs is an optional array of Secret names containing environment variables to set.</summary>
        /// <remarks>
        /// Deprecated: use EnvRefs instead.
        ///
        /// <strong>Schema</strong>: StackSpec#envSecrets
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "envSecrets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EnvSecrets
        {
            get;
            set;
        }

        /// <summary>(optional) ExpectNoRefreshChanges can be set to true if a stack is not expected to have changes during a refresh before the update is run.</summary>
        /// <remarks>
        /// This could occur, for example, is a resource's state is changing outside of Pulumi
        /// (e.g., metadata, timestamps).
        ///
        /// <strong>Schema</strong>: StackSpec#expectNoRefreshChanges
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expectNoRefreshChanges", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ExpectNoRefreshChanges
        {
            get;
            set;
        }

        /// <summary>FluxSource specifies how to fetch source code from a Flux source object.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpec#fluxSource
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fluxSource", typeJson: "{\"fqn\":\"compulumi.StackSpecFluxSource\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecFluxSource? FluxSource
        {
            get;
            set;
        }

        /// <summary>(optional) GitAuth allows configuring git authentication options There are 3 different authentication options: * SSH private key (and its optional password) * Personal access token * Basic auth username and password Only one authentication mode will be considered if more than one option is specified, with ssh private key/password preferred first, then personal access token, and finally basic auth credentials.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpec#gitAuth
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitAuth", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuth\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecGitAuth? GitAuth
        {
            get;
            set;
        }

        /// <summary>(optional) GitAuthSecret is the the name of a Secret containing an authentication option for the git repository.</summary>
        /// <remarks>
        /// There are 3 different authentication options:
        ///
        /// <list type="bullet">
        /// <description>Personal access token</description>
        /// <description>SSH private key (and it's optional password)</description>
        /// <description>Basic auth username and password
        /// Only one authentication mode will be considered if more than one option is specified,
        /// with ssh private key/password preferred first, then personal access token, and finally
        /// basic auth credentials.
        /// Deprecated. Use GitAuth instead.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: StackSpec#gitAuthSecret
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gitAuthSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GitAuthSecret
        {
            get;
            set;
        }

        /// <summary>(optional) Prerequisites is a list of references to other stacks, each with a constraint on how long ago it must have succeeded.</summary>
        /// <remarks>
        /// This can be used to make sure e.g., state is
        /// re-evaluated before running a stack that depends on it.
        ///
        /// <strong>Schema</strong>: StackSpec#prerequisites
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prerequisites", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"compulumi.StackSpecPrerequisites\"},\"kind\":\"array\"}}", isOptional: true)]
        public Com.Pulumi.IStackSpecPrerequisites[]? Prerequisites
        {
            get;
            set;
        }

        /// <summary>ProgramRef refers to a Program object, to be used as the source for the stack.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpec#programRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "programRef", typeJson: "{\"fqn\":\"compulumi.StackSpecProgramRef\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecProgramRef? ProgramRef
        {
            get;
            set;
        }

        /// <summary>ProjectRepo is the git source control repository from which we fetch the project code and configuration.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpec#projectRepo
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "projectRepo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProjectRepo
        {
            get;
            set;
        }

        /// <summary>(optional) Refresh can be set to true to refresh the stack before it is updated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpec#refresh
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "refresh", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Refresh
        {
            get;
            set;
        }

        /// <summary>(optional) RepoDir is the directory to work from in the project's source repository where Pulumi.yaml is located. It is used in case Pulumi.yaml is not in the project source root.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpec#repoDir
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "repoDir", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RepoDir
        {
            get;
            set;
        }

        /// <summary>(optional) ResyncFrequencySeconds when set to a non-zero value, triggers a resync of the stack at the specified frequency even if no changes to the custom resource are detected.</summary>
        /// <remarks>
        /// If branch tracking is enabled (branch is non-empty), commit polling will occur at this frequency.
        /// The minimal resync frequency supported is 60 seconds. The default value for this field is 60 seconds.
        ///
        /// <strong>Schema</strong>: StackSpec#resyncFrequencySeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resyncFrequencySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ResyncFrequencySeconds
        {
            get;
            set;
        }

        /// <summary>(optional) RetryOnUpdateConflict issues a stack update retry reconciliation loop in the event that the update hits a HTTP 409 conflict due to another update in progress.</summary>
        /// <remarks>
        /// This is only recommended if you are sure that the stack updates are
        /// idempotent, and if you are willing to accept retry loops until
        /// all spawned retries succeed. This will also create a more populated,
        /// and randomized activity timeline for the stack in the Pulumi Service.
        ///
        /// <strong>Schema</strong>: StackSpec#retryOnUpdateConflict
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryOnUpdateConflict", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? RetryOnUpdateConflict
        {
            get;
            set;
        }

        /// <summary>(optional) Secrets is the secret configuration for this stack, which can be optionally specified inline.</summary>
        /// <remarks>
        /// If this
        /// is omitted, secrets configuration is assumed to be checked in and taken from the source repository.
        /// Deprecated: use SecretRefs instead.
        ///
        /// <strong>Schema</strong>: StackSpec#secrets
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secrets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Secrets
        {
            get;
            set;
        }

        /// <summary>(optional) SecretsProvider is used to initialize a Stack with alternative encryption.</summary>
        /// <remarks>
        /// Examples:
        ///
        /// <list type="bullet">
        /// <description>AWS:   "awskms:///arn:aws:kms:us-east-1:111122223333:key/1234abcd-12ab-34bc-56ef-1234567890ab?region=us-east-1"</description>
        /// <description>Azure: "azurekeyvault://acmecorpvault.vault.azure.net/keys/mykeyname"</description>
        /// <description>GCP:   "gcpkms://projects/MYPROJECT/locations/MYLOCATION/keyRings/MYKEYRING/cryptoKeys/MYKEY"</description>
        /// </list>
        ///
        /// See: https://www.pulumi.com/docs/intro/concepts/secrets/#initializing-a-stack-with-alternative-encryption
        ///
        /// <strong>Schema</strong>: StackSpec#secretsProvider
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretsProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretsProvider
        {
            get;
            set;
        }

        /// <summary>(optional) SecretRefs is the secret configuration for this stack which can be specified through ResourceRef.</summary>
        /// <remarks>
        /// If this is omitted, secrets configuration is assumed to be checked in and taken from the source repository.
        ///
        /// <strong>Schema</strong>: StackSpec#secretsRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretsRef", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"compulumi.StackSpecSecretsRef\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, Com.Pulumi.IStackSpecSecretsRef>? SecretsRef
        {
            get;
            set;
        }

        /// <summary>(optional) Targets is a list of URNs of resources to update exclusively.</summary>
        /// <remarks>
        /// If supplied, only
        /// resources mentioned will be updated.
        ///
        /// <strong>Schema</strong>: StackSpec#targets
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Targets
        {
            get;
            set;
        }

        /// <summary>(optional) UseLocalStackOnly can be set to true to prevent the operator from creating stacks that do not exist in the tracking git repo.</summary>
        /// <remarks>
        /// The default behavior is to create a stack if it doesn't exist.
        ///
        /// <strong>Schema</strong>: StackSpec#useLocalStackOnly
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useLocalStackOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? UseLocalStackOnly
        {
            get;
            set;
        }
    }
}
