///===================================================================================================
///
/// Source https://github.com/PeterWaher/IoTGateway/tree/master/Security/Waher.Security.EllipticCurves
/// Owner  https://github.com/PeterWaher
///
///===================================================================================================

namespace Blockcoli.Libra.Net.Crypto
{
    /// <summary>
	/// Implements the SHA3-512 hash function, as defined in section 6.1
	/// in the NIST FIPS 202: 
	/// https://nvlpubs.nist.gov/nistpubs/FIPS/NIST.FIPS.202.pdf
	/// </summary>
	public class SHA3_512 : Keccak1600
	{
		/// <summary>
		/// Implements the SHA3-512 hash function, as defined in section 6.1
		/// in the NIST FIPS 202: 
		/// https://nvlpubs.nist.gov/nistpubs/FIPS/NIST.FIPS.202.pdf
		/// </summary>
		public SHA3_512() : base(1024, 0b10, 512)
		{
		}
	}
}