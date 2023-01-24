using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Event
    {
        public long EventId { get; set; }
        public DateTime InsertedDate { get; set; }
        public string JsonData { get; set; }
        public string EventType { get; set; }
        public string LoggedUserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
