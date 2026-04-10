# UsingDelegatesAndEvents

Simple console demo showing how to declare and use a delegate and how to build a multicast delegate in C#.

## Overview

This repository contains a small .NET Framework console app that demonstrates:

- Declaring a delegate type (`Notifier`)
- Assigning instance methods to a delegate
- Combining delegates to create a multicast delegate that calls multiple handlers

Target: C# 7.3, .NET Framework 4.7.2.

## Files

- `UsingDelegatesAndEvents\Program.cs` — main program and `ShowMessage` class.

## How to run

- Open the project in Visual Studio (recommended) targeting .NET Framework 4.7.2 and press F5.
- Or build with MSBuild from the solution/project folder:
  - `msbuild YourSolution.sln` (or the `.csproj` file)
  - Run the resulting executable.

## What the program does

1. Creates an instance of `ShowMessage`.
2. Declares a delegate type `Notifier` that accepts a `string`.
3. Assigns `ShowMessage.ShowMessageOnScreen` to a `Notifier` variable and invokes it to write to the console.
4. Adds `ShowMessage.SendMessageByEmail` to the same `Notifier` (multicast) and invokes it again so both methods run.

## Key types and members

- `public delegate void Notifier(string message)` — delegate type used for notifications.
- `public class ShowMessage`
  - `public void ShowMessageOnScreen(string message)` — writes a message to the console.
  - `public void SendMessageByEmail(string message)` — simulates sending an email (writes to console).

## Example console output

Press any key to create the delegate...
[after pressing a key]

[Message on Screen]: Hello, this is a message displayed on the screen!

Press any key to change the delegate to send an email...
[after pressing a key]

[Message on Screen]: Hello, this is a new important message!

[Message Sent by Email (Simulation)]: Hello, this is a new important message!

## Notes

- This is an educational sample focused on delegates and multicast invocation. It simulates email sending by printing to the console.
- Compatible with C# 7.3 and .NET Framework 4.7.2 as indicated in the project.

