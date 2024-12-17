using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CachedPoseIndices")]
	public partial class FCachedPoseIndices : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CachedPoseIndices");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCachedPoseIndices() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCachedPoseIndices() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCachedPoseIndices A, FCachedPoseIndices B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCachedPoseIndices A, FCachedPoseIndices B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCachedPoseIndices;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<int> OrderedSavedPoseNodeIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OrderedSavedPoseNodeIndices, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OrderedSavedPoseNodeIndices, __InBuffer);
				}
			}
		}

		private static uint __OrderedSavedPoseNodeIndices = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}