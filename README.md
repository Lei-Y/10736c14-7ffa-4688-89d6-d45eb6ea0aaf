# Longest Increasing Subsequence (LIS)

## Overview
This project finds the longest increasing subsequence from a string of integers separated by spaces.

If there are multiple valid results with the same length, the earliest one is returned.

## Input
A single string of integers separated by whitespace.

Example:
6 1 5 9 2

## Output
A string representing the longest increasing subsequence.

Example:
1 5 9

## Note

The problem says "subsequence", but test cases like `6 2 4 6 1 5 9 2` -> `2 4 6` show that the answer must be **continuous** numbers. So this code finds the longest continuous increasing run.

## Requirements

- .NET 8 SDK

## Build

```bash
dotnet build
```

## Test

```bash
dotnet test
```

## Usage

With pipe:

```bash
echo "6 1 5 9 2" | dotnet run --project LongestIncreasingSubsequence.Cli
# Output: 1 5 9
```

With args:

```bash
dotnet run --project LongestIncreasingSubsequence.Cli -- 6 1 5 9 2
# Output: 1 5 9
```