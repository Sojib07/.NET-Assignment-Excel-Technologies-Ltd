using CustomerInformation.Infrastructure.Entities;

namespace CustomerInformation.Infrastructure.Seeds
{
    public class CountrySeed
    {
        public Country[] Countries
        {
            get
            {
                return new Country[]
                {
                    new Country{ Id=1, CountryName="Afghanistan"},
                    new Country{ Id=2, CountryName="Albania"},
                    new Country{ Id=3, CountryName="Algeria"},
                    new Country{ Id=4, CountryName="Andorra"},
                    new Country{ Id=5, CountryName="Angola"},
                    new Country{ Id=6, CountryName="Antigua and Barbuda"},

                };
            }
        }
    }
}