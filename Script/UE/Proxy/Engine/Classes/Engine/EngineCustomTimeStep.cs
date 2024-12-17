using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EngineCustomTimeStep")]
	public partial class UEngineCustomTimeStep : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.EngineCustomTimeStep");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}