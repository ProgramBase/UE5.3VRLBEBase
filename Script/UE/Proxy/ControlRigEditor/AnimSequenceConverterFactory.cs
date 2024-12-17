using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.AnimSequenceConverterFactory")]
	public partial class UAnimSequenceConverterFactory : UAnimSequenceFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.AnimSequenceConverterFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}