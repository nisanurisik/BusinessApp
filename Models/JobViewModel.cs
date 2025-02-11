using BusinessApp.Entities;

namespace BusinessApp.Models
{
    public class JobViewModel
    {
        public IEnumerable<Job> Jobs { get; set; } = null!;
        public Job? Job { get; set; }
        public User? User { get; set; }
        public IEnumerable<JobType> JobTypes { get; set; } = null!;
        public IEnumerable<Category> Categories { get; set; } = null!;
        public IEnumerable<City> Cities { get; set; } = null!;
        public IEnumerable<SavedJob> SavedJobs { get; set; } = null!;
        public IEnumerable<RemoteOption> RemoteOptions { get; set; } = null!;
        public IEnumerable<PositionLevel> PositionLevels { get; set; } = null!;
        public IEnumerable<Specialization> Specializations { get; set; } = null!;
    }
}