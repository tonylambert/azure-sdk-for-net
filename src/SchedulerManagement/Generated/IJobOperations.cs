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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Scheduler.Models;

namespace Microsoft.WindowsAzure.Scheduler
{
    public partial interface IJobOperations
    {
        /// <summary>
        /// If the user wants the server to create the job id then he can use a
        /// POST request to the jobs resource.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Job operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Job operation response.
        /// </returns>
        Task<JobCreateResponse> CreateAsync(JobCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Jobs can be created or updated with a PUT operation to a job's
        /// address. The resource name is the ID of the job. Doing a PUT
        /// operation on a jobId that already exists will completely overwrite
        /// the existing job. Putting an existing job (replace) will reset
        /// internal execution counters.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job to create or update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the job operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Update Job operation response.
        /// </returns>
        Task<JobCreateOrUpdateResponse> CreateOrUpdateAsync(string jobId, JobCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteAsync(string jobId, CancellationToken cancellationToken);
        
        /// <summary>
        /// The status of an individual job can be access by a GET call to a
        /// job's address, jobId.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job to get.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Job operation response.
        /// </returns>
        Task<JobGetResponse> GetAsync(string jobId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Job history tracks the updates and executions of a job.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job to get the history of.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Get Job History operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Job History operation response.
        /// </returns>
        Task<JobGetHistoryResponse> GetHistoryAsync(string jobId, JobGetHistoryParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Job history tracks the updates and executions of a job.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job to get the history of.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Get Job History With Filter operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Job History operation response.
        /// </returns>
        Task<JobGetHistoryResponse> GetHistoryWithFilterAsync(string jobId, JobGetHistoryWithFilterParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Fetch all jobs in a job collection.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the List Jobs operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Jobs operation response.
        /// </returns>
        Task<JobListResponse> ListAsync(JobListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Job collections can be updated through a simple PATCH operation.
        /// The format of the request is the same as that for creating a job,
        /// though if a field is unspecified we will carry forward the current
        /// value.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Jobs State operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Update Jobs State operation response.
        /// </returns>
        Task<JobCollectionJobsUpdateStateResponse> UpdateJobCollectionStateAsync(PatchJobCollectionJobsUpdateStateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Jobs can be updated through a simple PATCH operation to a job's
        /// address. The format of the request is the same as that for
        /// creating a job, though if a field is unspecified we will carry
        /// forward the current value.
        /// </summary>
        /// <param name='jobId'>
        /// Id of the job to update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Job State operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Update Job State operation response.
        /// </returns>
        Task<JobUpdateStateResponse> UpdateStateAsync(string jobId, JobUpdateStateParameters parameters, CancellationToken cancellationToken);
    }
}