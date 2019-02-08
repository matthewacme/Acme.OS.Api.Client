using System;
using Newtonsoft.Json;

namespace Acme.Api.Client.Models
{
    /// <summary>
    /// Class Airport.
    /// </summary>
    /// <remarks>lazy</remarks>
    public class Airport
    {

        /// <summary>
        /// Gets or sets the icao.
        /// </summary>
        /// <value>The icao.</value>
        /// <remarks>lazy</remarks>
        [JsonProperty( NullValueHandling = NullValueHandling.Ignore )]
        public virtual string Icao { get; set; }

        /// <summary>
        /// Gets or sets the iata.
        /// </summary>
        /// <value>The iata.</value>
        /// <remarks>lazy</remarks>
        [JsonProperty( NullValueHandling = NullValueHandling.Ignore )]
        public virtual string Iata { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        /// <remarks>lazy</remarks>
        [JsonProperty( NullValueHandling = NullValueHandling.Ignore )]
        public virtual string Label { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>The full name.</value>
        /// <remarks>lazy</remarks>
        [JsonProperty( NullValueHandling = NullValueHandling.Ignore )]
        public virtual string FullName { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        /// <remarks>lazy</remarks>
        [JsonProperty( NullValueHandling = NullValueHandling.Ignore )]
        public virtual string City { get; set; }

        /// <summary>
        /// Gets or sets the name of the time zone.
        /// </summary>
        /// <value>The name of the time zone.</value>
        /// <remarks>lazy</remarks>
        [JsonProperty( NullValueHandling = NullValueHandling.Ignore )]
        public virtual string TimeZoneName { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        /// <remarks>lazy</remarks>
        [JsonProperty( NullValueHandling = NullValueHandling.Ignore )]
        public virtual string Type { get; set; }


        /// <summary>
        /// Converts the UTC to local date time.
        /// </summary>
        /// <param name="utcDateTime">The UTC date time.</param>
        /// <returns>System.Nullable&lt;DateTimeOffset&gt;.</returns>
        public DateTimeOffset? ConvertUtcToLocalDateTime( DateTime utcDateTime )
        {
            try
            {
                return TimeZoneInfo.ConvertTimeFromUtc( utcDateTime , TimeZoneInfo.FindSystemTimeZoneById( this.TimeZoneName ) );
            }
            catch ( Exception ex ) when ( ex is TimeZoneNotFoundException || ex is ArgumentNullException || ex is InvalidTimeZoneException )
            {
                return null;
            }
        }
    }

}