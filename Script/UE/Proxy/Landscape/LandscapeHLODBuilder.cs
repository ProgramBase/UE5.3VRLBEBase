using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeHLODBuilder")]
	public partial class ULandscapeHLODBuilder : UHLODBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Landscape.LandscapeHLODBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}