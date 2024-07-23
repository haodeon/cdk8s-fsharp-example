open Constructs
open Org.Cdk8s
open K8s

// Define a function to create a Kubernetes Deployment
let createDeployment (scope: Chart) (ns: string) (appLabel: string) =
    let metadata =
        ObjectMeta(
            Labels = Map.ofList [ ("app", appLabel) ]
        )

    let container =
        Container(
            Name = "app-container",
            Image = "nginx:1.19.10",
            Ports = [| ContainerPort_(ContainerPort = 80.0) :> IContainerPort |]
        )

    let podSpec =
        PodSpec(
            Containers = [| container |]
        )

    let podTemplate =
        PodTemplateSpec(
            Metadata = metadata,
            Spec = podSpec
        )

    let labelSelector =
        LabelSelector(
            MatchLabels = Map.ofList [ ("app", appLabel) ]
        )

    let deploymentSpec =
        DeploymentSpec(
            Replicas = 3,
            Selector = labelSelector,
            Template = podTemplate
        )

    KubeDeployment(scope, ns, KubeDeploymentProps(Spec = deploymentSpec))

[<EntryPoint>]
let main argv =
    let app = App()
    let chart = Chart(app, "getting-started")
    // Create the deployment using the function
    let _ = createDeployment chart "my-deployment" "my-app"
    app.Synth()
    0 // Return an integer exit code
