using System.Text;

namespace RecordType;

public record PersonRecord(string FullName, DateOnly DateOfBirth)
{
    protected virtual bool PrintMembers(StringBuilder builder)
    {
        builder.Append($"Name is: {FullName}");
        builder.Append($"Date Of Birth is: {DateOfBirth}");
        return true;
    }
}

// public record Person
// {
//     public string FullName { get; init; } = default!;
//     public DateOnly DateOfBirth { get; init; } = default!;
// }

public record struct PersonStruct(string FullName, DateOnly DateOfBirth);

public class PersonClass
{
    public string FullName { get; init; } = default!;
    public DateOnly DateOfBirth { get; init; } = default!;
}