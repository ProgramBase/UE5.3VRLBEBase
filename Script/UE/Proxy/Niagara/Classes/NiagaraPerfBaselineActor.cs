using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraPerfBaselineActor")]
	public partial class ANiagaraPerfBaselineActor : AActor, IStaticClass
	{
		public UNiagaraBaselineController Controller
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Controller, __ReturnBuffer);

					return *(UNiagaraBaselineController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Controller, __InBuffer);
				}
			}
		}

		public UTextRenderComponent Label
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Label, __ReturnBuffer);

					return *(UTextRenderComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Label, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraPerfBaselineActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Controller = 0;

		private static uint __Label = 0;
	}
}