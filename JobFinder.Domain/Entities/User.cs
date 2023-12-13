

namespace JobFinder.Domain.Entities
{
    public sealed  class User // Identity inheritance
    {

            // So 


            // Company / "Normal User" Data --> 2 entities or here nullable fields?
            public Guid? NormalUserId { get; set; }
            public NormalUser? NormalUser { get; set; }
             public Guid? CompanyId { get; set; }
             public Company? Company { get; set; }
    

}
}
