using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionEditorHash")]
	public partial class UWorldPartitionEditorHash : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionEditorHash");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}