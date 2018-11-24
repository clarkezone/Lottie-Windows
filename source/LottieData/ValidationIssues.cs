// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Toolkit.Uwp.UI.Lottie.LottieData
{
    sealed class ValidationIssues
    {
        readonly HashSet<(string Code, string Description)> _issues = new HashSet<(string Code, string Description)>();

        internal (string Code, string Description)[] GetIssues() => _issues.ToArray();

        internal void LayerHasInPointAfterOutPoint(string layerName)
        {
            Report("LV0001", $"Layer {layerName} has in-point after out-point");
        }

        internal void LayerInCycle(string layerName)
        {
            Report("LV0002", $"Layer {layerName} is in a cycle");
        }

        internal void InvalidLayerParent(string layerParent)
        {
            Report("LV0003", $"Invalid layer parent: {layerParent}");
        }

        void Report(string code, string description)
        {
            _issues.Add((code, description));
        }
    }
}