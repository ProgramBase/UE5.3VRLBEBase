using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorInstanceHandleInterface")]
	public partial class UActorInstanceHandleInterface : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ActorInstanceHandleInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}