﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMPSystem.Core.System.Events.EventModel
{
    public class EntityChangeStatus<T,TChangeStatus>
    {
        /// <summary>
        /// T主键，或实体对象
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="changeStatus"></param>
        public EntityChangeStatus(T entity,TChangeStatus oldStatus)
        {
            this.Entity = entity;
            this.ChangeStatus = oldStatus;
        }

        public EntityChangeStatus(T entity, TChangeStatus changeStatus, TChangeStatus oldChangeStatus)
            : this(entity, oldChangeStatus)
        {
            this.ChangeStatus = changeStatus;
        } 

        public T Entity { get; set; }
        public TChangeStatus ChangeStatus { get; set; }
        public TChangeStatus OldChangeStatus { get; set; }
    }
}
