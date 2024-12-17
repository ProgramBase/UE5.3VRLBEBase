using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LandscapeGrassTypeCommandlet")]
	public partial class ULandscapeGrassTypeCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LandscapeGrassTypeCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}