using SchoolManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities.Abstract
{
    public abstract class ContractBase: IEntity
    {
        public DateTime? SystemDate { get; set; } = DateTime.Today;
        public DateTime? UpdateSystemDate { get; set; } = DateTime.Today;
    }
}
