// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    public partial class EntityRecognitionPiiTasksItem
    {
        internal static EntityRecognitionPiiTasksItem DeserializeEntityRecognitionPiiTasksItem(JsonElement element)
        {
            Optional<PiiEntitiesResult> results = default;
            DateTimeOffset lastUpdateDateTime = default;
            string name = default;
            JobStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    results = PiiEntitiesResult.DeserializePiiEntitiesResult(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new JobStatus(property.Value.GetString());
                    continue;
                }
            }
            return new EntityRecognitionPiiTasksItem(lastUpdateDateTime, name, status, results.Value);
        }
    }
}