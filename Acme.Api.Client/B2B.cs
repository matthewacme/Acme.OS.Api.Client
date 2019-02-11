using Acme.Api.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Acme.Api.Client
{
	public class B2B : IDisposable
	{


		#region ' Member Variables '

		private HttpClient _client;
		private string _token;

		#endregion // Member Variables


		#region ' Constructors / Destructors '

		private B2B() { }

		public B2B( string token ) : this( true , token ) { }

		public B2B( bool isProduction , string token )
		{
			IsProduction = isProduction;
			if ( IsProduction )
			{
				TargetUri = new Uri( "https://api.flightwise.com/" );
			}
			else
			{
				//TargetUri = new Uri( "http://localhost:6783/" );
				TargetUri = new Uri( "https://fbnapi.flightwise.com/" );
			}
			CreateClient();
			SetToken( token );
		}

		public B2B( Uri targetUri , string token )
		{
			IsProduction = false;
			TargetUri = targetUri;
			CreateClient();
			SetToken( token );
		}

		private void CreateClient()
		{
			_client = new HttpClient
			{
				BaseAddress = TargetUri
			};

			_client.DefaultRequestHeaders.Accept.Clear();
			_client.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( @"application/json" ) );

		}



		#region ' IDisposable Support '

		private bool disposedValue = false; // To detect redundant calls

		protected virtual void Dispose( bool disposing )
		{
			if ( !disposedValue )
			{
				if ( disposing )
				{
					_client?.Dispose();
				}

				disposedValue = true;
			}
		}

		// This code added to correctly implement the disposable pattern.
		public void Dispose()
		{
			// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
			Dispose( true );
		}

		#endregion // IDisposable Support

		#endregion // Constructors / Destructors


		#region ' Properties '

		public bool IsProduction { get; set; }
		public Uri TargetUri { get; protected set; }

		#endregion // Properties


		#region ' Public Methods '

		public void SetToken( string token )
		{
			_token = token;
			_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "Bearer" , _token );
		}

		public IList<ApiFlight> GetAirportArrivals( string airportAbbv , bool filtered = true )
		{
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get ,
				RequestUri = new Uri( $"b2b/js/aa/{airportAbbv}" , UriKind.Relative )
			};

			var response = _client.SendAsync( request ).Result;
			if ( response.IsSuccessStatusCode )
			{
				var data = response.Content.ReadAsStringAsync().Result;
				var rtrn = string.IsNullOrWhiteSpace( data ) ? default : JsonConvert.DeserializeObject<List<ApiFlight>>( data );
				return rtrn;
			}
			else
			{
				throw new Exception( $@"Error response of {response.StatusCode}, message: {response.ReasonPhrase}" );
			}

		}


		#endregion // Public Methods



	}
}
