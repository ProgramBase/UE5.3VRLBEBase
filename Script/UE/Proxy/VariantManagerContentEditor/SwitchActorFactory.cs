using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.VariantManagerContentEditor
{
	[PathName("/Script/VariantManagerContentEditor.SwitchActorFactory")]
	public partial class USwitchActorFactory : UActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContentEditor.SwitchActorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}