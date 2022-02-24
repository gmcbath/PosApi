﻿#region (c) 2022 Binary Builders Inc. All rights reserved.

// ICompanyService.cs
// 
// Copyright (C) 2022 Binary Builders Inc.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

#endregion

#region using

using Api.Entities.Models;
using Api.Shared.DataTransferObjects;

#endregion

namespace Api.Service.Contracts;

public interface ICompanyService
{
    IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges);
    CompanyDto GetCompany(int companyId, bool trackChanges);
    CompanyDto CreateCompany(CompanyForCreationDto company);
    IEnumerable<CompanyDto> GetByIds(IEnumerable<int> ids, bool trackChanges);
    (IEnumerable<CompanyDto> companies, string ids) CreateCompanyCollection(IEnumerable<CompanyForCreationDto> companyCollection);
    void DeleteCompany(int companyId, bool trackChanges);
    void UpdateCompany(int companyId, CompanyForUpdateDto companyForUpdate, bool trackChanges);
    (CompanyForUpdateDto companyToPatch, Company companyEntity) GetCompanyForPatch(int companyId, bool compTrackChanges);
    void SaveChangesForPatch(CompanyForUpdateDto companyToPatch, Company companyEntity);
}