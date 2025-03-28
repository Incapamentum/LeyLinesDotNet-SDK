// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of LeyLines.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using System.Text.Json.Serialization;

namespace LeyLines.Models.Commerce
{
    public class Listing
    {
        [JsonPropertyName("listings")]
        public int Listings { get; set; }

        [JsonPropertyName("unit_price")]
        public int UnitPrice { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }

    public class ListingData
    {
        [JsonPropertyName("id")]
        public int ItemId { get; set; }

        [JsonPropertyName("buys")]
        public List<Listing> Buys { get; set; }

        [JsonPropertyName("sells")]
        public List<Listing> Sells { get; set; }
    }
}
