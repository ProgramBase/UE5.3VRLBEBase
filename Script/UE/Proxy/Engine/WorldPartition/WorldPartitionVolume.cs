using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionVolume")]
	public partial class ADEPRECATED_WorldPartitionVolume : AVolume, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}