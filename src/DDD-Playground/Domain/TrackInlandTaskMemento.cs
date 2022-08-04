using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TrackInlandTaskMemento
    {
		public string InternalStatus { get; set; }
		public Guid TaskId { get; set; }
		public DateTime DueDate { get; set; }
		public string Status { get; set; }
		public IEnumerable<string> Assignees { get; set; }
		public IEnumerable<KeyValuePair<string, int>> Entities { get; set; }
		public object Details { get; set; }
	}
}
