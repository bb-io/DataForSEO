using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class SslInfo
{
    [Display("Valid certificate")]
    [JsonProperty("valid_certificate")]
    public bool? ValidCertificate { get; set; }

    [Display("Certificate issuer")]
    [JsonProperty("certificate_issuer")]
    public string? CertificateIssuer { get; set; }

    [Display("Certificate subject")]
    [JsonProperty("certificate_subject")]
    public string? CertificateSubject { get; set; }

    [Display("Certificate version")]
    [JsonProperty("certificate_version")]
    public long? CertificateVersion { get; set; }

    [Display("Certificate hash")]
    [JsonProperty("certificate_hash")]
    public string? CertificateHash { get; set; }

    [Display("Certificate expiration date")]
    [JsonProperty("certificate_expiration_date")]
    public string? CertificateExpirationDate { get; set; }
}
