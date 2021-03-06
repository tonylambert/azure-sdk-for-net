// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// Data contract for retrieving gateway connection information. All of its
    /// properties are set by the service side and read-only on the client
    /// side.
    /// </summary>
    public partial class GatewayConnectionInfo
    {
        private Uri _hostServiceUri;
        
        /// <summary>
        /// Required. Gateway host service Uri.
        /// </summary>
        public Uri HostServiceUri
        {
            get { return this._hostServiceUri; }
            set { this._hostServiceUri = value; }
        }
        
        private string _identityCertThumbprint;
        
        /// <summary>
        /// Required. Gateway identity certificate thumbprint.
        /// </summary>
        public string IdentityCertThumbprint
        {
            get { return this._identityCertThumbprint; }
            set { this._identityCertThumbprint = value; }
        }
        
        private string _serviceToken;
        
        /// <summary>
        /// Required. Gateway service token.
        /// </summary>
        public string ServiceToken
        {
            get { return this._serviceToken; }
            set { this._serviceToken = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GatewayConnectionInfo class.
        /// </summary>
        public GatewayConnectionInfo()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the GatewayConnectionInfo class with
        /// required arguments.
        /// </summary>
        public GatewayConnectionInfo(string serviceToken, string identityCertThumbprint, Uri hostServiceUri)
            : this()
        {
            if (serviceToken == null)
            {
                throw new ArgumentNullException("serviceToken");
            }
            if (identityCertThumbprint == null)
            {
                throw new ArgumentNullException("identityCertThumbprint");
            }
            if (hostServiceUri == null)
            {
                throw new ArgumentNullException("hostServiceUri");
            }
            this.ServiceToken = serviceToken;
            this.IdentityCertThumbprint = identityCertThumbprint;
            this.HostServiceUri = hostServiceUri;
        }
    }
}
