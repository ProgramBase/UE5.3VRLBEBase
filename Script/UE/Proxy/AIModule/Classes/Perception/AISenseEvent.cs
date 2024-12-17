using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISenseEvent")]
	public partial class UAISenseEvent : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AISenseEvent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}