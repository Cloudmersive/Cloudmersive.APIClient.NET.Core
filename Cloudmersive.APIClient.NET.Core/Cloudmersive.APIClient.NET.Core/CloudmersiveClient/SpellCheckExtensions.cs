﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Cloudmersive
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for SpellCheck.
    /// </summary>
    public static partial class SpellCheckExtensions
    {
            /// <summary>
            /// Spell check a word
            /// </summary>
            /// Check if a word is spelled correctly
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input string word
            /// </param>
            public static PostOKResponse Post(this ISpellCheck operations, string value)
            {
                return Task.Factory.StartNew(s => ((ISpellCheck)s).PostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Spell check a word
            /// </summary>
            /// Check if a word is spelled correctly
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input string word
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PostOKResponse> PostAsync(this ISpellCheck operations, string value, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Spell check a sentence
            /// </summary>
            /// Check if a sentence is spelled correctly
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input sentence word
            /// </param>
            public static bool? CheckSentenceString(this ISpellCheck operations, string value)
            {
                return Task.Factory.StartNew(s => ((ISpellCheck)s).CheckSentenceStringAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Spell check a sentence
            /// </summary>
            /// Check if a sentence is spelled correctly
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input sentence word
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> CheckSentenceStringAsync(this ISpellCheck operations, string value, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckSentenceStringWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Check if sentence is spelled correctly
            /// </summary>
            /// Checks whether the sentence is spelled correctly and returns the result as
            /// JSON
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input sentence
            /// </param>
            public static CheckSentenceJsonOKResponse CheckSentenceJson(this ISpellCheck operations, string value)
            {
                return Task.Factory.StartNew(s => ((ISpellCheck)s).CheckSentenceJsonAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check if sentence is spelled correctly
            /// </summary>
            /// Checks whether the sentence is spelled correctly and returns the result as
            /// JSON
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input sentence
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckSentenceJsonOKResponse> CheckSentenceJsonAsync(this ISpellCheck operations, string value, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckSentenceJsonWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Spell check word
            /// </summary>
            /// Spell check a word as JSON
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input sentence
            /// </param>
            public static CheckJsonOKResponse CheckJson(this ISpellCheck operations, string value)
            {
                return Task.Factory.StartNew(s => ((ISpellCheck)s).CheckJsonAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Spell check word
            /// </summary>
            /// Spell check a word as JSON
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input sentence
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckJsonOKResponse> CheckJsonAsync(this ISpellCheck operations, string value, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckJsonWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Find spelling corrections
            /// </summary>
            /// Find the spelling corrections for a word
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input word
            /// </param>
            public static string Correct(this ISpellCheck operations, string value)
            {
                return Task.Factory.StartNew(s => ((ISpellCheck)s).CorrectAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Find spelling corrections
            /// </summary>
            /// Find the spelling corrections for a word
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input word
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> CorrectAsync(this ISpellCheck operations, string value, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CorrectWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Find spelling corrections
            /// </summary>
            /// Find spelling correction suggestions and return result as JSON
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input string
            /// </param>
            public static CorrectJsonOKResponse CorrectJson(this ISpellCheck operations, string value)
            {
                return Task.Factory.StartNew(s => ((ISpellCheck)s).CorrectJsonAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Find spelling corrections
            /// </summary>
            /// Find spelling correction suggestions and return result as JSON
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// Input string
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CorrectJsonOKResponse> CorrectJsonAsync(this ISpellCheck operations, string value, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CorrectJsonWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
