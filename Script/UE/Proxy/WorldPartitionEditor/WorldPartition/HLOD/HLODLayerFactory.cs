using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.WorldPartitionEditor
{
	[PathName("/Script/WorldPartitionEditor.HLODLayerFactory")]
	public partial class UHLODLayerFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WorldPartitionEditor.HLODLayerFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}