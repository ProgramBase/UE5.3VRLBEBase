using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TexAlignerDefault")]
	public partial class UTexAlignerDefault : UTexAligner, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TexAlignerDefault");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}