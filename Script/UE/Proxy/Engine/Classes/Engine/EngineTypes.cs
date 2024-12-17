using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EngineTypes")]
	public partial class UEngineTypes : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.EngineTypes");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}