﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.MultiTenancy;

namespace Abp.WebHooks
{
    /// <summary>
    /// Store created web hooks. To see who get that webhook check with <see cref="WebHookWorkItem.WebHookId"/> and you can get <see cref="WebHookWorkItem.WebHookSubscriptionId"/>
    /// </summary>
    [Table("AbpWebHooks")]
    public class WebHookInfo : FullAuditedEntity<Guid>, IMayHaveTenant
    {
        /// <summary>
        /// Webhook unique name id
        /// </summary>
        public string WebHookDefinition { get; set; }

        /// <summary>
        /// WebHook data as JSON string.
        /// </summary>
        public string Data { get; set; }

        public int? TenantId { get; set; }
    }
}