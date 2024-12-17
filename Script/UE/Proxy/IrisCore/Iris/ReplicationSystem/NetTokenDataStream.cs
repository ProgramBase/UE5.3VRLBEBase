using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetTokenDataStream")]
	public partial class UNetTokenDataStream : UDataStream, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetTokenDataStream");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}