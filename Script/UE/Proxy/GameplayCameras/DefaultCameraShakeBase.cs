using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.DefaultCameraShakeBase")]
	public partial class UDefaultCameraShakeBase : UCameraShakeBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayCameras.DefaultCameraShakeBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}