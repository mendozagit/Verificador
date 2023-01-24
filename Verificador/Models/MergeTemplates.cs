using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class MergeTemplates
    {
        public int MergeTemplateId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string TemplateName { get; set; }
        public string DataSource { get; set; }
        public int DataSourceIndex { get; set; }
        public string Base64Rtf { get; set; }
    }
}
