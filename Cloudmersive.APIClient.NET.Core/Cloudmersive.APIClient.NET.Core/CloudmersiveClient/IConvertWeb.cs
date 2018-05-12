﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Cloudmersive
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// ConvertWeb operations.
    /// </summary>
    public partial interface IConvertWeb
    {
        /// <summary>
        /// Take screenshot of URL
        /// </summary>
        /// Fully renders a website and returns a PNG screenshot of the full
        /// page image.  Javascript, HTML5, CSS and other advanced features
        /// are all supported.
        /// <param name='input'>
        /// Screenshot request parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<System.IO.Stream>> UrlToScreenshotWithHttpMessagesAsync(Input input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Convert a URL to PDF
        /// </summary>
        /// Fully renders a website and returns a PDF of the full page.
        /// Javascript, HTML5, CSS and other advanced features are all
        /// supported.
        /// <param name='input'>
        /// URL to PDF request parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<System.IO.Stream>> UrlToPdfWithHttpMessagesAsync(Input input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Convert HTML string to PDF
        /// </summary>
        /// Fully renders a website and returns a PDF of the HTML.
        /// Javascript, HTML5, CSS and other advanced features are all
        /// supported.
        /// <param name='input'>
        /// HTML to PDF request parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> HtmlToPdfWithHttpMessagesAsync(Input input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
