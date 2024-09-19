﻿using MtslErp.Common.Domain.Interfaces;

namespace PrintFactoryManagement.Domain.Entities;

public sealed class User : IAutoIncrementalEntity<long>
{
    public long Id { get;  }
    public required string UserName { get; set; }
    public required string FullName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? ProfilePictureUri { get; set; }
    public required DateOnly DateOfBirth { get; set; }
    public string? Address { get; set; }
}
