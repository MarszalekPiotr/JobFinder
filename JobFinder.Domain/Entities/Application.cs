

namespace JobFinder.Domain.Entities
{
    public sealed  class ApplicationForJob
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        // Q: how to handle file store in app
        public string CvFilePath { get; set; } = string.Empty;

        // Relations fields
        [ForeignKey("ApplicantId")]
        public Guid ApplicantId { get; set; }
        public User Applicant { get; set; }

        [ForeignKey("JobId")]
        public Guid JobId { get; set; }
        public Job Job { get; set; }
    }
}
