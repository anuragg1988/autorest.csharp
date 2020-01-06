// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.ContentTypeHeader.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for ContentTypes.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(ContentTypesConverter))]
    public struct ContentTypes : System.IEquatable<ContentTypes>
    {
        private ContentTypes(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly ContentTypes TextPlain = "text/plain";

        public static readonly ContentTypes TextJson = "text/json";


        /// <summary>
        /// Underlying value of enum ContentTypes
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for ContentTypes
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type ContentTypes
        /// </summary>
        public bool Equals(ContentTypes e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to ContentTypes
        /// </summary>
        public static implicit operator ContentTypes(string value)
        {
            return new ContentTypes(value);
        }

        /// <summary>
        /// Implicit operator to convert ContentTypes to string
        /// </summary>
        public static implicit operator string(ContentTypes e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum ContentTypes
        /// </summary>
        public static bool operator == (ContentTypes e1, ContentTypes e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum ContentTypes
        /// </summary>
        public static bool operator != (ContentTypes e1, ContentTypes e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for ContentTypes
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is ContentTypes && Equals((ContentTypes)obj);
        }

        /// <summary>
        /// Returns for hashCode ContentTypes
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}