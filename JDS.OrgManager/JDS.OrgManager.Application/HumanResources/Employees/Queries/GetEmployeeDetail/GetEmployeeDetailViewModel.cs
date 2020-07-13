// Copyright ?020 Jacobs Data Solutions

// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the
// License at

// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
using JDS.OrgManager.Application.Models;
using JDS.OrgManager.Domain.Common.People;
using System;

namespace JDS.OrgManager.Application.HumanResources.Employees.Queries.GetEmployeeDetail
{
    public class GetEmployeeDetailViewModel : ViewModel
    {
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string CurrencyCode { get; set; }

        public DateTime? DateExited { get; set; }

        public DateTime DateHired { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int EmployeeLevel { get; set; }

        public string FirstName { get; set; }

        public Gender Gender { get; set; }

        public int Id { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public int PaidTimeOffPolicyId { get; set; }

        public decimal? PtoHoursRemaining { get; set; }

        public decimal Salary { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }
    }
}