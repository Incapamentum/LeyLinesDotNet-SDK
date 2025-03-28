// Copyright (c) 2025 Gustavo Diaz Galeas
// This file is part of LeyLines.NET SDK.
//
// Licensed under the GNU AGPL v3.0 (see LICENSE file).
// Additional restriction: This software may not be used for commercial purposes
// without prior written permission from the author.

using System.Text.Json.Serialization;

namespace LeyLines.Models.Commerce
{
    public class PriceEntry
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("unit_price")]
        public int UnitPrice { get; set; }
    }

    public class Prices
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("buys")]
        public required PriceEntry Buys { get; set; }

        [JsonPropertyName("sells")]
        public required PriceEntry Sells { get; set; }
    }
}
