using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.IKRigDefinitionFactory")]
	public partial class UIKRigDefinitionFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRigEditor.IKRigDefinitionFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}