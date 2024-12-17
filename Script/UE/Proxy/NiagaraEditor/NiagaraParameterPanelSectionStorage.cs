using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraParameterPanelSectionStorage")]
	public partial class FNiagaraParameterPanelSectionStorage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraParameterPanelSectionStorage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraParameterPanelSectionStorage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraParameterPanelSectionStorage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraParameterPanelSectionStorage A, FNiagaraParameterPanelSectionStorage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraParameterPanelSectionStorage A, FNiagaraParameterPanelSectionStorage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraParameterPanelSectionStorage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid ParamStorageId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParamStorageId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParamStorageId, __InBuffer);
				}
			}
		}

		public TArray<FGuid> ExpandedCategories
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpandedCategories, __ReturnBuffer);

					return *(TArray<FGuid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpandedCategories, __InBuffer);
				}
			}
		}

		private static uint __ParamStorageId = 0;

		private static uint __ExpandedCategories = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}