using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SmokeTestCommandlet")]
	public partial class USmokeTestCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SmokeTestCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}