using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraNewAssetDialogConfig")]
	public partial class FNiagaraNewAssetDialogConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraNewAssetDialogConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraNewAssetDialogConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraNewAssetDialogConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraNewAssetDialogConfig A, FNiagaraNewAssetDialogConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraNewAssetDialogConfig A, FNiagaraNewAssetDialogConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraNewAssetDialogConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int SelectedOptionIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SelectedOptionIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SelectedOptionIndex, __InBuffer);
				}
			}
		}

		public FVector2D WindowSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WindowSize, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WindowSize, __InBuffer);
				}
			}
		}

		private static uint __SelectedOptionIndex = 0;

		private static uint __WindowSize = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}