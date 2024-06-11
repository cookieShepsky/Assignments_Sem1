namespace Gardener;

public enum Month   // In case anyone points out PascalCase vs UPPERCASE:
{                   // Here's Microsoft's own documentation on the matter: https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/capitalization-conventions
    // TODO: Month names should be localizable. Currently displaying Enum.ToString() -> display value "generated" in back-end -> bad practice.
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}