using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraPreviewBase")]
	public partial class ANiagaraPreviewBase : AActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraPreviewBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSystem(UNiagaraSystem InSystem)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSystem?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __SetSystem, __InBuffer);
			}
		}

		public virtual void SetLabelText(FText InXAxisText, FText InYAxisText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InXAxisText?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InYAxisText?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __SetLabelText, __InBuffer);
			}
		}

		private static uint __SetSystem = 0;

		private static uint __SetLabelText = 0;
	}
}