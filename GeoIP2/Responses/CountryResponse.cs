﻿using MaxMind.GeoIP2.Model;

namespace MaxMind.GeoIP2.Responses
{
    /// <summary>
    /// This class provides a model for the data returned by the GeoIP2 Country end
    /// point.
    /// 
    /// The only difference between the City, City/ISP/Org, and Omni response classes is
    /// which fields in each record may be populated.
    /// 
    /// See <a href="http://dev.maxmind.com/geoip/geoip2/web-services">GeoIP2 Web
    ///      Services</a>
    /// </summary>
    public class CountryResponse : AbstractCountryResponse
    {
        public CountryResponse() { }

        public CountryResponse(Continent continent = null, Country country = null, Model.MaxMind maxMind = null,
            Country registeredCountry = null, RepresentedCountry representedCountry = null, Traits traits = null)
            : base(continent, country, maxMind, registeredCountry, representedCountry, traits)
        {
        }
    }
}
