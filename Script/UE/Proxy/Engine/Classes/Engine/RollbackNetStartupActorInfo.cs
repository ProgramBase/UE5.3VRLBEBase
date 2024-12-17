using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RollbackNetStartupActorInfo")]
	public partial class FRollbackNetStartupActorInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RollbackNetStartupActorInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRollbackNetStartupActorInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRollbackNetStartupActorInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRollbackNetStartupActorInfo A, FRollbackNetStartupActorInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRollbackNetStartupActorInfo A, FRollbackNetStartupActorInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRollbackNetStartupActorInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UObject Archetype
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Archetype, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Archetype, __InBuffer);
				}
			}
		}

		public TArray<UObject> ObjReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjReferences, __ReturnBuffer);

					return *(TArray<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjReferences, __InBuffer);
				}
			}
		}

		private static uint __Archetype = 0;

		private static uint __ObjReferences = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}