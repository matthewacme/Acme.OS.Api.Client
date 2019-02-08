using Acme.Api.Client;
using Acme.Api.Client.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.Write( "Enter Airport Id > " );
			var airportId = Console.ReadLine();

			Console.Write( "Filter out Non-Commercial Flights? [T|F] (default True) > " );
			var filter = true;
			var filterResponse= Console.ReadLine();
			if ( !string.IsNullOrWhiteSpace(filterResponse) && (filterResponse.StartsWith('f') ||  filterResponse.StartsWith( 'F' )) )
			{
				filter = false;
			}

			Console.WriteLine( "Please enter your bearer token value :" );
			var token = Console.ReadLine();

			Console.Clear();

			Console.WriteLine( "Getting Flights" );

			using ( var client = new B2B( filter , token ) )
			{
				var flights = client.GetAirportArrivals( airportId );
				Console.Clear();
				for ( int i = 0 ; i < 10 && i< flights.Count ; i++ )
				{
					Console.WriteLine( $@"Flight {flights[ i ].FlightId} arriving" );
				}
			}

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine( "Get Complete" );
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine( "Hit Enter to Exit" );
			Console.ReadLine();
		}
	}
}
