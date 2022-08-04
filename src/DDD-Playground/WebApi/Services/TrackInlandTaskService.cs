using Domain;
using Infrastructure;

namespace WebApi.Services
{
    public class TrackInlandTaskService
    {
		TrackInlandTaskRepository _repo = new TrackInlandTaskRepository();

		public void CreateNewTask(DateTime dueDate)
		{
			var task = TrackInlandTask.Create(dueDate);

			// operating
			var newAssignee = "new";
			task.AddAssignee(newAssignee);

			
			// saving

			_repo.Save(task);  // option 1

			//var memento = task.GetMemento();  // option 2
			//_repo.Save(memento);  // option 2
		}
	}

	public class ReassignTrackInlandTaskService
	{
		TrackInlandTaskRepository _repo = new TrackInlandTaskRepository();

		public void Reassign(Guid taskId,string newAssignee, string oldAssignee)
		{
			var task = _repo.Read(taskId);

			// do something

			// save
		}
	}
}
