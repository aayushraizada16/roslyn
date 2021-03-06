﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Immutable;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Packaging;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.AddImport
{
    internal interface IRemoteAddImportFeatureService
    {
        Task<ImmutableArray<AddImportFixData>> GetFixesAsync(
            DocumentId documentId, TextSpan span, string diagnosticId, bool placeSystemNamespaceFirst,
            bool searchReferenceAssemblies, ImmutableArray<PackageSource> packageSources);
    }
}