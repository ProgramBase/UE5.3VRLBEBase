using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TriggerVolume")]
	public partial class ATriggerVolume : AVolume, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TriggerVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}