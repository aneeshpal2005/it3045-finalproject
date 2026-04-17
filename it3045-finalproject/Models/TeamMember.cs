namespace it3045_finalproject.Models
{
    public class TeamMember
    {
        public int TeamMemberId { get; set; }
        public required string TeamMemberBirthdate { get; set; }
        public required string TeamMemberName { get; set; }
        public required string TeamMemberProgram { get; set; }
        public required string TeamMemberYear { get; set; }
    }
}
