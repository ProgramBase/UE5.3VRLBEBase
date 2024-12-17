using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolResetAsset")]
	public partial class UFractureToolResetAsset : UFractureToolGenerateAsset, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolResetAsset");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}