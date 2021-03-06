﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Toolkit.Uwp.UI.Lottie.LottieData.Serialization
{
    /// <summary>
    /// Issues.
    /// </summary>
    sealed class ParsingIssues
    {
        readonly HashSet<(string Code, string Description)> _issues = new HashSet<(string Code, string Description)>();
        readonly bool _throwOnIssue;

        internal ParsingIssues(bool throwOnIssue)
        {
            _throwOnIssue = throwOnIssue;
        }

        internal (string Code, string Description)[] GetIssues() => _issues.ToArray();

        internal void FailedToParseJson(string message) => Report("LP0001", $"Failed to parse JSON. {message}.");

        internal void FatalError(string message) => Report("LP0002", $"Fatal error: {message}.");

        internal void AssetType(string type) => Report("LP0005", $"Unsupported asset type: {type}.");

        internal void LayerWithRenderFalse() => Report("LP0006", "Layer with render = false.");

        internal void IllustratorLayers() => Report("LP0007", "Illustrator layers.");

        internal void LayerEffectsIsNotSupported(string layer) => Report("LP0008", $"{layer} has layer effects, which is not supported.");

        internal void Mattes() => Report("LP0009", "Mattes.");

        internal void TimeRemappingOfPreComps() => Report("LP0011", "Time remapping of precomp layers.");

        internal void UnexpectedShapeContentType(string type) => Report("LP0012", $"Unexpected shape content type: {type}.");

        internal void GradientStrokes() => Report("LP0013", "Gradient strokes.");

        internal void PolystarAnimation(string property) => Report("LP0014", $"Polystar {property} animation.");

        internal void Expressions() => Report("LP0015", "Expressions.");

        internal void IgnoredField(string field) => Report("LP0016", $"Ignored field: {field}.");

        internal void UnexpectedField(string field) => Report("LP0017", $"Unexpected field: {field}.");

        void Report(string code, string description)
        {
            _issues.Add((code, description));

            if (_throwOnIssue)
            {
                throw new NotSupportedException($"{code}: {description}");
            }
        }
    }
}
