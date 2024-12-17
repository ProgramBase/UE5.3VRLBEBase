using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraThumbnailRendererBase")]
	public partial class UNiagaraThumbnailRendererBase : UTextureThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraThumbnailRendererBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}