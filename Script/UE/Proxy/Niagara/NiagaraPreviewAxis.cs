using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraPreviewAxis")]
	public partial class UNiagaraPreviewAxis : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraPreviewAxis");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual int Num()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Num, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void ApplyToPreview(UNiagaraComponent PreviewComponent, int PreviewIndex, bool bIsXAxis, ref FString OutLabelText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = PreviewComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = PreviewIndex;

				*(bool*)(__InBuffer + 12) = bIsXAxis;

				*(nint*)(__InBuffer + 13) = OutLabelText?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ApplyToPreview, __InBuffer, __OutBuffer);

				OutLabelText = *(FString*)(__OutBuffer);

			}
		}

		private static uint __Num = 0;

		private static uint __ApplyToPreview = 0;
	}
}