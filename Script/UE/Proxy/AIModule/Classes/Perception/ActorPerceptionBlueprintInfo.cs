using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.ActorPerceptionBlueprintInfo")]
	public partial class FActorPerceptionBlueprintInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.ActorPerceptionBlueprintInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorPerceptionBlueprintInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActorPerceptionBlueprintInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActorPerceptionBlueprintInfo A, FActorPerceptionBlueprintInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorPerceptionBlueprintInfo A, FActorPerceptionBlueprintInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorPerceptionBlueprintInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public AActor Target
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Target, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Target, __InBuffer);
				}
			}
		}

		public TArray<FAIStimulus> LastSensedStimuli
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastSensedStimuli, __ReturnBuffer);

					return *(TArray<FAIStimulus>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastSensedStimuli, __InBuffer);
				}
			}
		}

		public bool bIsHostile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsHostile, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsHostile, __InBuffer);
				}
			}
		}

		private static uint __Target = 0;

		private static uint __LastSensedStimuli = 0;

		private static uint __bIsHostile = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}