using Script.CoreUObject;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeInfoMap")]
	public partial class ULandscapeInfoMap : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.LandscapeInfoMap");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}