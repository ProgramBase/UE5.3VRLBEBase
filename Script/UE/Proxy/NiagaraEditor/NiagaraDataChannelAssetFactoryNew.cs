using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraDataChannelAssetFactoryNew")]
	public partial class UNiagaraDataChannelAssetFactoryNew : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraDataChannelAssetFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}