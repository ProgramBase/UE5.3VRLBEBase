using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PhysicsFieldComponent")]
	public partial class UPhysicsFieldComponent : USceneComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PhysicsFieldComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}