using Script.CoreUObject;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequenceBindingReferences")]
	public partial class FLevelSequenceBindingReferences : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LevelSequence.LevelSequenceBindingReferences");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelSequenceBindingReferences() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelSequenceBindingReferences() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelSequenceBindingReferences A, FLevelSequenceBindingReferences B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelSequenceBindingReferences A, FLevelSequenceBindingReferences B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelSequenceBindingReferences;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FGuid, FLevelSequenceBindingReferenceArray> BindingIdToReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BindingIdToReferences, __ReturnBuffer);

					return *(TMap<FGuid, FLevelSequenceBindingReferenceArray>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BindingIdToReferences, __InBuffer);
				}
			}
		}

		public TSet<FGuid> AnimSequenceInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimSequenceInstances, __ReturnBuffer);

					return *(TSet<FGuid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimSequenceInstances, __InBuffer);
				}
			}
		}

		public TSet<FGuid> PostProcessInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PostProcessInstances, __ReturnBuffer);

					return *(TSet<FGuid>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PostProcessInstances, __InBuffer);
				}
			}
		}

		private static uint __BindingIdToReferences = 0;

		private static uint __AnimSequenceInstances = 0;

		private static uint __PostProcessInstances = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}