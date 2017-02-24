﻿using System.ComponentModel.DataAnnotations;

namespace Decision.DomainClasses.ApplicantInfo
{
    public enum MarriageStatus
    {
        [Display(ResourceType = typeof(Resources), Name = nameof(Resources.Married))]
        Married = 0,

        [Display(ResourceType = typeof(Resources), Name = nameof(Resources.Single))]
        Single
    }
}