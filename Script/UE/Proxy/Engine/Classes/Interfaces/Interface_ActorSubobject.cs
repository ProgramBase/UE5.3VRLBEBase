using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Interface_ActorSubobject")]
	public partial class UInterface_ActorSubobject : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Interface_ActorSubobject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.Interface_ActorSubobject")]
	public interface IInterface_ActorSubobject : IInterface
	{
	}
}