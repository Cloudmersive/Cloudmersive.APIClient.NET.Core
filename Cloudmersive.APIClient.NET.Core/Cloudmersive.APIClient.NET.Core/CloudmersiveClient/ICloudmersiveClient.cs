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
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// </summary>
    public partial interface ICloudmersiveClient : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IDomain.
        /// </summary>
        IDomain Domain { get; }

        /// <summary>
        /// Gets the IEmail.
        /// </summary>
        IEmail Email { get; }

        /// <summary>
        /// Gets the IIPAddress.
        /// </summary>
        IIPAddress IPAddress { get; }

        /// <summary>
        /// Gets the IExtractEntitiesString.
        /// </summary>
        IExtractEntitiesString ExtractEntitiesString { get; }

        /// <summary>
        /// Gets the ILanguageDetection.
        /// </summary>
        ILanguageDetection LanguageDetection { get; }

        /// <summary>
        /// Gets the IParseString.
        /// </summary>
        IParseString ParseString { get; }

        /// <summary>
        /// Gets the IPosTaggerJson.
        /// </summary>
        IPosTaggerJson PosTaggerJson { get; }

        /// <summary>
        /// Gets the IPosTaggerString.
        /// </summary>
        IPosTaggerString PosTaggerString { get; }

        /// <summary>
        /// Gets the ISentences.
        /// </summary>
        ISentences Sentences { get; }

        /// <summary>
        /// Gets the ISpellCheck.
        /// </summary>
        ISpellCheck SpellCheck { get; }

        /// <summary>
        /// Gets the IWords.
        /// </summary>
        IWords Words { get; }

        /// <summary>
        /// Gets the IImageOcr.
        /// </summary>
        IImageOcr ImageOcr { get; }

        /// <summary>
        /// Gets the IBarcodeLookup.
        /// </summary>
        IBarcodeLookup BarcodeLookup { get; }

        /// <summary>
        /// Gets the IGenerateBarcode.
        /// </summary>
        IGenerateBarcode GenerateBarcode { get; }

        /// <summary>
        /// Gets the IFace.
        /// </summary>
        IFace Face { get; }

        /// <summary>
        /// Gets the INsfw.
        /// </summary>
        INsfw Nsfw { get; }

        /// <summary>
        /// Gets the IRecognize.
        /// </summary>
        IRecognize Recognize { get; }

        /// <summary>
        /// Gets the IResize.
        /// </summary>
        IResize Resize { get; }

        /// <summary>
        /// Gets the IConvertData.
        /// </summary>
        IConvertData ConvertData { get; }

        /// <summary>
        /// Gets the IConvertDocument.
        /// </summary>
        IConvertDocument ConvertDocument { get; }

        /// <summary>
        /// Gets the IConvertImage.
        /// </summary>
        IConvertImage ConvertImage { get; }

        /// <summary>
        /// Gets the IConvertTemplate.
        /// </summary>
        IConvertTemplate ConvertTemplate { get; }

        /// <summary>
        /// Gets the IConvertWeb.
        /// </summary>
        IConvertWeb ConvertWeb { get; }

        /// <summary>
        /// Gets the IScan.
        /// </summary>
        IScan Scan { get; }

    }
}
