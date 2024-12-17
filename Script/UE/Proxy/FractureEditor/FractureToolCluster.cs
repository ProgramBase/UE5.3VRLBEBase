using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolCluster")]
	public partial class UFractureToolCluster : UFractureActionTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolCluster");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}