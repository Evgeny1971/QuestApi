#region Copyright notice and license

// Copyright 2019 The gRPC Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

using GoogleMapsApi;
using Google.Protobuf.WellKnownTypes;


namespace Server.Services
{

    public class EscapeGameService : EscapeGameService.EscapeGameServiceBase
    {
        private readonly GoogleMapsAPI _googleMapsApi;

        public EscapeGameService(GoogleMapsAPI googleMapsApi)
        {
            _googleMapsApi = googleMapsApi;
        }

        public override Task<Empty> CreateGame(Empty request, ServerCallContext context)
        {
            // Implement logic to create a game
            return Task.FromResult(new Empty());
        }

        public override Task<Empty> AddLocation(Location request, ServerCallContext context)
        {
            // Implement logic to add a location to the game
            return Task.FromResult(new Empty());
        }

        public override Task<Empty> RemoveLocation(Location request, ServerCallContext context)
        {
            // Implement logic to remove a location from the game
            return Task.FromResult(new Empty());
        }

        public override Task<Location> Geocode(string request, ServerCallContext context)
        {
            // Implement geocoding logic using the Google Maps API
            Location location = _googleMapsApi.Geocode(request);
            return Task.FromResult(location);
        }

        public override Task<Empty> CalculateRoute(Location request, Location responseStream, ServerCallContext context)
        {
            // Implement route calculation logic using the Google Maps API
            _googleMapsApi.CalculateRoute(request, responseStream);
            return Task.FromResult(new Empty());
        }

        public override Task<Empty> CheckLocation(Location request, Location responseStream, ServerCallContext context)
        {
            // Implement location checking logic using the Google Maps API
            _googleMapsApi.CheckLocation(request, responseStream);
            return Task.FromResult(new Empty());
        }

        public override Task<Empty> AddMarker(Location request, google.protobuf.Empty responseStream, ServerCallContext context)
        {
            // Implement logic to add a marker to the map using the Google Maps API
            _googleMapsApi.AddMarker(request);
            return Task.FromResult(new Empty());
        }

        public override Task<Empty> AddInfoWindow(Location request, StringValue content, ServerCallContext context)
        {
            // Implement logic to add an information window to a marker using the Google Maps API
            _googleMapsApi.AddInfoWindow(request, content.Value);
            return Task.FromResult(new Empty());
        }
    }

}