using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraLwcStructConverter")]
	public partial class FNiagaraLwcStructConverter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraLwcStructConverter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraLwcStructConverter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraLwcStructConverter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraLwcStructConverter A, FNiagaraLwcStructConverter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraLwcStructConverter A, FNiagaraLwcStructConverter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraLwcStructConverter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int LWCSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LWCSize, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LWCSize, __InBuffer);
				}
			}
		}

		public int SWCSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SWCSize, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SWCSize, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraStructConversionStep> ConversionSteps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConversionSteps, __ReturnBuffer);

					return *(TArray<FNiagaraStructConversionStep>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConversionSteps, __InBuffer);
				}
			}
		}

		private static uint __LWCSize = 0;

		private static uint __SWCSize = 0;

		private static uint __ConversionSteps = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}