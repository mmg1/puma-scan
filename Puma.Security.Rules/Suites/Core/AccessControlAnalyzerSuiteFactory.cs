﻿/* 
 * Copyright(c) 2016 - 2019 Puma Security, LLC (https://www.pumascan.com)
 * 
 * Project Leader: Eric Johnson (eric.johnson@pumascan.com)
 * Lead Developer: Eric Mead (eric.mead@pumascan.com)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. 
 */

using Puma.Security.Rules.Analyzer;
using Puma.Security.Rules.Analyzer.AccessControl.Authorize;
using Puma.Security.Rules.Analyzer.AccessControl.Jwt;
using System.Collections.Immutable;


namespace Puma.Security.Rules.Suites.Core
{
    public class AccessControlAnalyzerSuiteFactory : IAnalyzerSuiteFactory
    {
        public ImmutableArray<ICompilationAnalyzer> Create()
        {
            return new ICompilationAnalyzer[]
            {
                new AuthorizeAnalyzer(),
                new JwtSignatureAnalyzer(),
            }.ToImmutableArray();
        }
    }
}
