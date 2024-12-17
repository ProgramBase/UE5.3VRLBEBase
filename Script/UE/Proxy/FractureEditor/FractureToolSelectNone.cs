using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolSelectNone")]
	public partial class UFractureToolSelectNone : UFractureToolSelectAll, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolSelectNone");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}