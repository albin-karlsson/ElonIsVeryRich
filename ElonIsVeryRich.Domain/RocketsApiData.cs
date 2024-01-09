using Newtonsoft.Json;

namespace ElonIsVeryRich.Domain
{
    public class RocketCompositeFairing
    {
        [JsonProperty("height")]
        public RocketHeight? Height { get; set; }

        [JsonProperty("diameter")]
        public RocketDiameter? Diameter { get; set; }
    }

    public class RocketDiameter
    {
        [JsonProperty("meters")]
        public double? Meters { get; set; }

        [JsonProperty("feet")]
        public double? Feet { get; set; }
    }

    public class RocketEngines
    {
        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("layout")]
        public string? Layout { get; set; }

        [JsonProperty("engine_loss_max")]
        public int? EngineLossMax { get; set; }

        [JsonProperty("propellant_1")]
        public string? Propellant1 { get; set; }

        [JsonProperty("propellant_2")]
        public string? Propellant2 { get; set; }

        [JsonProperty("thrust_sea_level")]
        public RocketThrustSeaLevel? ThrustSeaLevel { get; set; }

        [JsonProperty("thrust_vacuum")]
        public RocketThrustVacuum? ThrustVacuum { get; set; }

        [JsonProperty("thrust_to_weight")]
        public double? ThrustToWeight { get; set; }
    }

    public class RocketFirstStage
    {
        [JsonProperty("reusable")]
        public bool? Reusable { get; set; }

        [JsonProperty("engines")]
        public int? Engines { get; set; }

        [JsonProperty("fuel_amount_tons")]
        public double? FuelAmountTons { get; set; }

        [JsonProperty("burn_time_sec")]
        public int? BurnTimeSec { get; set; }

        [JsonProperty("thrust_sea_level")]
        public RocketThrustSeaLevel? ThrustSeaLevel { get; set; }

        [JsonProperty("thrust_vacuum")]
        public RocketThrustVacuum? ThrustVacuum { get; set; }

        [JsonProperty("cores")]
        public int? Cores { get; set; }
    }

    public class RocketHeight
    {
        [JsonProperty("meters")]
        public double? Meters { get; set; }

        [JsonProperty("feet")]
        public double? Feet { get; set; }
    }

    public class RocketLandingLegs
    {
        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("material")]
        public string? Material { get; set; }
    }

    public class RocketMass
    {
        [JsonProperty("kg")]
        public int? Kg { get; set; }

        [JsonProperty("lb")]
        public int? Lb { get; set; }
    }

    public class RocketPayloads
    {
        [JsonProperty("option_1")]
        public string? Option1 { get; set; }

        [JsonProperty("composite_fairing")]
        public RocketCompositeFairing? CompositeFairing { get; set; }

        [JsonProperty("option_2")]
        public string? Option2 { get; set; }
    }

    public class RocketPayloadWeight
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("kg")]
        public int? Kg { get; set; }

        [JsonProperty("lb")]
        public int? Lb { get; set; }
    }

    public class RocketRoot
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("stages")]
        public int? Stages { get; set; }

        [JsonProperty("boosters")]
        public int? Boosters { get; set; }

        [JsonProperty("cost_per_launch")]
        public int? CostPerLaunch { get; set; }

        [JsonProperty("success_rate_pct")]
        public int? SuccessRatePct { get; set; }

        [JsonProperty("first_flight")]
        public string? FirstFlight { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("company")]
        public string? Company { get; set; }

        [JsonProperty("height")]
        public RocketHeight? Height { get; set; }

        [JsonProperty("diameter")]
        public RocketDiameter? Diameter { get; set; }

        [JsonProperty("mass")]
        public RocketMass? Mass { get; set; }

        [JsonProperty("payload_weights")]
        public List<RocketPayloadWeight>? PayloadWeights { get; set; }

        [JsonProperty("first_stage")]
        public RocketFirstStage? FirstStage { get; set; }

        [JsonProperty("second_stage")]
        public RocketSecondStage? SecondStage { get; set; }

        [JsonProperty("engines")]
        public RocketEngines? Engines { get; set; }

        [JsonProperty("landing_legs")]
        public RocketLandingLegs? LandingLegs { get; set; }

        [JsonProperty("wikipedia")]
        public string? Wikipedia { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("rocket_id")]
        public string? RocketId { get; set; }

        [JsonProperty("rocket_name")]
        public string? RocketName { get; set; }

        [JsonProperty("rocket_type")]
        public string? RocketType { get; set; }
    }

    public class RocketSecondStage
    {
        [JsonProperty("engines")]
        public int? Engines { get; set; }

        [JsonProperty("fuel_amount_tons")]
        public double? FuelAmountTons { get; set; }

        [JsonProperty("burn_time_sec")]
        public int? BurnTimeSec { get; set; }

        [JsonProperty("thrust")]
        public RocketThrust? Thrust { get; set; }

        [JsonProperty("payloads")]
        public RocketPayloads? Payloads { get; set; }
    }

    public class RocketThrust
    {
        [JsonProperty("kN")]
        public int? KN { get; set; }

        [JsonProperty("lbf")]
        public int? Lbf { get; set; }
    }

    public class RocketThrustSeaLevel
    {
        [JsonProperty("kN")]
        public int? KN { get; set; }

        [JsonProperty("lbf")]
        public int? Lbf { get; set; }
    }

    public class RocketThrustVacuum
    {
        [JsonProperty("kN")]
        public int? KN { get; set; }

        [JsonProperty("lbf")]
        public int? Lbf { get; set; }
    }
}
