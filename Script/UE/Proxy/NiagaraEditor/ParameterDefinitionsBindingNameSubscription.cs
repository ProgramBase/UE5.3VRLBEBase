using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ParameterDefinitionsBindingNameSubscription")]
	public partial class FParameterDefinitionsBindingNameSubscription : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.ParameterDefinitionsBindingNameSubscription");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FParameterDefinitionsBindingNameSubscription() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FParameterDefinitionsBindingNameSubscription() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FParameterDefinitionsBindingNameSubscription A, FParameterDefinitionsBindingNameSubscription B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FParameterDefinitionsBindingNameSubscription A, FParameterDefinitionsBindingNameSubscription B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FParameterDefinitionsBindingNameSubscription;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UNiagaraParameterDefinitions SubscribedParameterDefinitions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SubscribedParameterDefinitions, __ReturnBuffer);

					return *(UNiagaraParameterDefinitions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SubscribedParameterDefinitions, __InBuffer);
				}
			}
		}

		public TArray<FScriptVarBindingNameSubscription> BindingNameSubscriptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BindingNameSubscriptions, __ReturnBuffer);

					return *(TArray<FScriptVarBindingNameSubscription>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BindingNameSubscriptions, __InBuffer);
				}
			}
		}

		private static uint __SubscribedParameterDefinitions = 0;

		private static uint __BindingNameSubscriptions = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}