namespace library.Models;

public class Member
{
    public long MemberId { get; set; }             // member_id   BIGINT
    public string FullName { get; set; } = "";     // full_name   NOT NULL
    public string? Email { get; set; }             // email       may be NULL
    public string MemberType { get; set; } = "Regular";  // member_type NOT NULL
}