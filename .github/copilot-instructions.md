﻿## 🧠 Context

- **Project Type**: Class Library
- **Language**: C#
- **Framework / Libraries**: .NET 9+
- **Description**: This solution is a MCP Server for generating UUIDs (GUIDs) and is packaged as a NuGet packge.

## 🔧 General Guidelines
- Use C#-idiomatic patterns and follow .NET coding conventions defined in `.editorconfig` and `.globalconfig`.
- Use the latest C# features (e.g., records, pattern matching, nullable reference types). Currently, C# 13 is the latest stable version.
- Use nullable reference types (`#nullable enable`) and async/await.
- Prioritize readability, testability, and SOLID principles.
- Never change global.json unless explicitly asked for.
- Never change the target framework unless explicitly asked for.

## 🧶 Patterns
### ✅ Patterns to Follow
- Use Dependency Injection for services and repositories.
- Use ILogger<T> for structured logging.
- Prefer file-scoped namespace declarations and single-line using directives.
- Insert new line before the opening curly brace of any block (ex. after `if`, `for`, `while`, `foreach`, `using`, `try` ).
- Use pattern matching and switch expressions where applicable.
- Use `nameof` instead of string literals when referring to member names.
- Ensure that XML doc comments are present for public APIs and methods.

### 🚫 Patterns to Avoid
- Don’t use static state or service locators.
- Avoid logic in controllers—delegate to services/handlers.
- Don’t hardcode config—use appsettings.json and IOptions.
- Avoid using magic strings or numbers; use constants or enums.
- Avoid synchronous code in async methods.
- Avoid starting XML comments with 'Gets or Sets' for properties.

## Reference
- [Official Documentation](https://modelcontextprotocol.io/)
- [Protocol Specification](https://spec.modelcontextprotocol.io/)
- [GitHub Organization](https://github.com/modelcontextprotocol)
