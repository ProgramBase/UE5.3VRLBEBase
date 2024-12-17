using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorDomainSaveCommandlet")]
	public partial class UEditorDomainSaveCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorDomainSaveCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}