// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Network.Models;
using System.Text.RegularExpressions;
using MNM = Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Commands.Network.AzureFirewall.PacketCaptureRule
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "FirewallPacketCaptureRule", SupportsShouldProcess = true), OutputType(typeof(PSAzureFirewallPacketCaptureRule))]
    public class NewAzureFirewallPacketCaptureRuleCommand : AzureFirewallBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The source addresses of the rule")]
        [ValidateNotNullOrEmpty]
        public string[] Source { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The destination addresses of the rule")]
        [ValidateNotNullOrEmpty]
        public string[] Destination { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The destination ports of the rule")]
        public string[] DestinationPort { get; set; }

        public override void Execute()
        {
            base.Execute();

            // Sources and destinations must be specified
            if ((Source == null) || (Destination == null))
            {
                throw new ArgumentException("Both Sources and Destinations must be specified.");
            }

            var filterRule = new PSAzureFirewallPacketCaptureRule
            {
                Sources = Source.ToList(),
                Destinations = Destination.ToList(),
                DestinationPorts = DestinationPort?.ToList()
            };
            WriteObject(filterRule);
        }
    }
}
