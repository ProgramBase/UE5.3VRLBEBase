using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraCurveTemplate")]
	public partial class FNiagaraCurveTemplate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraCurveTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraCurveTemplate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraCurveTemplate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraCurveTemplate A, FNiagaraCurveTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraCurveTemplate A, FNiagaraCurveTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraCurveTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString DisplayNameOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DisplayNameOverride, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DisplayNameOverride, __InBuffer);
				}
			}
		}

		public FSoftObjectPath CurveAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurveAsset, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurveAsset, __InBuffer);
				}
			}
		}

		private static uint __DisplayNameOverride = 0;

		private static uint __CurveAsset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}