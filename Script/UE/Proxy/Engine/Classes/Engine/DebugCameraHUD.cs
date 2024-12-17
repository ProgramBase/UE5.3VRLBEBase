using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DebugCameraHUD")]
	public partial class ADebugCameraHUD : AHUD, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DebugCameraHUD");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}