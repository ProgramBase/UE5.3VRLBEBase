using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TransBuffer")]
	public partial class UTransBuffer : UTransactor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TransBuffer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}