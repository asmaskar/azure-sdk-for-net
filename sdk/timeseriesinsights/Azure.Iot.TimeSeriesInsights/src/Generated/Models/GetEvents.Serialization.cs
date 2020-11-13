// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    public partial class GetEvents : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("timeSeriesId");
            writer.WriteStartArray();
            foreach (var item in TimeSeriesId)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("searchSpan");
            writer.WriteObjectValue(SearchSpan);
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter");
                writer.WriteObjectValue(Filter);
            }
            if (Optional.IsCollectionDefined(ProjectedProperties))
            {
                writer.WritePropertyName("projectedProperties");
                writer.WriteStartArray();
                foreach (var item in ProjectedProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Take))
            {
                writer.WritePropertyName("take");
                writer.WriteNumberValue(Take.Value);
            }
            writer.WriteEndObject();
        }
    }
}