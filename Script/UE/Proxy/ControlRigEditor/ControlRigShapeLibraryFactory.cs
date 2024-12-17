using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigShapeLibraryFactory")]
	public partial class UControlRigShapeLibraryFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigShapeLibraryFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}