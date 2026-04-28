# Longest Increasing Subsequence (LIS)

[![.NET](https://github.com/Lei-Y/10736c14-7ffa-4688-89d6-d45eb6ea0aaf/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Lei-Y/10736c14-7ffa-4688-89d6-d45eb6ea0aaf/actions/workflows/dotnet.yml)
[![codecov](https://codecov.io/github/Lei-Y/10736c14-7ffa-4688-89d6-d45eb6ea0aaf/graph/badge.svg?token=W6A3U5BO3Z)](https://codecov.io/github/Lei-Y/10736c14-7ffa-4688-89d6-d45eb6ea0aaf)

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

## Coverage

```bash
dotnet test --collect:"XPlat Code Coverage"
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

## Docker

Build the image:

```bash
docker build -t lis .
```

Run with pipe:

```bash
echo "6 1 5 9 2" | docker run --rm -i lis
# Output: 1 5 9
```

Run with args:

```bash
docker run --rm lis 6 1 5 9 2
# Output: 1 5 9
```