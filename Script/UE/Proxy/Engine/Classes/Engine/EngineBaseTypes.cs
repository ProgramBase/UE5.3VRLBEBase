using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EngineBaseTypes")]
	public partial class UEngineBaseTypes : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.EngineBaseTypes");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}