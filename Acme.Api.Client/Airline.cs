using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Api.Client.Models
{
	/// <summary>
	/// Class Airline.
	/// </summary>
	/// <remarks>lazy</remarks>
	public class Airline 
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		/// <remarks>lazy</remarks>
		[JsonProperty(PropertyName ="id")]
		public virtual string Id { get; set; }
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
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		/// <remarks>lazy</remarks>
		[JsonProperty( NullValueHandling = NullValueHandling.Ignore )]
		public virtual string Name { get; set; }
		/// <summary>
		/// Gets or sets the company.
		/// </summary>
		/// <value>The company.</value>
		/// <remarks>lazy</remarks>
		[JsonProperty( NullValueHandling = NullValueHandling.Ignore )]
		public virtual string Company { get; set; }
	}
}
