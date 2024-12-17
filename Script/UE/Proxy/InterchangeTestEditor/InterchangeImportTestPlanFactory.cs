using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.InterchangeTestEditor
{
	[PathName("/Script/InterchangeTestEditor.InterchangeImportTestPlanFactory")]
	public partial class UInterchangeImportTestPlanFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTestEditor.InterchangeImportTestPlanFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}