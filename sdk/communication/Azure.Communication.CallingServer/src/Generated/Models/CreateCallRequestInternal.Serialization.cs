// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class CreateCallRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceAlternateIdentity))
            {
                writer.WritePropertyName("sourceAlternateIdentity");
                writer.WriteObjectValue(SourceAlternateIdentity);
            }
            writer.WritePropertyName("targets");
            writer.WriteStartArray();
            foreach (var item in Targets)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("source");
            writer.WriteObjectValue(Source);
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject");
                writer.WriteStringValue(Subject);
            }
            writer.WritePropertyName("callbackUri");
            writer.WriteStringValue(CallbackUri);
            writer.WritePropertyName("requestedModalities");
            writer.WriteStartArray();
            foreach (var item in RequestedModalities)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("requestedCallEvents");
            writer.WriteStartArray();
            foreach (var item in RequestedCallEvents)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}
