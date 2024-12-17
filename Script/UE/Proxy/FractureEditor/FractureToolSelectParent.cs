using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolSelectParent")]
	public partial class UFractureToolSelectParent : UFractureToolSelectAll, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolSelectParent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}