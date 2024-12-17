using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundWaveProcedural")]
	public partial class USoundWaveProcedural : USoundWave, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundWaveProcedural");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}