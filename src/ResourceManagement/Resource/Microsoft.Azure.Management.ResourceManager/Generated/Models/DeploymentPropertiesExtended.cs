// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Deployment properties with additional details.
    /// </summary>
    public partial class DeploymentPropertiesExtended
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentPropertiesExtended
        /// class.
        /// </summary>
        public DeploymentPropertiesExtended() { }

        /// <summary>
        /// Initializes a new instance of the DeploymentPropertiesExtended
        /// class.
        /// </summary>
        public DeploymentPropertiesExtended(string provisioningState = default(string), string correlationId = default(string), DateTime? timestamp = default(DateTime?), object outputs = default(object), IList<Provider> providers = default(IList<Provider>), IList<Dependency> dependencies = default(IList<Dependency>), object template = default(object), TemplateLink templateLink = default(TemplateLink), object parameters = default(object), ParametersLink parametersLink = default(ParametersLink), DeploymentMode? mode = default(DeploymentMode?), DebugSetting debugSetting = default(DebugSetting))
        {
            ProvisioningState = provisioningState;
            CorrelationId = correlationId;
            Timestamp = timestamp;
            Outputs = outputs;
            Providers = providers;
            Dependencies = dependencies;
            Template = template;
            TemplateLink = templateLink;
            Parameters = parameters;
            ParametersLink = parametersLink;
            Mode = mode;
            DebugSetting = debugSetting;
        }

        /// <summary>
        /// Gets or sets the state of the provisioning.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the correlation ID of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the template deployment.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets key/value pairs that represent deploymentoutput.
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public object Outputs { get; set; }

        /// <summary>
        /// Gets the list of resource providers needed for the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "providers")]
        public IList<Provider> Providers { get; set; }

        /// <summary>
        /// Gets the list of deployment dependencies.
        /// </summary>
        [JsonProperty(PropertyName = "dependencies")]
        public IList<Dependency> Dependencies { get; set; }

        /// <summary>
        /// Gets or sets the template content. Use only one of Template or
        /// TemplateLink.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public object Template { get; set; }

        /// <summary>
        /// Gets or sets the URI referencing the template. Use only one of
        /// Template or TemplateLink.
        /// </summary>
        [JsonProperty(PropertyName = "templateLink")]
        public TemplateLink TemplateLink { get; set; }

        /// <summary>
        /// Deployment parameters. Use only one of Parameters or
        /// ParametersLink.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public object Parameters { get; set; }

        /// <summary>
        /// Gets or sets the URI referencing the parameters. Use only one of
        /// Parameters or ParametersLink.
        /// </summary>
        [JsonProperty(PropertyName = "parametersLink")]
        public ParametersLink ParametersLink { get; set; }

        /// <summary>
        /// Gets or sets the deployment mode. Possible values for this
        /// property include: 'Incremental', 'Complete'.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public DeploymentMode? Mode { get; set; }

        /// <summary>
        /// Gets or sets the debug setting of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "debugSetting")]
        public DebugSetting DebugSetting { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.TemplateLink != null)
            {
                this.TemplateLink.Validate();
            }
            if (this.ParametersLink != null)
            {
                this.ParametersLink.Validate();
            }
        }
    }
}
