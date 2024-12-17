using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TexAlignerPlanar")]
	public partial class UTexAlignerPlanar : UTexAligner, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TexAlignerPlanar");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}