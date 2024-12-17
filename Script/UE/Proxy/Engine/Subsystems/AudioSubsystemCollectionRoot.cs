using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AudioSubsystemCollectionRoot")]
	public partial class UAudioSubsystemCollectionRoot : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AudioSubsystemCollectionRoot");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}