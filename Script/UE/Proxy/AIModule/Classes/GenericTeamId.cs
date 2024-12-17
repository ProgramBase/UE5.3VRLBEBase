using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.GenericTeamId")]
	public partial class FGenericTeamId : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.GenericTeamId");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGenericTeamId() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGenericTeamId() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGenericTeamId A, FGenericTeamId B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGenericTeamId A, FGenericTeamId B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGenericTeamId;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public byte TeamID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TeamID, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TeamID, __InBuffer);
				}
			}
		}

		private static uint __TeamID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}