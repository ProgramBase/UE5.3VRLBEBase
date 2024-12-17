using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraShakePattern")]
	public partial class UCameraShakePattern : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CameraShakePattern");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}