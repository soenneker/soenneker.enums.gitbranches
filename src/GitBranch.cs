using Intellenum;

namespace Soenneker.Enums.GitBranches;

/// <summary>
/// An enum for common git repository branch names
/// </summary>
[Intellenum<string>]
public partial class GitBranch
{
    /// <summary> develop </summary>
    public static readonly GitBranch Develop = new("develop");

    /// <summary> staging </summary>
    public static readonly GitBranch Staging = new("staging");

    /// <summary> main </summary>
    public static readonly GitBranch Main = new("main");
}