[![](https://img.shields.io/nuget/v/soenneker.enums.gitbranches.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.gitbranches/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.gitbranches/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.gitbranches/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.gitbranches.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.gitbranches/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.gitbranches/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.gitbranches/actions/workflows/codeql.yml)

# Soenneker.Enums.GitBranches

A string-backed enum-value type for the conventional `develop`, `staging`, and `main` Git branch names.

## Install

```bash
dotnet add package Soenneker.Enums.GitBranches
```

## Usage

```csharp
using Soenneker.Enums.GitBranches;

GitBranch branch = GitBranch.Main;
string branchName = branch.Value; // "main"

if (GitBranch.TryFromValue(input, out GitBranch? parsed))
{
    // parsed is one of the shared static instances
}
```

Available values:

- `Develop` → `"develop"`
- `Staging` → `"staging"`
- `Main` → `"main"`

`System.Text.Json` serializes the type as the lowercase branch name. `FromValue` throws for unknown input; use `TryFromValue` when parsing configuration or webhook payloads. `FromName` and `TryFromName` use the C# member names, such as `"Main"`.

The values are short branch names, not full refs such as `refs/heads/main`. This package does not inspect a repository, determine its default branch, validate that a branch exists, or run Git commands. Repositories with other branch conventions should keep using their actual string names rather than forcing them into this closed set.
