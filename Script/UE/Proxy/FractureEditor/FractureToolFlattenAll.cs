using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolFlattenAll")]
	public partial class UFractureToolFlattenAll : UFractureActionTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolFlattenAll");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}