using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.EdGraphSchema")]
	public partial class UEdGraphSchema : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.EdGraphSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}