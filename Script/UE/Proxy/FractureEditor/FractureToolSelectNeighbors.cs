using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolSelectNeighbors")]
	public partial class UFractureToolSelectNeighbors : UFractureToolSelectAll, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolSelectNeighbors");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}