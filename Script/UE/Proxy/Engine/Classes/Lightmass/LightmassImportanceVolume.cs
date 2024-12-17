using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LightmassImportanceVolume")]
	public partial class ALightmassImportanceVolume : AVolume, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LightmassImportanceVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}