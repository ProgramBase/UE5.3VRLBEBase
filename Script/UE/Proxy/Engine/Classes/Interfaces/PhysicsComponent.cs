using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PhysicsComponent")]
	public partial class UPhysicsComponent : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PhysicsComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.PhysicsComponent")]
	public interface IPhysicsComponent : IInterface
	{
	}
}