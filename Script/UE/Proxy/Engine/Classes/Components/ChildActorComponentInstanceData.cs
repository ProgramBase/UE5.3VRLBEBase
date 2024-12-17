using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ChildActorComponentInstanceData")]
	public partial class FChildActorComponentInstanceData : FSceneComponentInstanceData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ChildActorComponentInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FChildActorComponentInstanceData()
		{
		}

		public static bool operator ==(FChildActorComponentInstanceData A, FChildActorComponentInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FChildActorComponentInstanceData A, FChildActorComponentInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FChildActorComponentInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<AActor> ChildActorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChildActorClass, __ReturnBuffer);

					return *(TSubclassOf<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChildActorClass, __InBuffer);
				}
			}
		}

		public FName ChildActorName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChildActorName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChildActorName, __InBuffer);
				}
			}
		}

		public TArray<FChildActorAttachedActorInfo> AttachedActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AttachedActors, __ReturnBuffer);

					return *(TArray<FChildActorAttachedActorInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AttachedActors, __InBuffer);
				}
			}
		}

		private static uint __ChildActorClass = 0;

		private static uint __ChildActorName = 0;

		private static uint __AttachedActors = 0;

	}
}