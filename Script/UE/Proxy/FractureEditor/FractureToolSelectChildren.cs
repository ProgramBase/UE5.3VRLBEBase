using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolSelectChildren")]
	public partial class UFractureToolSelectChildren : UFractureToolSelectAll, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolSelectChildren");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}