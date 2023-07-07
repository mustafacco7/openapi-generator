// <auto-generated>
/*
 * Example
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// A representation of an adult
    /// </summary>
    public partial class Adult : Person, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Adult" /> class.
        /// </summary>
        /// <param name="children">children</param>
        /// <param name="firstName">firstName</param>
        /// <param name="lastName">lastName</param>
        /// <param name="type">type</param>
        [JsonConstructor]
        public Adult(List<Child> children, string firstName, string lastName, string type) : base(firstName, lastName, type)
        {
            Children = children;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [JsonPropertyName("children")]
        public List<Child> Children { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Adult {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Adult" />
    /// </summary>
    public class AdultJsonConverter : JsonConverter<Adult>
    {
        /// <summary>
        /// Deserializes json to <see cref="Adult" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Adult Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            List<Child>? children = default;
            string? firstName = default;
            string? lastName = default;
            string? type = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "children":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                children = JsonSerializer.Deserialize<List<Child>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "firstName":
                            firstName = utf8JsonReader.GetString();
                            break;
                        case "lastName":
                            lastName = utf8JsonReader.GetString();
                            break;
                        case "$_type":
                            type = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (children == null)
                throw new ArgumentNullException(nameof(children), "Property is required for class Adult.");

            if (firstName == null)
                throw new ArgumentNullException(nameof(firstName), "Property is required for class Adult.");

            if (lastName == null)
                throw new ArgumentNullException(nameof(lastName), "Property is required for class Adult.");

            if (type == null)
                throw new ArgumentNullException(nameof(type), "Property is required for class Adult.");

            return new Adult(children, firstName, lastName, type);
        }

        /// <summary>
        /// Serializes a <see cref="Adult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="adult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Adult adult, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, adult, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Adult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="adult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Adult adult, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WritePropertyName("children");
            JsonSerializer.Serialize(writer, adult.Children, jsonSerializerOptions);
            writer.WriteString("firstName", adult.FirstName);
            writer.WriteString("lastName", adult.LastName);
            writer.WriteString("$_type", adult.Type);
        }
    }
}
