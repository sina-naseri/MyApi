﻿using Entities.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Entities.User;

public class Role : IdentityRole<int>, IEntity
{
    [Required]
    [StringLength(100)]
    public string Description { get; set; }
}

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
    }
}
