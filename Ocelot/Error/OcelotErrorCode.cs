/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Error
* 项目描述 ：
* 类 名 称 ：OcelotErrorCode
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Error
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/2/25 16:53:33
* 更新时间 ：2022/2/25 16:53:33
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Error
{
    public enum OcelotErrorCode
    {
        UnauthenticatedError = 0,
        UnknownError = 1,
        DownstreampathTemplateAlreadyUsedError = 2,
        UnableToFindDownstreamRouteError = 3,
        CannotAddDataError = 4,
        CannotFindDataError = 5,
        UnableToCompleteRequestError = 6,
        UnableToCreateAuthenticationHandlerError = 7,
        UnsupportedAuthenticationProviderError = 8,
        CannotFindClaimError = 9,
        ParsingConfigurationHeaderError = 10,
        NoInstructionsError = 11,
        InstructionNotForClaimsError = 12,
        UnauthorizedError = 13,
        ClaimValueNotAuthorisedError = 14,
        ScopeNotAuthorisedError = 15,
        UserDoesNotHaveClaimError = 16,
        DownstreamPathTemplateContainsSchemeError = 17,
        DownstreamPathNullOrEmptyError = 18,
        DownstreamSchemeNullOrEmptyError = 19,
        DownstreamHostNullOrEmptyError = 20,
        ServicesAreNullError = 21,
        ServicesAreEmptyError = 22,
        UnableToFindServiceDiscoveryProviderError = 23,
        UnableToFindLoadBalancerError = 24,
        RequestTimedOutError = 25,
        UnableToFindQoSProviderError = 26,
        UnmappableRequestError = 27,
        RateLimitOptionsError = 28,
        PathTemplateDoesntStartWithForwardSlash = 29,
        FileValidationFailedError = 30,
        UnableToFindDelegatingHandlerProviderError = 31,
        CouldNotFindPlaceholderError = 32,
        CouldNotFindAggregatorError = 33,
        CannotAddPlaceholderError = 34,
        CannotRemovePlaceholderError = 35,
        QuotaExceededError = 36,
        RequestCanceled = 37,
    }
}
