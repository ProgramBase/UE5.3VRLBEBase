using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationCore
{
	[PathName("/Script/AnimationCore.NodeHierarchyWithUserData")]
	public partial class FNodeHierarchyWithUserData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationCore.NodeHierarchyWithUserData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNodeHierarchyWithUserData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNodeHierarchyWithUserData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNodeHierarchyWithUserData A, FNodeHierarchyWithUserData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNodeHierarchyWithUserData A, FNodeHierarchyWithUserData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNodeHierarchyWithUserData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FNodeHierarchyData Hierarchy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Hierarchy, __ReturnBuffer);

					return *(FNodeHierarchyData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Hierarchy, __InBuffer);
				}
			}
		}

		private static uint __Hierarchy = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}