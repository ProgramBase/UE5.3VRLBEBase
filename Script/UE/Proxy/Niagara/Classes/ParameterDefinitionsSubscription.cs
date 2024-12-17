using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ParameterDefinitionsSubscription")]
	public partial class FParameterDefinitionsSubscription : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.ParameterDefinitionsSubscription");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FParameterDefinitionsSubscription() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FParameterDefinitionsSubscription() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FParameterDefinitionsSubscription A, FParameterDefinitionsSubscription B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FParameterDefinitionsSubscription A, FParameterDefinitionsSubscription B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FParameterDefinitionsSubscription;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UNiagaraParameterDefinitionsBase Definitions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Definitions, __ReturnBuffer);

					return *(UNiagaraParameterDefinitionsBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Definitions, __InBuffer);
				}
			}
		}

		public int CachedChangeIdHash
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CachedChangeIdHash, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CachedChangeIdHash, __InBuffer);
				}
			}
		}

		private static uint __Definitions = 0;

		private static uint __CachedChangeIdHash = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}