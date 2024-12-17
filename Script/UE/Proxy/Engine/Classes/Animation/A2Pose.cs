using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.A2Pose")]
	public partial class FA2Pose : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.A2Pose");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FA2Pose() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FA2Pose() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FA2Pose A, FA2Pose B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FA2Pose A, FA2Pose B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FA2Pose;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FTransform> Bones
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bones, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Bones, __InBuffer);
				}
			}
		}

		private static uint __Bones = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}