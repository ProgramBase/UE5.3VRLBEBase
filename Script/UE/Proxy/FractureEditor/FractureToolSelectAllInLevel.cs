using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolSelectAllInLevel")]
	public partial class UFractureToolSelectAllInLevel : UFractureToolSelectAll, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolSelectAllInLevel");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}