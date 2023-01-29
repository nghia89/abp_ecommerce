﻿using System;
using Volo.Abp.Application.Dtos;

namespace ABPEcommerce.Admin.Roles
{
    public class RoleDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}