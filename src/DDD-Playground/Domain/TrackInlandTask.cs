namespace Domain
{
    public class TrackInlandTask
	{
		// readonly properties
		private List<string> _assignee = new List<string>();
		private string _internalStatus = "UNKNOWN";

		public Guid TaskId { get; init; }
		public DateTime DueDate { get; init; }  // required
		public string Status { get; init; } = "Inactive";
		public IEnumerable<string> Assignees { get; }  // cannot be directly modified
		public IEnumerable<KeyValuePair<string, int>> Entities { get; init; }
		public object Details { get; init; }


		private TrackInlandTask(DateTime dueDate)
		{

		}

		TrackInlandTask(Guid taskId, DateTime dueDate, string status, IEnumerable<string> assignees, IEnumerable<KeyValuePair<string, int>> entities, object details, string internalStatus)
		{
			TaskId = taskId;
			DueDate = dueDate;
			// and so on to restore all propeties
			_internalStatus = internalStatus;
		}

		// for repository
		public static TrackInlandTask Restore(TrackInlandTaskMemento trackInlandTaskMemento)
		{
			return new TrackInlandTask(trackInlandTaskMemento.TaskId, trackInlandTaskMemento.DueDate, trackInlandTaskMemento.Status, trackInlandTaskMemento.Assignees, trackInlandTaskMemento.Entities, trackInlandTaskMemento.Details, trackInlandTaskMemento.InternalStatus);
		}

		public TrackInlandTaskMemento GetMemento()
		{
			return new TrackInlandTaskMemento
			{
				TaskId = this.TaskId,
				DueDate = this.DueDate,
				Status = this.Status,
				Assignees = this.Assignees,
				Entities = this.Entities,
				Details = this.Details,
				InternalStatus = _internalStatus,
			};
		}

		public static TrackInlandTask Create(DateTime dueDate)
		{
			return new TrackInlandTask(Guid.NewGuid(), dueDate, null, null, null, null, null);
		}

		public void AddAssignee(string assignee)
		{
			_assignee.Add(assignee);
		}

		public void ReplaceAssignee(string newAssignee, string oldAssignee)
        {
			if (newAssignee == null)
            {
				throw new ArgumentNullException();
            }

			if (oldAssignee == null)
			{
				throw new ArgumentNullException();
			}

			_assignee.Remove(oldAssignee);
			_assignee.Add(newAssignee);
		}
	}
}