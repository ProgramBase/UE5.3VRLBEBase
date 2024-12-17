using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LightmassCharacterIndirectDetailVolume")]
	public partial class ALightmassCharacterIndirectDetailVolume : AVolume, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LightmassCharacterIndirectDetailVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}