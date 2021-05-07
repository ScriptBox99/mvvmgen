﻿// ***********************************************************************
// ⚡ MvvmGen => https://github.com/thomasclaudiushuber/mvvmgen
// Copyright © by Thomas Claudius Huber
// Licensed under the MIT license => See the LICENSE file in project root
// ***********************************************************************

namespace Sample.WpfApp.Events
{
    public record EmployeeSavedEvent(int EmployeeId, string FirstName);
    public record EmployeeSelectedEvent(int EmployeeId);
}