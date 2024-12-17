using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.LegacyCameraShakePattern")]
	public partial class ULegacyCameraShakePattern : UCameraShakePattern, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayCameras.LegacyCameraShakePattern");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}