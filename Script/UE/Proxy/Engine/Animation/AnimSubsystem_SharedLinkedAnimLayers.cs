using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimSubsystem_SharedLinkedAnimLayers")]
	public partial class FAnimSubsystem_SharedLinkedAnimLayers : FAnimSubsystemInstance, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimSubsystem_SharedLinkedAnimLayers");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimSubsystem_SharedLinkedAnimLayers()
		{
		}

		public static bool operator ==(FAnimSubsystem_SharedLinkedAnimLayers A, FAnimSubsystem_SharedLinkedAnimLayers B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimSubsystem_SharedLinkedAnimLayers A, FAnimSubsystem_SharedLinkedAnimLayers B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimSubsystem_SharedLinkedAnimLayers;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FLinkedAnimLayerClassData> ClassesData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ClassesData, __ReturnBuffer);

					return *(TArray<FLinkedAnimLayerClassData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ClassesData, __InBuffer);
				}
			}
		}

		public TArray<TSubclassOf<UAnimInstance>> PersistentClasses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PersistentClasses, __ReturnBuffer);

					return *(TArray<TSubclassOf<UAnimInstance>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PersistentClasses, __InBuffer);
				}
			}
		}

		private static uint __ClassesData = 0;

		private static uint __PersistentClasses = 0;

	}
}