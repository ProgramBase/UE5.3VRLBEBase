using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraBlockingVolume")]
	public partial class ACameraBlockingVolume : AVolume, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CameraBlockingVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}