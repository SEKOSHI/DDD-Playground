using Domain;

namespace Infrastructure
{
    public class TrackInlandTaskRepository
    {
		public void Save(TrackInlandTask trackInlandTask)
		{
			var memento = trackInlandTask.GetMemento();

			var details = trackInlandTask.Details;


			//database.Save(memento.Details.., memento.InternalStatus);
		}

		public TrackInlandTask Read(Guid taskId)
		{
			//var data = database.Read(memento.Details.., memento.InternalStatus);
			
			var trackInlandTaskMemento = new TrackInlandTaskMemento
			{
				// initialization
			};

			return TrackInlandTask.Restore(trackInlandTaskMemento);
		}
	}
}