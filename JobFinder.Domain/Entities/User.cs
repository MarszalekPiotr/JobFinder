

namespace JobFinder.Domain.Entities
{
    public sealed  class User // Identity inheritance
    {

            // Some Basic User Data
            public Guid Id { get; set; }
            

            // Company / "Normal User" Data --> 2 entities or here nullable fields?
            public Guid? NormalUserId { get; set; }
            public NormalUser? NormalUser { get; set; }
             public Guid? CompanyId { get; set; }
             public Company? Company { get; set; }
    

}
}
