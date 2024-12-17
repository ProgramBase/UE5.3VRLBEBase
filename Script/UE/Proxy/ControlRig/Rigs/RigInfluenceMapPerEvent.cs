using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigInfluenceMapPerEvent")]
	public partial class FRigInfluenceMapPerEvent : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigInfluenceMapPerEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigInfluenceMapPerEvent() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigInfluenceMapPerEvent() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigInfluenceMapPerEvent A, FRigInfluenceMapPerEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigInfluenceMapPerEvent A, FRigInfluenceMapPerEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigInfluenceMapPerEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRigInfluenceMap> Maps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Maps, __ReturnBuffer);

					return *(TArray<FRigInfluenceMap>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Maps, __InBuffer);
				}
			}
		}

		public TMap<FName, int> EventToIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EventToIndex, __ReturnBuffer);

					return *(TMap<FName, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EventToIndex, __InBuffer);
				}
			}
		}

		private static uint __Maps = 0;

		private static uint __EventToIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}