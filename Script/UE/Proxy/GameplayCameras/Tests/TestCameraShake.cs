using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.TestCameraShake")]
	public partial class UTestCameraShake : UCameraShakeBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayCameras.TestCameraShake");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}