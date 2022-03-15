﻿#region (c) 2022 Binary Builders Inc. All rights reserved.

// CompanyCollectionBadRequestException.cs
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

using System.Diagnostics.CodeAnalysis;

#endregion

[assembly: SuppressMessage("NDepend", "ND1500:APIBreakingChangesTypes", Target = "Api.Entities.Exceptions", Scope = "type", Justification = "TODO")]

public sealed class CompanyCollectionBadRequestException : BadRequestException
{
    public CompanyCollectionBadRequestException()
        : base("Company collection sent from a client is null.")
    {
    }
}