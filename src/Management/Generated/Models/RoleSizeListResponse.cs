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
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Models;

namespace Microsoft.WindowsAzure.Management.Models
{
    /// <summary>
    /// The List Role Sizes operation response.
    /// </summary>
    public partial class RoleSizeListResponse : OperationResponse, IEnumerable<RoleSizeListResponse.RoleSize>
    {
        private IList<RoleSizeListResponse.RoleSize> _roleSizes;
        
        /// <summary>
        /// Optional. The role sizes that are valid for your subscription.
        /// </summary>
        public IList<RoleSizeListResponse.RoleSize> RoleSizes
        {
            get { return this._roleSizes; }
            set { this._roleSizes = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RoleSizeListResponse class.
        /// </summary>
        public RoleSizeListResponse()
        {
            this._roleSizes = new List<RoleSizeListResponse.RoleSize>();
        }
        
        /// <summary>
        /// Gets the sequence of RoleSizes.
        /// </summary>
        public IEnumerator<RoleSizeListResponse.RoleSize> GetEnumerator()
        {
            return this.RoleSizes.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of RoleSizes.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// A role size that is valid for your subscription.
        /// </summary>
        public partial class RoleSize
        {
            private int _cores;
            
            /// <summary>
            /// Optional. Number of cores available for the role size.
            /// </summary>
            public int Cores
            {
                get { return this._cores; }
                set { this._cores = value; }
            }
            
            private string _label;
            
            /// <summary>
            /// Optional. Localized label of the role size.
            /// </summary>
            public string Label
            {
                get { return this._label; }
                set { this._label = value; }
            }
            
            private int _maxDataDiskCount;
            
            /// <summary>
            /// Optional. Number of data disks that can be attached for the
            /// given role size.
            /// </summary>
            public int MaxDataDiskCount
            {
                get { return this._maxDataDiskCount; }
                set { this._maxDataDiskCount = value; }
            }
            
            private int _memoryInMb;
            
            /// <summary>
            /// Optional. Memory available for the role size.
            /// </summary>
            public int MemoryInMb
            {
                get { return this._memoryInMb; }
                set { this._memoryInMb = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. The name of a role size that is valid for your
            /// subscription.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private bool _supportedByVirtualMachines;
            
            /// <summary>
            /// Optional. Indicating if the role size is supported by VMs.
            /// </summary>
            public bool SupportedByVirtualMachines
            {
                get { return this._supportedByVirtualMachines; }
                set { this._supportedByVirtualMachines = value; }
            }
            
            private bool _supportedByWebWorkerRoles;
            
            /// <summary>
            /// Optional. Indicating if the role size is supported by
            /// web/worker roles.
            /// </summary>
            public bool SupportedByWebWorkerRoles
            {
                get { return this._supportedByWebWorkerRoles; }
                set { this._supportedByWebWorkerRoles = value; }
            }
            
            private int _virtualMachineResourceDiskSizeInMb;
            
            /// <summary>
            /// Optional. Resource disk drive size for the role size in IaaS
            /// deployment.
            /// </summary>
            public int VirtualMachineResourceDiskSizeInMb
            {
                get { return this._virtualMachineResourceDiskSizeInMb; }
                set { this._virtualMachineResourceDiskSizeInMb = value; }
            }
            
            private int _webWorkerResourceDiskSizeInMb;
            
            /// <summary>
            /// Optional. Resource disk drive size for the role size in PaaS
            /// deployment.
            /// </summary>
            public int WebWorkerResourceDiskSizeInMb
            {
                get { return this._webWorkerResourceDiskSizeInMb; }
                set { this._webWorkerResourceDiskSizeInMb = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the RoleSize class.
            /// </summary>
            public RoleSize()
            {
            }
        }
    }
}
