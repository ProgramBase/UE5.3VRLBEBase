using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraCompilerTag")]
	public partial class FNiagaraCompilerTag : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraCompilerTag");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraCompilerTag() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraCompilerTag() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraCompilerTag A, FNiagaraCompilerTag B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraCompilerTag A, FNiagaraCompilerTag B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraCompilerTag;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNiagaraVariable Variable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Variable, __ReturnBuffer);

					return *(FNiagaraVariable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Variable, __InBuffer);
				}
			}
		}

		public FString StringValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StringValue, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StringValue, __InBuffer);
				}
			}
		}

		private static uint __Variable = 0;

		private static uint __StringValue = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}