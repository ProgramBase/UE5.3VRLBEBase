using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.FoliageEdit
{
	[PathName("/Script/FoliageEdit.LandscapeGrassTypeFactory")]
	public partial class ULandscapeGrassTypeFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FoliageEdit.LandscapeGrassTypeFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}