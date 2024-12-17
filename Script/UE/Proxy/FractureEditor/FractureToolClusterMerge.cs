using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolClusterMerge")]
	public partial class UFractureToolClusterMerge : UFractureActionTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolClusterMerge");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}