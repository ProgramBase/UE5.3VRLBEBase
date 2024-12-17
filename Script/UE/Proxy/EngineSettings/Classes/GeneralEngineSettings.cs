using Script.CoreUObject;
using Script.Library;

namespace Script.EngineSettings
{
	[PathName("/Script/EngineSettings.GeneralEngineSettings")]
	public partial class UGeneralEngineSettings : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineSettings.GeneralEngineSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}