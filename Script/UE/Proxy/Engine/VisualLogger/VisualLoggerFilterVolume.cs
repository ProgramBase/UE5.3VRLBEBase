using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VisualLoggerFilterVolume")]
	public partial class AVisualLoggerFilterVolume : AVolume, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.VisualLoggerFilterVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}