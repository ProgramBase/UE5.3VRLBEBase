using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.CryptoKeys
{
	[PathName("/Script/CryptoKeys.CryptoKeysCommandlet")]
	public partial class UCryptoKeysCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CryptoKeys.CryptoKeysCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}