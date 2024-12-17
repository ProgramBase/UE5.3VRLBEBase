using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ScriptViewportClient")]
	public partial class UScriptViewportClient : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ScriptViewportClient");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}