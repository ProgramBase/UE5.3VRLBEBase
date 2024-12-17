using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolDeleteBranch")]
	public partial class UFractureToolDeleteBranch : UFractureActionTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolDeleteBranch");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}