using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.ScriptStruct")]
	public partial class UScriptStruct : UStruct, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.ScriptStruct");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}