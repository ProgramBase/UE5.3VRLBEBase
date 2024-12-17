using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIDataProvider")]
	public partial class UAIDataProvider : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AIDataProvider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}