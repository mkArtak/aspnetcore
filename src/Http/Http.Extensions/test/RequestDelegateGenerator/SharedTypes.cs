// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using Microsoft.AspNetCore.Http.Metadata;

namespace Microsoft.AspNetCore.Http.Generators.Tests;

public class TestService
{
    public string TestServiceMethod() => "Produced from service!";
}

public class Todo
{
    public int Id { get; set; }
    public string Name { get; set; } = "Todo";
    public bool IsComplete { get; set; }
}

public interface ITodo
{
    public int Id { get; }
    public string Name { get; }
    public bool IsComplete { get; }
}

public class FromBodyAttribute : Attribute, IFromBodyMetadata
{
    public bool AllowEmpty { get; set; }
}
