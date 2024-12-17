using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TexAlignerFit")]
	public partial class UTexAlignerFit : UTexAligner, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TexAlignerFit");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}