﻿// Copyright ©2020 Jacobs Data Solutions

// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the
// License at

// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
using AutoFixture;
using JDS.OrgManager.Application.Common.PaidTimeOffPolicies;
using JDS.OrgManager.Domain.HumanResources.PaidTimeOffPolicies;
using Xunit;

namespace JDS.OrgManager.Application.UnitTests.Common.PaidTimeOffPolicies
{
    public class PaidTimeOffPolicyDomainToDbEntityMapperTests
    {
        private Fixture fixture;

        private PaidTimeOffPolicyDomainToDbEntityMapper mapper;

        public PaidTimeOffPolicyDomainToDbEntityMapperTests()
        {
            mapper = new PaidTimeOffPolicyDomainToDbEntityMapper();
            mapper.ApplyMappingConfiguration();

            fixture = new Fixture();
            // client has a circular reference from AutoFixture point of view
            fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }

        [Fact]
        public void MapToDbEntity_WorksAsExpected()
        {
            var e = new PaidTimeOffPolicy(true, 6, true, 55.0m, "HELLO", 10.0M) { Id = 67 };
            var d = mapper.MapToDbEntity(e);
            Assert.Equal(e.Id, d.Id);
            Assert.Equal(e.AllowsUnlimitedPto, d.AllowsUnlimitedPto);
            Assert.Equal(e.EmployeeLevel, d.EmployeeLevel);
            Assert.Equal(e.IsDefaultForEmployeeLevel, d.IsDefaultForEmployeeLevel);
            Assert.Equal(e.MaxPtoHours, d.MaxPtoHours);
            Assert.Equal(e.Name, d.Name);
            Assert.Equal(e.PtoAccrualRate, d.PtoAccrualRate);
        }

        [Fact]
        public void MapToDomainEntity_WorksAsExpected()
        {
            var d = fixture.Create<PaidTimeOffPolicyEntity>();
            var e = mapper.MapToDomainEntity(d);
            Assert.Equal(d.Id, e.Id);
            Assert.Equal(d.AllowsUnlimitedPto, e.AllowsUnlimitedPto);
            Assert.Equal(d.EmployeeLevel, e.EmployeeLevel);
            Assert.Equal(d.IsDefaultForEmployeeLevel, e.IsDefaultForEmployeeLevel);
            Assert.Equal(d.MaxPtoHours, e.MaxPtoHours);
            Assert.Equal(d.Name, e.Name);
            Assert.Equal(d.PtoAccrualRate, e.PtoAccrualRate);
        }
    }
}