using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ScriptVarBindingNameSubscription")]
	public partial class FScriptVarBindingNameSubscription : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.ScriptVarBindingNameSubscription");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FScriptVarBindingNameSubscription() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FScriptVarBindingNameSubscription() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FScriptVarBindingNameSubscription A, FScriptVarBindingNameSubscription B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FScriptVarBindingNameSubscription A, FScriptVarBindingNameSubscription B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FScriptVarBindingNameSubscription;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid ExternalScriptVarId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExternalScriptVarId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExternalScriptVarId, __InBuffer);
				}
			}
		}

		public TArray<FGuid> InternalScriptVarIds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InternalScriptVarIds, __ReturnBuffer);

					return *(TArray<FGuid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InternalScriptVarIds, __InBuffer);
				}
			}
		}

		private static uint __ExternalScriptVarId = 0;

		private static uint __InternalScriptVarIds = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}