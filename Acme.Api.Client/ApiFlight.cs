using System;

namespace Acme.Api.Client.Models
{
	/// <summary>
	/// Class ApiFlight.
	/// </summary>
	public class ApiFlight
    {
		/// <summary>
		/// Row identifier
		/// </summary>
		/// <value>The identifier.</value>
		public virtual string Id { get; set; }

		/// <summary>
		/// Gets or sets the airline.
		/// </summary>
		/// <value>The airline.</value>
		public virtual Airline Airline { get; set; }

		/// <summary>
		/// Tail Number or commercial flight identifier
		/// </summary>
		/// <value>The flight identifier.</value>
		public virtual string FlightId { get; set; }

		/// <summary>
		/// Gets or sets the type of the aircraft.
		/// </summary>
		/// <value>The type of the aircraft.</value>
		public virtual string AircraftType { get; set; }

		/// <summary>
		/// Gets or sets the type description of the aircraft.
		/// </summary>
		/// <value>The type of the aircraft.</value>
		public virtual string AircraftTypeDescription { get; set; }

		/// <summary>
		/// Gets or sets the arrival airport.
		/// </summary>
		/// <value>The arrival airport.<see cref="Acme.Air.Airport"/></value>
		public Airport ArrivalAirport { get; set; }

		/// <summary>
		/// Gets or sets the arrival time UTC.
		/// </summary>
		/// <value>The arrival time UTC.</value>
		public DateTime? ArrivalTimeUtc { get; set; }

		/// <summary>
		/// Gets or sets the original arrival time UTC.
		/// </summary>
		/// <value>The originally scheduled arrival time UTC, null if ontime.</value>
		public DateTime? ArrivalTimeOriginalUtc { get; set; }

		/// <summary>
		/// Gets or sets the departure Airport.
		/// </summary>
		/// <value>The departure airport. <see cref="Acme.Air.Airport"/></value>
		public Airport DepartureAirport { get; set; }

		/// <summary>
		/// Gets or sets the departure time UTC.
		/// </summary>
		/// <value>The departure time UTC.</value>
		public DateTime? DepartureTimeUtc { get; set; }

		/// <summary>
		/// Gets or sets the original departure time UTC.
		/// </summary>
		/// <value>The originally scheduled departure time UTC, null if ontime.</value>
		public DateTime? DepartureTimeOriginalUtc { get; set; }

		/// <summary>
		/// Date of flight - based on departing date
		/// </summary>
		/// <value>The flight date.</value>
		public virtual DateTimeOffset FlightDate { get; set; }

		/// <summary>
		/// Owner of the aircraft
		/// </summary>
		public string Owner { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
		public virtual string Status { get; set; }

	}
}
